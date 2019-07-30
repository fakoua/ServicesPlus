Imports ServicesPlus.BLL.OM

Namespace Forms

    Friend Class FrmUpdate

        Private Sub BtnDownload_Click(sender As Object, e As EventArgs) Handles BtnDownload.Click
            Process.Start("https://servicesplus.codeplex.com/")
            Close()
        End Sub

        Sub Open(updateInformation As UpdateEntity)
            LblInstalledVersion.Text = updateInformation.AppVersion
            lblNewVersion.Text = updateInformation.OnlineVersion
            txtChangeLog.Text = updateInformation.ChangeLog
            ShowDialog()
        End Sub
    End Class
End Namespace