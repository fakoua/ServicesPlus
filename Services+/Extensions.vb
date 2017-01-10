Imports System.Runtime.CompilerServices
Imports System.Globalization
Imports ServicesPlus.BLL.OM
Imports System.Text
Imports ServicesPlus.Modules

Module Extensions
    <Extension>
    Public Function ToCleanString(s As String) As String
        'TODO: buggy, should imporve algo
        For i = 0 To 10
            s = s.Replace(vbNewLine, " ")
            s = s.Replace(vbTab, " ")
            s = s.Replace("  ", " ")
        Next
        Return s
    End Function

    <Extension>
    Function ToCap(s As String) As String
        If String.IsNullOrEmpty(s) Then Return String.Empty
        Return String.Format(CultureInfo.InvariantCulture, "{0}{1}", s.Substring(0, 1).ToUpperInvariant, s.Substring(1, s.Length - 1))
    End Function

    '<Extension>
    'Function ToColor(s As String) As Drawing.Color
    '    Trace()
    '    Try
    '        Dim rtnVal As Color = Color.Red
    '        format r,g,b, or a,r,g,b
    '        Dim colors = s.Split(",".ToCharArray, StringSplitOptions.RemoveEmptyEntries)
    '        If colors.Count = 4 Then
    '            rtnVal = Color.FromArgb(CInt(colors(0)), CInt(colors(1)), CInt(colors(2)), CInt(colors(3)))
    '        End If
    '        If colors.Count = 3 Then
    '            rtnVal = Color.FromArgb(CInt(colors(0)), CInt(colors(1)), CInt(colors(2)))
    '        End If
    '        Return rtnVal
    '    Catch ex As Exception
    '        PushLog(ex)
    '        Return Color.Red
    '    End Try
    'End Function

    <Extension>
    Function EscapeCsv(s As String) As String
        Dim rtnVal = s.Replace(",", " ")
        rtnVal = rtnVal.Replace(vbNewLine, " ")
        Return rtnVal
    End Function
    <Extension>
    Function ToCsv(service As Service) As String
        Trace()
        Try
            Dim builder As New StringBuilder
            builder.AppendFormat("{0},", service.SystemName)
            builder.AppendFormat("{0},", service.ServiceName)
            builder.AppendFormat("{0},", service.DisplayName.EscapeCsv)
            builder.AppendFormat("{0},", service.Description.EscapeCsv)
            builder.AppendFormat("{0},", service.PathName)
            builder.AppendFormat("{0},", service.Status)
            builder.AppendFormat("{0},", service.State)
            builder.AppendFormat("{0},", service.StartMode)
            builder.AppendFormat("{0},", service.StartName)
            builder.AppendFormat("{0},", service.AcceptPause)
            builder.AppendFormat("{0},", service.AcceptStop)
            builder.AppendFormat("{0},", service.DesktopInteract)
            builder.AppendFormat("{0},", service.ProcessId)
            builder.AppendLine(service.ServiceType)
            Return builder.ToString
        Catch ex As Exception
            PushLog(ex)
            Return String.Empty
        End Try
    End Function

    <Extension>
    Function ToHtml(service As Service) As String
        Trace()
        Try
            Dim builder As New StringBuilder
            builder.Append("<tr>")
            builder.AppendFormat("<td>{0}</td>", service.SystemName)
            builder.AppendFormat("<td>{0}</td>", service.ServiceName)
            builder.AppendFormat("<td>{0}</td>", service.DisplayName.EscapeCsv)
            builder.AppendFormat("<td>{0}</td>", service.Description.EscapeCsv)
            builder.AppendFormat("<td>{0}</td>", service.PathName)
            builder.AppendFormat("<td>{0}</td>", service.Status)
            builder.AppendFormat("<td>{0}</td>", service.State)
            builder.AppendFormat("<td>{0}</td>", service.StartMode)
            builder.AppendFormat("<td>{0}</td>", service.StartName)
            builder.AppendFormat("<td>{0}</td>", service.AcceptPause)
            builder.AppendFormat("<td>{0}</td>", service.AcceptStop)
            builder.AppendFormat("<td>{0}</td>", service.DesktopInteract)
            builder.AppendFormat("<td>{0}</td>", service.ProcessId)
            builder.AppendFormat("<td>{0}</td>", service.ServiceType)
            builder.AppendLine("</tr>")
            Return builder.ToString
        Catch ex As Exception
            PushLog(ex)
            Return String.Empty
        End Try
    End Function

    <Extension>
    Public Function Capablites(service As Service) As ServiceCapability
        Dim rtnVal As New ServiceCapability

        rtnVal.CanDelete = If(service Is Nothing, False, Not service.IsSystem)

        If service Is Nothing OrElse
            service.StartMode.ToUpperInvariant = "DISABLED" OrElse
            service.IsSystem Then

            rtnVal.CanStart = False
            rtnVal.CanPause = False
            rtnVal.CanRestart = False
            rtnVal.CanResume = False
            rtnVal.CanStop = False
            Return rtnVal
        End If

        If service.State.ToUpperInvariant = "STOPPED" Then
            rtnVal.CanStart = True
            rtnVal.CanPause = False
            rtnVal.CanRestart = False
            rtnVal.CanResume = False
            rtnVal.CanStop = False
            Return rtnVal
        End If
        If service.State.ToUpperInvariant = "RUNNING" Then
            rtnVal.CanStart = False
            rtnVal.CanPause = service.AcceptPause
            rtnVal.CanStop = service.AcceptStop
            rtnVal.CanRestart = service.AcceptStop
            rtnVal.CanResume = False
            Return rtnVal
        End If
        If service.State.ToUpperInvariant = "PAUSED" Then
            rtnVal.CanStart = False
            rtnVal.CanPause = False
            rtnVal.CanRestart = True
            rtnVal.CanResume = True
            rtnVal.CanStop = service.AcceptStop
            Return rtnVal
        End If

        rtnVal.CanStart = False
        rtnVal.CanPause = False
        rtnVal.CanRestart = False
        rtnVal.CanResume = False
        rtnVal.CanStop = False

        Return rtnVal
    End Function

End Module
