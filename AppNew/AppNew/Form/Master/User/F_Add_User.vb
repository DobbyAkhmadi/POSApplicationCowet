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
Public Class F_Add_User
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
    Sub clear()
        txtid.Text = ""
        txtnama.Text = ""
        txtpwd.Text = ""
        txtuser.Text = ""
    End Sub
    Private Sub BtnSimpan_Click(sender As System.Object, e As System.EventArgs) Handles BtnSimpan.Click
        If txtnama.Text = "" Then
            Pesan_Peringatan("Inputkan Nama lengkap :)")
        ElseIf txtuser.Text = "" Then
            Pesan_Peringatan("inputkan nama pengguna/Username untuk login nanti :)")
        ElseIf txtpwd.Text = "" Then
            Pesan_Peringatan("inputkan nama sandi/password untuk login nanti :)")
        ElseIf ComboBoxEdit1.EditValue = "" Then
            Pesan_Peringatan("Pilih salah satu akses nya yah :)")
        Else
            Save_Login(txtid.Text, txtnama.Text, txtuser.Text, txtpwd.Text, ComboBoxEdit1.EditValue)
            Pesan_Simpan()
            clear()
            View_Login()

            Me.Hide()
        End If
    End Sub

    Private Sub F_Add_User_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AutoLogin()
    End Sub
End Class