Imports System.Data.SqlClient
Public Class ClassProduk
    Private V_ID_Produk As String
    Private V_ID_Kategori As String
    Private V_Nama As String
    Private V_HargaBeli As String
    Private V_HargaJual As String
    Private V_Stok As String
#Region "Property"
    Property Db_ID_Produk()
        Get
            Db_ID_Produk = V_ID_Produk
        End Get
        Set(ByVal value)
            V_ID_Produk = value
        End Set
    End Property
    Property Db_ID_Kategori()
        Get
            Db_ID_Kategori = V_ID_Kategori
        End Get
        Set(ByVal value)
            V_ID_Kategori = value
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
    Property Db_Harga_Beli()
        Get
            Db_Harga_Beli = V_HargaBeli
        End Get
        Set(ByVal value)
            V_HargaBeli = value
        End Set
    End Property
    Property Db_Harga_Jual()
        Get
            Db_Harga_Jual = V_HargaJual
        End Get
        Set(ByVal value)
            V_HargaJual = value
        End Set
    End Property
    Property Db_Stok()
        Get
            Db_Stok = V_Stok
        End Get
        Set(ByVal value)
            V_Stok = value
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
            strku = "000".Substring(1, 3 - Len(strku)) + strku
            F_Add_Produk.txtid.Text = "PRD-" + strku
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
                .AddWithValue("@1", Db_ID_Produk)
                .AddWithValue("@2", Db_ID_Kategori)
                .AddWithValue("@3", Db_Nama)
                .AddWithValue("@4", Db_Harga_Beli)
                .AddWithValue("@5", Db_Harga_Jual)
                .AddWithValue("@6", Db_Stok)
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
                .AddWithValue("@1", Db_ID_Produk)
                .AddWithValue("@2", Db_ID_Kategori)
                .AddWithValue("@3", Db_Nama)
                .AddWithValue("@4", Db_Harga_Beli)
                .AddWithValue("@5", V_HargaJual)
                .AddWithValue("@6", Db_Stok)
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
                .AddWithValue("@1", Db_ID_Produk)
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
        F_Produk.GridView1.OptionsBehavior.Editable = 0
        While F_Produk.GridView1.RowCount <> 0
            F_Produk.GridView1.SelectAll()
            F_Produk.GridView1.DeleteSelectedRows()
        End While
        Cmd = New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.StoredProcedure
            .CommandText = SP_VIEW
            Data.Load(.ExecuteReader)
            F_Produk.GridControl1.DataSource = Data
            F_Produk.GridControl1.DataMember = Data.TableName
            .Dispose()
        End With
        Disconnected()
        Return SP_VIEW
    End Function
    Public Function Get_Kategori(ByVal kategori As String)
        Connected()
        Dim da As New SqlDataAdapter(kategori, Con)
        Dim ds As New DataSet
        da.Fill(ds, "tbl_kategori")
        With F_Add_Produk.LookUpEdit1
            .Properties.DataSource = ds.Tables("tbl_kategori")
            .Properties.DisplayMember = "Nama Kategori"
            .Properties.ValueMember = "ID Kategori"
            '  .ItemIndex = 0
        End With
        da.Dispose()
        ds.Dispose()
        Disconnected()
        Return kategori
    End Function

    Public Function Get_Kategori_Edit(ByVal kategori As String)
        Connected()
        Dim da As New SqlDataAdapter(kategori, Con)
        Dim ds As New DataSet
        da.Fill(ds, "tbl_kategori")
        With F_Edit_Produk.LookUpEdit1
            .Properties.DataSource = ds.Tables("tbl_kategori")
            .Properties.DisplayMember = "Nama Kategori"
            .Properties.ValueMember = "ID Kategori"
            .ItemIndex = 0
        End With
        da.Dispose()
        ds.Dispose()
        Disconnected()
        Return kategori
    End Function
#End Region
End Class
