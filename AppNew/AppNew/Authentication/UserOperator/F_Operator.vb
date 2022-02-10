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
Imports System.Data.SqlClient
Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.DashboardCommon

Public Class F_Operator

    Private Server = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\InovindoPointOfSale", "Server", Nothing)
    Private Database = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\InovindoPointOfSale", "Database", Nothing)
    Private Userid = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\InovindoPointOfSale", "UserID", Nothing)
    Private password = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\InovindoPointOfSale", "Password", Nothing)
#Region "Procedure"
    Private Sub Pesan_Error(ByVal xx As String)
        NotifyIcon1.Icon = Me.Icon
        NotifyIcon1.Visible = True
        NotifyIcon1.ShowBalloonTip(5000, "Pesan", xx, ToolTipIcon.Info)
    End Sub

    Private Sub Pesan_Baru()
        NotifyIcon1.Icon = Me.Icon
        NotifyIcon1.Visible = True
        NotifyIcon1.ShowBalloonTip(5000, "Pesan", "Anda Sudah Keluar Aplikasi, Terima Kasih atas Kontribusinya :) Salam Antusias !", ToolTipIcon.Info)
    End Sub
    Private Sub F_Main_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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
#End Region
#Region "Menu"

    Private Sub tasksItem_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles tasksItem.LinkClicked
        F_Transaksi_Beli.ShowDialog()
    End Sub

    Private Sub NavBarItem2_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem2.LinkClicked
        F_Transaksi_Retur_Beli.ShowDialog()
    End Sub

    Private Sub draftsItem_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
        F_User.ShowDialog()
    End Sub

    Private Sub NavBarItem6_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem6.LinkClicked

    End Sub


    Private Sub NavBarItem8_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem8.LinkClicked
        F_Kategori.ShowDialog()
    End Sub

    Private Sub NavBarItem9_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem9.LinkClicked
        F_Pembayaran.ShowDialog()
    End Sub

    Private Sub outboxItem_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles outboxItem.LinkClicked
        F_Pemasok.ShowDialog()
    End Sub

    Private Sub calendarItem_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles calendarItem.LinkClicked
        F_Transaksi_Jual.ShowDialog()
    End Sub

    Private Sub NavBarItem1_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem1.LinkClicked
        F_Transaksi_Retur_Jual.ShowDialog()
    End Sub

    Private Sub inboxItem_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles inboxItem.LinkClicked
        F_Produk.ShowDialog()
    End Sub

    Private Sub NavBarItem3_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem3.LinkClicked
        F_Pembayaran.ShowDialog()
    End Sub
#End Region

#Region "Config"
    Sub New()
        InitSkins()
        InitializeComponent()
    End Sub
    Sub InitSkins()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        UserLookAndFeel.Default.SetSkinStyle("Caramel")
    End Sub
    Private Sub Load_Dashboard()
        Dim AppDash As Dashboard = New Dashboard
        AppDash.LoadFromXml(Application.StartupPath & "\Dashboard\Operator.xml")
        DashboardViewer4.Dashboard = AppDash
        DashboardViewer4.Refresh()
    End Sub

#End Region
    Private Sub F_Main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Load_Dashboard()
    End Sub


    Private Sub DashboardViewer4_ConfigureDataConnection(ByVal sender As System.Object, ByVal e As DevExpress.DataAccess.ConfigureDataConnectionEventArgs) Handles DashboardViewer4.ConfigureDataConnection
        Dim pcp As MsSqlConnectionParameters = TryCast(e.ConnectionParameters, MsSqlConnectionParameters)
        With pcp
            .ServerName = Server
            .DatabaseName = Database
            .UserName = Userid
            .Password = password
            .AuthorizationType = MsSqlAuthorizationType.SqlServer
        End With
    End Sub
End Class
