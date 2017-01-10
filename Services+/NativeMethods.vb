Imports System.Runtime.InteropServices

Friend Class NativeMethods
    ' constants from winbase.h
    Public Const Logon32LogonInteractive As Integer = 2
    Public Const Logon32LogonNetwork As Integer = 3
    Public Const Logon32LogonBatch As Integer = 4
    Public Const Logon32LogonService As Integer = 5
    Public Const Logon32LogonUnlock As Integer = 7
    Public Const Logon32LogonNetworkCleartext As Integer = 8
    Public Const Logon32LogonNewCredentials As Integer = 9

    Public Const Logon32ProviderDefault As Integer = 0
    Public Const Logon32ProviderWinnt35 As Integer = 1
    Public Const Logon32ProviderWinnt40 As Integer = 2
    Public Const Logon32ProviderWinnt50 As Integer = 3

    Private Sub New()

    End Sub

    <DllImport("uxtheme", CharSet:=CharSet.Unicode)>
    Shared Function SetWindowTheme(ByVal hWnd As IntPtr, ByVal textSubAppName As String, ByVal textSubIdList As String) As Integer
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Unicode)>
    Shared Function SendMessage(hWnd As IntPtr, msg As Integer, wp As IntPtr, lp As String) As IntPtr
    End Function

    <DllImport("advapi32.dll", SetLastError:=True)> _
    Public Shared Function LogonUserA(lpszUserName As [String], lpszDomain As [String], lpszPassword As [String], dwLogonType As Integer, dwLogonProvider As Integer, ByRef phToken As IntPtr) As Integer
    End Function
    <DllImport("advapi32.dll", CharSet:=CharSet.Auto, SetLastError:=True)> _
    Public Shared Function DuplicateToken(hToken As IntPtr, impersonationLevel As Integer, ByRef hNewToken As IntPtr) As Integer
    End Function

    <DllImport("advapi32.dll", CharSet:=CharSet.Auto, SetLastError:=True)> _
    Public Shared Function RevertToSelf() As Boolean
    End Function

    <DllImport("kernel32.dll", CharSet:=CharSet.Auto)> _
    Public Shared Function CloseHandle(handle As IntPtr) As Boolean
    End Function

End Class
