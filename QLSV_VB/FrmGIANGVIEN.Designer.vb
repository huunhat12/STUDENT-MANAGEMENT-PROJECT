<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGIANGVIEN
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
        Dim MAGVLabel As System.Windows.Forms.Label
        Dim HOLabel As System.Windows.Forms.Label
        Dim TENLabel As System.Windows.Forms.Label
        Dim PHAILabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGIANGVIEN))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnThem = New DevExpress.XtraBars.BarButtonItem()
        Me.btnGhi = New DevExpress.XtraBars.BarButtonItem()
        Me.btnXoa = New DevExpress.XtraBars.BarButtonItem()
        Me.btnsua = New DevExpress.XtraBars.BarButtonItem()
        Me.btnReload = New DevExpress.XtraBars.BarButtonItem()
        Me.btnXuatexcel = New DevExpress.XtraBars.BarButtonItem()
        Me.btnThoat = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarCheckItem1 = New DevExpress.XtraBars.BarCheckItem()
        Me.DS = New QLSV_VB.DS()
        Me.GIANGVIENBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GIANGVIENTableAdapter = New QLSV_VB.DSTableAdapters.GIANGVIENTableAdapter()
        Me.TableAdapterManager = New QLSV_VB.DSTableAdapters.TableAdapterManager()
        Me.GIANGVIENGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMAGV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPHAI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PHAICheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.txtTen = New DevExpress.XtraEditors.TextEdit()
        Me.txtHo = New DevExpress.XtraEditors.TextEdit()
        Me.txtMagv = New DevExpress.XtraEditors.TextEdit()
        MAGVLabel = New System.Windows.Forms.Label()
        HOLabel = New System.Windows.Forms.Label()
        TENLabel = New System.Windows.Forms.Label()
        PHAILabel = New System.Windows.Forms.Label()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GIANGVIENBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GIANGVIENGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PHAICheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMagv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MAGVLabel
        '
        MAGVLabel.AutoSize = True
        MAGVLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MAGVLabel.Location = New System.Drawing.Point(187, 47)
        MAGVLabel.Name = "MAGVLabel"
        MAGVLabel.Size = New System.Drawing.Size(67, 19)
        MAGVLabel.TabIndex = 0
        MAGVLabel.Text = "MÃ GV :"
        '
        'HOLabel
        '
        HOLabel.AutoSize = True
        HOLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HOLabel.Location = New System.Drawing.Point(187, 92)
        HOLabel.Name = "HOLabel"
        HOLabel.Size = New System.Drawing.Size(35, 19)
        HOLabel.TabIndex = 2
        HOLabel.Text = "HỌ:"
        '
        'TENLabel
        '
        TENLabel.AutoSize = True
        TENLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TENLabel.Location = New System.Drawing.Point(439, 92)
        TENLabel.Name = "TENLabel"
        TENLabel.Size = New System.Drawing.Size(39, 19)
        TENLabel.TabIndex = 4
        TENLabel.Text = "TÊN"
        '
        'PHAILabel
        '
        PHAILabel.AutoSize = True
        PHAILabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PHAILabel.Location = New System.Drawing.Point(439, 47)
        PHAILabel.Name = "PHAILabel"
        PHAILabel.Size = New System.Drawing.Size(45, 19)
        PHAILabel.TabIndex = 6
        PHAILabel.Text = "PHÁI"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnThem, Me.btnGhi, Me.btnXoa, Me.btnsua, Me.btnReload, Me.BarCheckItem1, Me.btnXuatexcel, Me.btnThoat})
        Me.BarManager1.MaxItemId = 8
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnsua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnXuatexcel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar1.Text = "Tools"
        '
        'btnThem
        '
        Me.btnThem.Caption = "THÊM"
        Me.btnThem.Glyph = CType(resources.GetObject("btnThem.Glyph"), System.Drawing.Image)
        Me.btnThem.Id = 0
        Me.btnThem.Name = "btnThem"
        '
        'btnGhi
        '
        Me.btnGhi.Caption = "GHI"
        Me.btnGhi.Glyph = CType(resources.GetObject("btnGhi.Glyph"), System.Drawing.Image)
        Me.btnGhi.Id = 1
        Me.btnGhi.Name = "btnGhi"
        '
        'btnXoa
        '
        Me.btnXoa.Caption = "XÓA"
        Me.btnXoa.Glyph = CType(resources.GetObject("btnXoa.Glyph"), System.Drawing.Image)
        Me.btnXoa.Id = 2
        Me.btnXoa.Name = "btnXoa"
        '
        'btnsua
        '
        Me.btnsua.Caption = "SỬA"
        Me.btnsua.Glyph = CType(resources.GetObject("btnsua.Glyph"), System.Drawing.Image)
        Me.btnsua.Id = 3
        Me.btnsua.Name = "btnsua"
        '
        'btnReload
        '
        Me.btnReload.Caption = "RELOAD"
        Me.btnReload.Glyph = CType(resources.GetObject("btnReload.Glyph"), System.Drawing.Image)
        Me.btnReload.Id = 4
        Me.btnReload.Name = "btnReload"
        '
        'btnXuatexcel
        '
        Me.btnXuatexcel.Caption = "XUẤT EXCEL"
        Me.btnXuatexcel.Glyph = Global.QLSV_VB.My.Resources.Resources.Carlosjj_Microsoft_Office_2013_Excel
        Me.btnXuatexcel.Id = 6
        Me.btnXuatexcel.Name = "btnXuatexcel"
        '
        'btnThoat
        '
        Me.btnThoat.Caption = "THOÁT"
        Me.btnThoat.Glyph = CType(resources.GetObject("btnThoat.Glyph"), System.Drawing.Image)
        Me.btnThoat.Id = 7
        Me.btnThoat.Name = "btnThoat"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(849, 47)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 508)
        Me.barDockControlBottom.Size = New System.Drawing.Size(849, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 47)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 461)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(849, 47)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 461)
        '
        'BarCheckItem1
        '
        Me.BarCheckItem1.Id = 5
        Me.BarCheckItem1.Name = "BarCheckItem1"
        '
        'DS
        '
        Me.DS.DataSetName = "DS"
        Me.DS.EnforceConstraints = False
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GIANGVIENBindingSource
        '
        Me.GIANGVIENBindingSource.DataMember = "GIANGVIEN"
        Me.GIANGVIENBindingSource.DataSource = Me.DS
        '
        'GIANGVIENTableAdapter
        '
        Me.GIANGVIENTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DIEMTableAdapter = Nothing
        Me.TableAdapterManager.GIANGVIENTableAdapter = Me.GIANGVIENTableAdapter
        Me.TableAdapterManager.LOPTableAdapter = Nothing
        Me.TableAdapterManager.MONHOCTableAdapter = Nothing
        Me.TableAdapterManager.SINHVIENTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = QLSV_VB.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GIANGVIENGridControl
        '
        Me.GIANGVIENGridControl.DataSource = Me.GIANGVIENBindingSource
        Me.GIANGVIENGridControl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GIANGVIENGridControl.Location = New System.Drawing.Point(0, 208)
        Me.GIANGVIENGridControl.MainView = Me.GridView1
        Me.GIANGVIENGridControl.MenuManager = Me.BarManager1
        Me.GIANGVIENGridControl.Name = "GIANGVIENGridControl"
        Me.GIANGVIENGridControl.Size = New System.Drawing.Size(849, 300)
        Me.GIANGVIENGridControl.TabIndex = 5
        Me.GIANGVIENGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMAGV, Me.colHO, Me.colTEN, Me.colPHAI})
        Me.GridView1.GridControl = Me.GIANGVIENGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsFind.AlwaysVisible = True
        '
        'colMAGV
        '
        Me.colMAGV.Caption = "MÃ GIẢNG VIÊN"
        Me.colMAGV.FieldName = "MAGV"
        Me.colMAGV.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colMAGV.Name = "colMAGV"
        Me.colMAGV.Visible = True
        Me.colMAGV.VisibleIndex = 0
        Me.colMAGV.Width = 127
        '
        'colHO
        '
        Me.colHO.Caption = "HỌ"
        Me.colHO.FieldName = "HO"
        Me.colHO.Name = "colHO"
        Me.colHO.Visible = True
        Me.colHO.VisibleIndex = 1
        Me.colHO.Width = 233
        '
        'colTEN
        '
        Me.colTEN.Caption = "TÊN"
        Me.colTEN.FieldName = "TEN"
        Me.colTEN.Name = "colTEN"
        Me.colTEN.Visible = True
        Me.colTEN.VisibleIndex = 2
        Me.colTEN.Width = 233
        '
        'colPHAI
        '
        Me.colPHAI.Caption = "PHÁI"
        Me.colPHAI.FieldName = "PHAI"
        Me.colPHAI.Name = "colPHAI"
        Me.colPHAI.Visible = True
        Me.colPHAI.VisibleIndex = 3
        Me.colPHAI.Width = 236
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PHAICheckEdit)
        Me.GroupBox1.Controls.Add(PHAILabel)
        Me.GroupBox1.Controls.Add(TENLabel)
        Me.GroupBox1.Controls.Add(Me.txtTen)
        Me.GroupBox1.Controls.Add(HOLabel)
        Me.GroupBox1.Controls.Add(Me.txtHo)
        Me.GroupBox1.Controls.Add(MAGVLabel)
        Me.GroupBox1.Controls.Add(Me.txtMagv)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(849, 137)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông Tin Giảng Viên"
        '
        'PHAICheckEdit
        '
        Me.PHAICheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.GIANGVIENBindingSource, "PHAI", True))
        Me.PHAICheckEdit.Location = New System.Drawing.Point(532, 47)
        Me.PHAICheckEdit.MenuManager = Me.BarManager1
        Me.PHAICheckEdit.Name = "PHAICheckEdit"
        Me.PHAICheckEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PHAICheckEdit.Properties.Appearance.Options.UseFont = True
        Me.PHAICheckEdit.Properties.Caption = "Nam"
        Me.PHAICheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.PHAICheckEdit.Size = New System.Drawing.Size(75, 20)
        Me.PHAICheckEdit.TabIndex = 4
        '
        'txtTen
        '
        Me.txtTen.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.GIANGVIENBindingSource, "TEN", True))
        Me.txtTen.Location = New System.Drawing.Point(532, 85)
        Me.txtTen.MenuManager = Me.BarManager1
        Me.txtTen.Name = "txtTen"
        Me.txtTen.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTen.Properties.Appearance.Options.UseFont = True
        Me.txtTen.Size = New System.Drawing.Size(115, 26)
        Me.txtTen.TabIndex = 3
        '
        'txtHo
        '
        Me.txtHo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.GIANGVIENBindingSource, "HO", True))
        Me.txtHo.Location = New System.Drawing.Point(260, 85)
        Me.txtHo.MenuManager = Me.BarManager1
        Me.txtHo.Name = "txtHo"
        Me.txtHo.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHo.Properties.Appearance.Options.UseFont = True
        Me.txtHo.Size = New System.Drawing.Size(167, 26)
        Me.txtHo.TabIndex = 2
        '
        'txtMagv
        '
        Me.txtMagv.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.GIANGVIENBindingSource, "MAGV", True))
        Me.txtMagv.Location = New System.Drawing.Point(260, 40)
        Me.txtMagv.MenuManager = Me.BarManager1
        Me.txtMagv.Name = "txtMagv"
        Me.txtMagv.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMagv.Properties.Appearance.Options.UseFont = True
        Me.txtMagv.Size = New System.Drawing.Size(100, 26)
        Me.txtMagv.TabIndex = 1
        '
        'FrmGIANGVIEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 508)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GIANGVIENGridControl)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "FrmGIANGVIEN"
        Me.Text = "BẢNG GIẢNG VIÊN"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GIANGVIENBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GIANGVIENGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PHAICheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMagv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnThem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnGhi As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnXoa As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnsua As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnReload As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnXuatexcel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarCheckItem1 As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents GIANGVIENBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS As QLSV_VB.DS
    Friend WithEvents GIANGVIENTableAdapter As QLSV_VB.DSTableAdapters.GIANGVIENTableAdapter
    Friend WithEvents TableAdapterManager As QLSV_VB.DSTableAdapters.TableAdapterManager
    Friend WithEvents GIANGVIENGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtHo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMagv As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnThoat As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colMAGV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPHAI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PHAICheckEdit As DevExpress.XtraEditors.CheckEdit
End Class
