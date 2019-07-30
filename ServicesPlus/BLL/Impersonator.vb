Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Security.Principal

Namespace BLL

    Friend Class Impersonator

        Public Shared Function LogOn(userName As String, password As String) As WindowsImpersonationContext
            Return LogOn(userName, password, "")
        End Function

        Public Shared Function LogOn(userName As String, password As String, domain As String) As WindowsImpersonationContext
            Dim tempWindowsIdentity As WindowsIdentity
            Dim impersonationContext As WindowsImpersonationContext
            Dim token As IntPtr = IntPtr.Zero
            Dim tokenDuplicate As IntPtr = IntPtr.Zero

            If NativeMethods.RevertToSelf() Then
                If NativeMethods.LogonUserA(userName, domain, password, NativeMethods.Logon32LogonInteractive, NativeMethods.Logon32ProviderDefault, token) <> 0 Then
                    If NativeMethods.DuplicateToken(token, 2, tokenDuplicate) <> 0 Then
                        tempWindowsIdentity = New WindowsIdentity(tokenDuplicate)
                        impersonationContext = tempWindowsIdentity.Impersonate()
                        If impersonationContext IsNot Nothing Then
                            NativeMethods.CloseHandle(token)
                            NativeMethods.CloseHandle(tokenDuplicate)
                            Return impersonationContext
                        End If
                    End If
                Else
                    Dim win32 = New Win32Exception(Marshal.GetLastWin32Error())
                    'throw new Exception(string.Format("{0}, Domain:{1}, User:{2}, Password:{3}",
                    '    win32.Message, domain, userName, password));
                    Throw New Exception(win32.Message)
                End If
            End If
            If token <> IntPtr.Zero Then
                NativeMethods.CloseHandle(token)
            End If
            If tokenDuplicate <> IntPtr.Zero Then
                NativeMethods.CloseHandle(tokenDuplicate)
            End If
            Return Nothing
            ' Failed to impersonate
        End Function

        Public Shared Function LogOff(context As WindowsImpersonationContext) As Boolean
            Dim result As Boolean = False
            Try
                If context IsNot Nothing Then
                    context.Undo()
                    context.Dispose()
                    result = True
                End If
            Catch
                result = False
            End Try
            Return result
        End Function
    End Class
End Namespace