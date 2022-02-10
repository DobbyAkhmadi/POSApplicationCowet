Imports System.Drawing.Printing
Imports Microsoft.VisualBasic
Imports Microsoft.Win32
Imports System.Data.SqlClient
Public Class F_Config
    Private Sub Pesan_Warning(ByVal x As String)
        NotifyIcon1.Icon = Me.Icon
        NotifyIcon1.Visible = True
        NotifyIcon1.ShowBalloonTip(5000, "Pesan", x, ToolTipIcon.Warning)
    End Sub
    Private Sub Pesan_Error(ByVal x As String)
        NotifyIcon1.Icon = Me.Icon
        NotifyIcon1.Visible = True
        NotifyIcon1.ShowBalloonTip(5000, "Pesan", x, ToolTipIcon.Error)
    End Sub
    Private Sub Pesan_Berhasil(ByVal x As String)
        NotifyIcon1.Icon = Me.Icon
        NotifyIcon1.Visible = True
        NotifyIcon1.ShowBalloonTip(5000, "Pesan", x, ToolTipIcon.Info)
    End Sub
    Private Sub F_Config_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBoxEdit1.Properties.Items.Clear()
        Dim pkInstalledPrinters As String
        For Each pkInstalledPrinters In _
            PrinterSettings.InstalledPrinters
            ComboBoxEdit1.Properties.Items.Add(pkInstalledPrinters)
        Next pkInstalledPrinters
        ComboBoxEdit1.Properties.ActionButtonIndex = 0
    End Sub
  
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Try
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\InovindoPointOfSale", "Server", TextEdit1.EditValue)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\InovindoPointOfSale", "Database", ComboBoxEdit3.EditValue)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\InovindoPointOfSale", "UserID", TextEdit2.EditValue)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\InovindoPointOfSale", "Password", TextEdit3.Text)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\InovindoPointOfSale", "Konfigurasi", ComboBoxEdit1.EditValue)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\InovindoPointOfSale", "type", ComboBoxEdit2.EditValue)
            load_db()
            Pesan_Berhasil("Konfigurasi Selesai :)")
        Catch ex As Exception
            Pesan_Error("" + ex.Message + " " + CRUD_Module.pesan_error + "")
        End Try
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        load_db_Registry()
    End Sub

    
   
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If TxtUsr.Text = "" Then
            Pesan_Warning("Inputkan username default administrator :)")
        ElseIf Txtpwd.Text = "" Then
            Pesan_Warning("Inputkan password default administrator :)")
        Else
            Save_Config(TxtUsr.Text, Txtpwd.Text)
            Pesan_Berhasil("Konfigurasi Akun Administrator Selesai :)")
        End If

    End Sub
End Class