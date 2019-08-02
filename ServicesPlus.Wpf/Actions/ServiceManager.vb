Imports System.Globalization
Imports System.Management
Imports System.Runtime.InteropServices
Imports System.Security.Permissions
Imports System.Security.Principal
Imports System.Threading

Friend Class ServiceManager
    Property MachineName As String
    Property Services As List(Of ServiceViewModel)
    Property Identity As IdentityModel
    Private _tcsListServices As TaskCompletionSource(Of List(Of ServiceViewModel))
    Private _tcsService As TaskCompletionSource(Of ServiceViewModel)
    Private _tcsPerformance As TaskCompletionSource(Of PerformanceModel)
    Private _tcsWmiReturn As TaskCompletionSource(Of ControlModel)

    Public Sub New()

    End Sub

    Public Sub New(machineName As String, identity As IdentityModel)
        Me.MachineName = machineName
        Me.Identity = identity
        If String.IsNullOrEmpty(machineName) Then
            Me.MachineName = "."
        End If
    End Sub

    Dim _lastError As String
    ReadOnly Property LastError As String
        Get
            Return _lastError
        End Get
    End Property

    Public Async Function GetServicesByMachineAsync() As Task
        Trace()
        Try
            _tcsListServices = New TaskCompletionSource(Of List(Of ServiceViewModel))
            Dim th As New Thread(CType(Sub() GetServicesByMachine(MachineName), ThreadStart))
            th.Start()
            Services = Await _tcsListServices.Task
        Catch ex As Exception
            PushLog(ex)
        End Try
    End Function

    <PermissionSetAttribute(SecurityAction.Demand, Name:="FullTrust")>
    Private Sub GetServicesByMachine(ByVal machine As String)
        Dim context As WindowsImpersonationContext = Nothing
        Try
            Dim rtnVal As New List(Of ServiceViewModel)
            Dim opt As ObjectGetOptions
            opt = New ObjectGetOptions(Nothing, TimeSpan.MaxValue, True)

            Using manClass As New ManagementClass(String.Format(CultureInfo.InvariantCulture, "\\{0}\root\cimv2", machine), "Win32_Service", opt)
                Try
                    manClass.Scope.Options.EnablePrivileges = True
                    manClass.Scope.Options.Impersonation = ImpersonationLevel.Impersonate
                    If Me.Identity IsNot Nothing Then
                        manClass.Scope.Options.Username = Me.Identity.UserName
                        manClass.Scope.Options.Password = Me.Identity.Password
                        manClass.Scope.Options.Authority = "ntlmdomain:" & Me.Identity.Domain
                    End If

                    For Each manObj As ManagementObject In manClass.GetInstances
                        Dim service As New ServiceViewModel
                        service.ServiceName = ToObjString(manObj.GetPropertyValue("Name"))
                        service.AcceptPause = ToObjBool(manObj.GetPropertyValue("AcceptPause"))
                        service.AcceptStop = ToObjBool(manObj.GetPropertyValue("AcceptStop"))
                        service.Description = ToObjString(manObj.GetPropertyValue("Description"))
                        service.DesktopInteract = ToObjBool(manObj.GetPropertyValue("DesktopInteract"))
                        service.DisplayName = ToObjString(manObj.GetPropertyValue("DisplayName"))
                        service.ErrorControl = ToObjString(manObj.GetPropertyValue("ErrorControl"))
                        service.PathName = ToObjString(manObj.GetPropertyValue("PathName"))
                        service.ProcessId = ToObjInt(manObj.GetPropertyValue("ProcessId"))
                        service.ServiceType = ToObjString(manObj.GetPropertyValue("ServiceType"))
                        service.Started = ToObjBool(manObj.GetPropertyValue("Started"))
                        service.StartMode = ToObjString(manObj.GetPropertyValue("StartMode"))
                        service.StartName = ToObjString(manObj.GetPropertyValue("StartName"))
                        service.State = ToObjString(manObj.GetPropertyValue("State"))
                        service.Status = ToObjString(manObj.GetPropertyValue("Status"))
                        service.SystemName = ToObjString(manObj.GetPropertyValue("SystemName"))
                        service.IsSystem = False
                        rtnVal.Add(service)
                    Next
                Catch ex As COMException
                    _lastError = ex.Message
                    PushLog(ex)
                Catch ex As Exception
                    _lastError = ex.ToString
                    PushLog(ex)
                End Try
            End Using

            Using manClass As New ManagementClass(String.Format(CultureInfo.InvariantCulture, "\\{0}\root\cimv2", machine), "Win32_SystemDriver", opt)
                Try
                    manClass.Scope.Options.EnablePrivileges = True
                    manClass.Scope.Options.Impersonation = ImpersonationLevel.Impersonate
                    If Me.Identity IsNot Nothing Then
                        manClass.Scope.Options.Username = Me.Identity.UserName
                        manClass.Scope.Options.Password = Me.Identity.Password
                        manClass.Scope.Options.Authority = "ntlmdomain:" & Me.Identity.Domain
                    End If
                    For Each manObj As ManagementObject In manClass.GetInstances
                        Dim service As New ServiceViewModel
                        service.IsSystem = True
                        service.ServiceName = ToObjString(manObj.GetPropertyValue("Name"))
                        service.AcceptPause = ToObjBool(manObj.GetPropertyValue("AcceptPause"))
                        service.AcceptStop = ToObjBool(manObj.GetPropertyValue("AcceptStop"))
                        service.Description = ToObjString(manObj.GetPropertyValue("Description"))
                        service.DesktopInteract = ToObjBool(manObj.GetPropertyValue("DesktopInteract"))
                        service.DisplayName = ToObjString(manObj.GetPropertyValue("DisplayName"))
                        service.ErrorControl = ToObjString(manObj.GetPropertyValue("ErrorControl"))
                        service.PathName = ToObjString(manObj.GetPropertyValue("PathName"))
                        service.ServiceType = ToObjString(manObj.GetPropertyValue("ServiceType"))
                        service.Started = ToObjBool(manObj.GetPropertyValue("Started"))
                        service.StartMode = ToObjString(manObj.GetPropertyValue("StartMode"))
                        service.StartName = ToObjString(manObj.GetPropertyValue("StartName"))
                        service.State = ToObjString(manObj.GetPropertyValue("State"))
                        service.Status = ToObjString(manObj.GetPropertyValue("Status"))
                        service.SystemName = ToObjString(manObj.GetPropertyValue("SystemName"))
                        rtnVal.Add(service)
                    Next
                Catch ex As COMException
                    _lastError = ex.Message
                    PushLog(ex)
                Catch ex As Exception
                    _lastError = ex.ToString
                    PushLog(ex)
                End Try
            End Using
            'For Each s In rtnVal
            '    If Not s.PathName.StartsWith("""") Then Debug.WriteLine(s.PathName)
            'Next
            _tcsListServices.SetResult(rtnVal)
        Catch ex As Exception
            _lastError = ex.ToString
            PushLog(ex)
            _tcsListServices.SetResult(Nothing)
        Finally
        End Try
    End Sub

    <PermissionSetAttribute(SecurityAction.Demand, Name:="FullTrust")>
    Public Sub GetServicesByMachine()
        Dim context As WindowsImpersonationContext = Nothing
        Try
            Dim rtnVal As New List(Of ServiceViewModel)
            Dim opt As ObjectGetOptions
            opt = New ObjectGetOptions(Nothing, TimeSpan.MaxValue, True)

            Using manClass As New ManagementClass(String.Format(CultureInfo.InvariantCulture, "\\{0}\root\cimv2", Me.MachineName), "Win32_Service", opt)
                Try
                    manClass.Scope.Options.EnablePrivileges = True
                    manClass.Scope.Options.Impersonation = ImpersonationLevel.Impersonate
                    If Me.Identity IsNot Nothing Then
                        manClass.Scope.Options.Username = Me.Identity.UserName
                        manClass.Scope.Options.Password = Me.Identity.Password
                        manClass.Scope.Options.Authority = "ntlmdomain:" & Me.Identity.Domain
                    End If

                    For Each manObj As ManagementObject In manClass.GetInstances
                        Dim service As New ServiceViewModel
                        service.ServiceName = ToObjString(manObj.GetPropertyValue("Name"))
                        service.AcceptPause = ToObjBool(manObj.GetPropertyValue("AcceptPause"))
                        service.AcceptStop = ToObjBool(manObj.GetPropertyValue("AcceptStop"))
                        service.Description = ToObjString(manObj.GetPropertyValue("Description"))
                        service.DesktopInteract = ToObjBool(manObj.GetPropertyValue("DesktopInteract"))
                        service.DisplayName = ToObjString(manObj.GetPropertyValue("DisplayName"))
                        service.ErrorControl = ToObjString(manObj.GetPropertyValue("ErrorControl"))
                        service.PathName = ToObjString(manObj.GetPropertyValue("PathName"))
                        service.ProcessId = ToObjInt(manObj.GetPropertyValue("ProcessId"))
                        service.ServiceType = ToObjString(manObj.GetPropertyValue("ServiceType"))
                        service.Started = ToObjBool(manObj.GetPropertyValue("Started"))
                        service.StartMode = ToObjString(manObj.GetPropertyValue("StartMode"))
                        service.StartName = ToObjString(manObj.GetPropertyValue("StartName"))
                        service.State = ToObjString(manObj.GetPropertyValue("State"))
                        service.Status = ToObjString(manObj.GetPropertyValue("Status"))
                        service.SystemName = ToObjString(manObj.GetPropertyValue("SystemName"))
                        service.IsSystem = False
                        rtnVal.Add(service)
                    Next
                Catch ex As COMException
                    _lastError = ex.Message
                    PushLog(ex)
                Catch ex As Exception
                    _lastError = ex.ToString
                    PushLog(ex)
                End Try
            End Using

            Using manClass As New ManagementClass(String.Format(CultureInfo.InvariantCulture, "\\{0}\root\cimv2", Me.MachineName), "Win32_SystemDriver", opt)
                Try
                    manClass.Scope.Options.EnablePrivileges = True
                    manClass.Scope.Options.Impersonation = ImpersonationLevel.Impersonate
                    If Me.Identity IsNot Nothing Then
                        manClass.Scope.Options.Username = Me.Identity.UserName
                        manClass.Scope.Options.Password = Me.Identity.Password
                        manClass.Scope.Options.Authority = "ntlmdomain:" & Me.Identity.Domain
                    End If
                    For Each manObj As ManagementObject In manClass.GetInstances
                        Dim service As New ServiceViewModel
                        service.IsSystem = True
                        service.ServiceName = ToObjString(manObj.GetPropertyValue("Name"))
                        service.AcceptPause = ToObjBool(manObj.GetPropertyValue("AcceptPause"))
                        service.AcceptStop = ToObjBool(manObj.GetPropertyValue("AcceptStop"))
                        service.Description = ToObjString(manObj.GetPropertyValue("Description"))
                        service.DesktopInteract = ToObjBool(manObj.GetPropertyValue("DesktopInteract"))
                        service.DisplayName = ToObjString(manObj.GetPropertyValue("DisplayName"))
                        service.ErrorControl = ToObjString(manObj.GetPropertyValue("ErrorControl"))
                        service.PathName = ToObjString(manObj.GetPropertyValue("PathName"))
                        service.ServiceType = ToObjString(manObj.GetPropertyValue("ServiceType"))
                        service.Started = ToObjBool(manObj.GetPropertyValue("Started"))
                        service.StartMode = ToObjString(manObj.GetPropertyValue("StartMode"))
                        service.StartName = ToObjString(manObj.GetPropertyValue("StartName"))
                        service.State = ToObjString(manObj.GetPropertyValue("State"))
                        service.Status = ToObjString(manObj.GetPropertyValue("Status"))
                        service.SystemName = ToObjString(manObj.GetPropertyValue("SystemName"))
                        rtnVal.Add(service)
                    Next
                Catch ex As COMException
                    _lastError = ex.Message
                    PushLog(ex)
                Catch ex As Exception
                    _lastError = ex.ToString
                    PushLog(ex)
                End Try
            End Using
            Me.Services = rtnVal
        Catch ex As Exception
            _lastError = ex.ToString
            PushLog(ex)
        Finally
        End Try
    End Sub

    'TODO: this function should be moved to WMI class
    Public Async Function GetPerformanceAsync(service As ServiceViewModel) As Task(Of PerformanceModel)
        Trace()
        Try
            _tcsPerformance = New TaskCompletionSource(Of PerformanceModel)()
            Dim th As New Thread(CType(Sub() GetPerformance(service), ThreadStart))
            th.Start()
            Return Await _tcsPerformance.Task
        Catch ex As Exception
            PushLog(ex)
            Return Nothing
        End Try
    End Function

    Private Sub GetPerformance(service As ServiceViewModel)
        Trace()
        Try
            Dim p = Process.GetProcessById(Convert.ToInt32(service.ProcessId), service.SystemName)
            Dim rtnVal As New PerformanceModel
            rtnVal.Memory = Convert.ToUInt64(p.PrivateMemorySize64)
            rtnVal.PeakMemory = Convert.ToUInt64(p.PeakWorkingSet64)
            _tcsPerformance.SetResult(rtnVal)
        Catch ex As Exception
            PushLog(ex)
        End Try

    End Sub

    Private Shared Function ToObjString(obj As Object, Optional [default] As String = "") As String
        Return If(obj Is Nothing, [default], obj.ToString)
    End Function

    Private Shared Function ToObjBool(obj As Object, Optional [default] As Boolean = False) As Boolean
        Return If(obj Is Nothing, [default], CBool(obj.ToString))
    End Function

    Private Shared Function ToObjInt(obj As Object, Optional [default] As UInt32 = 0) As UInt32
        Return If(obj Is Nothing, [default], Convert.ToUInt32(obj.ToString, CultureInfo.InvariantCulture))
    End Function

    ''' <summary>
    ''' Get service by name and machine for update list view
    ''' </summary>
    ''' <param name="machine"></param>
    ''' <param name="serviceName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ''' 
    Public Async Function GetServiceByNameAsync(machine As String, serviceName As String) As Task(Of ServiceViewModel)
        Trace()
        Try
            _tcsService = New TaskCompletionSource(Of ServiceViewModel)
            Dim th As New Thread(CType(Sub() GetServiceByName(machine, serviceName, 0), ThreadStart))
            th.Start()
            Dim rtnVal = Await _tcsService.Task

            'Second attempt to get the service is the status contains pending
            If rtnVal.Status.ToUpperInvariant.Contains("pending".ToUpperInvariant) Then
                _tcsService = New TaskCompletionSource(Of ServiceViewModel)
                th = New Thread(CType(Sub() GetServiceByName(machine, serviceName, 2000), ThreadStart))
                th.Start()
                rtnVal = Await _tcsService.Task
            End If

            'Third attempt to get the service is the status contains pending
            If rtnVal.Status.ToUpperInvariant.Contains("pending".ToUpperInvariant) Then
                _tcsService = New TaskCompletionSource(Of ServiceViewModel)
                th = New Thread(CType(Sub() GetServiceByName(machine, serviceName, 4000), ThreadStart))
                th.Start()
                rtnVal = Await _tcsService.Task
            End If

            Return rtnVal
        Catch ex As Exception
            PushLog(ex)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Return the servie
    ''' </summary>
    ''' <param name="machine"></param>
    ''' <param name="serviceName"></param>
    ''' <param name="waitTime">Wait Time used in sleep function in order to allow some time to refresh the status in case of PENDING</param>
    ''' <remarks></remarks>
    Private Sub GetServiceByName(ByVal machine As String, serviceName As String, waitTime As Integer)
        Trace()
        Dim service As ServiceViewModel = Nothing
        Try
            If waitTime > 0 Then
                Thread.Sleep(waitTime)
            End If
            Dim manPath = String.Format(CultureInfo.InvariantCulture, "\\{0}\root\cimv2:Win32_Service.Name='{1}'", machine, serviceName)
            Using manObject As New ManagementObject(manPath)
                Try
                    If Me.Identity IsNot Nothing Then
                        manObject.Scope.Options.Username = Me.Identity.UserName
                        manObject.Scope.Options.Password = Me.Identity.Password
                        manObject.Scope.Options.Authority = "ntlmdomain:" & Me.Identity.Domain
                    End If
                    service = New ServiceViewModel
                    service.ServiceName = ToObjString(manObject.GetPropertyValue("Name"))
                    service.AcceptPause = ToObjBool(manObject.GetPropertyValue("AcceptPause"))
                    service.AcceptStop = ToObjBool(manObject.GetPropertyValue("AcceptStop"))
                    service.Description = ToObjString(manObject.GetPropertyValue("Description"))
                    service.DesktopInteract = ToObjBool(manObject.GetPropertyValue("DesktopInteract"))
                    service.DisplayName = ToObjString(manObject.GetPropertyValue("DisplayName"))
                    service.ErrorControl = ToObjString(manObject.GetPropertyValue("ErrorControl"))
                    service.PathName = ToObjString(manObject.GetPropertyValue("PathName"))
                    service.ProcessId = ToObjInt(manObject.GetPropertyValue("ProcessId"))
                    service.ServiceType = ToObjString(manObject.GetPropertyValue("ServiceType"))
                    service.Started = ToObjBool(manObject.GetPropertyValue("Started"))
                    service.StartMode = ToObjString(manObject.GetPropertyValue("StartMode"))
                    service.StartName = ToObjString(manObject.GetPropertyValue("StartName"))
                    service.State = ToObjString(manObject.GetPropertyValue("State"))
                    service.Status = ToObjString(manObject.GetPropertyValue("Status"))
                    service.SystemName = ToObjString(manObject.GetPropertyValue("SystemName"))
                Catch ex As Exception
                    PushLog(ex)
                End Try
            End Using
            _tcsService.SetResult(service)
        Catch ex As Exception
            PushLog(ex)
            _tcsListServices.SetResult(Nothing)
        End Try
    End Sub

    Async Function ControlServiceAsync(service As ServiceViewModel, action As WmiMethod) As Task(Of ControlModel)
        Trace()
        Try
            _tcsWmiReturn = New TaskCompletionSource(Of ControlModel)
            Dim th As New Thread(CType(Sub() ControlService(service, action), ThreadStart))
            th.Start()
            Dim rtnVal = Await _tcsWmiReturn.Task
            rtnVal.ServiceRefresh = Await GetServiceByNameAsync(service.SystemName, service.ServiceName)
            Return rtnVal
        Catch ex As Exception
            PushLog(ex)
            Dim rtnVal As New ControlModel
            rtnVal.ServiceRefresh = Nothing
            rtnVal.LastError = ex.ToString
            rtnVal.WmiValue = WmiReturn.HandledError
            Return rtnVal
        End Try
    End Function

    Private Sub ControlService(service As ServiceViewModel, action As WmiMethod)
        Dim rtnVal As New ControlModel
        rtnVal.ServiceRefresh = service
        Try
            Dim objPath = String.Format(CultureInfo.InvariantCulture, "\\{0}\root\cimv2:Win32_Service.Name='{1}'", service.SystemName, service.ServiceName)
            Using objService As New ManagementObject(objPath)
                If Me.Identity IsNot Nothing Then
                    objService.Scope.Options.Username = Me.Identity.UserName
                    objService.Scope.Options.Password = Me.Identity.Password
                    objService.Scope.Options.Authority = "ntlmdomain:" & Me.Identity.Domain
                End If
                Dim outParams = objService.InvokeMethod(action.ToString, Nothing)
                rtnVal.WmiValue = CInt(outParams)
                Thread.Sleep(3000) 'Wait 3 sec for status refresh (Pending issue)
                _tcsWmiReturn.SetResult(rtnVal)
            End Using
        Catch ex As Exception
            rtnVal.WmiValue = WmiReturn.HandledError
            rtnVal.LastError = ex.ToString
            _tcsWmiReturn.SetResult(rtnVal)
            PushLog(ex)
        End Try
    End Sub

    Async Function ChangeAsync(editEntity As EditServiceModel) As Task(Of ControlModel)
        Trace()
        Try
            _tcsWmiReturn = New TaskCompletionSource(Of ControlModel)
            Dim th As New Thread(CType(Sub() Change(editEntity), ThreadStart))
            th.Start()
            Dim rtnVal = Await _tcsWmiReturn.Task
            rtnVal.ServiceRefresh = Await GetServiceByNameAsync(editEntity.SystemName, editEntity.ServiceName)
            Return rtnVal
        Catch ex As Exception
            PushLog(ex)
            Dim rtnVal As New ControlModel
            rtnVal.ServiceRefresh = Nothing
            rtnVal.LastError = ex.ToString
            rtnVal.WmiValue = WmiReturn.HandledError
            Return rtnVal
        End Try
    End Function

    Friend Sub Change(editEntity As EditServiceModel)
        Dim rtnVal As New ControlModel
        Try
            Dim objPath = String.Format(CultureInfo.InvariantCulture, "\\{0}\root\cimv2:Win32_Service.Name='{1}'", editEntity.SystemName, editEntity.ServiceName)
            Using objService As New ManagementObject(objPath)
                If Me.Identity IsNot Nothing Then
                    objService.Scope.Options.Username = Me.Identity.UserName
                    objService.Scope.Options.Password = Me.Identity.Password
                    objService.Scope.Options.Authority = "ntlmdomain:" & Me.Identity.Domain
                End If
                Dim inParams = objService.GetMethodParameters("Change")
                inParams("DesktopInteract") = editEntity.DesktopInteract
                inParams("DisplayName") = editEntity.DisplayName
                inParams("ErrorControl") = Util.ErrorControlToNumber(editEntity.ErrorControl)
                inParams("StartMode") = editEntity.StartMode
                inParams("StartName") = editEntity.StartName
                inParams("StartPassword") = editEntity.StartPassword
                Dim outParams = objService.InvokeMethod("Change", inParams, Nothing)

                rtnVal.WmiValue = CInt(outParams("ReturnValue").ToString)
                rtnVal.LastError = ""
                _tcsWmiReturn.SetResult(rtnVal)
            End Using
        Catch ex As Exception
            rtnVal.WmiValue = WmiReturn.HandledError
            rtnVal.LastError = ex.ToString
            _tcsWmiReturn.SetResult(rtnVal)
            PushLog(ex)
        End Try
    End Sub

    Async Function CreateAsync(createEntity As CreateServiceModel) As Task(Of ControlModel)
        Trace()
        Try
            _tcsWmiReturn = New TaskCompletionSource(Of ControlModel)
            Dim th As New Thread(CType(Sub() Create(createEntity), ThreadStart))
            th.Start()
            Dim rtnVal = Await _tcsWmiReturn.Task
            Return rtnVal
        Catch ex As Exception
            PushLog(ex)
            Dim rtnVal As New ControlModel
            rtnVal.ServiceRefresh = Nothing
            rtnVal.LastError = ex.ToString
            rtnVal.WmiValue = WmiReturn.HandledError
            Return rtnVal
        End Try
    End Function

    Private Sub Create(createEntity As CreateServiceModel)
        Dim rtnVal As New ControlModel
        Try
            Dim opt As ObjectGetOptions
            opt = New ObjectGetOptions(Nothing, TimeSpan.MaxValue, True)

            'Using manClass As New ManagementClass(String.Format(CultureInfo.InvariantCulture, "\\{0}\root\cimv2", createEntity.SystemName), "Win32_Service", opt)
            Using manClass As New ManagementClass("Win32_Service")
                If Me.Identity IsNot Nothing Then
                    manClass.Scope.Options.Username = Me.Identity.UserName
                    manClass.Scope.Options.Password = Me.Identity.Password
                    manClass.Scope.Options.Authority = "ntlmdomain:" & Me.Identity.Domain
                End If

                Dim inParams = manClass.GetMethodParameters("create")
                inParams("Name") = createEntity.ServiceName
                inParams("DisplayName") = createEntity.DisplayName
                inParams("DesktopInteract") = createEntity.DesktopInteract
                inParams("ErrorControl") = Util.ErrorControlToNumber(createEntity.ErrorControl)
                inParams("StartMode") = createEntity.StartMode
                inParams("StartName") = createEntity.StartName
                inParams("StartPassword") = createEntity.StartPassword
                inParams("PathName") = createEntity.PathName
                inParams("ServiceType") = 16 'Own Process
                Dim outParams = manClass.InvokeMethod("Create", inParams, Nothing)
                rtnVal.WmiValue = CInt(outParams("ReturnValue").ToString)
                rtnVal.LastError = ""
                _tcsWmiReturn.SetResult(rtnVal)
            End Using
        Catch ex As Exception
            rtnVal.WmiValue = WmiReturn.HandledError
            rtnVal.LastError = ex.ToString
            _tcsWmiReturn.SetResult(rtnVal)
            PushLog(ex)
        End Try
    End Sub

    Async Function DeleteAsync(service As ServiceViewModel) As Task(Of ControlModel)
        Trace()
        Try
            _tcsWmiReturn = New TaskCompletionSource(Of ControlModel)
            Dim th As New Thread(CType(Sub() Delete(service), ThreadStart))
            th.Start()
            Dim rtnVal = Await _tcsWmiReturn.Task
            Return rtnVal
        Catch ex As Exception
            PushLog(ex)
            Dim rtnVal As New ControlModel
            rtnVal.ServiceRefresh = Nothing
            rtnVal.LastError = ex.ToString
            rtnVal.WmiValue = WmiReturn.HandledError
            Return rtnVal
        End Try
    End Function

    Private Sub Delete(service As ServiceViewModel)
        Dim rtnVal As New ControlModel
        Try
            Dim objPath = String.Format(CultureInfo.InvariantCulture, "\\{0}\root\cimv2:Win32_Service.Name='{1}'", service.SystemName, service.ServiceName)
            Using objService As New ManagementObject(objPath)

                If Me.Identity IsNot Nothing Then
                    objService.Scope.Options.Username = Me.Identity.UserName
                    objService.Scope.Options.Password = Me.Identity.Password
                    objService.Scope.Options.Authority = "ntlmdomain:" & Me.Identity.Domain
                End If

                Dim outParams = objService.InvokeMethod("Delete", Nothing, Nothing)

                rtnVal.WmiValue = CInt(outParams("ReturnValue").ToString)
                rtnVal.LastError = ""
                _tcsWmiReturn.SetResult(rtnVal)
            End Using
        Catch ex As Exception
            rtnVal.WmiValue = WmiReturn.HandledError
            rtnVal.LastError = ex.ToString
            _tcsWmiReturn.SetResult(rtnVal)
            PushLog(ex)
        End Try
    End Sub
End Class
