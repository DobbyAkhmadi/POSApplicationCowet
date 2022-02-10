Imports DevExpress.UserSkins.OfficeSkins
Imports System.IO.File
Imports DevExpress.XtraBars
Imports DevExpress.XtraTabbedMdi
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Base
Imports System.Globalization
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports System.IO
Imports System.Security.Principal
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Controls
Imports DevComponents.DotNetBar
Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class F_Transaksi_Jual
    Inherits DevExpress.XtraEditors.XtraForm
#Region "pesan"
    Private Sub Pesan_Baru()
        NotifyIcon1.Icon = Me.Icon
        NotifyIcon1.Visible = True
        NotifyIcon1.ShowBalloonTip(5000, "Pesan", "Data Baru !", ToolTipIcon.Info)
    End Sub
    Private Sub Pesan_Simpan()
        NotifyIcon1.Icon = Me.Icon
        NotifyIcon1.Visible = True
        NotifyIcon1.ShowBalloonTip(5000, "Pesan", "Data Telah Tersimpan!", ToolTipIcon.Info)
    End Sub
    Private Sub Pesan_Batal()
        NotifyIcon1.Icon = Me.Icon
        NotifyIcon1.Visible = True
        NotifyIcon1.ShowBalloonTip(5000, "Pesan", "Input Data Dibatalkan !", ToolTipIcon.Info)
    End Sub
    Private Sub Pesan_Peringatan(ByVal xx As String)
        NotifyIcon1.Icon = Me.Icon
        NotifyIcon1.Visible = True
        NotifyIcon1.ShowBalloonTip(5000, "Pesan", xx, ToolTipIcon.Warning)
    End Sub
    Private Sub Pesan_Custom(ByVal xx As String)
        NotifyIcon1.Icon = Me.Icon
        NotifyIcon1.Visible = True
        NotifyIcon1.ShowBalloonTip(5000, "Pesan", xx, ToolTipIcon.Info)
    End Sub
    Private Sub Pesan_Ubah()
        NotifyIcon1.Icon = Me.Icon
        NotifyIcon1.Visible = True
        NotifyIcon1.ShowBalloonTip(5000, "Pesan", "Data Telah Terubah!", ToolTipIcon.Warning)
    End Sub
    Private Sub Pesan_Hapus()
        NotifyIcon1.Icon = Me.Icon
        NotifyIcon1.Visible = True
        NotifyIcon1.ShowBalloonTip(5000, "Pesan", "Data Telah Terhapus!", ToolTipIcon.Info)
    End Sub
    Public Sub Pesan_Error(ByVal x As String)
        NotifyIcon1.Icon = Icon
        NotifyIcon1.Visible = True
        NotifyIcon1.ShowBalloonTip(5000, "Pesan", x, ToolTipIcon.Error)
    End Sub
#End Region
#Region "Function"
    Private Sub currency()
        DataGrid.Columns(3).DefaultCellStyle.Format = "c2"
        DataGrid.Columns(5).DefaultCellStyle.Format = "c2"
        DataGrid.Refresh()
    End Sub
    Private Sub Activated_(ByVal a As Boolean)
        BtnBaru.Enabled = Not a
        BtnSimpan.Enabled = a
        BtnBatal.Enabled = a
        BtnTambah.Enabled = a
        TxtTotalHarga.Enabled = a
        TxtNoTrans.Enabled = a
        TxtJumlah.Enabled = a
        ' TxtDiskon.Enabled = a
        txtpelanggan.Enabled = a
        DateTanggal.Enabled = a
        LookProduk.Enabled = a
        LookPembayaran.Enabled = a
        TxtGrand.Enabled = a
        GroupControl5.Enabled = a
        ComboBoxEdit1.Enabled = a
        TxBayar.Enabled = a
        TxKembali.Enabled = a
        TxtKategori.Enabled = a
    End Sub
    Private Sub Total_Harga()
        Dim tot As Double = 0
        For x As Integer = 0 To DataGrid.RowCount - 1
            tot = tot + DataGrid.Rows(x).Cells(5).Value
        Next
        TxtTotalHarga.EditValue = tot
    End Sub
    Private Sub clear_txt()
        DataGrid.Rows.Clear()
        TxtNoTrans.Text = ""
        txtpelanggan.Text = ""
        LookProduk.EditValue = ""
        LookPembayaran.EditValue = ""
        Label3.ResetText()
        TxtDiskon.EditValue = ""
        TxtGrand.EditValue = ""
        TxtTotalHarga.ResetText()
        TxtDiskon.ResetText()
        TxtKreditPersen.ResetText()
        TxBayar.Text = ""
        TxKembali.Text = ""
    End Sub
