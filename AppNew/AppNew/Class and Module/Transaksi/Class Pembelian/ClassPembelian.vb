Imports System.Data.SqlClient
Public Class ClassPembelian
    '============================== HEAD TRANSAKSI
    Private V_No_Transaksi_ID As String
    Private V_User_ID As String
    Private V_Supplier_ID As String
    Private V_Pembayaran As Integer
    Private V_Tanggal As DateTime
    Private V_Type As String
    Private V_Kredit As String = 0
    Private V_Diskon As String = 0
    Private V_Status As String
    Private V_Grand As Long
    '============================== DETAIL TRANSAKSI
    Private V_Product_ID As String
    Private V_Jumlah As Integer
    Private V_Harga As Long
#Region "Property Head"
    Property Db_No_Transaksi_ID()
        Get
            Db_No_Transaksi_ID = V_No_Transaksi_ID
        End Get
        Set(ByVal value)
            V_No_Transaksi_ID = value
        End Set
    End Property
    Property DbUser()
        Get
            DbUser = V_User_ID
        End Get
        Set(ByVal value)
            V_User_ID = value
        End Set
    End Property
    Property DbSupplier()
        Get
            DbSupplier = V_Supplier_ID
        End Get
        Set(ByVal value)
            V_Supplier_ID = value
        End Set
    End Property
    Property DbPembayaran()
        Get
            DbPembayaran = V_Pembayaran
        End Get
        Set(ByVal value)
            V_Pembayaran = value
        End Set
    End Property
    Property DbTanggal()
        Get
            DbTanggal = V_Tanggal
        End Get
        Set(ByVal value)
            V_Tanggal = value
        End Set
    End Property
    Property DbType()
        Get
            DbType = V_Type
        End Get
        Set(ByVal value)
            V_Diskon = value
        End Set
    End Property
    Property DbKredit()
        Get
            DbKredit = V_Kredit
        End Get
        Set(ByVal value)
            V_Kredit = value
        End Set
    End Property
    Property DbDiskon()
        Get
            DbDiskon = V_Diskon
        End Get
        Set(ByVal value)
            V_Diskon = value
        End Set
    End Property
    Property DbStatus()
        Get
            DbStatus = V_Status
        End Get
        Set(ByVal value)
            V_Status = value
        End Set
    End Property
    Property DbGrand()
        Get
            DbGrand = V_Grand
        End Get
        Set(ByVal value)
            V_Grand = value
        End Set
    End Property
#End Region
#Region "Property Detail"
    Property Db_Product_ID()
        Get
            Db_Product_ID = V_Product_ID
        End Get
        Set(ByVal value)
            V_Product_ID = value
        End Set
    End Property
    Property Db_Jumlah()
        Get
            Db_Jumlah = V_Jumlah
        End Get
        Set(ByVal value)
            V_Jumlah = value
        End Set
    End Property
    Property Db_Harga()
        Get
            Db_Harga = V_Harga
        End Get
        Set(ByVal value)
            V_Harga = value
        End Set
    End Property
