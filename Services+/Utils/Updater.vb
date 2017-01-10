Imports System.Reflection
Imports System.Xml
Imports ServicesPlus.BLL.OM
Imports ServicesPlus.Forms

Namespace Utils

    Friend Class Updater
        Const VersionUrl As String = "https://servicesplus.svn.codeplex.com/svn/Services+/Services+/Version.xml"

        Shared Async Function CheckForUpdate() As Threading.Tasks.Task
            Try
                If Debugger.IsAttached Then Exit Function
                Using objRequest As New Net.WebClient
                    Dim xmlVersion = Await objRequest.DownloadStringTaskAsync(VersionUrl)
                    Dim xmlDoc As New XmlDocument
                    xmlDoc.LoadXml(xmlVersion)
                    Dim onlineVersion = xmlDoc.GetElementsByTagName("Version").Item(0).FirstChild.InnerText
                    Dim changeLog = xmlDoc.GetElementsByTagName("Version").Item(0).ChildNodes(1).InnerText
                    Dim appVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString
                    If onlineVersion <> appVersion Then
                        Dim updateInfo As New UpdateEntity
                        updateInfo.AppVersion = appVersion
                        updateInfo.OnlineVersion = onlineVersion
                        updateInfo.ChangeLog = changeLog
                        Using objUpdate As New FrmUpdate
                            objUpdate.Open(updateInfo)
                        End Using
                    End If
                End Using
            Catch ex As Exception
                Modules.PushLog(ex)
            End Try
        End Function
    End Class
End Namespace