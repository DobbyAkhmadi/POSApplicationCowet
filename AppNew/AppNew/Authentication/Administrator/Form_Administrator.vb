Imports System.ComponentModel
Imports System.Text
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins
Imports DevExpress.XtraEditors
Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.DashboardCommon


Public Class Form_Admin
    Private Server = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\InovindoPointOfSale", "Server", Nothing)
    Private Database = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\InovindoPointOfSale", "Database", Nothing)
    Private Userid = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\InovindoPointOfSale", "UserID", Nothing)
    Private password = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\InovindoPointOfSale", "Password", Nothing)
    Sub New()
        InitSkins()
        InitializeComponent()
    End Sub
    Sub InitSkins()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        UserLookAndFeel.Default.SetSkinStyle("Caramel")
    End Sub
#Region "Mesage"

    Private Sub Pesan_Error(ByVal xx As String)
        NotifyIcon1.Icon = Me.Icon
        NotifyIcon1.Visible = True
        NotifyIcon1.ShowBalloonTip(5000, "Pesan", xx, ToolTipIcon.Info)
    End Sub
    Private Sub Pesan_Warning(ByVal xx As String)
        NotifyIcon1.Icon = Me.Icon
        NotifyIcon1.Visible = True
        NotifyIcon1.ShowBalloonTip(5000, "Pesan", xx, ToolTipIcon.Warning)
    End Sub

    Private Sub Pesan_Baru()
        NotifyIcon1.Icon = Me.Icon
        NotifyIcon1.Visible = True
        NotifyIcon1.ShowBalloonTip(5000, "Pesan", "Anda Sudah Keluar Aplikasi, Terima Kasih atas Kontribusinya :) Salam Antusias !", ToolTipIcon.Info)
    End Sub
#End Region
#Region "Menu"
    Private Sub calendarItem_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles calendarItem.LinkClicked
        F_Transaksi_Jual.ShowDialog()
    End Sub

    Private Sub tasksItem_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles tasksItem.LinkClicked
        F_Transaksi_Beli.ShowDialog()
    End Sub

    Private Sub NavBarItem1_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem1.LinkClicked
        F_Transaksi_Retur_Jual.ShowDialog()
    End Sub

    Private Sub NavBarItem2_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem2.LinkClicked
        F_Transaksi_Retur_Beli.ShowDialog()
    End Sub

    Private Sub inboxItem_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles BtnBarang.LinkClicked
        F_Produk.ShowDialog()
    End Sub

    Private Sub outboxItem_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles BtnPemasok.LinkClicked
        F_Pemasok.ShowDialog()
    End Sub

    Private Sub draftsItem_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles BtnPembayaran.LinkClicked
        F_Pembayaran.ShowDialog()
    End Sub

    Private Sub trashItem_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles BtnKategori.LinkClicked
        F_Kategori.ShowDialog()
    End Sub

#End Region
    Public Sub Load_Dashboard(Path As String)
        Dim AppDash As Dashboard = New Dashboard
        AppDash.LoadFromXml(Application.StartupPath & Path)
        DashboardViewer1.Dashboard = AppDash
        DashboardViewer1.Refresh()
    End Sub

    Private Sub Form_Administrator_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim x As Integer
        x = MsgBox("Keluar Aplikasi?", vbQuestion + vbYesNo, "Pesan")
        If x = vbYes Then
            Me.Hide()
            Pesan_Baru()
            F_Login.Show()
            F_Login.TxtUser.Clear()
            F_Login.TxtPass.Clear()
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub Form_Administrator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub



    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If DateEdit1.EditValue > DateEdit2.EditValue Then
            Pesan_Warning("Maaf tanggal yang di pilih tidak boleh melebihi tanggal " + DateEdit2.EditValue + "")
        Else
            If DateEdit1.EditValue > DateEdit2.EditValue Then
                MsgBox("Tanggal Tidak Boleh Kurang Dari Tanggal Sekarang", vbInformation, "Pesan")
            Else
                If ComboBoxEdit1.SelectedIndex = 0 Then
                    General_Report("Laporan Filter Penjualan",
                                   "Rpt\Rpt_Penjualan.rpt",
                                   DateEdit1.EditValue, DateEdit2.EditValue,
                                   "tbl_head_jual.tanggal")
                ElseIf ComboBoxEdit1.SelectedIndex = 1 Then
                    General_Report("Laporan Filter Pembelian",
                                   "Rpt\Rpt_Pembelian.rpt",
                                   DateEdit1.EditValue, DateEdit2.EditValue,
                                   "tbl_head_beli.tanggal")
                ElseIf ComboBoxEdit1.SelectedIndex = 2 Then
                    General_Report("Laporan Filter Retur Penjualan",
                                   "Rpt\Rpt_R_Penjualan.rpt",
                                   DateEdit1.EditValue, DateEdit2.EditValue,
                                   "tbl_retur_penjualan.tanggal")
                ElseIf ComboBoxEdit1.SelectedIndex = 3 Then
                    General_Report("Laporan Filter Retur Pembelian",
                                   "Rpt\Rpt_R_Pembelian.rpt",
                                   DateEdit1.EditValue, DateEdit2.EditValue,
                                   "tbl_retur_pembelian.tanggal")
                End If
            End If
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        If DateEdit1.EditValue > DateEdit2.EditValue Then
            Pesan_Warning("Maaf tanggal yang di pilih tidak boleh melebihi tanggal " + DateEdit2.EditValue + "")
        Else
            If ComboBoxEdit2.SelectedIndex = 0 Then
                General_Report("Laporan Stok Barang", "Rpt\Rpt_Daftar_Barang.rpt")
            ElseIf ComboBoxEdit2.SelectedIndex = 1 Then
                General_Report("Laporan Daily Stok Barang Keluar",
                               "Rpt\Rpt_Barang_Keluar.rpt",
                               DateEdit4.EditValue, DateEdit3.EditValue,
                               "barang_keluar.TANGGAL")

            ElseIf ComboBoxEdit2.SelectedIndex = 2 Then
                General_Report("Laporan Daily Stok Barang Masuk",
                               "Rpt\Rpt_Barang_Masuk.rpt",
                               DateEdit4.EditValue, DateEdit3.EditValue,
                               "barang_masuk.tanggal")

            End If

        End If

    End Sub

    Private Sub SimpleButton4_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton4.Click
        General_Report("Laporan Laba Rugi", "Rpt\Rpt_LabaRugi.rpt")
    End Sub

    Private Sub DashboardViewer1_ConfigureDataConnection(sender As Object, e As DevExpress.DataAccess.ConfigureDataConnectionEventArgs) Handles DashboardViewer1.ConfigureDataConnection
        Dim pcp As MsSqlConnectionParameters = TryCast(e.ConnectionParameters, MsSqlConnectionParameters)
        With pcp
            .ServerName = Server
            .DatabaseName = Database
            .UserName = Userid
            .Password = password
            .AuthorizationType = MsSqlAuthorizationType.SqlServer
        End With
    End Sub

    Private Sub NavBarItem3_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles BtnPengguna.LinkClicked
        F_User.ShowDialog()
    End Sub


    Private Sub iExit_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles iExit.ItemClick
        Dim x As Integer
        x = MsgBox("Keluar Aplikasi?", vbQuestion + vbYesNo, "Pesan")
        If x = vbYes Then
            Me.Hide()
            Pesan_Baru()
            F_Login.Show()
            F_Login.TxtUser.Clear()
            F_Login.TxtPass.Clear()
        End If
    End Sub
End Class
