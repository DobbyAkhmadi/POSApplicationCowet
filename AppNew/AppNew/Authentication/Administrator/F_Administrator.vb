'Imports System.ComponentModel
'Imports System.Text
'Imports DevExpress.Skins
'Imports DevExpress.LookAndFeel
'Imports DevExpress.UserSkins
'Imports DevExpress.XtraEditors
'Imports DevExpress.XtraBars.Helpers
'Imports DevExpress.XtraBars
'Imports DevExpress.XtraTabbedMdi
'Imports DevExpress.XtraPrinting.Preview.DocumentViewer
'Imports CrystalDecisions.CrystalReports.Engine
'Imports CrystalDecisions.Shared
'Imports System.Data.SqlClient
'Imports DevExpress.DataAccess.ConnectionParameters
'Imports DevExpress.DashboardCommon

'Public Class F_Administrator
'    Private Server = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\InovindoPointOfSale", "Server", Nothing)
'    Private Database = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\InovindoPointOfSale", "Database", Nothing)
'    Private Userid = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\InovindoPointOfSale", "UserID", Nothing)
'    Private password = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\InovindoPointOfSale", "Password", Nothing)
'#Region "Procedure"
'    Private Sub Pesan_Error(ByVal xx As String)
'        NotifyIcon1.Icon = Me.Icon
'        NotifyIcon1.Visible = True
'        NotifyIcon1.ShowBalloonTip(5000, "Pesan", xx, ToolTipIcon.Info)
'    End Sub
'    Private Sub Pesan_Warning(ByVal xx As String)
'        NotifyIcon1.Icon = Me.Icon
'        NotifyIcon1.Visible = True
'        NotifyIcon1.ShowBalloonTip(5000, "Pesan", xx, ToolTipIcon.Warning)
'    End Sub

'    Private Sub Pesan_Baru()
'        NotifyIcon1.Icon = Me.Icon
'        NotifyIcon1.Visible = True
'        NotifyIcon1.ShowBalloonTip(5000, "Pesan", "Anda Sudah Keluar Aplikasi, Terima Kasih atas Kontribusinya :) Salam Antusias !", ToolTipIcon.Info)
'    End Sub
'    Private Sub F_Main_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
'        Dim x As Integer
'        x = MsgBox("Keluar Aplikasi?", vbQuestion + vbYesNo, "Pesan")
'        If x = vbYes Then
'            Me.Hide()
'            Pesan_Baru()
'            F_Login.Show()
'            F_Login.TxtUser.Clear()
'            F_Login.TxtPass.Clear()
'            Timer1.Dispose()

'        Else
'            e.Cancel = True
'        End If
'    End Sub
'#End Region
'#Region "Menu"

'    Private Sub tasksItem_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles tasksItem.LinkClicked
'        F_Transaksi_Beli.ShowDialog()
'    End Sub

'    Private Sub NavBarItem2_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem2.LinkClicked
'        F_Transaksi_Retur_Beli.ShowDialog()
'    End Sub

'    Private Sub draftsItem_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles draftsItem.LinkClicked
'        F_User.ShowDialog()
'    End Sub

'    Private Sub NavBarItem8_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem8.LinkClicked
'        F_Kategori.ShowDialog()
'    End Sub

'    Private Sub NavBarItem9_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem9.LinkClicked
'        F_Pembayaran.ShowDialog()
'    End Sub

'    Private Sub outboxItem_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles outboxItem.LinkClicked
'        F_Pemasok.ShowDialog()
'    End Sub

'    Private Sub calendarItem_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles calendarItem.LinkClicked
'        F_Transaksi_Jual.ShowDialog()
'    End Sub

'    Private Sub NavBarItem1_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem1.LinkClicked
'        F_Transaksi_Retur_Jual.ShowDialog()
'    End Sub

'    Private Sub inboxItem_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles inboxItem.LinkClicked
'        F_Produk.ShowDialog()
'    End Sub

'    Private Sub NavBarItem3_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem3.LinkClicked
'        F_Pembayaran.ShowDialog()
'    End Sub
'#End Region
'#Region "Reporting"
'    Private Sub NavBarItem13_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
'        Try
'            General_Report("Laporan Penjualan", "Rpt\Rpt_Penjualan.rpt")
'        Catch ex As Exception
'            Pesan_Error("" + ex.Message + "" + CRUD_Module.pesan_error + "")
'        End Try
'    End Sub
'    Private Sub NavBarItem10_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
'        Try
'            General_Report("Laporan Stok Barang", "Rpt\Rpt_Daftar_Barang.rpt")
'        Catch ex As Exception
'            Pesan_Error("" + ex.Message + "" + CRUD_Module.pesan_error + "")
'        End Try
'    End Sub
'    Private Sub NavBarItem12_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
'        Try
'            General_Report("Laporan Pembelian", "Rpt\Rpt_Pembelian.rpt")
'        Catch ex As Exception
'            Pesan_Error("" + ex.Message + "" + CRUD_Module.pesan_error + "")
'        End Try
'    End Sub
'    Private Sub NavBarItem11_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem11.LinkClicked
'        Try
'            General_Report("Laporan Laba Rugi", "Rpt\Rpt_Laba_Rugi.rpt")
'        Catch ex As Exception
'            Pesan_Error("" + ex.Message + "" + CRUD_Module.pesan_error + "")
'        End Try
'    End Sub
'    Private Sub NavBarItem14_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
'        Try
'            General_Report("Laporan Retur Penjualan", "Rpt\Rpt_R_Penjualan.rpt")
'        Catch ex As Exception
'            Pesan_Error("" + ex.Message + "" + CRUD_Module.pesan_error + "")
'        End Try
'    End Sub
'    Private Sub NavBarItem15_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
'        Try
'            General_Report("Laporan Retur Pembelian", "Rpt\Rpt_R_Pembelian.rpt")
'        Catch ex As Exception
'            Pesan_Error("" + ex.Message + "" + CRUD_Module.pesan_error + "")
'        End Try
'    End Sub

