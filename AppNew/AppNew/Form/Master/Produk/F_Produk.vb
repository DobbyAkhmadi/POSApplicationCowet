Imports System.Data.SqlClient
Imports DevExpress.XtraBars
Imports DevExpress.XtraTabbedMdi
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Base
Imports System.Globalization
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Public Class F_Produk
    Private cls As New ClassProduk
    Private ciUSA As CultureInfo = New CultureInfo("id")
    Private ciEUR As CultureInfo = New CultureInfo("id", False)
#Region "Pesan"
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
        NotifyIcon1.ShowBalloonTip(5000, "Pesan", "Data Telah Terubah!", ToolTipIcon.Info)
    End Sub
    Private Sub Pesan_Hapus()
        NotifyIcon1.Icon = Me.Icon
        NotifyIcon1.Visible = True
        NotifyIcon1.ShowBalloonTip(5000, "Pesan", "Data Telah Terhapus!", ToolTipIcon.Info)
    End Sub
    Private Sub Pesan_Error(ByVal x As String)
        NotifyIcon1.Icon = Me.Icon
        NotifyIcon1.Visible = True
        NotifyIcon1.ShowBalloonTip(5000, "Pesan", x, ToolTipIcon.Error)
    End Sub
#End Region
    Private Sub F_Produk_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Clear_Adapter()
    End Sub
    Private Sub GridView1_CustomColumnDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs)
        Dim view As ColumnView = TryCast(sender, ColumnView)
        If e.Column.FieldName = "Harga Jual" AndAlso e.ListSourceRowIndex <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
            Dim price As Decimal = Convert.ToDecimal(e.Value)
            Dim currencyType As Integer = CInt(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "CurrencyType"))
            e.DisplayText = String.Format(ciUSA, "{0:c2}", price)
        ElseIf e.Column.FieldName = "Harga Beli" AndAlso e.ListSourceRowIndex <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
            Dim price As Decimal = Convert.ToDecimal(e.Value)
            e.DisplayText = String.Format(ciEUR, "{0:c2}", price)
        End If
    End Sub

    Private Sub BtnView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnView.Click
        Try
            Clear_Adapter()
            View_Produk()
        Catch ex As Exception
            Pesan_Error("" + ex.Message + "" + CRUD_Module.pesan_error + "")
        End Try
    End Sub

    Private Sub F_Produk_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Clear_Adapter()
    End Sub

    Private Sub BtnBaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBaru.Click
        F_Add_Produk.ShowDialog()
    End Sub

    Private Sub GridView1_CustomColumnDisplayText1(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GridView1.CustomColumnDisplayText
        Dim view As ColumnView = TryCast(sender, ColumnView)
        If e.Column.FieldName = "Harga Jual" AndAlso e.ListSourceRowIndex <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
            Dim price As Decimal = Convert.ToDecimal(e.Value)
            Dim currencyType As Integer = CInt(view.GetListSourceRowCellValue(e.ListSourceRowIndex, "CurrencyType"))
            e.DisplayText = String.Format(ciUSA, "{0:c2}", price)
        ElseIf e.Column.FieldName = "Harga Beli" AndAlso e.ListSourceRowIndex <> DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
            Dim price As Decimal = Convert.ToDecimal(e.Value)
            e.DisplayText = String.Format(ciEUR, "{0:c2}", price)
        End If
    End Sub

    Private Sub GridView1_PopupMenuShowing(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles GridView1.PopupMenuShowing
        Dim View As GridView = CType(sender, GridView)
        Dim HitInfo As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo
        HitInfo = View.CalcHitInfo(e.Point)
        If HitInfo.InRow Then
            View.FocusedRowHandle = HitInfo.RowHandle
            ContextMenuStrip1.Show(View.GridControl, e.Point)
        End If
    End Sub

    Private Sub HapusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusToolStripMenuItem.Click
        Dim a As String = MsgBox("Hapus?", vbQuestion + vbYesNo, "Pesan")
        If a = vbYes Then
            Try
                Delete_Produk(GridView1.GetFocusedRowCellValue("ID Produk").ToString())
                Pesan_Hapus()
                BtnView_Click(sender, e)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub UbahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UbahToolStripMenuItem.Click
        F_Edit_Produk.ShowDialog()
    End Sub
End Class