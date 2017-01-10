Imports System.Globalization
Imports System.IO
Imports System.Text
Imports System.Threading

Namespace Modules

    Friend Module ModMain

        Public ColorBackgroud As Color = Color.FromArgb(255, 239, 239, 242)
        Public ColorBlue As Color = Color.FromArgb(255, 0, 122, 204)
        Public ColorLightblue As Color = Color.FromArgb(255, 28, 151, 234)

        Public Function GetLogPath() As String
            Dim logFile = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
            logFile = Path.Combine(logFile, "Services+")
            If Not Directory.Exists(logFile) Then
                Directory.CreateDirectory(logFile)
            End If
            logFile = Path.Combine(logFile, "Services+.log.txt")
            If Not IO.File.Exists(logFile) Then
                My.Computer.FileSystem.WriteAllText(logFile, "######### Please report this log to s.fakoua@outlook.com #########" & vbNewLine & vbNewLine, True)
            End If
            Return logFile
        End Function

        Public Sub PushLog(ex As Exception)
            Dim message = String.Empty
            Try
                Dim stack = New StackTrace
                Dim methodName = stack.GetFrames(1).GetMethod.Name
                If methodName = "MoveNext" Then
                    methodName = stack.GetFrames(3).GetMethod.Name
                End If

                Dim exMsg = ex.ToString.Replace(vbNewLine, "")
                message = String.Format(CultureInfo.InvariantCulture, "{0} {1} --> {2}: {3}{4}", Date.Now.ToShortDateString, Date.Now.ToShortTimeString, methodName, exMsg, vbNewLine)

                Dim logFile = GetLogPath()
                My.Computer.FileSystem.WriteAllText(logFile, message, True, ASCIIEncoding.Default)
                If Debugger.IsAttached Then
                    MsgBox(message)
                End If
            Catch notHandledex As Exception
                MsgBox(message)
            End Try
        End Sub

        Sub Trace()
            If Environment.GetCommandLineArgs.Count > 1 AndAlso Environment.GetCommandLineArgs(1) = "debug" Then
                Dim stack = New StackTrace
                Dim methodName = stack.GetFrames(1).GetMethod.Name
                If methodName = "MoveNext" Then
                    methodName = stack.GetFrames(3).GetMethod.Name
                End If
                Dim msg = String.Format(CultureInfo.InvariantCulture, "{2}: {0}{1}", methodName, vbNewLine, My.Computer.Clock.TickCount)

                My.Computer.FileSystem.WriteAllText("c:\temp\trace.txt", msg, True)
            End If
        End Sub

        Friend Sub DebugWait()
            If Debugger.IsAttached Then
                Thread.Sleep(1)
            End If
        End Sub

    End Module
End Namespace