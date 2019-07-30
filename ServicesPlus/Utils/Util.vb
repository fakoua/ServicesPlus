Imports System.Globalization
Imports ServicesPlus.BLL

Namespace Utils

    Friend Module Util
        Public Sub OpenFileLocation(fullPathWithArguments As String, systemName As String)
            Dim pathParser As New PathParser(fullPathWithArguments)
            Dim fullPath = pathParser.FullPath
            If Not (systemName.ToUpperInvariant = Environment.MachineName.ToUpperInvariant) Then
                fullPath = String.Format(CultureInfo.InvariantCulture, "\\{0}\{1}", systemName, fullPath.Replace(":", "$"))
            End If
            If fullPath.Contains(" ") Then
                fullPath = String.Format(CultureInfo.InvariantCulture, """{0}""", fullPath)
            End If
            Process.Start("explorer.exe", "/select," & fullPath)
        End Sub

        Public Function SizeToReadable(size As ULong) As String
            Dim sizes As String() = {"B", "KB", "MB", "GB"}
            Dim order As Integer = 0
            While Size >= 1024 AndAlso order + 1 < sizes.Length
                order += 1
                Size = Convert.ToUInt64(Size / 1024)
            End While
            Dim result As String = [String].Format(CultureInfo.InvariantCulture, "{0:0.##} {1}", Size, sizes(order))
            Return result
        End Function

        Public Function WmiDateToDate(wmiDate As String) As String
            Dim year = wmiDate.Substring(0, 4)
            Dim month = wmiDate.Substring(4, 2)
            Dim day = wmiDate.Substring(6, 2)
            Return String.Format(CultureInfo.InvariantCulture, "{0}-{1}-{2}", year, month, day)
        End Function

        Function ColorByState(service As OM.Service) As Color
            'Trace()
            If service.StartMode.ToUpperInvariant = "disabled".ToUpperInvariant Then
                Return Color.Gray
            End If
            Select Case service.State.ToUpperInvariant
                Case "running".ToUpperInvariant
                    Return Color.Black
                Case "stopped".ToUpperInvariant
                    Return Color.Red
                Case "paused".ToUpperInvariant
                    Return Color.Green
                Case Else
                    Return Color.Blue
            End Select
        End Function

        Friend Function ImageByState(service As OM.Service) As Integer
            'Trace()
            Dim shift = If(service.IsSystem, 4, 0)
            If service.StartMode.ToUpperInvariant = "disabled".ToUpperInvariant Then
                Return 3 + shift
            End If
            Select Case service.State.ToUpperInvariant
                Case "running".ToUpperInvariant
                    Return 0 + shift
                Case "stopped".ToUpperInvariant
                    Return 2 + shift
                Case "paused".ToUpperInvariant
                    Return 1 + shift
                Case Else
                    Return 3 + shift
            End Select
        End Function

        ''' <summary>
        ''' Due to WMI inconsistancy, ErrorControl is String during read but integer during change operation
        ''' </summary>
        ''' <param name="errorControl">ErrorControl String: Ignore, Normal, Severe and Critical</param>
        ''' <returns>0 to 3</returns>
        ''' <remarks>You best convert it to Enum</remarks>
        Public Function ErrorControlToNumber(errorControl As String) As UInt16
            Dim lstError = {New With {.ErrorControl = "Ignore", .Index = 0},
                            New With {.ErrorControl = "Normal", .Index = 1},
                            New With {.ErrorControl = "Severe", .Index = 2},
                            New With {.ErrorControl = "Critical", .Index = 3}}.ToList

            Return lstError.Where(Function(p) p.ErrorControl = errorControl).Single.Index
        End Function

    End Module
End Namespace