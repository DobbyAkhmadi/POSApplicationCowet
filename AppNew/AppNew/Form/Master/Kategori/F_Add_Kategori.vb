Imports System.Data.SqlClient
Public Class F_Add_Kategori
    Private Sub Pesan_Simpan()
        NotifyIcon1.Icon = Me.Icon
        NotifyIcon1.Visible = True
        NotifyIcon1.ShowBalloonTip(5000, "Pesan", "Data Telah Tersimpan!", ToolTipIcon.Info)
    End Sub
    Private Sub BtnSimpan_Click(sender As System.Object, e As System.EventArgs) Handles BtnSimpan.Click
        Try
            Save_Kategori(txtnama.Text)
            Pesan_Simpan()
            View_Kategori()
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       
    End Sub
End Class