Imports System.Globalization
Imports System.Threading.Tasks
Imports ServicesPlus.BLL
Imports ServicesPlus.Modules
Imports ServicesPlus.Utils.Util

Namespace Controls

    Friend Class ServerInfo

        Property Identity As OM.Identity

        Public Async Function RefreshUi(machineName As String) As Task
            Trace()
            HLoader1.Start()
            Dim objWmi As New Wmi(Identity)
            Dim inf = Await objWmi.GetServerInfoAsync(machineName)
            If inf IsNot Nothing Then
                lblName.Text = inf.MachineName
                lblOS.Text = String.Format("{0} ({1})", inf.OsName, inf.Architecture)
                lblInstallDate.Text = String.Format("Install Date: {0}", inf.InstallDate)
                lblCPU.Text = inf.Cpu
                lblMemory.Text = String.Format("{0} RAM", SizeToReadable(inf.TotalMemory))

                lblName.Visible = True
                lblOS.Visible = True
                lblInstallDate.Visible = True
                lblCPU.Visible = True
                lblMemory.Visible = True
                HLoader1.Done()
            Else
                lblName.Visible = True
                lblName.Text = String.Format(CultureInfo.InvariantCulture, "Unable to get the server info.{0}Check the application log.", vbNewLine)
                HLoader1.Done()
            End If
        End Function

        Private Sub ServerInfo_Load(sender As Object, e As System.EventArgs) Handles Me.Load
            If Not DesignMode Then
                lblCaption.BorderStyle = BorderStyle.None
                lblCPU.BorderStyle = BorderStyle.None
                lblInstallDate.BorderStyle = BorderStyle.None
                lblMemory.BorderStyle = BorderStyle.None
                lblName.BorderStyle = BorderStyle.None
                lblOS.BorderStyle = BorderStyle.None
            End If
        End Sub

    End Class
End Namespace