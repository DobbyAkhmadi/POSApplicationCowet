Imports System.Data.SqlClient
Module LoginSecurityAuth
    Private log As New ClassLoginHistory
    Public Sub Authentication()
        With log
            .dbUser = F_Login.TxtUser.Text
            .dbPwd = F_Login.TxtPass.Text
            .Authentication("proc_proses_Login")
        End With
    End Sub
End Module
