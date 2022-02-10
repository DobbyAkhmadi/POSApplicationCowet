Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Helpers


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits RibbonForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.splitContainerControl = New DevExpress.XtraEditors.SplitContainerControl()
        Me.navBarControl = New DevExpress.XtraNavBar.NavBarControl()
        Me.mailGroup = New DevExpress.XtraNavBar.NavBarGroup()
        Me.inboxItem = New DevExpress.XtraNavBar.NavBarItem()
        Me.outboxItem = New DevExpress.XtraNavBar.NavBarItem()
        Me.draftsItem = New DevExpress.XtraNavBar.NavBarItem()
        Me.trashItem = New DevExpress.XtraNavBar.NavBarItem()
        Me.organizerGroup = New DevExpress.XtraNavBar.NavBarGroup()
        Me.calendarItem = New DevExpress.XtraNavBar.NavBarItem()
        Me.tasksItem = New DevExpress.XtraNavBar.NavBarItem()
        Me.navbarImageCollectionLarge = New DevExpress.Utils.ImageCollection(Me.components)
        Me.navbarImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.galleryImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.appMenu = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
        Me.popupControlContainer2 = New DevExpress.XtraBars.PopupControlContainer(Me.components)
        Me.buttonEdit = New DevExpress.XtraEditors.ButtonEdit()
        Me.iNew = New DevExpress.XtraBars.BarButtonItem()
        Me.iOpen = New DevExpress.XtraBars.BarButtonItem()
        Me.iSave = New DevExpress.XtraBars.BarButtonItem()
        Me.iSaveAs = New DevExpress.XtraBars.BarButtonItem()
        Me.iExit = New DevExpress.XtraBars.BarButtonItem()
        Me.popupControlContainer1 = New DevExpress.XtraBars.PopupControlContainer(Me.components)
        Me.someLabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.someLabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.ribbonImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.iClose = New DevExpress.XtraBars.BarButtonItem()
        Me.iFind = New DevExpress.XtraBars.BarButtonItem()
        Me.iHelp = New DevExpress.XtraBars.BarButtonItem()
        Me.iAbout = New DevExpress.XtraBars.BarButtonItem()
        Me.siStatus = New DevExpress.XtraBars.BarStaticItem()
        Me.siInfo = New DevExpress.XtraBars.BarStaticItem()
        Me.alignButtonGroup = New DevExpress.XtraBars.BarButtonGroup()
        Me.iBoldFontStyle = New DevExpress.XtraBars.BarButtonItem()
        Me.iItalicFontStyle = New DevExpress.XtraBars.BarButtonItem()
        Me.iUnderlinedFontStyle = New DevExpress.XtraBars.BarButtonItem()
        Me.fontStyleButtonGroup = New DevExpress.XtraBars.BarButtonGroup()
        Me.iLeftTextAlign = New DevExpress.XtraBars.BarButtonItem()
        Me.iCenterTextAlign = New DevExpress.XtraBars.BarButtonItem()
        Me.iRightTextAlign = New DevExpress.XtraBars.BarButtonItem()
        Me.rgbiSkins = New DevExpress.XtraBars.RibbonGalleryBarItem()
        Me.ribbonImageCollectionLarge = New DevExpress.Utils.ImageCollection(Me.components)
        Me.homeRibbonPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.fileRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.formatRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.skinsRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.exitRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.helpRibbonPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.helpRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        CType(Me.splitContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainerControl.SuspendLayout()
        CType(Me.navBarControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.navbarImageCollectionLarge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.navbarImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.galleryImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.appMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popupControlContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popupControlContainer2.SuspendLayout()
        CType(Me.buttonEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popupControlContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popupControlContainer1.SuspendLayout()
        CType(Me.ribbonImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonImageCollectionLarge, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'splitContainerControl
        '
        Me.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainerControl.Location = New System.Drawing.Point(0, 144)
        Me.splitContainerControl.Name = "splitContainerControl"
        Me.splitContainerControl.Padding = New System.Windows.Forms.Padding(6)
        Me.splitContainerControl.Panel1.Controls.Add(Me.navBarControl)
        Me.splitContainerControl.Panel1.Text = "Panel1"
        Me.splitContainerControl.Panel2.Text = "Panel2"
        Me.splitContainerControl.Size = New System.Drawing.Size(1100, 525)
        Me.splitContainerControl.SplitterPosition = 165
        Me.splitContainerControl.TabIndex = 1
        Me.splitContainerControl.Text = "splitContainerControl1"
        '
        'navBarControl
        '
        Me.navBarControl.ActiveGroup = Me.mailGroup
        Me.navBarControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.navBarControl.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.mailGroup, Me.organizerGroup})
        Me.navBarControl.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.inboxItem, Me.outboxItem, Me.draftsItem, Me.trashItem, Me.calendarItem, Me.tasksItem})
        Me.navBarControl.LargeImages = Me.navbarImageCollectionLarge
        Me.navBarControl.Location = New System.Drawing.Point(0, 0)
        Me.navBarControl.Name = "navBarControl"
        Me.navBarControl.OptionsNavPane.ExpandedWidth = 165
        Me.navBarControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.ExplorerBar
        Me.navBarControl.Size = New System.Drawing.Size(165, 513)
        Me.navBarControl.SmallImages = Me.navbarImageCollection
        Me.navBarControl.StoreDefaultPaintStyleName = True
        Me.navBarControl.TabIndex = 1
        Me.navBarControl.Text = "navBarControl1"
        '
        'mailGroup
        '
        Me.mailGroup.Caption = "Mail"
        Me.mailGroup.Expanded = True
        Me.mailGroup.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.inboxItem), New DevExpress.XtraNavBar.NavBarItemLink(Me.outboxItem), New DevExpress.XtraNavBar.NavBarItemLink(Me.draftsItem), New DevExpress.XtraNavBar.NavBarItemLink(Me.trashItem)})
        Me.mailGroup.LargeImageIndex = 0
        Me.mailGroup.Name = "mailGroup"
        '
        'inboxItem
        '
        Me.inboxItem.Caption = "Inbox"
        Me.inboxItem.Name = "inboxItem"
        Me.inboxItem.SmallImageIndex = 0
        '
        'outboxItem
        '
        Me.outboxItem.Caption = "Outbox"
        Me.outboxItem.Name = "outboxItem"
        Me.outboxItem.SmallImageIndex = 1
        '
        'draftsItem
        '
        Me.draftsItem.Caption = "Drafts"
        Me.draftsItem.Name = "draftsItem"
        Me.draftsItem.SmallImageIndex = 2
        '
        'trashItem
        '
        Me.trashItem.Caption = "Trash"
        Me.trashItem.Name = "trashItem"
        Me.trashItem.SmallImageIndex = 3
        '
        'organizerGroup
        '
        Me.organizerGroup.Caption = "Organizer"
        Me.organizerGroup.Expanded = True
        Me.organizerGroup.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.calendarItem), New DevExpress.XtraNavBar.NavBarItemLink(Me.tasksItem)})
        Me.organizerGroup.LargeImageIndex = 1
        Me.organizerGroup.Name = "organizerGroup"
        '
        'calendarItem
        '
        Me.calendarItem.Caption = "Calendar"
        Me.calendarItem.Name = "calendarItem"
        Me.calendarItem.SmallImageIndex = 4
        '
        'tasksItem
        '
        Me.tasksItem.Caption = "Tasks"
        Me.tasksItem.Name = "tasksItem"
        Me.tasksItem.SmallImageIndex = 5
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
        'ribbonControl
        '
        Me.ribbonControl.ApplicationButtonDropDownControl = Me.appMenu
        Me.ribbonControl.ApplicationButtonText = Nothing
        Me.ribbonControl.ExpandCollapseItem.Id = 0
        Me.ribbonControl.Images = Me.ribbonImageCollection
        Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.iNew, Me.iOpen, Me.iClose, Me.iFind, Me.iSave, Me.iSaveAs, Me.iExit, Me.iHelp, Me.iAbout, Me.siStatus, Me.siInfo, Me.alignButtonGroup, Me.iBoldFontStyle, Me.iItalicFontStyle, Me.iUnderlinedFontStyle, Me.fontStyleButtonGroup, Me.iLeftTextAlign, Me.iCenterTextAlign, Me.iRightTextAlign, Me.rgbiSkins})
        Me.ribbonControl.LargeImages = Me.ribbonImageCollectionLarge
        Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl.MaxItemId = 62
        Me.ribbonControl.Name = "ribbonControl"
        Me.ribbonControl.PageHeaderItemLinks.Add(Me.iAbout)
        Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.homeRibbonPage, Me.helpRibbonPage})
        Me.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.ribbonControl.Size = New System.Drawing.Size(1100, 144)
        Me.ribbonControl.StatusBar = Me.ribbonStatusBar
        Me.ribbonControl.Toolbar.ItemLinks.Add(Me.iNew)
        Me.ribbonControl.Toolbar.ItemLinks.Add(Me.iOpen)
        Me.ribbonControl.Toolbar.ItemLinks.Add(Me.iSave)
        Me.ribbonControl.Toolbar.ItemLinks.Add(Me.iSaveAs)
        Me.ribbonControl.Toolbar.ItemLinks.Add(Me.iHelp)
        '
        'appMenu
        '
        Me.appMenu.BottomPaneControlContainer = Me.popupControlContainer2
        Me.appMenu.ItemLinks.Add(Me.iNew)
        Me.appMenu.ItemLinks.Add(Me.iOpen)
        Me.appMenu.ItemLinks.Add(Me.iSave)
        Me.appMenu.ItemLinks.Add(Me.iSaveAs)
        Me.appMenu.ItemLinks.Add(Me.iExit)
        Me.appMenu.Name = "appMenu"
        Me.appMenu.Ribbon = Me.ribbonControl
        Me.appMenu.RightPaneControlContainer = Me.popupControlContainer1
        Me.appMenu.ShowRightPane = True
        '
        'popupControlContainer2
        '
        Me.popupControlContainer2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.popupControlContainer2.Appearance.Options.UseBackColor = True
        Me.popupControlContainer2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.popupControlContainer2.Controls.Add(Me.buttonEdit)
        Me.popupControlContainer2.Location = New System.Drawing.Point(238, 289)
        Me.popupControlContainer2.Name = "popupControlContainer2"
        Me.popupControlContainer2.Ribbon = Me.ribbonControl
        Me.popupControlContainer2.Size = New System.Drawing.Size(118, 28)
        Me.popupControlContainer2.TabIndex = 7
        Me.popupControlContainer2.Visible = False
        '
        'buttonEdit
        '
        Me.buttonEdit.EditValue = "Some Text"
        Me.buttonEdit.Location = New System.Drawing.Point(3, 5)
        Me.buttonEdit.MenuManager = Me.ribbonControl
        Me.buttonEdit.Name = "buttonEdit"
        Me.buttonEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.buttonEdit.Size = New System.Drawing.Size(100, 20)
        Me.buttonEdit.TabIndex = 0
        '
        'iNew
        '
        Me.iNew.Caption = "New"
        Me.iNew.Description = "Creates a new, blank file."
        Me.iNew.Hint = "Creates a new, blank file"
        Me.iNew.Id = 1
        Me.iNew.ImageIndex = 0
        Me.iNew.LargeImageIndex = 0
        Me.iNew.Name = "iNew"
        '
        'iOpen
        '
        Me.iOpen.Caption = "&Open"
        Me.iOpen.Description = "Opens a file."
        Me.iOpen.Hint = "Opens a file"
        Me.iOpen.Id = 2
        Me.iOpen.ImageIndex = 1
        Me.iOpen.LargeImageIndex = 1
        Me.iOpen.Name = "iOpen"
        Me.iOpen.RibbonStyle = CType((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'iSave
        '
        Me.iSave.Caption = "&Save"
        Me.iSave.Description = "Saves the active document."
        Me.iSave.Hint = "Saves the active document"
        Me.iSave.Id = 16
        Me.iSave.ImageIndex = 4
        Me.iSave.LargeImageIndex = 4
        Me.iSave.Name = "iSave"
        '
        'iSaveAs
        '
        Me.iSaveAs.Caption = "Save As"
        Me.iSaveAs.Description = "Saves the active document in a different location."
        Me.iSaveAs.Hint = "Saves the active document in a different location"
        Me.iSaveAs.Id = 17
        Me.iSaveAs.ImageIndex = 5
        Me.iSaveAs.LargeImageIndex = 5
        Me.iSaveAs.Name = "iSaveAs"
        '
        'iExit
        '
        Me.iExit.Caption = "Exit"
        Me.iExit.Description = "Closes this program after prompting you to save unsaved data."
        Me.iExit.Hint = "Closes this program after prompting you to save unsaved data"
        Me.iExit.Id = 20
        Me.iExit.ImageIndex = 6
        Me.iExit.LargeImageIndex = 6
        Me.iExit.Name = "iExit"
        '
        'popupControlContainer1
        '
        Me.popupControlContainer1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.popupControlContainer1.Appearance.Options.UseBackColor = True
        Me.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.popupControlContainer1.Controls.Add(Me.someLabelControl2)
        Me.popupControlContainer1.Controls.Add(Me.someLabelControl1)
        Me.popupControlContainer1.Location = New System.Drawing.Point(111, 197)
        Me.popupControlContainer1.Name = "popupControlContainer1"
        Me.popupControlContainer1.Ribbon = Me.ribbonControl
        Me.popupControlContainer1.Size = New System.Drawing.Size(76, 70)
        Me.popupControlContainer1.TabIndex = 6
        Me.popupControlContainer1.Visible = False
        '
        'someLabelControl2
        '
        Me.someLabelControl2.Location = New System.Drawing.Point(3, 57)
        Me.someLabelControl2.Name = "someLabelControl2"
        Me.someLabelControl2.Size = New System.Drawing.Size(49, 13)
        Me.someLabelControl2.TabIndex = 0
        Me.someLabelControl2.Text = "Some Info"
        '
        'someLabelControl1
        '
        Me.someLabelControl1.Location = New System.Drawing.Point(3, 3)
        Me.someLabelControl1.Name = "someLabelControl1"
        Me.someLabelControl1.Size = New System.Drawing.Size(49, 13)
        Me.someLabelControl1.TabIndex = 0
        Me.someLabelControl1.Text = "Some Info"
        '
        'ribbonImageCollection
        '
        Me.ribbonImageCollection.ImageStream = CType(resources.GetObject("ribbonImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ribbonImageCollection.Images.SetKeyName(0, "Ribbon_New_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(1, "Ribbon_Open_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(2, "Ribbon_Close_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(3, "Ribbon_Find_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(4, "Ribbon_Save_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(5, "Ribbon_SaveAs_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(6, "Ribbon_Exit_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(7, "Ribbon_Content_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(8, "Ribbon_Info_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(9, "Ribbon_Bold_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(10, "Ribbon_Italic_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(11, "Ribbon_Underline_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(12, "Ribbon_AlignLeft_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(13, "Ribbon_AlignCenter_16x16.png")
        Me.ribbonImageCollection.Images.SetKeyName(14, "Ribbon_AlignRight_16x16.png")
        '
        'iClose
        '
        Me.iClose.Caption = "&Close"
        Me.iClose.Description = "Closes the active document."
        Me.iClose.Hint = "Closes the active document"
        Me.iClose.Id = 3
        Me.iClose.ImageIndex = 2
        Me.iClose.LargeImageIndex = 2
        Me.iClose.Name = "iClose"
        Me.iClose.RibbonStyle = CType((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'iFind
        '
        Me.iFind.Caption = "Find"
        Me.iFind.Description = "Searches for the specified info."
        Me.iFind.Hint = "Searches for the specified info"
        Me.iFind.Id = 15
        Me.iFind.ImageIndex = 3
        Me.iFind.LargeImageIndex = 3
        Me.iFind.Name = "iFind"
        Me.iFind.RibbonStyle = CType((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'iHelp
        '
        Me.iHelp.Caption = "Help"
        Me.iHelp.Description = "Start the program help system."
        Me.iHelp.Hint = "Start the program help system"
        Me.iHelp.Id = 22
        Me.iHelp.ImageIndex = 7
        Me.iHelp.LargeImageIndex = 7
        Me.iHelp.Name = "iHelp"
        '
        'iAbout
        '
        Me.iAbout.Caption = "About"
        Me.iAbout.Description = "Displays general program information."
        Me.iAbout.Hint = "Displays general program information"
        Me.iAbout.Id = 24
        Me.iAbout.ImageIndex = 8
        Me.iAbout.LargeImageIndex = 8
        Me.iAbout.Name = "iAbout"
        '
        'siStatus
        '
        Me.siStatus.Caption = "Some Status Info"
        Me.siStatus.Id = 31
        Me.siStatus.Name = "siStatus"
        Me.siStatus.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'siInfo
        '
        Me.siInfo.Caption = "Some Info"
        Me.siInfo.Id = 32
        Me.siInfo.Name = "siInfo"
        Me.siInfo.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'alignButtonGroup
        '
        Me.alignButtonGroup.Caption = "Align Commands"
        Me.alignButtonGroup.Id = 52
        Me.alignButtonGroup.ItemLinks.Add(Me.iBoldFontStyle)
        Me.alignButtonGroup.ItemLinks.Add(Me.iItalicFontStyle)
        Me.alignButtonGroup.ItemLinks.Add(Me.iUnderlinedFontStyle)
        Me.alignButtonGroup.Name = "alignButtonGroup"
        '
        'iBoldFontStyle
        '
        Me.iBoldFontStyle.Caption = "Bold"
        Me.iBoldFontStyle.Id = 53
        Me.iBoldFontStyle.ImageIndex = 9
        Me.iBoldFontStyle.Name = "iBoldFontStyle"
        '
        'iItalicFontStyle
        '
        Me.iItalicFontStyle.Caption = "Italic"
        Me.iItalicFontStyle.Id = 54
        Me.iItalicFontStyle.ImageIndex = 10
        Me.iItalicFontStyle.Name = "iItalicFontStyle"
        '
        'iUnderlinedFontStyle
        '
        Me.iUnderlinedFontStyle.Caption = "Underlined"
        Me.iUnderlinedFontStyle.Id = 55
        Me.iUnderlinedFontStyle.ImageIndex = 11
        Me.iUnderlinedFontStyle.Name = "iUnderlinedFontStyle"
        '
        'fontStyleButtonGroup
        '
        Me.fontStyleButtonGroup.Caption = "Font Style"
        Me.fontStyleButtonGroup.Id = 56
        Me.fontStyleButtonGroup.ItemLinks.Add(Me.iLeftTextAlign)
        Me.fontStyleButtonGroup.ItemLinks.Add(Me.iCenterTextAlign)
        Me.fontStyleButtonGroup.ItemLinks.Add(Me.iRightTextAlign)
        Me.fontStyleButtonGroup.Name = "fontStyleButtonGroup"
        '
        'iLeftTextAlign
        '
        Me.iLeftTextAlign.Caption = "Left"
        Me.iLeftTextAlign.Id = 57
        Me.iLeftTextAlign.ImageIndex = 12
        Me.iLeftTextAlign.Name = "iLeftTextAlign"
        '
        'iCenterTextAlign
        '
        Me.iCenterTextAlign.Caption = "Center"
        Me.iCenterTextAlign.Id = 58
        Me.iCenterTextAlign.ImageIndex = 13
        Me.iCenterTextAlign.Name = "iCenterTextAlign"
        '
        'iRightTextAlign
        '
        Me.iRightTextAlign.Caption = "Right"
        Me.iRightTextAlign.Id = 59
        Me.iRightTextAlign.ImageIndex = 14
        Me.iRightTextAlign.Name = "iRightTextAlign"
        '
        'rgbiSkins
        '
        Me.rgbiSkins.Caption = "Skins"
        '
        '
        '
        Me.rgbiSkins.Gallery.AllowHoverImages = True
        Me.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = True
        Me.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
        Me.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.rgbiSkins.Gallery.ColumnCount = 4
        Me.rgbiSkins.Gallery.FixedHoverImageSize = False
        Me.rgbiSkins.Gallery.ImageSize = New System.Drawing.Size(32, 17)
        Me.rgbiSkins.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Top
        Me.rgbiSkins.Gallery.RowCount = 4
        Me.rgbiSkins.Id = 60
        Me.rgbiSkins.Name = "rgbiSkins"
        '
        'ribbonImageCollectionLarge
        '
        Me.ribbonImageCollectionLarge.ImageSize = New System.Drawing.Size(32, 32)
        Me.ribbonImageCollectionLarge.ImageStream = CType(resources.GetObject("ribbonImageCollectionLarge.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ribbonImageCollectionLarge.Images.SetKeyName(0, "Ribbon_New_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(1, "Ribbon_Open_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(2, "Ribbon_Close_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(3, "Ribbon_Find_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(4, "Ribbon_Save_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(5, "Ribbon_SaveAs_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(6, "Ribbon_Exit_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(7, "Ribbon_Content_32x32.png")
        Me.ribbonImageCollectionLarge.Images.SetKeyName(8, "Ribbon_Info_32x32.png")
        '
        'homeRibbonPage
        '
        Me.homeRibbonPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.fileRibbonPageGroup, Me.formatRibbonPageGroup, Me.skinsRibbonPageGroup, Me.exitRibbonPageGroup})
        Me.homeRibbonPage.Name = "homeRibbonPage"
        Me.homeRibbonPage.Text = "Home"
        '
        'fileRibbonPageGroup
        '
        Me.fileRibbonPageGroup.ItemLinks.Add(Me.iNew)
        Me.fileRibbonPageGroup.ItemLinks.Add(Me.iOpen)
        Me.fileRibbonPageGroup.ItemLinks.Add(Me.iClose)
        Me.fileRibbonPageGroup.ItemLinks.Add(Me.iFind)
        Me.fileRibbonPageGroup.ItemLinks.Add(Me.iSave)
        Me.fileRibbonPageGroup.ItemLinks.Add(Me.iSaveAs)
        Me.fileRibbonPageGroup.Name = "fileRibbonPageGroup"
        Me.fileRibbonPageGroup.Text = "File"
        '
        'formatRibbonPageGroup
        '
        Me.formatRibbonPageGroup.ItemLinks.Add(Me.alignButtonGroup)
        Me.formatRibbonPageGroup.ItemLinks.Add(Me.fontStyleButtonGroup)
        Me.formatRibbonPageGroup.Name = "formatRibbonPageGroup"
        Me.formatRibbonPageGroup.Text = "Format"
        '
        'skinsRibbonPageGroup
        '
        Me.skinsRibbonPageGroup.ItemLinks.Add(Me.rgbiSkins)
        Me.skinsRibbonPageGroup.Name = "skinsRibbonPageGroup"
        Me.skinsRibbonPageGroup.ShowCaptionButton = False
        Me.skinsRibbonPageGroup.Text = "Skins"
        '
        'exitRibbonPageGroup
        '
        Me.exitRibbonPageGroup.ItemLinks.Add(Me.iExit)
        Me.exitRibbonPageGroup.Name = "exitRibbonPageGroup"
        Me.exitRibbonPageGroup.Text = "Exit"
        '
        'helpRibbonPage
        '
        Me.helpRibbonPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.helpRibbonPageGroup})
        Me.helpRibbonPage.Name = "helpRibbonPage"
        Me.helpRibbonPage.Text = "Help"
        '
        'helpRibbonPageGroup
        '
        Me.helpRibbonPageGroup.ItemLinks.Add(Me.iHelp)
        Me.helpRibbonPageGroup.ItemLinks.Add(Me.iAbout)
        Me.helpRibbonPageGroup.Name = "helpRibbonPageGroup"
        Me.helpRibbonPageGroup.Text = "Help"
        '
        'ribbonStatusBar
        '
        Me.ribbonStatusBar.ItemLinks.Add(Me.siStatus)
        Me.ribbonStatusBar.ItemLinks.Add(Me.siInfo)
        Me.ribbonStatusBar.Location = New System.Drawing.Point(0, 669)
        Me.ribbonStatusBar.Name = "ribbonStatusBar"
        Me.ribbonStatusBar.Ribbon = Me.ribbonControl
        Me.ribbonStatusBar.Size = New System.Drawing.Size(1100, 31)
        '
        'Form1
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[False]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 700)
        Me.Controls.Add(Me.splitContainerControl)
        Me.Controls.Add(Me.popupControlContainer1)
        Me.Controls.Add(Me.popupControlContainer2)
        Me.Controls.Add(Me.ribbonStatusBar)
        Me.Controls.Add(Me.ribbonControl)
        Me.Name = "Form1"
        Me.Ribbon = Me.ribbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.ribbonStatusBar
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.splitContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainerControl.ResumeLayout(False)
        CType(Me.navBarControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.navbarImageCollectionLarge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.navbarImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.galleryImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.appMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popupControlContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popupControlContainer2.ResumeLayout(False)
        CType(Me.buttonEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popupControlContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popupControlContainer1.ResumeLayout(False)
        Me.popupControlContainer1.PerformLayout()
        CType(Me.ribbonImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonImageCollectionLarge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents splitContainerControl As DevExpress.XtraEditors.SplitContainerControl
    Private WithEvents ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents siStatus As DevExpress.XtraBars.BarStaticItem
    Private WithEvents siInfo As DevExpress.XtraBars.BarStaticItem
    Private WithEvents homeRibbonPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents fileRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents iNew As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iOpen As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iClose As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iFind As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iSave As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iSaveAs As DevExpress.XtraBars.BarButtonItem
    Private WithEvents formatRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents alignButtonGroup As DevExpress.XtraBars.BarButtonGroup
    Private WithEvents iBoldFontStyle As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iItalicFontStyle As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iUnderlinedFontStyle As DevExpress.XtraBars.BarButtonItem
    Private WithEvents fontStyleButtonGroup As DevExpress.XtraBars.BarButtonGroup
    Private WithEvents iLeftTextAlign As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iCenterTextAlign As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iRightTextAlign As DevExpress.XtraBars.BarButtonItem
    Private WithEvents skinsRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents rgbiSkins As DevExpress.XtraBars.RibbonGalleryBarItem
    Private WithEvents exitRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents iExit As DevExpress.XtraBars.BarButtonItem
    Private WithEvents helpRibbonPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents helpRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private WithEvents iHelp As DevExpress.XtraBars.BarButtonItem
    Private WithEvents iAbout As DevExpress.XtraBars.BarButtonItem
    Private WithEvents appMenu As DevExpress.XtraBars.Ribbon.ApplicationMenu
    Private WithEvents popupControlContainer1 As DevExpress.XtraBars.PopupControlContainer
    Private WithEvents someLabelControl2 As DevExpress.XtraEditors.LabelControl
    Private WithEvents someLabelControl1 As DevExpress.XtraEditors.LabelControl
    Private WithEvents popupControlContainer2 As DevExpress.XtraBars.PopupControlContainer
    Private WithEvents buttonEdit As DevExpress.XtraEditors.ButtonEdit
    Private WithEvents ribbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Private WithEvents ribbonImageCollection As DevExpress.Utils.ImageCollection
    Private WithEvents ribbonImageCollectionLarge As DevExpress.Utils.ImageCollection
    Private WithEvents navBarControl As DevExpress.XtraNavBar.NavBarControl
    Private WithEvents mailGroup As DevExpress.XtraNavBar.NavBarGroup
    Private WithEvents organizerGroup As DevExpress.XtraNavBar.NavBarGroup
    Private WithEvents inboxItem As DevExpress.XtraNavBar.NavBarItem
    Private WithEvents outboxItem As DevExpress.XtraNavBar.NavBarItem
    Private WithEvents draftsItem As DevExpress.XtraNavBar.NavBarItem
    Private WithEvents trashItem As DevExpress.XtraNavBar.NavBarItem
    Private WithEvents calendarItem As DevExpress.XtraNavBar.NavBarItem
    Private WithEvents tasksItem As DevExpress.XtraNavBar.NavBarItem
    Private WithEvents navbarImageCollection As DevExpress.Utils.ImageCollection
    Private WithEvents navbarImageCollectionLarge As DevExpress.Utils.ImageCollection
    Private WithEvents galleryImageCollection As DevExpress.Utils.ImageCollection

End Class
