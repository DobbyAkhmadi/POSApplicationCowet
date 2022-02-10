Imports System.Data.SqlClient
Public Class ClassReturPenjualan
    Private V_No_Transaksi_Retur As String
    Private V_User_ID As String
    Private V_No_Transaksi_Jual As String
    Private V_Tanggal As DateTime
    '======================================head =====================
    Private V_Product_ID As String
    Private V_Jumlah As Integer
    Private V_Harga As Long
    Private V_Status As String
    '========================================detail===================
#Region "Property Head"
    Property Db_No_Transaksi_Retur()
        Get
            Db_No_Transaksi_Retur = V_No_Transaksi_Retur
        End Get
        Set(ByVal value)
            V_No_Transaksi_Retur = value
        End Set
    End Property
    Property Db_User_ID()
        Get
            Db_User_ID = V_User_ID
        End Get
        Set(ByVal value)
            V_User_ID = value
        End Set
    End Property
    Property Db_No_Transaksi_Jual()
        Get
            Db_No_Transaksi_Jual = V_No_Transaksi_Jual
        End Get
        Set(ByVal value)
            V_No_Transaksi_Jual = value
        End Set
    End Property
    Property Db_Tanggal()
        Get
            Db_Tanggal = V_Tanggal
        End Get
        Set(ByVal value)
            V_Tanggal = value
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
    Property DbStatus()
        Get
            DbStatus = V_Status
        End Get
        Set(ByVal value)
            V_Status = value
        End Set
    End Property
#End Region
#Region "Method Retur"
    Public Function Auto_Number_Retur()
        Connected()
        Dim no As String
        Cmd = New SqlCommand
        With Cmd
            .CommandText = "select id_retur from tbl_retur_penjualan where left (id_retur,4)='" & Now.ToString("yyMM") & "'order by id_retur desc"
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
            F_Transaksi_Retur_Jual.TxtNoTrans.Text = Now.ToString("yyMM") + no
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
                .AddWithValue("@1", Db_No_Transaksi_Retur)
                .AddWithValue("@2", Db_User_ID)
                .AddWithValue("@3", Db_No_Transaksi_Jual)
                .AddWithValue("@4", Db_Tanggal)
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
                .AddWithValue("@1", Db_No_Transaksi_Retur)
                .AddWithValue("@2", Db_Product_ID)
                .AddWithValue("@3", Db_Jumlah)
            End With
            .ExecuteNonQuery()
            .Parameters.Clear()
            .Dispose()
        End With
        Disconnected()
        Return SP_SAVE_DETAIL
    End Function
    Public Function Get_Lookup_Retur(ByVal retur As String)
        Connected()
        Cmd = New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.StoredProcedure
            .CommandText = retur
            With Cmd.Parameters
                .AddWithValue("@1", SqlDbType.Char).Value = F_Transaksi_Retur_Jual.LookTransaksi.EditValue
            End With
            Read = .ExecuteReader
            While Read.Read
                F_Transaksi_Retur_Jual.DataGrid.Rows.Add(Read.Item(1), Read.Item(2), Read.Item(3), Read.Item(4), Read.Item(5), Read.Item(6))
            End While
            .Dispose()
            Read.Close()
            Disconnected()
        End With
        Return retur
    End Function
    Public Function Get_Edit_Value(ByVal values As String)
        Connected()
        Cmd = New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.StoredProcedure
            .CommandText = values
            With Cmd.Parameters
                .AddWithValue("@1", SqlDbType.Char).Value = F_Transaksi_Retur_Jual.LookTransaksi.EditValue
            End With
            Read = .ExecuteReader
            If Read.Read Then
                F_Transaksi_Retur_Jual.TxtUser.EditValue = Read.Item(1)
                F_Transaksi_Retur_Jual.txtpelanggan.EditValue = Read.Item(2)
                F_Transaksi_Retur_Jual.DateEdit1.EditValue = Read.Item(3)
                F_Transaksi_Retur_Jual.TextEdit2.EditValue = Read.Item(4)
            End If
            .Dispose()
            Read.Close()
            Disconnected()
        End With
        Return values
    End Function
    Public Function Get_Head_Data(ByVal head As String)
        Dim da As New SqlDataAdapter(head, Con)
        Dim ds As New DataSet
        da.Fill(ds, "tbl_head_jual")
        With F_Transaksi_Retur_Jual.LookTransaksi
            .Properties.DataSource = ds.Tables("tbl_head_jual")
            .Properties.DisplayMember = "Nama Pelanggan"
            .Properties.ValueMember = "ID"
            ' .ItemIndex = 0
        End With
        da.Dispose()
        ds.Dispose()
        Disconnected()
        Return head
    End Function
#End Region
  
   


End Class
