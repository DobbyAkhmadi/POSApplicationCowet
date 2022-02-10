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
Public Class F_Add_Produk
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
#Region "Function Object"
    Private Sub _Disabled(ByVal a As Boolean)
        BtnSimpan.Enabled = a
        '    Btnubah.Enabled = a
        txtid.Enabled = a
        LookUpEdit1.Enabled = a
        '  LookUpEdit1.Enabled = a
        txtnama.Enabled = a
        txtbeli.Enabled = a
        txtjual.Enabled = a
        txtstok.Enabled = a
    End Sub
    Private Sub format_currency()
        txtbeli.Properties.DisplayFormat.FormatType = FormatType.Numeric
        txtbeli.Properties.DisplayFormat.FormatString = "c2"
        txtjual.Properties.DisplayFormat.FormatType = FormatType.Numeric
        txtjual.Properties.DisplayFormat.FormatString = "c2"
    End Sub
    
    Private Sub clear_field()
        txtid.EditValue = ""
        txtjual.EditValue = ""
        txtbeli.EditValue = ""
        txtstok.EditValue = ""
        txtnama.EditValue = ""
        LookUpEdit1.Reset()
    End Sub
#End Region
#Region "Event"
    Private Sub F_Produk_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        clear_field()
    End Sub
    ''Private Sub LookUpEdit1_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LookUpEdit1.EditValueChanged
    ''    txtkategori.Text = LookUpEdit1.EditValue
    ''End Sub
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

    Private Sub GridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        format_currency()
        _Disabled(1)
        BtnSimpan.Enabled = 0
        txtnama.Focus()
    End Sub


    Private Sub txtnama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (e.KeyChar >= "!" And e.KeyChar <= "+") Then
            e.Handled() = True
        End If
    End Sub

    Private Sub cbid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled() = True
        End If
        If ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled() = True
        End If
    End Sub
    Private Sub txtjual_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not (((e.KeyChar >= Chr(48)) And (e.KeyChar <= Chr(57))) Or (e.KeyChar = Chr(8))) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtbeli_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not (((e.KeyChar >= Chr(48)) And (e.KeyChar <= Chr(57))) Or (e.KeyChar = Chr(8))) Then
            e.KeyChar = ""
        End If
    End Sub

#End Region

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x As String
        x = MsgBox("Batal Input?", vbQuestion + vbYesNo, "Pesan")
        If x = vbYes Then
            _Disabled(0)
            clear_field()
        End If
    End Sub
    Private Sub BtnView_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            format_currency()
            Clear_Adapter()
            View_Produk()
            clear_field()
        Catch ex As Exception
            Pesan_Error("" + ex.Message + "" + CRUD_Module.pesan_error + "")
        End Try
    End Sub

    Private Sub F_Produk_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        format_currency()
        AutoNumber_Produk()
        Get_Kategori_Produk()
    End Sub

    Private Sub LookUpEdit1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Get_Kategori_Produk()
    End Sub


    Private Sub txtnama_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim i As Integer = txtnama.SelectionStart
        txtnama.Text = StrConv(txtnama.Text, VbStrConv.ProperCase)
        txtnama.SelectionStart = i
    End Sub

    'Private Sub GridView1_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs)
    '    format_currency()
    '    txtid.Text = GridView1.GetFocusedRowCellValue("ID Produk").ToString
    '    LookUpEdit1.EditValue = GridView1.GetFocusedRowCellValue("Kategori")
    '    txtnama.Text = GridView1.GetFocusedRowCellValue("Nama Produk").ToString
    '    txtbeli.Text = Convert.ToDouble(GridView1.GetFocusedRowCellValue("Harga Beli"))
    '    txtjual.Text = Convert.ToDouble(GridView1.GetFocusedRowCellValue("Harga Jual"))
    '    txtstok.Text = Convert.ToInt16(GridView1.GetFocusedRowCellValue("Stok"))
    'End Sub

    
    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If LookUpEdit1.EditValue = Nothing Then
            Pesan_Peringatan("lengkapi Kategori Produknya yaa! :)")
        ElseIf txtnama.Text = "" Then
            Pesan_Peringatan("Lengkapi Nama Produknya yaa! :)")
        ElseIf txtjual.Text = "" Then
            Pesan_Peringatan("lengkapi harga jual Produknya yaa! :)")
        ElseIf txtbeli.Text = "" Then
            Pesan_Peringatan("lengkapi harga beli Produknya yaa! :)")
        Else
            Try
                Save_Produk(txtid.EditValue, LookUpEdit1.EditValue, txtnama.EditValue, txtbeli.EditValue, txtjual.EditValue, txtstok.EditValue)
                Pesan_Simpan()
                clear_field()
                Me.Hide()
            Catch ex As Exception
                Pesan_Error("" + ex.Message + "" + CRUD_Module.pesan_error + "")
            End Try
        End If
    End Sub
End Class