'#End Region
'#Region "Config"
'    Sub New()
'        InitSkins()
'        InitializeComponent()
'        'Me.InitSkinGallery()
'    End Sub
'    Sub InitSkins()
'        DevExpress.Skins.SkinManager.EnableFormSkins()
'        DevExpress.UserSkins.BonusSkins.Register()
'        UserLookAndFeel.Default.SetSkinStyle("Caramel")
'    End Sub
'    Private Sub Load_Dashboard()
'        Dim AppDash As Dashboard = New Dashboard
'        AppDash.LoadFromXml(Application.StartupPath & "\Dashboard\Administrator.xml")
'        DashboardViewer1.Dashboard = AppDash
'        DashboardViewer1.Refresh()
'    End Sub
'    Private Sub DashboardViewer1_ConfigureDataConnection(ByVal sender As Object, ByVal e As DevExpress.DataAccess.ConfigureDataConnectionEventArgs) Handles DashboardViewer1.ConfigureDataConnection
'        Dim pcp As MsSqlConnectionParameters = TryCast(e.ConnectionParameters, MsSqlConnectionParameters)
'        With pcp
'            .ServerName = Server
'            .DatabaseName = Database
'            .UserName = Userid
'            .Password = password
'            .AuthorizationType = MsSqlAuthorizationType.SqlServer
'        End With
'    End Sub
'#End Region

'    Private Sub F_Administrator_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
'        If e.KeyCode = Keys.F5 Then
'            Load_Dashboard()
'            Pesan_Warning("Refresh Dashboard :)")
'        End If
'    End Sub

'    Private Sub F_Main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
'        Load_Dashboard()
'        '  Add_Report_List()
'        Date1.Value = Now
'        Date2.Value = Now
'    End Sub


'    Private Sub ToolStripSplitButton1_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripSplitButton1.ButtonClick
'        Load_Dashboard()
'    End Sub

'    Private Sub BtnTampil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTampil.Click
'        If Date1.Value > Date2.Value Then
'            Pesan_Warning("Maaf tanggal yang di pilih tidak boleh melebihi tanggal " + Date2.Value + "")
'        Else
'            If Date1.Value > Date2.Value Then
'                MsgBox("Tanggal Tidak Boleh Kurang Dari Tanggal Sekarang", vbInformation, "Pesan")
'            Else
'                If ComboBoxEdit1.SelectedIndex = 0 Then
'                    General_Report("Laporan Filter Penjualan Dari " + Date1.Value + " sd " + Date2.Value + "", "Rpt\Rpt_Penjualan.rpt", Date1.Value, Date2.Value, "tbl_head_jual.tanggal")
'                ElseIf ComboBoxEdit1.SelectedIndex = 1 Then
'                    General_Report("Laporan Filter Pembelian Dari " + Date1.Value + " sd " + Date2.Value + "", "Rpt\Rpt_Pembelian.rpt", Date1.Value, Date2.Value, "tbl_head_beli.tanggal")
'                ElseIf ComboBoxEdit1.SelectedIndex = 2 Then
'                    General_Report("Laporan Filter Retur Penjualan Dari " + Date1.Value + " sd " + Date2.Value + "", "Rpt\Rpt_R_Penjualan.rpt", Date1.Value, Date2.Value, "tbl_retur_penjualan.tanggal")
'                ElseIf ComboBoxEdit1.SelectedIndex = 3 Then
'                    General_Report("Laporan Filter Retur Pembelian Dari " + Date1.Value + " sd " + Date2.Value + "", "Rpt\Rpt_R_Pembelian.rpt", Date1.Value, Date2.Value, "tbl_retur_pembelian.tanggal")
'                End If
'            End If
'        End If
'    End Sub

'    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
'        If DateTimePicker1.Value > DateTimePicker1.Value Then
'            MsgBox("Tanggal Tidak Boleh Kurang Dari Tanggal Sekarang", vbInformation, "Pesan")
'        Else
'            If ComboBoxEdit1.SelectedIndex = 0 Then
'                Try
'                    General_Report("Laporan Stok Barang", "Rpt\Rpt_Daftar_Barang.rpt")
'                Catch ex As Exception
'                    Pesan_Error("" + ex.Message + "" + CRUD_Module.pesan_error + "")
'                End Try
'            End If
'        End If
'    End Sub
'End Class