#End Region
#Region "Method"
    Public Function Auto_Number_Beli()
        Connected()
        Dim no As String
        Cmd = New SqlCommand
        With Cmd
            .CommandText = "select ID_TRANSAKSI_BELI from tbl_head_beli where left (ID_TRANSAKSI_BELI,4)='" & Now.ToString("yyMM") & "'order by ID_TRANSAKSI_BELI desc"
            .CommandType = CommandType.Text
            .Connection = Con
            Read = Cmd.ExecuteReader
            If Read.HasRows = False Then
                no = 1
            Else
                Read.Read()
                no = Val(Read.Item(0).ToString.Substring(4, 3)) + 1
            End If
            no = "000".Substring(0, 3 - Len(no)) + no
            F_Transaksi_Beli.TxtNoTrans.Text = Now.ToString("yyMM") + no
            .Dispose()
            Read.Close()
        End With
        Read.Close()
        Return Cmd
    End Function
    Public Function Save_A(ByVal SP_SAVE_HEAD As String)
        Connected()
        Cmd = New SqlCommand
        With Cmd
            .Connection = Con
            .CommandText = SP_SAVE_HEAD
            .CommandType = CommandType.StoredProcedure
            With Cmd.Parameters
                .AddWithValue("@1", Db_No_Transaksi_ID)
                .AddWithValue("@2", DbUser)
                .AddWithValue("@3", DbSupplier)
                .AddWithValue("@4", DbPembayaran)
                .AddWithValue("@5", DbTanggal)
                .AddWithValue("@6", SqlDbType.VarChar).Value = F_Transaksi_Beli.Status_beli
                .AddWithValue("@7", DbKredit)
                .AddWithValue("@8", DbDiskon)
                .AddWithValue("@9", DbStatus)
                .AddWithValue("@10", DbGrand)
            End With
            .ExecuteNonQuery()
            .Parameters.Clear()
            .Dispose()
        End With
        Disconnected()
        Return SP_SAVE_HEAD
    End Function
    Public Function Save_B(ByVal SP_SAVE_DETAIL As String)
        Connected()
        Cmd = New SqlCommand
        With Cmd
            .Connection = Con
            .CommandText = SP_SAVE_DETAIL
            .CommandType = CommandType.StoredProcedure
            With Cmd.Parameters
                .AddWithValue("@1", Db_No_Transaksi_ID)
                .AddWithValue("@2", Db_Product_ID)
                .AddWithValue("@3", Db_Jumlah)
                .AddWithValue("@4", Db_Harga)
                .AddWithValue("@5", DbStatus)
            End With
            .ExecuteNonQuery()
            .Parameters.Clear()
            .Dispose()
        End With
        Disconnected()
        Return SP_SAVE_DETAIL
    End Function
    Public Function Get_Pembayaran(ByVal bayar As String)
        Dim da As New SqlDataAdapter(bayar, Con)
        Dim ds As New DataSet
        da.Fill(ds, "TBL_PEMBAYARAN")
        With F_Transaksi_Beli.LookPembayaran
            .Properties.DataSource = ds.Tables("TBL_PEMBAYARAN")
            .Properties.DisplayMember = "Via Bank"
            .Properties.ValueMember = "ID"
            '  .ItemIndex = 0
        End With
        da.Dispose()
        ds.Dispose()
        Return bayar
    End Function
    Public Function Get_Produk(ByVal produk As String)
        Dim da As New SqlDataAdapter(produk, Con)
        Dim ds As New DataSet
        da.Fill(ds, "tbl_produk")
        With F_Transaksi_Beli.LookProduk
            .Properties.DataSource = ds.Tables("tbl_produk")
            .Properties.DisplayMember = "Produk"
            .Properties.ValueMember = "ID Produk"
            '  .ItemIndex = 0
        End With
        da.Dispose()
        ds.Dispose()
        Return produk
    End Function
    Public Function Get_Supplier(ByVal produk As String)
        Dim da As New SqlDataAdapter(produk, Con)
        Dim ds As New DataSet
        da.Fill(ds, "tbL_supplier")
        With F_Transaksi_Beli.LookPemasok
            .Properties.DataSource = ds.Tables("tbl_supplier")
            .Properties.DisplayMember = "Nama"
            .Properties.ValueMember = "ID Supplier"
            '  .ItemIndex = 0
        End With
        da.Dispose()
        ds.Dispose()
        Return produk
    End Function
    Public Function View_Detail(ByVal detail As String)
        Connected()
        Cmd = New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.StoredProcedure
            .CommandText = detail
            With Cmd.Parameters
                .AddWithValue("@1", SqlDbType.Char).Value = F_Transaksi_Beli.LookProduk.EditValue
            End With
            Read = .ExecuteReader
            While Read.Read
                F_Transaksi_Beli.DataGrid.Rows.Add(Read.Item(0), Read.Item(1), Read.Item(2), Convert.ToDouble(Read.Item(3)), F_Transaksi_Beli.TxtJumlah.Value)
            End While
            .Dispose()
            Read.Close()
        End With
        Disconnected()
        Return detail
    End Function
#End Region
    
End Class
