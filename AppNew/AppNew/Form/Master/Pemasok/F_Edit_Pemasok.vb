Imports System.Data.SqlClient

Public Class F_Edit_Pemasok
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


    Private Sub F_Pemasok_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        clear_data()
    End Sub

    Private Sub BtnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            View_Pemasok()
        Catch ex As Exception
            Pesan_Error("" + ex.Message + "" + CRUD_Module.pesan_error + "")
        End Try
    End Sub


#Region "Function"
    Private Sub clear_data()
        txtnama.Text = ""
        txtid.Text = ""
        Txtalamat.Text = ""
        Txttelp.Text = ""
    End Sub

#End Region

    Private Sub F_Pemasok_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '_default(0)
        get_view()
    End Sub

    Sub get_view()
        txtid.Text = F_Pemasok.GridView1.GetFocusedRowCellValue("ID Pemasok").ToString
        txtnama.Text = F_Pemasok.GridView1.GetFocusedRowCellValue("Nama Pemasok").ToString
        Txtalamat.Text = F_Pemasok.GridView1.GetFocusedRowCellValue("Alamat").ToString
        Txttelp.Text = F_Pemasok.GridView1.GetFocusedRowCellValue("No Telp").ToString
    End Sub



    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        Try
            Update_Pemasok(txtid.Text, txtnama.Text, Txtalamat.Text, Txttelp.Text)
            Pesan_Simpan()
            clear_data()
            Me.Hide()
        Catch ex As Exception
            Pesan_Error("" + ex.Message + "" + CRUD_Module.pesan_error + "")
        End Try
    End Sub
End Class