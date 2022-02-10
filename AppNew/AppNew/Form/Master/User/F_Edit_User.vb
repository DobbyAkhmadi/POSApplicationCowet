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
Public Class F_Edit_User
    Sub clear()
        txtid.Text = ""
        txtnama.Text = ""
        txtpwd.Text = ""
        txtuser.Text = ""
    End Sub
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
    Private Sub F_Edit_User_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        get_datagrid()
    End Sub
    Sub get_datagrid()
        txtid.Text = F_User.GridView1.GetFocusedRowCellValue("ID Pengguna").ToString
        txtnama.Text = F_User.GridView1.GetFocusedRowCellValue("Nama").ToString
        txtuser.Text = F_User.GridView1.GetFocusedRowCellValue("Username").ToString
        ' txtpwd.Text = F_User.GridView1.GetFocusedRowCellValue("Password").ToString
        ComboBoxEdit1.EditValue = F_User.GridView1.GetFocusedRowCellValue("Akses").ToString
    End Sub

    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click
        Update_Login(txtid.Text, txtnama.Text, txtuser.Text, txtpwd.Text, ComboBoxEdit1.EditValue)
        Pesan_Simpan()
        clear()
        View_Login()
        Me.Hide()
    End Sub
End Class