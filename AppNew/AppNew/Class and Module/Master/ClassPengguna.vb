Imports System.Data.SqlClient
Public Class ClassPengguna
    Private V_ID_User As String
    Private V_Nama_User As String
    Private V_Username As String
    Private V_Password As String
    Private V_Akses As String
#Region "Property"

    Property dbIDUser()
        Get
            dbIDUser = V_ID_User
        End Get
        Set(ByVal value)
            V_ID_User = value
        End Set
    End Property
    Property dbNamaUser()
        Get
            dbNamaUser = V_Nama_User
        End Get
        Set(ByVal value)
            V_Nama_User = value
        End Set
    End Property
    Property dbUsername()
        Get
            dbUsername = V_Username
        End Get
        Set(ByVal value)
            V_Username = value
        End Set
    End Property
    Property dbPassword()
        Get
            dbPassword = V_Password
        End Get
        Set(ByVal value)
            V_Password = value
        End Set
    End Property
    Property dbAkses()
        Get
            dbAkses = V_Akses
        End Get
        Set(ByVal value)
            V_Akses = value
        End Set
    End Property

#End Region

#Region "Method"
    Public Function Auto(ByVal AutoGenerate As String)
        Connected()
        Dim strku As String
        Cmd = New SqlCommand
        With Cmd
            .Connection = Con
            .CommandText = AutoGenerate
            .CommandType = CommandType.StoredProcedure
            strku = Cmd.ExecuteScalar + 1
            strku = "00".Substring(1, 2 - Len(strku)) + strku
            F_Add_User.txtid.Text = "USER-" + strku
            .Parameters.Clear()
            .Dispose()
        End With
        Return AutoGenerate
        Disconnected()
    End Function
    Public Function Save(ByVal SP_SAVE As String)
        Connected()
        Cmd = New SqlCommand
        With Cmd
            .Connection = Con
            .CommandText = SP_SAVE
            .CommandType = CommandType.StoredProcedure
            With Cmd.Parameters
                .AddWithValue("@1", dbIDUser)
                .AddWithValue("@2", dbNamaUser)
                .AddWithValue("@3", dbUsername)
                .AddWithValue("@4", dbPassword)
                .AddWithValue("@5", dbAkses)
            End With
            .ExecuteNonQuery()
            .Parameters.Clear()
            .Dispose()
        End With
        Return SP_SAVE
        Disconnected()
    End Function
    Public Function Update(ByVal SP_UPDATE As String)
        Connected()
        Cmd = New SqlCommand
        With Cmd
            .Connection = Con
            .CommandText = SP_UPDATE
            .CommandType = CommandType.StoredProcedure
            With Cmd.Parameters
                .AddWithValue("@1", dbIDUser)
                .AddWithValue("@2", dbNamaUser)
                .AddWithValue("@3", dbUsername)
                .AddWithValue("@4", dbPassword)
                .AddWithValue("@5", dbAkses)
            End With
            .ExecuteNonQuery()
            .Parameters.Clear()
            .Dispose()
        End With
        Return SP_UPDATE
        Disconnected()
    End Function
    Public Function Delete(ByVal SP_DELETE As String)
        Connected()
        Cmd = New SqlCommand
        With Cmd
            .Connection = Con
            .CommandText = SP_DELETE
            .CommandType = CommandType.StoredProcedure
            With Cmd.Parameters
                .AddWithValue("@1", dbIDUser)
            End With
            .ExecuteNonQuery()
            .Parameters.Clear()
            .Dispose()
        End With
        Disconnected()
        Return SP_DELETE
    End Function
    Public Function View(ByVal SP_VIEW As String)
         Connected()
        Clear_Adapter()
        F_User.GridView1.OptionsBehavior.Editable = 0
        While F_User.GridView1.RowCount <> 0
            F_User.GridView1.SelectAll()
            F_User.GridView1.DeleteSelectedRows()
        End While
        Cmd = New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.StoredProcedure
            .CommandText = SP_VIEW
            Data.Load(.ExecuteReader)
            F_User.GridControl1.DataSource = Data
            F_User.GridControl1.DataMember = Data.TableName
            .Dispose()
        End With
        Disconnected()
        Return SP_VIEW
    End Function
#End Region

End Class
