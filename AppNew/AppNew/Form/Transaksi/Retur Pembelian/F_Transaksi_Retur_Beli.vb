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

Public Class F_Transaksi_Retur_Beli

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
    Private Sub Clear_()
        TxtNoTrans.Text = ""
        TxtUser.Text = ""
        TxTPemasok.Text = ""
        LookTransaksiBeli.EditValue = ""
        DataGrid.Rows.Clear()
        TextEdit1.EditValue = ""
        TxtAlamat.Text = ""
        TxtBayar.Text = ""
        TxtTelp.Text = ""
    End Sub
    Private Sub currency()
        DataGrid.Columns(3).DefaultCellStyle.Format = "c"
        DataGrid.Columns(7).DefaultCellStyle.Format = "c"
        DataGrid.Refresh()
    End Sub
    Private Sub Total_Harga()
        Dim tot As Double = 0
        For x As Integer = 0 To DataGrid.RowCount - 1
            tot = tot + DataGrid.Rows(x).Cells(7).Value
        Next
        TextEdit1.EditValue = tot
    End Sub
    Private Sub Activated_(ByVal a As Boolean)
        BtnBaru.Enabled = Not a
        BtnSimpan.Enabled = a
        BtnBatal.Enabled = a
        BtnTambah.Enabled = a
        '  BtnHapus.Enabled = a
        TxtNoTrans.Enabled = a
        TxTPemasok.Enabled = a
        DateTanggal.Enabled = a
        LookTransaksiBeli.Enabled = a
        DateEdit1.Enabled = a
        TxtUser.Enabled = a
        TxtAlamat.Enabled = a
        TxTPemasok.Enabled = a
        TxtTelp.Enabled = a
    End Sub
#End Region
#Region "Event"

    Private Sub F_Transaksi_Retur_Jual_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Clear_()
    End Sub

    Private Sub DataGrid_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles DataGrid.UserDeletingRow
        If MsgBox("Data Akan Di Hapus?", vbQuestion + vbYesNo, "Pesan") = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub DataGrid_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DataGrid.UserDeletedRow
        Total_Harga()
    End Sub


    Private Sub SimpleButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim a As String
        a = MsgBox("Hapus?", vbQuestion + vbYesNo, "Pesan")
        If a = vbYes Then
            For Each row As DataGridViewRow In DataGrid.SelectedRows
                DataGrid.Rows.Remove(row)
            Next
        End If

    End Sub
    Private Sub TextEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextEdit1.EditValueChanged
        TextEdit1.Properties.DisplayFormat.FormatType = FormatType.Numeric
        TextEdit1.Properties.DisplayFormat.FormatString = "c2"
    End Sub
    Private Sub LookUpEdit2_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LookTransaksiBeli.EditValueChanged
        Try
            Get_View_Lookup_Beli()
            currency()
        Catch ex As Exception
            Pesan_Error("" + ex.Message + "" + CRUD_Module.pesan_error + "")
        End Try
    End Sub


    Private Sub DataGrid_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles DataGrid.RowsAdded
        Try
            DataGrid.Rows(e.RowIndex).Cells(7).Value = DataGrid.Rows(e.RowIndex).Cells(3).Value * DataGrid.Rows(e.RowIndex).Cells(4).Value
            currency()
            Total_Harga()
        Catch ex As Exception
            Pesan_Error("" + ex.Message + "" + CRUD_Module.pesan_error + "")
        End Try
    End Sub
    Private Sub DataGridViewX1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGrid.CellEndEdit
        Try
            If DataGrid.Rows(e.RowIndex).Cells(6).Value < 0 Then
                BtnTambah_Click(sender, e)
                Pesan_Peringatan("Maaf jumlah yang diinputkan tidak boleh minus :( pilih data kembali yah :)")
            ElseIf DataGrid.Rows(e.RowIndex).Cells(6).Value > DataGrid.Rows(e.RowIndex).Cells(4).Value Then
                BtnTambah_Click(sender, e)
                Pesan_Peringatan("Maaf jumlah yang diinputkan tidak boleh lebih dari " + Convert.ToString(DataGrid.Rows(e.RowIndex).Cells(4).Value) + " :( pilih data kembali yah :)")
            Else
                If e.ColumnIndex = 3 Then
                    DataGrid.Rows(e.RowIndex).Cells(7).Value = (DataGrid.Rows(e.RowIndex).Cells(4).Value - DataGrid.Rows(e.RowIndex).Cells(6).Value) * DataGrid.Rows(e.RowIndex).Cells(3).Value
                ElseIf e.ColumnIndex = 4 Then
                    DataGrid.Rows(e.RowIndex).Cells(7).Value = (DataGrid.Rows(e.RowIndex).Cells(4).Value - DataGrid.Rows(e.RowIndex).Cells(6).Value) * DataGrid.Rows(e.RowIndex).Cells(3).Value
                ElseIf e.ColumnIndex = 6 Then
                    DataGrid.Rows(e.RowIndex).Cells(7).Value = (DataGrid.Rows(e.RowIndex).Cells(4).Value - DataGrid.Rows(e.RowIndex).Cells(6).Value) * DataGrid.Rows(e.RowIndex).Cells(3).Value
                End If
            End If
            currency()
            Total_Harga()
        Catch ex As Exception
            Pesan_Error("" + ex.Message + "" + CRUD_Module.pesan_error + "")
        End Try
    End Sub

#End Region
#Region "CRUD"

    Private Sub BtnBaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBaru.Click
        DateTanggal.EditValue = Now.ToString("dd/MMM/yyyy")
        Activated_(1)
        Auto_Beli_Retur()
        Get_View_Head_Beli()
    End Sub
    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        Try
            Save_Head_Retur_Beli()
            Update_Detail_Retur_Beli()
            Pesan_Simpan()
            DirectPrint_Faktur("Rpt\Rpt_R_Beli.rpt", "tbl_retur_pembelian.id_retur_beli", TxtNoTrans.Text)
            Activated_(0)
            Clear_()
            Clear_Adapter()
        Catch ex As Exception
            Pesan_Error("" + ex.Message + "" + CRUD_Module.pesan_error + "")
        End Try
    End Sub
    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        If LookTransaksiBeli.EditValue = "" Then
            Pesan_Peringatan("Pilih dulu yah produknya :)")
        Else
            Try
                DataGrid.Rows.Clear()
                Clear_Adapter()
                Get_View_Retur_Detail_Beli()
                Total_Harga()
                currency()
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
            Clear_()
        End If
    End Sub
#End Region
    Private Sub F_Transaksi_Jual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clear_Adapter()
        Activated_(0)
    End Sub

  
End Class
