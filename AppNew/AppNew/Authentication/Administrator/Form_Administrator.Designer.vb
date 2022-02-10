Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins
Imports DevExpress.XtraEditors


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Admin
    Inherits XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Admin))
        Me.splitContainerControl = New DevExpress.XtraEditors.SplitContainerControl()
        Me.navBarControl = New DevExpress.XtraNavBar.NavBarControl()
        Me.mailGroup = New DevExpress.XtraNavBar.NavBarGroup()
        Me.BtnBarang = New DevExpress.XtraNavBar.NavBarItem()
        Me.BtnPemasok = New DevExpress.XtraNavBar.NavBarItem()
        Me.BtnPembayaran = New DevExpress.XtraNavBar.NavBarItem()
        Me.BtnKategori = New DevExpress.XtraNavBar.NavBarItem()
        Me.BtnPengguna = New DevExpress.XtraNavBar.NavBarItem()
        Me.organizerGroup = New DevExpress.XtraNavBar.NavBarGroup()
        Me.calendarItem = New DevExpress.XtraNavBar.NavBarItem()
        Me.tasksItem = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarItem1 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem2 = New DevExpress.XtraNavBar.NavBarItem()
        Me.navbarImageCollectionLarge = New DevExpress.Utils.ImageCollection(Me.components)
        Me.navbarImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.DashboardViewer1 = New DevExpress.DashboardWin.DashboardViewer(Me.components)
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.XtraTabControl2 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.barManager = New DevExpress.XtraBars.BarManager(Me.components)
        Me.bar2 = New DevExpress.XtraBars.Bar()
        Me.mFile = New DevExpress.XtraBars.BarSubItem()
        Me.iNew = New DevExpress.XtraBars.BarButtonItem()
        Me.iOpen = New DevExpress.XtraBars.BarButtonItem()
        Me.iExit = New DevExpress.XtraBars.BarButtonItem()
        Me.mHelp = New DevExpress.XtraBars.BarSubItem()
        Me.iAbout = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.iClose = New DevExpress.XtraBars.BarButtonItem()
        Me.iSave = New DevExpress.XtraBars.BarButtonItem()
        Me.iSaveAs = New DevExpress.XtraBars.BarButtonItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.DateEdit3 = New DevExpress.XtraEditors.DateEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateEdit4 = New DevExpress.XtraEditors.DateEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBoxEdit2 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel6 = New System.Windows.Forms.ToolStripLabel()
        Me.galleryImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        CType(Me.splitContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainerControl.SuspendLayout()
        CType(Me.navBarControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.navbarImageCollectionLarge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.navbarImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.DashboardViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl2.SuspendLayout()
        Me.XtraTabPage5.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.DateEdit2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.DateEdit3.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit4.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.galleryImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'splitContainerControl
        '
        Me.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainerControl.Location = New System.Drawing.Point(0, 22)
        Me.splitContainerControl.Name = "splitContainerControl"
        Me.splitContainerControl.Padding = New System.Windows.Forms.Padding(6)
        Me.splitContainerControl.Panel1.Controls.Add(Me.navBarControl)
        Me.splitContainerControl.Panel1.Text = "Panel1"
        Me.splitContainerControl.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.splitContainerControl.Panel2.Controls.Add(Me.ToolStrip1)
        Me.splitContainerControl.Panel2.Text = "Panel2"
        Me.splitContainerControl.Size = New System.Drawing.Size(784, 539)
        Me.splitContainerControl.SplitterPosition = 185
        Me.splitContainerControl.TabIndex = 1
        Me.splitContainerControl.Text = "splitContainerControl1"
        '
        'navBarControl
        '
        Me.navBarControl.ActiveGroup = Me.mailGroup
        Me.navBarControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.navBarControl.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.mailGroup, Me.organizerGroup, Me.NavBarGroup1})
        Me.navBarControl.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.BtnBarang, Me.BtnPemasok, Me.BtnPembayaran, Me.BtnKategori, Me.calendarItem, Me.tasksItem, Me.NavBarItem1, Me.NavBarItem2, Me.BtnPengguna})
        Me.navBarControl.LargeImages = Me.navbarImageCollectionLarge
        Me.navBarControl.Location = New System.Drawing.Point(0, 0)
        Me.navBarControl.Name = "navBarControl"
        Me.navBarControl.OptionsNavPane.ExpandedWidth = 185
        Me.navBarControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane
        Me.navBarControl.Size = New System.Drawing.Size(185, 527)
        Me.navBarControl.SmallImages = Me.navbarImageCollection
        Me.navBarControl.StoreDefaultPaintStyleName = True
        Me.navBarControl.TabIndex = 1
        Me.navBarControl.Text = "navBarControl1"
        '
        'mailGroup
        '
        Me.mailGroup.Caption = "Master"
        Me.mailGroup.Expanded = True
        Me.mailGroup.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.BtnBarang), New DevExpress.XtraNavBar.NavBarItemLink(Me.BtnPemasok), New DevExpress.XtraNavBar.NavBarItemLink(Me.BtnPembayaran), New DevExpress.XtraNavBar.NavBarItemLink(Me.BtnKategori), New DevExpress.XtraNavBar.NavBarItemLink(Me.BtnPengguna)})
        Me.mailGroup.Name = "mailGroup"
        Me.mailGroup.SmallImage = CType(resources.GetObject("mailGroup.SmallImage"), System.Drawing.Image)
        '
        'BtnBarang
        '
        Me.BtnBarang.Caption = "Manajemen Barang"
        Me.BtnBarang.Name = "BtnBarang"
        Me.BtnBarang.SmallImage = CType(resources.GetObject("BtnBarang.SmallImage"), System.Drawing.Image)
        '
        'BtnPemasok
        '
        Me.BtnPemasok.Caption = "Manajemen Pemasok"
        Me.BtnPemasok.Name = "BtnPemasok"
        Me.BtnPemasok.SmallImage = CType(resources.GetObject("BtnPemasok.SmallImage"), System.Drawing.Image)
        '
        'BtnPembayaran
        '
        Me.BtnPembayaran.Caption = "Manajemen Pembayaran"
        Me.BtnPembayaran.Name = "BtnPembayaran"
        Me.BtnPembayaran.SmallImage = CType(resources.GetObject("BtnPembayaran.SmallImage"), System.Drawing.Image)
        Me.BtnPembayaran.SmallImageIndex = 2
        '
        'BtnKategori
        '
        Me.BtnKategori.Caption = "Manajemen Kategori"
        Me.BtnKategori.Name = "BtnKategori"
        Me.BtnKategori.SmallImageIndex = 2
        '
        'BtnPengguna
        '
        Me.BtnPengguna.Caption = "Manajemen Pengguna"
        Me.BtnPengguna.Name = "BtnPengguna"
        Me.BtnPengguna.SmallImage = CType(resources.GetObject("BtnPengguna.SmallImage"), System.Drawing.Image)
        '
        'organizerGroup
        '
        Me.organizerGroup.Caption = "Transaksi"
        Me.organizerGroup.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.calendarItem), New DevExpress.XtraNavBar.NavBarItemLink(Me.tasksItem)})
        Me.organizerGroup.LargeImageIndex = 1
        Me.organizerGroup.Name = "organizerGroup"
        '
        'calendarItem
        '
        Me.calendarItem.Caption = "Penjualan"
        Me.calendarItem.Name = "calendarItem"
        Me.calendarItem.SmallImageIndex = 1
        '
        'tasksItem
        '
        Me.tasksItem.Caption = "Pembelian"
        Me.tasksItem.Name = "tasksItem"
        Me.tasksItem.SmallImageIndex = 0
        '
        'NavBarGroup1
        '
        Me.NavBarGroup1.Caption = "Retur"
        Me.NavBarGroup1.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem1), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem2)})
        Me.NavBarGroup1.Name = "NavBarGroup1"
        Me.NavBarGroup1.SmallImage = CType(resources.GetObject("NavBarGroup1.SmallImage"), System.Drawing.Image)
        '
        'NavBarItem1
        '
        Me.NavBarItem1.Caption = "Penjualan"
        Me.NavBarItem1.Name = "NavBarItem1"
        Me.NavBarItem1.SmallImage = CType(resources.GetObject("NavBarItem1.SmallImage"), System.Drawing.Image)
        '
        'NavBarItem2
        '
        Me.NavBarItem2.Caption = "Pembelian"
        Me.NavBarItem2.Name = "NavBarItem2"
        Me.NavBarItem2.SmallImage = CType(resources.GetObject("NavBarItem2.SmallImage"), System.Drawing.Image)
        '
        'navbarImageCollectionLarge
        '
        Me.navbarImageCollectionLarge.ImageStream = CType(resources.GetObject("navbarImageCollectionLarge.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.navbarImageCollectionLarge.TransparentColor = System.Drawing.Color.Transparent
        Me.navbarImageCollectionLarge.Images.SetKeyName(0, "Mail_16x16.png")
        Me.navbarImageCollectionLarge.Images.SetKeyName(1, "Organizer_16x16.png")
        '
        'navbarImageCollection
        '
        Me.navbarImageCollection.ImageStream = CType(resources.GetObject("navbarImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.navbarImageCollection.TransparentColor = System.Drawing.Color.Transparent
        Me.navbarImageCollection.Images.SetKeyName(0, "Inbox_16x16.png")
        Me.navbarImageCollection.Images.SetKeyName(1, "Outbox_16x16.png")
        Me.navbarImageCollection.Images.SetKeyName(2, "Drafts_16x16.png")
        Me.navbarImageCollection.Images.SetKeyName(3, "Trash_16x16.png")
        Me.navbarImageCollection.Images.SetKeyName(4, "Calendar_16x16.png")
        Me.navbarImageCollection.Images.SetKeyName(5, "Tasks_16x16.png")
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(582, 502)
        Me.XtraTabControl1.TabIndex = 3
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.DashboardViewer1)
        Me.XtraTabPage1.Image = CType(resources.GetObject("XtraTabPage1.Image"), System.Drawing.Image)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(576, 471)
        Me.XtraTabPage1.Text = "Informasi"
        '
        'DashboardViewer1
        '
        Me.DashboardViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DashboardViewer1.Location = New System.Drawing.Point(0, 0)
        Me.DashboardViewer1.Name = "DashboardViewer1"
        Me.DashboardViewer1.PrintingOptions.FontInfo.GdiCharSet = CType(0, Byte)
        Me.DashboardViewer1.PrintingOptions.FontInfo.Name = Nothing
        Me.DashboardViewer1.Size = New System.Drawing.Size(576, 471)
        Me.DashboardViewer1.TabIndex = 0
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.CrystalReportViewer1)
        Me.XtraTabPage2.Controls.Add(Me.Panel1)
        Me.XtraTabPage2.Image = CType(resources.GetObject("XtraTabPage2.Image"), System.Drawing.Image)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(576, 471)
        Me.XtraTabPage2.Text = "Data Laporan"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 80)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(576, 391)
        Me.CrystalReportViewer1.TabIndex = 2
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.XtraTabControl2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(576, 80)
        Me.Panel1.TabIndex = 1
        '
        'XtraTabControl2
        '
        Me.XtraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl2.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl2.Name = "XtraTabControl2"
        Me.XtraTabControl2.SelectedTabPage = Me.XtraTabPage5
        Me.XtraTabControl2.Size = New System.Drawing.Size(576, 80)
        Me.XtraTabControl2.TabIndex = 0
        Me.XtraTabControl2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage3, Me.XtraTabPage4, Me.XtraTabPage5})
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.Controls.Add(Me.SimpleButton4)
        Me.XtraTabPage5.Image = CType(resources.GetObject("XtraTabPage5.Image"), System.Drawing.Image)
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.Size = New System.Drawing.Size(570, 49)
        Me.XtraTabPage5.Text = "Data Laba Rugi"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(13, 13)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(58, 23)
        Me.SimpleButton4.TabIndex = 18
        Me.SimpleButton4.Text = "Tampil"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.SimpleButton1)
        Me.XtraTabPage3.Controls.Add(Me.DateEdit2)
        Me.XtraTabPage3.Controls.Add(Me.Label3)
        Me.XtraTabPage3.Controls.Add(Me.Label2)
        Me.XtraTabPage3.Controls.Add(Me.DateEdit1)
        Me.XtraTabPage3.Controls.Add(Me.Label1)
        Me.XtraTabPage3.Controls.Add(Me.ComboBoxEdit1)
        Me.XtraTabPage3.Image = CType(resources.GetObject("XtraTabPage3.Image"), System.Drawing.Image)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(570, 49)
        Me.XtraTabPage3.Text = "Daily Data Transaksi"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(520, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(58, 23)
        Me.SimpleButton1.TabIndex = 6
        Me.SimpleButton1.Text = "Tampil"
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Location = New System.Drawing.Point(414, 14)
        Me.DateEdit2.MenuManager = Me.barManager
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Size = New System.Drawing.Size(100, 20)
        Me.DateEdit2.TabIndex = 5
        '
        'barManager
        '
        Me.barManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar2})
        Me.barManager.DockControls.Add(Me.barDockControlTop)
        Me.barManager.DockControls.Add(Me.barDockControlBottom)
        Me.barManager.DockControls.Add(Me.barDockControlLeft)
        Me.barManager.DockControls.Add(Me.barDockControlRight)
        Me.barManager.Form = Me
        Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.mFile, Me.barButtonItem2, Me.iOpen, Me.iClose, Me.iNew, Me.iSave, Me.iSaveAs, Me.iExit, Me.mHelp, Me.iAbout, Me.BarButtonItem1})
        Me.barManager.MainMenu = Me.bar2
        Me.barManager.MaxItemId = 13
        '
        'bar2
        '
        Me.bar2.BarName = "Main menu"
        Me.bar2.DockCol = 0
        Me.bar2.DockRow = 0
        Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.mFile), New DevExpress.XtraBars.LinkPersistInfo(Me.mHelp)})
        Me.bar2.OptionsBar.MultiLine = True
        Me.bar2.OptionsBar.UseWholeRow = True
        Me.bar2.Text = "Main menu"
        '
        'mFile
        '
        Me.mFile.Caption = "&File"
        Me.mFile.Id = 0
        Me.mFile.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.iNew), New DevExpress.XtraBars.LinkPersistInfo(Me.iOpen), New DevExpress.XtraBars.LinkPersistInfo(Me.iExit)})
        Me.mFile.Name = "mFile"
        '
        'iNew
        '
        Me.iNew.Caption = "Database"
        Me.iNew.Id = 6
        Me.iNew.Name = "iNew"
        '
        'iOpen
        '
        Me.iOpen.Caption = "Konfigurasi"
        Me.iOpen.Id = 4
        Me.iOpen.Name = "iOpen"
        '
        'iExit
        '
        Me.iExit.Caption = "Keluar"
        Me.iExit.Id = 9
        Me.iExit.Name = "iExit"
        '
        'mHelp
        '
        Me.mHelp.Caption = "&Help"
        Me.mHelp.Id = 10
        Me.mHelp.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.iAbout), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1)})
        Me.mHelp.Name = "mHelp"
        '
        'iAbout
        '
        Me.iAbout.Caption = "&About"
        Me.iAbout.Id = 11
        Me.iAbout.Name = "iAbout"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Panduan Aplikasi"
        Me.BarButtonItem1.Id = 12
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(784, 22)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 561)
        Me.barDockControlBottom.Size = New System.Drawing.Size(784, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 539)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(784, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 539)
        '
        'barButtonItem2
        '
        Me.barButtonItem2.Caption = "Open"
        Me.barButtonItem2.Id = 2
        Me.barButtonItem2.Name = "barButtonItem2"
        '
        'iClose
        '
        Me.iClose.Caption = "&Close"
        Me.iClose.Id = 5
        Me.iClose.Name = "iClose"
        '
        'iSave
        '
        Me.iSave.Caption = "&Save"
        Me.iSave.Id = 7
        Me.iSave.Name = "iSave"
        '
        'iSaveAs
        '
        Me.iSaveAs.Caption = "Save &As"
        Me.iSaveAs.Id = 8
        Me.iSaveAs.Name = "iSaveAs"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(390, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "To"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(250, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "From"
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(284, 14)
        Me.DateEdit1.MenuManager = Me.barManager
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Size = New System.Drawing.Size(100, 20)
        Me.DateEdit1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data Transaksi"
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(96, 14)
        Me.ComboBoxEdit1.MenuManager = Me.barManager
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Properties.Items.AddRange(New Object() {"Penjualan", "Pembelian", "Retur Penjualan", "Retur Pembelian"})
        Me.ComboBoxEdit1.Properties.NullText = "Pilih"
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(148, 20)
        Me.ComboBoxEdit1.TabIndex = 0
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.SimpleButton2)
        Me.XtraTabPage4.Controls.Add(Me.DateEdit3)
        Me.XtraTabPage4.Controls.Add(Me.Label4)
        Me.XtraTabPage4.Controls.Add(Me.Label5)
        Me.XtraTabPage4.Controls.Add(Me.DateEdit4)
        Me.XtraTabPage4.Controls.Add(Me.Label6)
        Me.XtraTabPage4.Controls.Add(Me.ComboBoxEdit2)
        Me.XtraTabPage4.Image = CType(resources.GetObject("XtraTabPage4.Image"), System.Drawing.Image)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(570, 49)
        Me.XtraTabPage4.Text = "Daily Data Stok Barang"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(518, 12)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(58, 23)
        Me.SimpleButton2.TabIndex = 13
        Me.SimpleButton2.Text = "Tampil"
        '
        'DateEdit3
        '
        Me.DateEdit3.EditValue = Nothing
        Me.DateEdit3.Location = New System.Drawing.Point(409, 14)
        Me.DateEdit3.MenuManager = Me.barManager
        Me.DateEdit3.Name = "DateEdit3"
        Me.DateEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit3.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit3.Size = New System.Drawing.Size(100, 20)
        Me.DateEdit3.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(385, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "To"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(245, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "From"
        '
        'DateEdit4
        '
        Me.DateEdit4.EditValue = Nothing
        Me.DateEdit4.Location = New System.Drawing.Point(279, 14)
        Me.DateEdit4.MenuManager = Me.barManager
        Me.DateEdit4.Name = "DateEdit4"
        Me.DateEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit4.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit4.Size = New System.Drawing.Size(100, 20)
        Me.DateEdit4.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Data Barang"
        '
        'ComboBoxEdit2
        '
        Me.ComboBoxEdit2.Location = New System.Drawing.Point(96, 14)
        Me.ComboBoxEdit2.MenuManager = Me.barManager
        Me.ComboBoxEdit2.Name = "ComboBoxEdit2"
        Me.ComboBoxEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit2.Properties.DropDownRows = 3
        Me.ComboBoxEdit2.Properties.Items.AddRange(New Object() {"Data Stok Barang", "Daily Stok Barang Keluar", "Daily Stok Barang Masuk"})
        Me.ComboBoxEdit2.Properties.NullText = "Pilih"
        Me.ComboBoxEdit2.Size = New System.Drawing.Size(143, 20)
        Me.ComboBoxEdit2.TabIndex = 7
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripLabel2, Me.ToolStripLabel3, Me.ToolStripLabel4, Me.ToolStripLabel5, Me.ToolStripLabel6})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 502)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(582, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(50, 22)
        Me.ToolStripLabel1.Text = "User ID :"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(12, 22)
        Me.ToolStripLabel2.Text = "-"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(45, 22)
        Me.ToolStripLabel3.Text = "Nama :"
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(12, 22)
        Me.ToolStripLabel4.Text = "-"
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(43, 22)
        Me.ToolStripLabel5.Text = "Akses :"
        '
        'ToolStripLabel6
        '
        Me.ToolStripLabel6.Name = "ToolStripLabel6"
        Me.ToolStripLabel6.Size = New System.Drawing.Size(12, 22)
        Me.ToolStripLabel6.Text = "-"
        '
        'galleryImageCollection
        '
        Me.galleryImageCollection.ImageSize = New System.Drawing.Size(120, 120)
        Me.galleryImageCollection.ImageStream = CType(resources.GetObject("galleryImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.galleryImageCollection.Images.SetKeyName(0, "DSC_01.jpg")
        Me.galleryImageCollection.Images.SetKeyName(1, "DSC_02.jpg")
        Me.galleryImageCollection.Images.SetKeyName(2, "DSC_03.jpg")
        Me.galleryImageCollection.Images.SetKeyName(3, "DSC_04.jpg")
        Me.galleryImageCollection.Images.SetKeyName(4, "IMG_05.jpg")
        Me.galleryImageCollection.Images.SetKeyName(5, "IMG_06.jpg")
        Me.galleryImageCollection.Images.SetKeyName(6, "IMG_07.jpg")
        Me.galleryImageCollection.Images.SetKeyName(7, "IMG_08.jpg")
        Me.galleryImageCollection.Images.SetKeyName(8, "IMG_09.jpg")
        Me.galleryImageCollection.Images.SetKeyName(9, "IMG_10.jpg")
        Me.galleryImageCollection.Images.SetKeyName(10, "IMG_11.jpg")
        Me.galleryImageCollection.Images.SetKeyName(11, "IMG_12.jpg")
        Me.galleryImageCollection.Images.SetKeyName(12, "IMG_13.jpg")
        Me.galleryImageCollection.Images.SetKeyName(13, "IMG_14.jpg")
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Form_Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.splitContainerControl)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplikasi POS Cowet Bunda"
        CType(Me.splitContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainerControl.ResumeLayout(False)
        CType(Me.navBarControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.navbarImageCollectionLarge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.navbarImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.DashboardViewer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl2.ResumeLayout(False)
        Me.XtraTabPage5.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage3.PerformLayout()
        CType(Me.DateEdit2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        Me.XtraTabPage4.PerformLayout()
        CType(Me.DateEdit3.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit4.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.galleryImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents splitContainerControl As DevExpress.XtraEditors.SplitContainerControl
    Private WithEvents barManager As DevExpress.XtraBars.BarManager
    Private WithEvents bar2 As DevExpress.XtraBars.Bar
    Private WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Private WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Private WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Private WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Private WithEvents mFile As DevExpress.XtraBars.BarSubItem
    Private WithEvents barButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iOpen As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iClose As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iNew As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iSave As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iSaveAs As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iExit As DevExpress.XtraBars.BarButtonItem
    Private WithEvents mHelp As DevExpress.XtraBars.BarSubItem
    Private WithEvents iAbout As DevExpress.XtraBars.BarButtonItem
    Private WithEvents navBarControl As DevExpress.XtraNavBar.NavBarControl
    Private WithEvents organizerGroup As DevExpress.XtraNavBar.NavBarGroup
    Private WithEvents calendarItem As DevExpress.XtraNavBar.NavBarItem
    Private WithEvents tasksItem As DevExpress.XtraNavBar.NavBarItem
    Private WithEvents navbarImageCollection As DevExpress.Utils.ImageCollection
    Private WithEvents navbarImageCollectionLarge As DevExpress.Utils.ImageCollection
    Private WithEvents galleryImageCollection As DevExpress.Utils.ImageCollection
    Friend WithEvents NavBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarItem1 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem2 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    '   Friend WithEvents DashboardViewer1 As DevExpress.DashboardWin.DashboardViewer
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel5 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel6 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents XtraTabControl2 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents DateEdit3 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateEdit4 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxEdit2 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabPage5 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DashboardViewer1 As DevExpress.DashboardWin.DashboardViewer
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Public WithEvents BtnBarang As DevExpress.XtraNavBar.NavBarItem
    Public WithEvents BtnPemasok As DevExpress.XtraNavBar.NavBarItem
    Public WithEvents BtnPembayaran As DevExpress.XtraNavBar.NavBarItem
    Public WithEvents BtnKategori As DevExpress.XtraNavBar.NavBarItem
    Public WithEvents BtnPengguna As DevExpress.XtraNavBar.NavBarItem
    Public WithEvents mailGroup As DevExpress.XtraNavBar.NavBarGroup

End Class
