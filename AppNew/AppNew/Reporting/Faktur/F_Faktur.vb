Imports System.Drawing.Printing
Imports Microsoft.VisualBasic
Imports Microsoft.Win32
Public Class F_Faktur
    Private PrinterName = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\InovindoPointOfSale",
        "Konfigurasi", Nothing)
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            cryRpt.Load("CR_Faktur.rpt")
            '  CrystalReportViewer1.SelectionFormula = CrystalReportViewer1.SelectionFormula = "{A_Tbl_Head.No_Faktur}='" & a & "'"
            '  CrystalReportViewer1.ReportSource = cryRpt
            cryRpt.PrintOptions.PrinterName = PrinterName
            cryRpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.Paper10x14
            cryRpt.PrintToPrinter(1, False, 0, 0)
        Catch ex As Exception

        End Try
    End Sub

  
End Class