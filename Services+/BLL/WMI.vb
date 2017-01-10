Imports System.Management
Imports System.Threading.Tasks
Imports System.Globalization
Imports System.Threading
Imports ServicesPlus.BLL.OM
Imports ServicesPlus.Modules
Imports ServicesPlus.Utils.Util

Namespace BLL
    Friend Class Wmi

        Private _tcsServerInfo As TaskCompletionSource(Of ServerInfoEntity)
        Private _tcsServices As TaskCompletionSource(Of List(Of Service))

        Dim _identity As BLL.OM.Identity

        Public Sub New(identity As BLL.OM.Identity)
            Me._identity = identity
        End Sub

        Public Async Function GetServerInfoAsync(machineName As String) As Task(Of ServerInfoEntity)
            Trace()
            Try
                _tcsServerInfo = New TaskCompletionSource(Of ServerInfoEntity)
                Dim th As New Thread(CType(Sub() GetServerInfo(machineName), ThreadStart))
                th.Start()
                Dim rtnVal = Await _tcsServerInfo.Task
                Return rtnVal
            Catch ex As Exception
                PushLog(ex)
                Return Nothing
            End Try
        End Function

        'TODO: should be moved to ServiceManager class
        Private Sub GetServerInfo(machineName As String)
            Try
                'System.Threading.Thread.Sleep(3000)
                Dim rtnVal As New ServerInfoEntity
                rtnVal.TotalMemory = GetMemory(machineName, _identity)

                Dim manScope As New ManagementScope(String.Format(CultureInfo.InvariantCulture, "\\{0}\root\cimv2", machineName))
                manScope.Options.EnablePrivileges = True
                If _identity IsNot Nothing Then
                    manScope.Options.Username = _identity.UserName
                    manScope.Options.Password = _identity.Password
                    manScope.Options.Authority = "ntlmdomain:" & _identity.Domain
                End If
                manScope.Connect()

                Dim query As New ObjectQuery("SELECT * FROM Win32_OperatingSystem")
                Using mos As ManagementObjectSearcher = New ManagementObjectSearcher(manScope, query)
                    Dim queryCollection As ManagementObjectCollection = mos.Get
                    For Each mo As ManagementObject In queryCollection
                        rtnVal.MachineName = mo("CSName").ToString
                        rtnVal.OsName = mo("Caption").ToString
                        rtnVal.Architecture = mo("OSArchitecture").ToString
                        rtnVal.InstallDate = WmiDateToDate(mo("InstallDate").ToString)
                        rtnVal.LastBootupTime = WmiDateToDate(mo("LastBootUpTime").ToString)
                    Next
                End Using

                query = New ObjectQuery("SELECT * FROM Win32_Processor")
                Using mp As ManagementObjectSearcher = New ManagementObjectSearcher(manScope, query)
                    Dim queryCollection As ManagementObjectCollection = mp.Get
                    For Each mo As ManagementObject In queryCollection
                        rtnVal.Cpu = mo("Name").ToString
                    Next
                End Using
                _tcsServerInfo.SetResult(rtnVal)
            Catch ex As Exception
                _tcsServerInfo.SetResult(Nothing)
                PushLog(ex)
            End Try
        End Sub

        Private Shared Function GetMemory(machineName As String, identity As OM.Identity) As ULong
            Const RtnVal As ULong = 0
            Try
                Dim opt As ObjectGetOptions
                opt = New ObjectGetOptions(Nothing, TimeSpan.MaxValue, True)

                Using manClass As New ManagementClass(String.Format(CultureInfo.InvariantCulture, "\\{0}\root\cimv2", machineName), "Win32_PhysicalMemory", opt)
                    manClass.Scope.Options.EnablePrivileges = True
                    If identity IsNot Nothing Then
                        manClass.Scope.Options.Username = identity.UserName
                        manClass.Scope.Options.Password = identity.Password
                        manClass.Scope.Options.Authority = "ntlmdomain:" & identity.Domain
                    End If
                    Return manClass.GetInstances.Cast(Of ManagementObject)().Aggregate(RtnVal, Function(current, manObj) current + Convert.ToUInt64(manObj.GetPropertyValue("Capacity"), CultureInfo.InvariantCulture))
                End Using
            Catch ex As Exception
                PushLog(ex)
                Return 0
            End Try
        End Function

        Async Function GetDependsOnAsync(service As Service, services As List(Of Service)) As Task(Of List(Of Service))
            Try
                _tcsServices = New TaskCompletionSource(Of List(Of Service))
                Dim th As New Thread(CType(Sub() GetDependsOn(service, services), ThreadStart))
                th.Start()
                Dim rtnVal = Await _tcsServices.Task
                Return rtnVal
            Catch ex As Exception
                PushLog(ex)
                Return Nothing
            End Try
        End Function

        Private Sub GetDependsOn(service As Service, services As List(Of Service))
            Try
                DebugWait()
                Dim queryPath = String.Format("SELECT * FROM Win32_DependentService WHERE Dependent='Win32_Service.Name=\'{0}\''", service.ServiceName)
                Dim query As New ObjectQuery(queryPath)
                Dim manScope As New ManagementScope(String.Format(CultureInfo.InvariantCulture, "\\{0}\root\cimv2", service.SystemName))
                manScope.Options.EnablePrivileges = True
                If Me._identity IsNot Nothing Then
                    manScope.Options.Username = Me._identity.UserName
                    manScope.Options.Password = Me._identity.Password
                    manScope.Options.Authority = "ntlmdomain:" & Me._identity.Domain
                End If
                manScope.Connect()
                Dim rtnVal As New List(Of Service)
                Using mos As ManagementObjectSearcher = New ManagementObjectSearcher(manScope, query)
                    Dim queryCollection As ManagementObjectCollection = mos.Get
                    'rtnVal.AddRange(From mo As ManagementObject In queryCollection Select serviceName = mo.Item("Antecedent").ToString Select serviceName = GetServiceName(serviceName) Select dependsOnService = services.Where(Function(p) p.ServiceName.ToUpperInvariant = serviceName).FirstOrDefault Where dependsOnService IsNot Nothing)
                    For Each mo As ManagementObject In queryCollection
                        Dim serviceName = mo.Item("Antecedent").ToString
                        serviceName = GetServiceName(serviceName)
                        Dim dependsOnService = services.Where(Function(p) p.ServiceName.ToUpperInvariant = serviceName).FirstOrDefault
                        'TODO: Should consider SystemDrivers and other type
                        If dependsOnService IsNot Nothing Then
                            rtnVal.Add(dependsOnService)
                        End If
                    Next
                End Using
                _tcsServices.SetResult(rtnVal)
            Catch ex As Exception
                _tcsServices.SetResult(Nothing)
                PushLog(ex)
            End Try
        End Sub

        ''' <summary>
        ''' Retreive Service name from WMI Path
        ''' Example: \\Computer\root\cimv2:Win32_Service.Name="RpcSs"
        ''' </summary>
        ''' <param name="wmiPath">WMI Path</param>
        ''' <returns>String, service name</returns>
        ''' <remarks>I think there is another way to get the name, need to consider change this approach</remarks>
        Private Shared Function GetServiceName(wmiPath As String) As String
            Try
                wmiPath = wmiPath.ToUpperInvariant
                Dim pos = wmiPath.IndexOf(".Name=".ToUpperInvariant, StringComparison.Ordinal)
                Dim name = wmiPath.Substring(pos + ".Name=".Length)
                name = name.Replace("""", "")
                name = name.Replace("'", "")
                Return name
            Catch ex As Exception
                PushLog(ex)
                Return String.Empty
            End Try
        End Function


        Async Function GetDependOnThisServiceAsync(service As Service, services As List(Of Service)) As Task(Of List(Of Service))
            Try
                _tcsServices = New TaskCompletionSource(Of List(Of Service))
                Dim th As New Thread(CType(Sub() GetDependOnThisService(service, services), ThreadStart))
                th.Start()
                Dim rtnVal = Await _tcsServices.Task
                Return rtnVal
            Catch ex As Exception
                PushLog(ex)
                Return Nothing
            End Try
        End Function

        Private Sub GetDependOnThisService(service As Service, services As List(Of Service))
            Try
                DebugWait()
                Dim queryPath = String.Format("SELECT * FROM Win32_DependentService WHERE Antecedent='Win32_Service.Name=\'{0}\''", service.ServiceName)
                Dim query As New ObjectQuery(queryPath)
                Dim manScope As New ManagementScope(String.Format(CultureInfo.InvariantCulture, "\\{0}\root\cimv2", service.SystemName))
                manScope.Options.EnablePrivileges = True
                If Me._identity IsNot Nothing Then
                    manScope.Options.Username = Me._identity.UserName
                    manScope.Options.Password = Me._identity.Password
                    manScope.Options.Authority = "ntlmdomain:" & Me._identity.Domain
                End If
                manScope.Connect()
                Dim rtnVal As New List(Of Service)
                Using mos As ManagementObjectSearcher = New ManagementObjectSearcher(manScope, query)
                    Dim queryCollection As ManagementObjectCollection = mos.Get
                    'rtnVal.AddRange(From mo As ManagementObject In queryCollection Select serviceName = mo.Item("Dependent").ToString Select serviceName = GetServiceName(serviceName) Select dependsOnService = services.Where(Function(p) p.ServiceName.ToUpperInvariant = serviceName).FirstOrDefault Where dependsOnService IsNot Nothing)
                    For Each mo As ManagementObject In queryCollection
                        Dim serviceName = mo.Item("Dependent").ToString
                        serviceName = GetServiceName(serviceName)
                        Dim dependsOnService = services.Where(Function(p) p.ServiceName.ToUpperInvariant = serviceName).FirstOrDefault
                        If dependsOnService IsNot Nothing Then
                            rtnVal.Add(dependsOnService)
                        End If
                    Next
                End Using
                _tcsServices.SetResult(rtnVal)
            Catch ex As Exception
                _tcsServices.SetResult(Nothing)
                PushLog(ex)
            End Try
        End Sub

    End Class
End Namespace
