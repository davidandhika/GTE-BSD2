<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuAdministrator1
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

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
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenuAdministrator1))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 8
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(871, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem1)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem2)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem3)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem4)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem5)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem6)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        ToolTipTitleItem1.Appearance.Image = Global.Gudang_Toko_Elektronik.My.Resources.Resources.button_gudang
        ToolTipTitleItem1.Appearance.Options.UseImage = True
        ToolTipTitleItem1.Image = Global.Gudang_Toko_Elektronik.My.Resources.Resources.button_gudang
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        Me.RibbonPageGroup1.SuperTip = SuperToolTip1
        Me.RibbonPageGroup1.Text = "Menu Administrator"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 418)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(871, 31)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Master Gudang"
        Me.BarButtonItem1.Glyph = Global.Gudang_Toko_Elektronik.My.Resources.Resources.button_gudang
        Me.BarButtonItem1.Id = 2
        Me.BarButtonItem1.LargeGlyph = Global.Gudang_Toko_Elektronik.My.Resources.Resources.button_gudang
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Master Rak"
        Me.BarButtonItem2.Glyph = Global.Gudang_Toko_Elektronik.My.Resources.Resources.button_rak
        Me.BarButtonItem2.Id = 3
        Me.BarButtonItem2.LargeGlyph = Global.Gudang_Toko_Elektronik.My.Resources.Resources.button_rak
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Master Type"
        Me.BarButtonItem3.Id = 4
        Me.BarButtonItem3.LargeGlyph = Global.Gudang_Toko_Elektronik.My.Resources.Resources.button_brand
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Master Type"
        Me.BarButtonItem4.Glyph = Global.Gudang_Toko_Elektronik.My.Resources.Resources.button_type
        Me.BarButtonItem4.Id = 5
        Me.BarButtonItem4.LargeGlyph = Global.Gudang_Toko_Elektronik.My.Resources.Resources.button_type
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Master Barang"
        Me.BarButtonItem5.Id = 6
        Me.BarButtonItem5.LargeGlyph = Global.Gudang_Toko_Elektronik.My.Resources.Resources.button_barang
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Master Rak Barang"
        Me.BarButtonItem6.Glyph = CType(resources.GetObject("BarButtonItem6.Glyph"), System.Drawing.Image)
        Me.BarButtonItem6.Id = 7
        Me.BarButtonItem6.LargeGlyph = CType(resources.GetObject("BarButtonItem6.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'FrmMenuAdministrator1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 449)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "FrmMenuAdministrator1"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "FrmMenuAdministrator1"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem


End Class
