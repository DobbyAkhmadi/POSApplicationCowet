Imports System.Data.SqlClient
Public Class ClassLoginHistory

    Private V_User As String
    Private V_Pwd As String
    Private V_ID As String
#Region "Property Login"
    Property dbUser()
        Get
            dbUser = V_User
        End Get
        Set(ByVal value)
            V_User = value
        End Set
    End Property
    Property dbPwd()
        Get
            dbPwd = V_Pwd
        End Get
        Set(ByVal value)
            V_Pwd = value
        End Set
    End Property
#End Region
#Region "Method"
    Public Function Authentication(ByVal Init_User As String)
        Connected()
        Cmd = New SqlCommand
        With Cmd
            .Connection = Con
            .CommandText = Init_User
            .CommandType = CommandType.StoredProcedure
            With Cmd.Parameters
                .AddWithValue("@3", dbUser)
                .AddWithValue("@4", dbPwd)
            End With
            Read = .ExecuteReader()
        End With
        Return Init_User
    End Function
#End Region
End Class
