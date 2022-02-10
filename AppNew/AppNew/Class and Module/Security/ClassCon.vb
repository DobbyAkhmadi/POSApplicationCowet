Imports System.Data.SqlClient
Public Class ClassCon
    Private _Server As String
    Private _Database As String
    Private _User As String
    Private _Password As String
#Region "Property"
    Public Property Server() As String
        Get
            Return Me._Server
        End Get
        Set(ByVal value As String)
            Me._Server = value
        End Set
    End Property
    Public Property Database() As String
        Get
            Return Me._Database
        End Get
        Set(ByVal value As String)
            Me._Database = value
        End Set
    End Property
    Public Property User() As String
        Get
            Return Me._User
        End Get
        Set(ByVal value As String)
            Me._User = value
        End Set
    End Property
    Public Property Password() As String
        Get
            Return Me._Password
        End Get
        Set(ByVal value As String)
            Me._Password = value
        End Set
    End Property
#End Region
#Region "Method"
   
    Function Connection()
        Dim connectionstring As String =
       "server=" & Server &
       ";database=" & Database &
       ";user id=" & User &
       ";password=" & Password
        Con = New SqlConnection
        With Con
            .ConnectionString = connectionstring
            .Open()
        End With
        Return True
    End Function

#End Region
End Class
