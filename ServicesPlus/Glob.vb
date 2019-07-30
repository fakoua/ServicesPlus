Imports System.IO
Imports System.Xml.Serialization

Friend Module Glob
    Property AppSettings As AppSettings

    Sub LoadSettings()
        AppSettings = LoadSettingsXml()
    End Sub

    Public Function GetSettingPath() As String
        Dim logFile = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
        logFile = Path.Combine(logFile, "Services+")
        If Not Directory.Exists(logFile) Then
            Directory.CreateDirectory(logFile)
        End If
        logFile = Path.Combine(logFile, "Services+.settings.xml")
        Return logFile
    End Function

    Private Function LoadSettingsXml() As AppSettings
        If Not IO.File.Exists(GetSettingPath) Then
            Return New AppSettings
        End If
        Try
            Dim temp As New AppSettings
            Using objStreamReader As New StreamReader(GetSettingPath)
                Dim x As New XmlSerializer(temp.GetType)
                temp = x.Deserialize(objStreamReader)
                objStreamReader.Close()
            End Using
            Return temp
        Catch ex As Exception
            Modules.PushLog(ex)
            Return New AppSettings
        End Try
    End Function

End Module
