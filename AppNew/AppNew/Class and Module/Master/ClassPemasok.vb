Imports System.Data.SqlClient
Public Class ClassPemasok
    Private V_ID_Supplier As String
    Private V_Nama As String
    Private V_Alamat As String
    Private V_NoTelp As String
#Region "Property"
    Property Db_ID_Supplier()
        Get
            Db_ID_Supplier = V_ID_Supplier
        End Get
        Set(ByVal value)
            V_ID_Supplier = value
        End Set
    End Property
    Property Db_Nama()
        Get
            Db_Nama = V_Nama
        End Get
        Set(ByVal value)
            V_Nama = value
        End Set
    End Property
    Property Db_Alamat()
        Get
            Db_Alamat = V_Alamat
        End Get
        Set(ByVal value)
            V_Alamat = value
        End Set
    End Property
    Property Db_NoTelp()
        Get
            Db_NoTelp = V_NoTelp
        End Get
        Set(ByVal value)
            V_NoTelp = value
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
            F_Add_Pemasok.txtid.Text = "PMSK-" + strku
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
                .AddWithValue("@1", Db_ID_Supplier)
                .AddWithValue("@2", Db_Nama)
                .AddWithValue("@3", Db_Alamat)
                .AddWithValue("@4", Db_NoTelp)
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
                .AddWithValue("@1", Db_ID_Supplier)
                .AddWithValue("@2", Db_Nama)
                .AddWithValue("@3", Db_Alamat)
                .AddWithValue("@4", Db_NoTelp)
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
                .AddWithValue("@1", Db_ID_Supplier)
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
        F_Pemasok.GridView1.OptionsBehavior.Editable = 0
        While F_Pemasok.GridView1.RowCount <> 0
            F_Pemasok.GridView1.SelectAll()
            F_Pemasok.GridView1.DeleteSelectedRows()
        End While
        Cmd = New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.StoredProcedure
            .CommandText = SP_VIEW
            Data.Load(.ExecuteReader)
            F_Pemasok.GridControl1.DataSource = Data
            F_Pemasok.GridControl1.DataMember = Data.TableName
            .Dispose()
        End With
        Disconnected()
        Return SP_VIEW
    End Function

#End Region
End Class
