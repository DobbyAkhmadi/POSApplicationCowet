Imports System.Data.SqlClient

Public Class F_Add_Pembayaran

    Private Sub F_Add_Pembayaran_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnSimpan_Click(sender As System.Object, e As System.EventArgs) Handles BtnSimpan.Click
        If txtnama.Text = "" Then
            MsgBox("Inputkan nama pembayaran nya", vbInformation, "Pesan")
        Else
            Try
                Save_Pembayaran(txtnama.Text)
                Pesan_Simpan()
                View_Pembayaran()
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub Pesan_Simpan()
        NotifyIcon1.Icon = Me.Icon
        NotifyIcon1.Visible = True
        NotifyIcon1.ShowBalloonTip(5000, "Pesan", "Data Telah Tersimpan!", ToolTipIcon.Info)
    End Sub

End Class