#End Region
#Region "Event"
    Private temp As Integer = Nothing
    Private Sub LookProduk_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LookProduk.EditValueChanged
        Try
            ComboBoxEdit1.Properties.Items.Clear()
            With ComboBoxEdit1.Properties
                ComboBoxEdit1.Properties.DisplayFormat.FormatType = FormatType.Custom
                ComboBoxEdit1.Properties.DisplayFormat.FormatString = "c2"
                .Items.Add(Convert.ToDouble(LookProduk.GetColumnValue("Beli")))
                .Items.Add(Convert.ToDouble(LookProduk.GetColumnValue("Jual")))
            End With
            ComboBoxEdit1.EditValue = Convert.ToDouble(LookProduk.GetColumnValue("Jual"))
            TxtKategori.EditValue = LookProduk.GetColumnValue("Kategori")
            temp = LookProduk.GetColumnValue("Stok")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TxtGrandTotal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtTotalHarga.EditValueChanged
        Try
            TxtTotalHarga.Text = FormatCurrency(TxtTotalHarga.Text)
            Label3.Text = Terbilang(TxtTotalHarga.EditValue) + "Rupiah"
            For a As Integer = 0 To DataGrid.RowCount - 1
                DataGrid.Rows(a).Cells(5).Value = Val(DataGrid.Rows(a).Cells(3).Value) * Val(DataGrid.Rows(a).Cells(4).Value)
            Next
            TxtGrand.EditValue = TxtTotalHarga.EditValue
            tmp_kredit = TxtGrand.EditValue
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TextEdit1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtTotalHarga.TextChanged
        Try
            Label3.Text = Terbilang(TxtTotalHarga.EditValue) + "Rupiah"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DataGrid_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGrid.CellEndEdit
        If e.ColumnIndex = 3 Then
            DataGrid.Rows(e.RowIndex).Cells(5).Value = DataGrid.Rows(e.RowIndex).Cells(3).Value * DataGrid.Rows(e.RowIndex).Cells(4).Value
        ElseIf e.ColumnIndex = 4 Then
            DataGrid.Rows(e.RowIndex).Cells(5).Value = DataGrid.Rows(e.RowIndex).Cells(3).Value * DataGrid.Rows(e.RowIndex).Cells(4).Value
        End If
        Total_Harga()
        Pesan_Custom("Jumlah Telah Diperbaharui Menjadi " + Convert.ToString(DataGrid.Rows(e.RowIndex).Cells(4).Value) + " :)")
    End Sub

    Private Sub DataGrid_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles DataGrid.RowsAdded
        For a As Integer = 0 To DataGrid.RowCount - 1
            DataGrid.Rows(a).Cells(5).Value = Val(DataGrid.Rows(a).Cells(3).Value) * Val(DataGrid.Rows(a).Cells(4).Value)
        Next
    End Sub
    Private Sub DataGrid_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGrid.CellClick
        Try
            If e.ColumnIndex = 3 Then
                DataGrid.Rows(e.RowIndex).Cells(5).Value = DataGrid.Rows(e.RowIndex).Cells(3).Value * DataGrid.Rows(e.RowIndex).Cells(4).Value
            ElseIf e.ColumnIndex = 4 Then
                DataGrid.Rows(e.RowIndex).Cells(5).Value = DataGrid.Rows(e.RowIndex).Cells(3).Value * DataGrid.Rows(e.RowIndex).Cells(4).Value
            End If
            Total_Harga()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DataGrid_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DataGrid.UserDeletedRow
        Total_Harga()
    End Sub
    Private Sub DataGrid_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles DataGrid.UserDeletingRow
        If MsgBox("Data Akan Di Hapus?", vbQuestion + vbYesNo, "Pesan") = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub
    Private Sub F_Transaksi_Jual_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        clear_txt()
    End Sub
