<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMONHOC
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
        Dim MAMHLabel As System.Windows.Forms.Label
        Dim TENMHLabel As System.Windows.Forms.Label
        Dim SOTCLTLabel As System.Windows.Forms.Label
        Dim SOTCTHLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMONHOC))
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.btnthem = New DevExpress.XtraBars.BarButtonItem()
        Me.btnghi = New DevExpress.XtraBars.BarButtonItem()
        Me.btnxoa = New DevExpress.XtraBars.BarButtonItem()
        Me.btnsua = New DevExpress.XtraBars.BarButtonItem()
        Me.btnreload = New DevExpress.XtraBars.BarButtonItem()
        Me.btnxuatexcel = New DevExpress.XtraBars.BarButtonItem()
        Me.btnthoat = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.DS = New QLSV_VB.DS()
        Me.MONHOCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MONHOCTableAdapter = New QLSV_VB.DSTableAdapters.MONHOCTableAdapter()
        Me.TableAdapterManager = New QLSV_VB.DSTableAdapters.TableAdapterManager()
        Me.MONHOCGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMAMH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTENMH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSOTCLT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSOTCTH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSOTCTH = New DevExpress.XtraEditors.SpinEdit()
        Me.txtSTCLT = New DevExpress.XtraEditors.SpinEdit()
        Me.txttenmh = New DevExpress.XtraEditors.TextEdit()
        Me.txtmamh = New DevExpress.XtraEditors.TextEdit()
        Me.DIEMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DIEMTableAdapter = New QLSV_VB.DSTableAdapters.DIEMTableAdapter()
        MAMHLabel = New System.Windows.Forms.Label()
        TENMHLabel = New System.Windows.Forms.Label()
        SOTCLTLabel = New System.Windows.Forms.Label()
        SOTCTHLabel = New System.Windows.Forms.Label()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MONHOCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MONHOCGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtSOTCTH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSTCLT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttenmh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtmamh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DIEMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MAMHLabel
        '
        MAMHLabel.AutoSize = True
        MAMHLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MAMHLabel.Location = New System.Drawing.Point(165, 53)
        MAMHLabel.Name = "MAMHLabel"
        MAMHLabel.Size = New System.Drawing.Size(114, 19)
        MAMHLabel.TabIndex = 0
        MAMHLabel.Text = "MÃ MÔN HỌC"
        '
        'TENMHLabel
        '
        TENMHLabel.AutoSize = True
        TENMHLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TENMHLabel.Location = New System.Drawing.Point(510, 53)
        TENMHLabel.Name = "TENMHLabel"
        TENMHLabel.Size = New System.Drawing.Size(119, 19)
        TENMHLabel.TabIndex = 2
        TENMHLabel.Text = "TÊN MÔN HỌC"
        '
        'SOTCLTLabel
        '
        SOTCLTLabel.AutoSize = True
        SOTCLTLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SOTCLTLabel.Location = New System.Drawing.Point(165, 97)
        SOTCLTLabel.Name = "SOTCLTLabel"
        SOTCLTLabel.Size = New System.Drawing.Size(179, 19)
        SOTCLTLabel.TabIndex = 4
        SOTCLTLabel.Text = "SỐ TÍN CHỈ LÝ THUYÊT"
        '
        'SOTCTHLabel
        '
        SOTCTHLabel.AutoSize = True
        SOTCTHLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SOTCTHLabel.Location = New System.Drawing.Point(510, 97)
        SOTCTHLabel.Name = "SOTCTHLabel"
        SOTCTHLabel.Size = New System.Drawing.Size(187, 19)
        SOTCTHLabel.TabIndex = 6
        SOTCTHLabel.Text = "SỐ TÍN CHỈ THỰC HÀNH"
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.Text = "Tools"
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 47)
        Me.BarDockControl1.Size = New System.Drawing.Size(904, 0)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 47)
        Me.BarDockControl2.Size = New System.Drawing.Size(904, 0)
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnthem, Me.btnghi, Me.btnxoa, Me.btnsua, Me.btnreload, Me.btnxuatexcel, Me.btnthoat})
        Me.BarManager1.MaxItemId = 7
        '
        'Bar2
        '
        Me.Bar2.BarName = "Tools"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnthem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnghi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnxoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnsua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnreload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnxuatexcel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnthoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar2.Text = "Tools"
        '
        'btnthem
        '
        Me.btnthem.Caption = "THÊM"
        Me.btnthem.Glyph = CType(resources.GetObject("btnthem.Glyph"), System.Drawing.Image)
        Me.btnthem.Id = 0
        Me.btnthem.Name = "btnthem"
        '
        'btnghi
        '
        Me.btnghi.Caption = "GHI"
        Me.btnghi.Glyph = CType(resources.GetObject("btnghi.Glyph"), System.Drawing.Image)
        Me.btnghi.Id = 1
        Me.btnghi.Name = "btnghi"
        '
        'btnxoa
        '
        Me.btnxoa.Caption = "XÓA"
        Me.btnxoa.Glyph = CType(resources.GetObject("btnxoa.Glyph"), System.Drawing.Image)
        Me.btnxoa.Id = 2
        Me.btnxoa.Name = "btnxoa"
        '
        'btnsua
        '
        Me.btnsua.Caption = "SỬA"
        Me.btnsua.Glyph = CType(resources.GetObject("btnsua.Glyph"), System.Drawing.Image)
        Me.btnsua.Id = 3
        Me.btnsua.Name = "btnsua"
        '
        'btnreload
        '
        Me.btnreload.Caption = "RELOAD"
        Me.btnreload.Glyph = CType(resources.GetObject("btnreload.Glyph"), System.Drawing.Image)
        Me.btnreload.Id = 4
        Me.btnreload.Name = "btnreload"
        '
        'btnxuatexcel
        '
        Me.btnxuatexcel.Caption = "XUẤT EXCEL"
        Me.btnxuatexcel.Glyph = Global.QLSV_VB.My.Resources.Resources.Carlosjj_Microsoft_Office_2013_Excel
        Me.btnxuatexcel.Id = 5
        Me.btnxuatexcel.LargeGlyph = Global.QLSV_VB.My.Resources.Resources.Carlosjj_Microsoft_Office_2013_Excel1
        Me.btnxuatexcel.Name = "btnxuatexcel"
        '
        'btnthoat
        '
        Me.btnthoat.Caption = "THOÁT"
        Me.btnthoat.Glyph = CType(resources.GetObject("btnthoat.Glyph"), System.Drawing.Image)
        Me.btnthoat.Id = 6
        Me.btnthoat.Name = "btnthoat"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(904, 47)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 459)
        Me.barDockControlBottom.Size = New System.Drawing.Size(904, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 47)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 412)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(904, 47)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 412)
        '
        'DS
        '
        Me.DS.DataSetName = "DS"
        Me.DS.EnforceConstraints = False
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MONHOCBindingSource
        '
        Me.MONHOCBindingSource.DataMember = "MONHOC"
        Me.MONHOCBindingSource.DataSource = Me.DS
        '
        'MONHOCTableAdapter
        '
        Me.MONHOCTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DIEMTableAdapter = Nothing
        Me.TableAdapterManager.GIANGVIENTableAdapter = Nothing
        Me.TableAdapterManager.LOPTableAdapter = Nothing
        Me.TableAdapterManager.MONHOCTableAdapter = Me.MONHOCTableAdapter
        Me.TableAdapterManager.SINHVIENTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = QLSV_VB.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MONHOCGridControl
        '
        Me.MONHOCGridControl.DataSource = Me.MONHOCBindingSource
        Me.MONHOCGridControl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MONHOCGridControl.Location = New System.Drawing.Point(0, 198)
        Me.MONHOCGridControl.MainView = Me.GridView1
        Me.MONHOCGridControl.MenuManager = Me.BarManager1
        Me.MONHOCGridControl.Name = "MONHOCGridControl"
        Me.MONHOCGridControl.Size = New System.Drawing.Size(904, 261)
        Me.MONHOCGridControl.TabIndex = 7
        Me.MONHOCGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMAMH, Me.colTENMH, Me.colSOTCLT, Me.colSOTCTH})
        Me.GridView1.GridControl = Me.MONHOCGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsFind.AlwaysVisible = True
        '
        'colMAMH
        '
        Me.colMAMH.Caption = "MÃ MÔN HỌC"
        Me.colMAMH.FieldName = "MAMH"
        Me.colMAMH.Name = "colMAMH"
        Me.colMAMH.Visible = True
        Me.colMAMH.VisibleIndex = 0
        '
        'colTENMH
        '
        Me.colTENMH.Caption = "TÊN MÔN HỌC"
        Me.colTENMH.FieldName = "TENMH"
        Me.colTENMH.Name = "colTENMH"
        Me.colTENMH.Visible = True
        Me.colTENMH.VisibleIndex = 1
        '
        'colSOTCLT
        '
        Me.colSOTCLT.Caption = "SỐ TÍN CHỈ LÝ THUYẾT"
        Me.colSOTCLT.FieldName = "SOTCLT"
        Me.colSOTCLT.Name = "colSOTCLT"
        Me.colSOTCLT.Visible = True
        Me.colSOTCLT.VisibleIndex = 2
        '
        'colSOTCTH
        '
        Me.colSOTCTH.Caption = "SỐ TÍN CHỈ THỰC HÀNH"
        Me.colSOTCTH.FieldName = "SOTCTH"
        Me.colSOTCTH.Name = "colSOTCTH"
        Me.colSOTCTH.Visible = True
        Me.colSOTCTH.VisibleIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(SOTCTHLabel)
        Me.GroupBox1.Controls.Add(Me.txtSOTCTH)
        Me.GroupBox1.Controls.Add(SOTCLTLabel)
        Me.GroupBox1.Controls.Add(Me.txtSTCLT)
        Me.GroupBox1.Controls.Add(TENMHLabel)
        Me.GroupBox1.Controls.Add(Me.txttenmh)
        Me.GroupBox1.Controls.Add(MAMHLabel)
        Me.GroupBox1.Controls.Add(Me.txtmamh)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(904, 138)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông Tin Môn Học"
        '
        'txtSOTCTH
        '
        Me.txtSOTCTH.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MONHOCBindingSource, "SOTCTH", True))
        Me.txtSOTCTH.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSOTCTH.Location = New System.Drawing.Point(751, 90)
        Me.txtSOTCTH.MenuManager = Me.BarManager1
        Me.txtSOTCTH.Name = "txtSOTCTH"
        Me.txtSOTCTH.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSOTCTH.Properties.Appearance.Options.UseFont = True
        Me.txtSOTCTH.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSOTCTH.Size = New System.Drawing.Size(100, 26)
        Me.txtSOTCTH.TabIndex = 7
        '
        'txtSTCLT
        '
        Me.txtSTCLT.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MONHOCBindingSource, "SOTCLT", True))
        Me.txtSTCLT.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSTCLT.Location = New System.Drawing.Point(376, 90)
        Me.txtSTCLT.MenuManager = Me.BarManager1
        Me.txtSTCLT.Name = "txtSTCLT"
        Me.txtSTCLT.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSTCLT.Properties.Appearance.Options.UseFont = True
        Me.txtSTCLT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSTCLT.Size = New System.Drawing.Size(100, 26)
        Me.txtSTCLT.TabIndex = 5
        '
        'txttenmh
        '
        Me.txttenmh.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MONHOCBindingSource, "TENMH", True))
        Me.txttenmh.Location = New System.Drawing.Point(654, 46)
        Me.txttenmh.MenuManager = Me.BarManager1
        Me.txttenmh.Name = "txttenmh"
        Me.txttenmh.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttenmh.Properties.Appearance.Options.UseFont = True
        Me.txttenmh.Size = New System.Drawing.Size(229, 26)
        Me.txttenmh.TabIndex = 3
        '
        'txtmamh
        '
        Me.txtmamh.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MONHOCBindingSource, "MAMH", True))
        Me.txtmamh.Location = New System.Drawing.Point(376, 46)
        Me.txtmamh.MenuManager = Me.BarManager1
        Me.txtmamh.Name = "txtmamh"
        Me.txtmamh.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmamh.Properties.Appearance.Options.UseFont = True
        Me.txtmamh.Size = New System.Drawing.Size(100, 26)
        Me.txtmamh.TabIndex = 1
        '
        'DIEMBindingSource
        '
        Me.DIEMBindingSource.DataMember = "FK_MONHOC_DIEM"
        Me.DIEMBindingSource.DataSource = Me.MONHOCBindingSource
        '
        'DIEMTableAdapter
        '
        Me.DIEMTableAdapter.ClearBeforeFill = True
        '
        'FrmMONHOC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 459)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MONHOCGridControl)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "FrmMONHOC"
        Me.Text = "FrmMONHOC"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MONHOCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MONHOCGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtSOTCTH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSTCLT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttenmh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtmamh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DIEMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents btnthem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnghi As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnxoa As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnsua As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnreload As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnxuatexcel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnthoat As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MONHOCBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS As QLSV_VB.DS
    Friend WithEvents MONHOCTableAdapter As QLSV_VB.DSTableAdapters.MONHOCTableAdapter
    Friend WithEvents TableAdapterManager As QLSV_VB.DSTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MONHOCGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtSOTCTH As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtSTCLT As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txttenmh As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtmamh As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colMAMH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTENMH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSOTCLT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSOTCTH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DIEMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DIEMTableAdapter As QLSV_VB.DSTableAdapters.DIEMTableAdapter
End Class
