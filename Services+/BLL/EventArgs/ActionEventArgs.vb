Namespace BLL.EventArgs
    Friend Class ActionEventArgs
        Property Action As ServiceAction
    End Class

    Friend Enum ServiceAction
        Start
        [Stop]
        Pause
        Restart
        [Resume]
        Refresh
        Change
    End Enum
End Namespace