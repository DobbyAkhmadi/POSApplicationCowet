Imports CrystalDecisions.CrystalReports.Engine
Imports System.Drawing.Printing
Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.DashboardCommon
Imports DevExpress.XtraEditors
Imports CrystalDecisions.Shared
Module ModuleReporting
    Dim crtableLogoninfos As New TableLogOnInfos
    Dim crtableLogoninfo As New TableLogOnInfo
    Dim crConnectionInfo As New ConnectionInfo
    Dim ParameterFieldDefinition As ParameterFieldDefinition
    Dim ParameterFieldDefinitions As ParameterFieldDefinitions
    Dim CrTables As Tables
    Dim CrTable As Table
    Public cryRpt As New ReportDocument
    Private PrinterName = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\InovindoPointOfSale", "Konfigurasi", Nothing)
    Private Server = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\InovindoPointOfSale", "Server", Nothing)
    Private Database = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\InovindoPointOfSale", "Database", Nothing)
    Private Userid = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\InovindoPointOfSale", "UserID", Nothing)
    Private password = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\InovindoPointOfSale", "Password", Nothing)
    Private printer As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\InovindoPointOfSale", "type", Nothing)
    Public Sub DirectPrint_Faktur(ByVal Crystal_Load As String, ByVal Parameter_ID_Faktur As String, ByVal ParameterValue As String, ByVal ParamDiskon As String)
        cryRpt.Load(Crystal_Load)
        With crConnectionInfo
            .ServerName = Server
            .DatabaseName = Database
            .UserID = Userid
            .Password = password
        End With
        CrTables = cryRpt.Database.Tables
        For Each CrTable In CrTables
            crtableLogoninfo = CrTable.LogOnInfo
            crtableLogoninfo.ConnectionInfo = crConnectionInfo
            CrTable.ApplyLogOnInfo(crtableLogoninfo)
        Next
        Dim RptForm As CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim T As CrystalDecisions.CrystalReports.Engine.TextObject
        RptForm = cryRpt    'rpt is your report object
        T = RptForm.ReportDefinition.Sections(0).ReportObjects("diskon")
        T.Text = ParamDiskon
        'cryRpt.SetParameterValue("diskon", ParamDiskon)
        F_Faktur.CrystalReportViewer1.SelectionFormula = "{" + Parameter_ID_Faktur + "}='" & ParameterValue & "'"
        F_Faktur.CrystalReportViewer1.ReportSource = cryRpt
        F_Faktur.CrystalReportViewer1.RefreshReport()
        cryRpt.PrintOptions.PrinterName = PrinterName
        Dim PrintLayout As New CrystalDecisions.Shared.PrintLayoutSettings
        PrintLayout.Centered = False
        PrintLayout.Scaling = CrystalDecisions.Shared.PrintLayoutSettings.PrintScaling.DoNotScale
        cryRpt.PrintOptions.ApplyPageMargins(New CrystalDecisions.Shared.PageMargins(6, 0, 6, 0))
        If printer = "Otomatis" Then
            cryRpt.PrintToPrinter(1, False, 0, 0)
        Else
            F_Faktur.Show()
        End If
    End Sub
    Public Sub DirectPrint_Faktur(ByVal Crystal_Load As String, ByVal Parameter_ID_Faktur As String, ByVal ParameterValue As String)
        cryRpt.Load(Crystal_Load)
        With crConnectionInfo
            .ServerName = Server
            .DatabaseName = Database
            .UserID = Userid
            .Password = password
        End With
        CrTables = cryRpt.Database.Tables
        For Each CrTable In CrTables
            crtableLogoninfo = CrTable.LogOnInfo
            crtableLogoninfo.ConnectionInfo = crConnectionInfo
            CrTable.ApplyLogOnInfo(crtableLogoninfo)
        Next
        F_Faktur.CrystalReportViewer1.SelectionFormula = "{" + Parameter_ID_Faktur + "}='" & ParameterValue & "'"
        F_Faktur.CrystalReportViewer1.ReportSource = cryRpt
        F_Faktur.CrystalReportViewer1.RefreshReport()
        cryRpt.PrintOptions.PrinterName = PrinterName
        Dim PrintLayout As New CrystalDecisions.Shared.PrintLayoutSettings
        PrintLayout.Centered = False
        PrintLayout.Scaling = CrystalDecisions.Shared.PrintLayoutSettings.PrintScaling.DoNotScale
        cryRpt.PrintOptions.ApplyPageMargins(New CrystalDecisions.Shared.PageMargins(6, 0, 6, 0))
        If printer = "Otomatis" Then
            cryRpt.PrintToPrinter(1, False, 0, 0)
        Else
            F_Faktur.Show()
        End If
    End Sub
    Public Sub General_Report(ByVal Judul As String, ByVal Directory As String)
        Form_Admin.XtraTabPage2.Text = Judul
        cryRpt.Load(Directory)
        Form_Admin.CrystalReportViewer1.ReportSource = cryRpt
        Form_Admin.CrystalReportViewer1.RefreshReport()
    End Sub
    Public Sub General_Report(ByVal Judul As String, ByVal Directory As String, ByVal Value_1 As Date, ByVal Value_2 As Date, ByVal GetHeadTanggal As String)
        Form_Admin.XtraTabPage2.Text = Judul
        cryRpt.Load(Directory)
        Form_Admin.CrystalReportViewer1.SelectionFormula = "date({" + GetHeadTanggal + "}) >= #" & Value_1 & "# and date({" + GetHeadTanggal + "})<=#" & Value_2 & "#"
        Form_Admin.CrystalReportViewer1.ReportSource = cryRpt
        Form_Admin.CrystalReportViewer1.RefreshReport()
    End Sub

End Module