#End Region
#Region "CRUD"
    Private Sub BtnBaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBaru.Click
        DateTanggal.EditValue = Now.ToString("dd/MMM/yyyy")
        Activated_(1)
        Auto_Jual()
        Get_Data_Pembayaran()
        Get_Data_Produk()
    End Sub
    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If LookPembayaran.Text = "" Then
            Pesan_Peringatan("Pilih pembayaran VIA")
        ElseIf txtpelanggan.Text = "" Then
            Pesan_Peringatan("Inputkan Nama Pelanggan")
        Else
            Dim a As String = FormatCurrency(TxtGrand.Text)
            Try
                Save_Head(TxtNoTrans.Text,
                          Form_Admin.ToolStripLabel2.Text,
                          txtpelanggan.Text,
                          LookPembayaran.EditValue,
                          DateTanggal.EditValue,
                          Status, TxtKreditPersen.EditValue,
                          TxtDiskon.EditValue,
                          tmp_kredit)
                Save_Detail()
                Pesan_Simpan()
                DirectPrint_Faktur("Rpt\Rpt_Jual.rpt", "TBL_HEAD_JUAL.ID_TRANSAKSI_JUAL", TxtNoTrans.Text, a)
                Activated_(0)
                clear_txt()
            Catch x As Exception
                Pesan_Error("" + x.Message + "" + CRUD_Module.pesan_error + "")
            End Try
        End If
    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        If TxtJumlah.Text = "" Then
            Pesan_Peringatan("Inputkan Jumlah Produk :)")
        ElseIf TxtJumlah.Value = 0 Then
            Pesan_Peringatan("Minimal Jumlah input 1 Produk :)")
        ElseIf TxtJumlah.Value < 0 Then
            Pesan_Peringatan("input barang tidak boleh minus :)")
        ElseIf Status = "" Then
            Pesan_Peringatan("pilih tipe pembayaran nya :)")
        Else
            Try
                Chek_Stok()
                If Read.Read Then
                    If Val(TxtJumlah.EditValue) > Val(Read.Item(1)) Then
                        Pesan_Peringatan("Maaf jumlah stok produk " + Convert.ToString(Read(0)) + " yang ada hanya " + Convert.ToString(Read(1)) + " :)")
                    Else
                        For i As Integer = 0 To DataGrid.Rows.GetLastRow(DataGridViewElementStates.None)
                            If DataGrid.Rows(i).Cells(0).Value = LookProduk.EditValue Then
                                DataGrid.Rows(i).Cells(4).Value = Val(DataGrid.Rows(i).Cells(4).Value) + Val(TxtJumlah.Value)
                                DataGrid.Rows(i).Cells(5).Value = Val(DataGrid.Rows(i).Cells(4).Value) * Val(DataGrid.Rows(i).Cells(3).Value)
                                Total_Harga()
                                If DataGrid.Rows(i).Cells(4).Value > temp Then
                                    DataGrid.Rows(i).Cells(4).Value = DataGrid.Rows(i).Cells(4).Value - Val(TxtJumlah.Value)
                                    Pesan_Peringatan("Jumlah Tidak Bisa ditambahkan Karena Stok Sisa " + Convert.ToString(temp) + " Produk  Maaf yah :)")
                                Else
                                    Pesan_Custom("Jumlah Telah ditambahkan " + Convert.ToString(TxtJumlah.EditValue) + " Produk :)")
                                    TxtJumlah.EditValue = ""
                                End If
                                Exit Sub
                            End If
                        Next i
                        View_Detail()
                        Total_Harga()
                        currency()
                        TxtJumlah.EditValue = ""
                        TxtKreditPersen.EditValue = 0
                        TxtDiskon.EditValue = 0
                    End If
                End If
                Read.Close()
                Disconnected()
            Catch ex As Exception
                Pesan_Error("" + ex.Message + "" + CRUD_Module.pesan_error + "")
            End Try
        End If

    End Sub
    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        Dim x As String
        x = MsgBox("Batal Input?", vbQuestion + vbYesNo, "Pesan")
        If x = vbYes Then
            Activated_(0)
            clear_txt()
            Clear_Adapter()
        End If
    End Sub
