Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid

Public Class F_Pembayaran
#Region "Pesan"
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
    Private Sub Pesan_Warning(ByVal x As String)
        NotifyIcon1.Icon = Me.Icon
        NotifyIcon1.Visible = True
        NotifyIcon1.ShowBalloonTip(5000, "Pesan", x, ToolTipIcon.Warning)
    End Sub
    Private Sub Pesan_info(ByVal x As String)
        NotifyIcon1.Icon = Me.Icon
        NotifyIcon1.Visible = True
        NotifyIcon1.ShowBalloonTip(5000, "Pesan", x, ToolTipIcon.Info)
    End Sub
    Private Sub Pesan_Simpan()
        NotifyIcon1.Icon = Me.Icon
        NotifyIcon1.Visible = True
        NotifyIcon1.ShowBalloonTip(5000, "Pesan", "Data Telah Tersimpan!", ToolTipIcon.Info)
    End Sub
#End Region
#Region "Event"

    Private Sub GridView1_PopupMenuShowing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles GridView1.PopupMenuShowing
        Dim View As GridView = CType(sender, GridView)
        Dim HitInfo As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo
        HitInfo = View.CalcHitInfo(e.Point)
        If HitInfo.InRow Then
            View.FocusedRowHandle = HitInfo.RowHandle
            ContextMenuStrip1.Show(View.GridControl, e.Point)
        End If
    End Sub
#End Region
#Region "CRUD"
    Private Sub BtnBaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBaru.Click
        F_Add_Pembayaran.ShowDialog()
        ''  If TextBoxX1.Text = "" Then
        'Pesan_Warning("Lengkapi dulu Field nya yaa :) ")
        'Else
        'Try
        '    Save_Pembayaran()
        '    View_Pembayaran()
        '    Pesan_Simpan()
        '    'TextBoxX1.Clear()
        'Catch ex As Exception
        '    Pesan_Error("" + ex.Message + "" + CRUD_Module.pesan_error + "")
        'End Try
        'End If

    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        View_Pembayaran()
    End Sub
  
#End Region
    Private Sub F_Pembayaran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clear_Adapter()
    End Sub

    Private Sub HapusToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HapusToolStripMenuItem.Click
        Dim a As String = MsgBox("Hapus?", vbQuestion + vbYesNo, "Pesan")
        If a = vbYes Then
            Try
                Delete_Pembayaran(GridView1.GetFocusedRowCellValue("ID Pembayaran").ToString())
                Pesan_Hapus()
                SimpleButton1_Click(sender, e)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class