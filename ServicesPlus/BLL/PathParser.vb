Imports ServicesPlus.Modules

Namespace BLL
    Friend Class PathParser
        Property FolderName As String
        Property FullPath As String
        Property FullPathWithArguments As String

        Private ReadOnly _pathWithArgs As String

        Public Sub New(pathWithArgs As String)
            _pathWithArgs = pathWithArgs
            FullPathWithArguments = _pathWithArgs
            Parse()
        End Sub

        ''' <summary>
        ''' Assert that servier is .exe or .sys
        ''' Path formats are:
        ''' 1- ____.ext
        ''' 2- "___SPACE__.ext"
        ''' 3- "_____.ext args"
        ''' 4- "____SPACE__.ext" args
        ''' 5- "____SPACE__.ext args"
        ''' 6- "____SPACE__.ext" args="__SPACE__" (this is rare case)
        ''' </summary>
        Private Sub Parse()
            Trace()
            Try
                Dim extPosition As Integer = 0 ' Start of .exe or .sys
                extPosition = _pathWithArgs.ToLowerInvariant.IndexOf(".exe")
                If extPosition < 0 Then extPosition = _pathWithArgs.ToLowerInvariant.IndexOf(".sys")

                FullPath = _pathWithArgs.Substring(0, extPosition + 4).Replace("""", "")
                Dim slashPos = FullPath.LastIndexOf("\")
                FolderName = FullPath.Substring(0, slashPos + 1)
            Catch ex As Exception
                PushLog(ex)
            End Try
        End Sub

    End Class
End Namespace