Imports System.ComponentModel
Imports System.Text
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraBars
Imports DevExpress.XtraTabbedMdi
Imports DevExpress.XtraPrinting.Preview.DocumentViewer
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class F_Login
    Private Sub Pesan_Custom(ByVal xx As String)
        NotifyIcon1.Icon = Me.Icon
        NotifyIcon1.Visible = True
        NotifyIcon1.ShowBalloonTip(5000, "Pesan", xx, ToolTipIcon.Info)
    End Sub
    Private Sub Pesan_Error(ByVal xx As String)
        NotifyIcon1.Icon = Me.Icon
        NotifyIcon1.Visible = True
        NotifyIcon1.ShowBalloonTip(5000, "Pesan", xx, ToolTipIcon.Info)
    End Sub
    Private Sub Pesan_Warning(ByVal xx As String)
        NotifyIcon1.Icon = Me.Icon
        NotifyIcon1.Visible = True
        NotifyIcon1.ShowBalloonTip(5000, "Pesan", xx, ToolTipIcon.Info)
    End Sub
    Sub New()
        InitSkins()
        InitializeComponent()
    End Sub
    Sub InitSkins()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        UserLookAndFeel.Default.SetSkinStyle("Office 2007 Blue")
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If TxtUser.Text = "" Then
            Pesan_Warning("Inputkan Username kamu :)")
        ElseIf TxtPass.Text = "" Then
            Pesan_Warning("Inputkan Password kamu :)")
        Else
            Try
                Authentication()
                If Read.Read Then
                    If Read.HasRows Then
                        If Read.Item(4) = "Admin" Then
                            Me.Hide()
                            Form_Admin.Show()
                            Form_Admin.ToolStripLabel2.Text = Read.Item(0)
                            Form_Admin.ToolStripLabel4.Text = Read.Item(1)
                            Form_Admin.ToolStripLabel6.Text = Read.Item(4)
                            Form_Admin.Load_Dashboard("\Dashboard\Administrator.xml")
                            Pesan_Custom("Selamat Datang " + Read.Item(1) + " di Aplikasi Inventory INOVINDO")
                            Exit Sub
                        ElseIf Read.Item(4) = "Operator" Then
                            Me.Hide()
                            Form_Admin.Show()
                            Form_Admin.ToolStripLabel2.Text = Read.Item(0)
                            Form_Admin.ToolStripLabel4.Text = Read.Item(1)
                            Form_Admin.ToolStripLabel6.Text = Read.Item(4)
                            Form_Admin.Load_Dashboard("\Dashboard\Operator.xml")
                            Form_Admin.XtraTabPage3.PageEnabled = 0
                            Form_Admin.XtraTabPage4.PageEnabled = 0
                            Form_Admin.XtraTabPage5.PageEnabled = 0
                            Form_Admin.BtnBarang.Enabled = 0
                            Form_Admin.BtnPemasok.Enabled = 0
                            Form_Admin.BtnKategori.Enabled = 0
                            Form_Admin.BtnPembayaran.Enabled = 0
                            Form_Admin.BtnPengguna.Enabled = 0
                            Form_Admin.mailGroup.Expanded = 1
                            Pesan_Custom("Selamat Datang " + Read.Item(1) + " di Aplikasi Inventory INOVINDO")
                            Exit Sub
                        ElseIf Read.Item(3) <> TxtUser.Text Then
                            Pesan_Error("Maaf username yang anda masukkan Salah :( mohon cek lagi atuh")
                        ElseIf Read.Item(4) <> TxtPass.Text Then
                            Pesan_Error("Maaf Password yang anda masukkan Salah :( mohon cek lagi atuh")
                        End If
                    End If
                End If
                Read.Close()
            Catch ex As Exception
                Pesan_Error("" + ex.Message + "" + CRUD_Module.pesan_error + "")
            End Try
        End If
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        F_Config.ShowDialog()
    End Sub

    Private Sub TxtUser_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtUser.KeyDown
        If e.KeyCode = Keys.Return Then
            TxtPass.Focus()
        End If
    End Sub

    Private Sub TxtPass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPass.KeyDown
        If e.KeyCode = Keys.Return Then
            SimpleButton1.Focus()
            SimpleButton1_Click(sender, e)
        End If
    End Sub

    Private Sub F_Log_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtUser.Clear()
        TxtPass.Clear()
    End Sub
End Class