#End Region

    Private Sub F_Transaksi_Jual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clear_Adapter()
        Activated_(0)
        TxtDiskon.Enabled = 0
        TxtKreditPersen.Enabled = 0

    End Sub

    Private Sub ComboBoxEdit1_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxEdit1.EditValueChanged
        ComboBoxEdit1.Properties.DisplayFormat.FormatType = FormatType.Numeric
        ComboBoxEdit1.Properties.DisplayFormat.FormatString = "c2"
    End Sub
    '--------------------------------
    Public Status As String = "Debit"
    '--------------------------------
    Public data1 As Double = 0
    Public Val1 As Double
    Public val2 As Double
    '===============
    Public data22 As Double = 0
    Public b As Double
    Public bbb As Double
    '--------------------------------
    Public data2 As Double = 0
    Public aa As Double
    Public cc As Double
    Public bb As Double
    Public data As Double = 0
    Public bc As Double
    Public tmp_kredit As Double
    Private Sub Data_Min()
        If Status = "Kredit" Then
            data1 = TxtTotalHarga.EditValue * (Val(TxtKreditPersen.EditValue) / 100)
            Val1 = data1
            b = TxtTotalHarga.EditValue
            TxtGrand.EditValue = FormatCurrency(b + Val1)
            tmp_kredit =TxtGrand.EditValue
        ElseIf Status = "DiskonKredit" Then
            data2 = TxtTotalHarga.EditValue * (Val(TxtKreditPersen.EditValue) / 100)
            aa = data2
            bb = TxtTotalHarga.EditValue
            data = TxtTotalHarga.EditValue * (Val(TxtDiskon.EditValue) / 100)
            cc = data
            bc = TxtTotalHarga.EditValue
            TxtGrand.EditValue = FormatCurrency(bc - cc + aa)
            tmp_kredit = TxtGrand.EditValue
        ElseIf Status = "Debit" Then
            TxtGrand.EditValue = TxtTotalHarga.EditValue
            tmp_kredit = TxtGrand.EditValue
        ElseIf Status = "Diskon" Then
            data22 = TxtTotalHarga.EditValue * (Val(TxtDiskon.EditValue) / 100)
            val2 = data22
            bbb = TxtTotalHarga.EditValue
            TxtGrand.EditValue = FormatCurrency(bbb - val2)
            tmp_kredit = TxtGrand.EditValue
        End If
    End Sub
    Private Sub TxtDiskon_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDiskon.KeyPress
        Try
            Data_Min()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub TxtDiskon_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDiskon.EditValueChanged
        Try
            Data_Min()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub TxtKreditPersen_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtKreditPersen.EditValueChanged
        Try
            Data_Min()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub TxtKreditPersen_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtKreditPersen.KeyPress
        Try
            Data_Min()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Status = Nothing
        Try
            TxtGrand.EditValue = TxtTotalHarga.EditValue
            TxtKreditPersen.ResetText()
            TxtDiskon.ResetText()

            TxtDiskon.Enabled = 1
            TxtKreditPersen.Enabled = 1
            Status = "DiskonKredit"
        Catch ex As Exception
        End Try
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Status = Nothing
        Try
            TxtGrand.EditValue = TxtTotalHarga.EditValue
            tmp_kredit = TxtGrand.EditValue

            TxtDiskon.Enabled = 0
            TxtKreditPersen.Enabled = 0

            Status = "Debit"
        Catch ex As Exception

        End Try

    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Status = Nothing
        Try
            TxtGrand.EditValue = TxtTotalHarga.EditValue
            TxtKreditPersen.ResetText()
            TxtDiskon.ResetText()

            TxtKreditPersen.Enabled = 1
            TxtDiskon.Enabled = 0

            Status = "Kredit"
        Catch ex As Exception

        End Try
      
    End Sub
    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        Status = Nothing
        Try
            TxtGrand.EditValue = TxtTotalHarga.EditValue
            TxtKreditPersen.ResetText()
            TxtDiskon.ResetText()

            TxtDiskon.Enabled = 1
            TxtKreditPersen.Enabled = 0

            Status = "Diskon"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TxBayar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxBayar.KeyDown
        If e.KeyCode = Keys.Return Then
            Dim kembalian As Double
            Dim total_uang As Double
            Dim total_biaya As Double
            total_biaya = TxtGrand.EditValue
            total_uang = TxBayar.EditValue
            '  If total_uang >= total_biaya Then
            kembalian = TxtGrand.EditValue - TxBayar.EditValue
            TxKembali.EditValue = FormatCurrency(kembalian)
            ' End If
        End If
    End Sub
    Dim kem As Double

    Private Sub TxBayar_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxBayar.KeyUp
        TxBayar_KeyDown(sender, e)
    End Sub

    
End Class
