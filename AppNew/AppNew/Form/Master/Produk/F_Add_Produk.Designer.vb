<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Add_Produk
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Add_Produk))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Me.LayoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.txtbeli = New DevExpress.XtraEditors.CalcEdit()
        Me.BtnSimpan = New DevExpress.XtraEditors.SimpleButton()
        Me.txtjual = New DevExpress.XtraEditors.CalcEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtstok = New DevExpress.XtraEditors.CalcEdit()
        Me.LookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtid = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtnama = New DevExpress.XtraEditors.TextEdit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtbeli.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtjual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtstok.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtnama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutViewCard1
        '
        Me.LayoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.LayoutViewCard1.Name = "LayoutViewCard1"
        Me.LayoutViewCard1.OptionsItemText.TextToControlDistance = 5
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'txtbeli
        '
        Me.txtbeli.Location = New System.Drawing.Point(408, 9)
        Me.txtbeli.Name = "txtbeli"
        Me.txtbeli.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtbeli.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtbeli.Properties.NullValuePrompt = "--> Klik ->>"
        Me.txtbeli.Properties.ShowCloseButton = True
        Me.txtbeli.ShowToolTips = False
        Me.txtbeli.Size = New System.Drawing.Size(130, 20)
        Me.txtbeli.TabIndex = 57
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSimpan.Image = CType(resources.GetObject("BtnSimpan.Image"), System.Drawing.Image)
        Me.BtnSimpan.Location = New System.Drawing.Point(408, 89)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(65, 25)
        Me.BtnSimpan.TabIndex = 56
        Me.BtnSimpan.Text = "Simpan"
        '
        'txtjual
        '
        Me.txtjual.Location = New System.Drawing.Point(408, 37)
        Me.txtjual.Name = "txtjual"
        Me.txtjual.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtjual.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtjual.Properties.NullValuePrompt = "--> Klik ->>"
        Me.txtjual.Properties.ShowCloseButton = True
        Me.txtjual.Size = New System.Drawing.Size(130, 20)
        Me.txtjual.TabIndex = 58
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(381, 40)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(21, 13)
        Me.LabelControl9.TabIndex = 62
        Me.LabelControl9.Text = "(Rp)"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(381, 12)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(21, 13)
        Me.LabelControl8.TabIndex = 61
        Me.LabelControl8.Text = "(Rp)"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(319, 64)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl7.TabIndex = 59
        Me.LabelControl7.Text = "Stok Awal"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(319, 38)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl5.TabIndex = 55
        Me.LabelControl5.Text = "Harga Jual"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(319, 12)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl4.TabIndex = 54
        Me.LabelControl4.Text = "Harga Beli"
        '
        'txtstok
        '
        Me.txtstok.Location = New System.Drawing.Point(408, 63)
        Me.txtstok.Name = "txtstok"
        Me.txtstok.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtstok.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtstok.Properties.NullValuePrompt = "--> Klik ->>"
        Me.txtstok.Size = New System.Drawing.Size(72, 20)
        Me.txtstok.TabIndex = 60
        '
        'LookUpEdit1
        '
        Me.LookUpEdit1.Location = New System.Drawing.Point(101, 35)
        Me.LookUpEdit1.Name = "LookUpEdit1"
        Me.LookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit1.Properties.DisplayFormat.FormatString = "c2"
        Me.LookUpEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.LookUpEdit1.Properties.DropDownRows = 6
        Me.LookUpEdit1.Properties.NullText = ""
        Me.LookUpEdit1.Properties.PopupSizeable = False
        Me.LookUpEdit1.Size = New System.Drawing.Size(201, 20)
        ToolTipTitleItem1.Appearance.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        ToolTipTitleItem1.Appearance.Options.UseImage = True
        ToolTipTitleItem1.Image = CType(resources.GetObject("ToolTipTitleItem1.Image"), System.Drawing.Image)
        ToolTipTitleItem1.Text = "Pesan"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "Pilih kategori yang diinginkan :)"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.LookUpEdit1.SuperTip = SuperToolTip1
        Me.LookUpEdit1.TabIndex = 53
        '
        'txtid
        '
        Me.txtid.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtid.Location = New System.Drawing.Point(101, 9)
        Me.txtid.Name = "txtid"
        Me.txtid.Properties.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(79, 20)
        Me.txtid.TabIndex = 52
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 38)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl2.TabIndex = 50
        Me.LabelControl2.Text = "Kategori"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl1.TabIndex = 49
        Me.LabelControl1.Text = "ID Produk"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 64)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl3.TabIndex = 48
        Me.LabelControl3.Text = "Nama Produk"
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(101, 61)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(139, 20)
        ToolTipTitleItem2.Appearance.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        ToolTipTitleItem2.Appearance.Options.UseImage = True
        ToolTipTitleItem2.Image = CType(resources.GetObject("ToolTipTitleItem2.Image"), System.Drawing.Image)
        ToolTipTitleItem2.Text = "Pesan (Field Ini Diperlukan)"
        ToolTipItem2.LeftIndent = 6
        ToolTipItem2.Text = "Inputkan data produk anda berupa makanan atau barang dll :)"
        SuperToolTip2.Items.Add(ToolTipTitleItem2)
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.txtnama.SuperTip = SuperToolTip2
        Me.txtnama.TabIndex = 51
        '
        'F_Add_Produk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 122)
        Me.Controls.Add(Me.txtbeli)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.txtjual)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtstok)
        Me.Controls.Add(Me.LookUpEdit1)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtnama)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_Add_Produk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Add Produk"
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtbeli.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtjual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtstok.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtnama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub




    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource


    Friend WithEvents TBLKATEGORIBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents KategoriBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MasterProdukBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LayoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents txtbeli As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents BtnSimpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtjual As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtstok As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtnama As DevExpress.XtraEditors.TextEdit

End Class
