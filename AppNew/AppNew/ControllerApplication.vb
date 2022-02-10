Imports System.Data.SqlClient
Imports DevExpress.XtraBars
Imports DevExpress.XtraTabbedMdi
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Base
Imports System.Globalization
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Module CRUD_Module
    Private kategori As New ClassKategori
    Private pembayaran As New ClassPembayaran
    Private login As New ClassPengguna
    Private produk As New ClassProduk
    Private supplier As New ClassPemasok
    Private beli As New ClassPembelian
    Private jual As New ClassPenjualan
    Private retur_jual As New ClassReturPenjualan
    Private retur_beli As New ClassReturPembelian
    Public pesan_error As String = " | Error ini sampaikan yaa ke developer :) nanti akan kami perbaiki."

    Public Sub ClearTextBox(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            ClearTextBox(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            End If
        Next ctrl
    End Sub
#Region "CRUD MASTER"
#Region "Data Kategori"
    Public Sub Save_Kategori(nama As Object)
        With kategori
            .Db_Nama = nama
            .Save("proc_save_kategori")
        End With
    End Sub
    Public Sub Delete_Kategori(id As Object)
        With kategori
            .Db_ID_Kategori = id
            .Delete("proc_delete_kategori")
        End With
    End Sub
    Public Sub View_Kategori()
        With kategori
            .View("proc_view_kategori")
        End With
    End Sub

#End Region
#Region "Data Pembayaran"
    Public Sub Save_Pembayaran(nama As Object)
        With pembayaran
            .Db_Nama = nama
            .Save("proc_save_pembayaran")
        End With
    End Sub
    Public Sub Delete_Pembayaran(id As Object)
        With pembayaran
            .Db_ID_Pembayaran = id
            .Delete("proc_delete_pembayaran")
        End With
    End Sub
    Public Sub View_Pembayaran()
        With pembayaran
            .View("proc_view_pembayaran")
        End With
    End Sub
#End Region
#Region "Data Login"
    Public Sub AutoLogin()
        With login
            .Auto("proc_auto_user")
        End With
    End Sub
    Public Sub Save_Login(id As Object, nama As Object, username As Object, pass As Object, akses As Object)
        With login
            .dbIDUser = id
            .dbNamaUser = nama
            .dbUsername = username
            .dbPassword = pass
            .dbAkses = akses
            .Save("proc_save_user")
        End With
    End Sub
    Public Sub Update_Login(id As Object, nama As Object, username As Object, pass As Object, akses As Object)
        With login
            .dbIDUser = id
            .dbNamaUser = nama
            .dbUsername = username
            .dbPassword = pass
            .dbAkses = akses
            .Update("proc_update_user")
        End With
    End Sub
    Public Sub Delete_Login(id As Object)
        With login
            .dbIDUser = id
            .Delete("proc_Delete_user")
        End With
    End Sub
    Public Sub View_Login()
        With login
            .View("proc_view_user")
        End With
    End Sub
#End Region
#Region "Data Produk"
    Public Sub AutoNumber_Produk()
        With produk
            .Auto("proc_auto_produk")
        End With
    End Sub
    Public Sub Save_Produk(ByVal id As Object,
                           ByVal kategori As Object,
                           ByVal nama As Object,
                           ByVal beli As Object,
                           ByVal jual As Object,
                           ByVal stok As Integer)
        With produk
            .Db_ID_Produk = id
            .Db_ID_Kategori = kategori
            .Db_Nama = nama
            .Db_Harga_Beli = beli
            .Db_Harga_Jual = jual
            .Db_Stok = stok
            .Save("Proc_save_product")
        End With
    End Sub
    Public Sub Update_Produk(ByVal id As Object,
                           ByVal kategori As Object,
                           ByVal nama As Object,
                           ByVal beli As Object,
                           ByVal jual As Object,
                           ByVal stok As Integer)
        With produk
            .Db_ID_Produk = id
            .Db_ID_Kategori = kategori
            .Db_Nama = nama
            .Db_Harga_Beli = beli
            .Db_Harga_Jual = jual
            .Db_Stok = stok
            .Update("proc_update_product")
        End With
    End Sub
    Public Sub Delete_Produk(ByVal id As Object)
        With produk
            .Db_ID_Produk = id
            .Delete("proc_delete_product")
        End With
    End Sub
    Public Sub View_Produk()
        With produk
            .View("Proc_View_product")
        End With
    End Sub
    Public Sub Get_Kategori_Produk()
        With produk
            .Get_Kategori("proc_get_kategori")
        End With
    End Sub
    Public Sub Get_Kategori_Produk_edit()
        With produk
            .Get_Kategori_Edit("proc_get_kategori")
        End With
    End Sub
#End Region
#Region "Data Pemasok"
    Public Sub AutoNumber_Pemasok()
        With supplier
            .Auto("proc_auto_pemasok")
        End With
    End Sub
    Public Sub Save_Pemasok(ByVal id As Object, ByVal nama As Object, ByVal alamat As Object, ByVal telp As Object)
        With supplier
            .Db_ID_Supplier = id
            .Db_Nama = nama
            .Db_Alamat = alamat
            .Db_NoTelp = telp
            .Save("proc_save_pemasok")
        End With
    End Sub
    Public Sub Update_Pemasok(ByVal id As Object, ByVal nama As Object, ByVal alamat As Object, ByVal telp As Object)
        With supplier
            .Db_ID_Supplier = id
            .Db_Nama = nama
            .Db_Alamat = alamat
            .Db_NoTelp = telp
            .Update("proc_update_pemasok")
        End With
    End Sub
    Public Sub Delete_Pemasok(ByVal id As Object)
        With supplier
            .Db_ID_Supplier = id
            .Delete("proc_delete_pemasok")
        End With
    End Sub
    Public Sub View_Pemasok()
        With supplier
            .View("proc_view_pemasok")
        End With
    End Sub
#End Region

#End Region
#Region "CRUD TRANSAKSI PENJUALAN "
#Region "Penjualan"
    Public Sub Auto_Jual()
        With jual
            .Auto_Number()
        End With
    End Sub
    Public Sub Save_Head(no As Object,
                         user As Object,
                         customer As Object,
                         pembayaran As Object,
                         tanggal As Date,
                         type As Object,
                         kredit As Object,
                         diskon As Object,
                         grand As Object)
        With jual
            .Db_No_Transaksi_ID = no
            .DbUser = user
            .DbCustomer = customer
            .DbPembayaran = pembayaran
            .DbTanggal = tanggal
            .DbType = type
            .DbKredit = kredit
            .DbDiskon = diskon
            .DbStatus = "Online"
            .DbGrand = grand
            .Save_A("proc_save_head_jual")
        End With
    End Sub
    Public Sub Save_Detail()
        For a As Integer = 0 To F_Transaksi_Jual.DataGrid.RowCount - 1
            With jual
                .Db_No_Transaksi_ID = F_Transaksi_Jual.TxtNoTrans.Text
                .Db_Product_ID = F_Transaksi_Jual.DataGrid.Rows(a).Cells(0).Value
                .Db_Jumlah = F_Transaksi_Jual.DataGrid.Rows(a).Cells(4).Value
                .Db_Harga = F_Transaksi_Jual.DataGrid.Rows(a).Cells(3).Value
                .DbStatus = "Online"
                .Save_B("proc_save_detail_jual")
            End With
        Next
    End Sub
    Public Sub Get_Data_Pembayaran()
        With jual
            .Get_Pembayaran("proc_get_pembayaran")
        End With
    End Sub
    Public Sub Get_Data_Produk()
        With jual
            .Get_Produk("proc_get_produk")
        End With
    End Sub
    Public Sub View_Detail()
        With jual
            .View_Detail("proc_view_detail")
        End With
    End Sub
    Public Sub Chek_Stok()
        With jual
            .Get_Chek_Stock("proc_chek_stok")
        End With
    End Sub
#End Region
#Region "Retur Penjualan"
    Public Sub Auto_Jual_Retur()
        With retur_jual
            .Auto_Number_Retur()
        End With
    End Sub
    Public Sub Save_Head_Retur()
        With retur_jual
            .Db_No_Transaksi_Retur = F_Transaksi_Retur_Jual.TxtNoTrans.EditValue
            .Db_User_ID = Form_Admin.ToolStripLabel2.Text
            .Db_No_Transaksi_Jual = F_Transaksi_Retur_Jual.LookTransaksi.EditValue
            .Db_Tanggal = F_Transaksi_Retur_Jual.DateTanggal.EditValue
            .Save_A("proc_save_retur_jual")
        End With
    End Sub
    Public Sub Update_Detail_Retur()
        For xxx As Integer = 0 To F_Transaksi_Retur_Jual.DataGrid.RowCount - 1
            With retur_jual
                .Db_No_Transaksi_Retur = F_Transaksi_Retur_Jual.TxtNoTrans.EditValue
                .Db_Product_ID = F_Transaksi_Retur_Jual.DataGrid.Rows(xxx).Cells(0).Value
                .Db_Jumlah = F_Transaksi_Retur_Jual.DataGrid.Rows(xxx).Cells(6).Value
                .Save_B("proc_insert_detail_retur")
            End With
        Next

    End Sub
    Public Sub Get_View_Retur_Detail()
        With retur_jual
            .Get_Lookup_Retur("proc_view_retur_Detail")
        End With
    End Sub
    Public Sub Get_View_Lookup()
        With retur_jual
            .Get_Edit_Value("proc_view_retur_data")
        End With
    End Sub
    Public Sub Get_View_Head()
        With retur_jual
            .Get_Head_Data("proc_get_head")
        End With
    End Sub
#End Region
#End Region
#Region "CRUD TRANSAKSI PEMBELIAN"
#Region "Pembelian"
    Public Sub Auto_Beli()
        With beli
            .Auto_Number_Beli()
        End With
    End Sub
    Public Sub Save_Head_Beli(id As Object,
                              user As Object,
                              supplier As Object,
                              pembayaran As Object,
                              tanggal As Date,
                              type As Object, kredit As Object, diskon As Object)
        With beli
            .Db_No_Transaksi_ID = id
            .DbUser = user
            .DbSupplier = supplier
            .DbPembayaran = pembayaran
            .DbTanggal = tanggal
            .DbType = type
            .DbKredit = kredit
            .DbDiskon = diskon
            .DbStatus = "Online"
            .Save_A("proc_save_head_beli")
        End With
    End Sub
    Public Sub Save_Detail_Beli()
        For a As Integer = 0 To F_Transaksi_Beli.DataGrid.RowCount - 1
            With beli
                .Db_No_Transaksi_ID = F_Transaksi_Beli.TxtNoTrans.Text
                .Db_Product_ID = F_Transaksi_Beli.DataGrid.Rows(a).Cells(0).Value
                .Db_Jumlah = F_Transaksi_Beli.DataGrid.Rows(a).Cells(4).Value
                .Db_Harga = F_Transaksi_Beli.DataGrid.Rows(a).Cells(3).Value
                .DbStatus = "Online"
                .Save_B("proc_save_detail_beli")
            End With
        Next
    End Sub
    Public Sub Get_Data_Produk_Beli()
        With beli
            .Get_Produk("proc_get_produk_beli")
        End With
    End Sub
    Public Sub Get_Data_Supplier_Beli()
        With beli
            .Get_Supplier("proc_get_supplier")
        End With
    End Sub
    Public Sub View_Detail_beli()
        With beli
            .View_Detail("proc_view_detail_beli")
        End With
    End Sub
    Public Sub Get_Data_Pembayaran_Beli()
        With beli
            .Get_Pembayaran("proc_get_pembayaran")
        End With
    End Sub
#End Region
#Region "Retur Pembelian"
    Public Sub Auto_Beli_Retur()
        With retur_beli
            .Auto_Number_Retur()
        End With
    End Sub
    Public Sub Save_Head_Retur_Beli()
        With retur_beli
            .Db_No_Transaksi_ID = F_Transaksi_Retur_Beli.TxtNoTrans.EditValue
            .DbUser = Form_Admin.ToolStripLabel2.Text
            .Db_TransaksiBeli = F_Transaksi_Retur_Beli.LookTransaksiBeli.EditValue
            .DbTanggal = F_Transaksi_Retur_Beli.DateTanggal.EditValue
            .Save_A("proc_save_retur_beli")
        End With
    End Sub
    Public Sub Update_Detail_Retur_Beli()
        For xxx As Integer = 0 To F_Transaksi_Retur_Beli.DataGrid.RowCount - 1
            With retur_beli
                .Db_No_Transaksi_ID = F_Transaksi_Retur_Beli.TxtNoTrans.EditValue
                .Db_Product_ID = F_Transaksi_Retur_Beli.DataGrid.Rows(xxx).Cells(0).Value
                .Db_Jumlah = F_Transaksi_Retur_Beli.DataGrid.Rows(xxx).Cells(6).Value
                .Save_B("proc_insert_detail_retur_beli")
            End With
        Next

    End Sub
    Public Sub Get_View_Retur_Detail_Beli()
        With retur_beli
            .Get_Lookup_Retur_Beli("proc_view_retur_Detail_beli")
        End With
    End Sub
    Public Sub Get_View_Lookup_Beli()
        With retur_beli
            .Get_Edit_Value("proc_view_retur_data_beli")
        End With
    End Sub
    Public Sub Get_View_Head_Beli()
        With retur_beli
            .Get_Head_Data("proc_get_head_beli")
        End With
    End Sub
#End Region
#End Region

End Module
