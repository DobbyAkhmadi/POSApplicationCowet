<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Edit_Pemasok
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Edit_Pemasok))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem3 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem3 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.BtnSimpan = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.Txttelp = New DevExpress.XtraEditors.TextEdit()
        Me.Txtalamat = New DevExpress.XtraEditors.TextEdit()
        Me.txtid = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtnama = New DevExpress.XtraEditors.TextEdit()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.Txttelp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txtalamat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtnama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.BtnSimpan)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.Txttelp)
        Me.GroupControl1.Controls.Add(Me.Txtalamat)
        Me.GroupControl1.Controls.Add(Me.txtid)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txtnama)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(572, 112)
        Me.GroupControl1.TabIndex = 31
        Me.GroupControl1.Text = "Data Pemasok"
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSimpan.Image = CType(resources.GetObject("BtnSimpan.Image"), System.Drawing.Image)
        Me.BtnSimpan.Location = New System.Drawing.Point(420, 51)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(91, 25)
        Me.BtnSimpan.TabIndex = 64
        Me.BtnSimpan.Text = "Update Data"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(349, 27)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl4.TabIndex = 31
        Me.LabelControl4.Text = "No Telepon"
        '
        'Txttelp
        '
        Me.Txttelp.Location = New System.Drawing.Point(420, 24)
        Me.Txttelp.Name = "Txttelp"
        Me.Txttelp.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Txttelp.Size = New System.Drawing.Size(139, 20)
        ToolTipTitleItem1.Appearance.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        ToolTipTitleItem1.Appearance.Options.UseImage = True
        ToolTipTitleItem1.Image = CType(resources.GetObject("ToolTipTitleItem1.Image"), System.Drawing.Image)
        ToolTipTitleItem1.Text = "Pesan (Field Ini Diperlukan)"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "Inputkan data produk anda berupa makanan atau barang dll :)"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.Txttelp.SuperTip = SuperToolTip1
        Me.Txttelp.TabIndex = 3
        '
        'Txtalamat
        '
        Me.Txtalamat.Location = New System.Drawing.Point(102, 80)
        Me.Txtalamat.Name = "Txtalamat"
        Me.Txtalamat.Size = New System.Drawing.Size(175, 20)
        ToolTipTitleItem2.Appearance.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        ToolTipTitleItem2.Appearance.Options.UseImage = True
        ToolTipTitleItem2.Image = CType(resources.GetObject("ToolTipTitleItem2.Image"), System.Drawing.Image)
        ToolTipTitleItem2.Text = "Pesan (Field Ini Diperlukan)"
        ToolTipItem2.LeftIndent = 6
        ToolTipItem2.Text = "Inputkan data produk anda berupa makanan atau barang dll :)"
        SuperToolTip2.Items.Add(ToolTipTitleItem2)
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.Txtalamat.SuperTip = SuperToolTip2
        Me.Txtalamat.TabIndex = 2
        '
        'txtid
        '
        Me.txtid.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtid.Location = New System.Drawing.Point(102, 28)
        Me.txtid.Name = "txtid"
        Me.txtid.Properties.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(79, 20)
        Me.txtid.TabIndex = 28
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(18, 57)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl2.TabIndex = 22
        Me.LabelControl2.Text = "Nama"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(18, 31)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl1.TabIndex = 20
        Me.LabelControl1.Text = "ID Pemasok"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(18, 83)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl3.TabIndex = 17
        Me.LabelControl3.Text = "Alamat"
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(102, 54)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(158, 20)
        ToolTipTitleItem3.Appearance.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        ToolTipTitleItem3.Appearance.Options.UseImage = True
        ToolTipTitleItem3.Image = CType(resources.GetObject("ToolTipTitleItem3.Image"), System.Drawing.Image)
        ToolTipTitleItem3.Text = "Pesan (Field Ini Diperlukan)"
        ToolTipItem3.LeftIndent = 6
        ToolTipItem3.Text = "Inputkan data produk anda berupa makanan atau barang dll :)"
        SuperToolTip3.Items.Add(ToolTipTitleItem3)
        SuperToolTip3.Items.Add(ToolTipItem3)
        Me.txtnama.SuperTip = SuperToolTip3
        Me.txtnama.TabIndex = 1
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'F_Add_Pemasok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 112)
        Me.Controls.Add(Me.GroupControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_Add_Pemasok"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Add Pemasok"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.Txttelp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txtalamat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtnama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtnama As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Txtalamat As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Txttelp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents BtnSimpan As DevExpress.XtraEditors.SimpleButton
End Class
