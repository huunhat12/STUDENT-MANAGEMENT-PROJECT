<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDIEM
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
        Dim MALOPLabel As System.Windows.Forms.Label
        Dim MAMHLabel As System.Windows.Forms.Label
        Dim LANLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDIEM))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnghi = New DevExpress.XtraBars.BarButtonItem()
        Me.btnxoa = New DevExpress.XtraBars.BarButtonItem()
        Me.btnreload = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnthoat = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.DS = New QLSV_VB.DS()
        Me.LOPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOPTableAdapter = New QLSV_VB.DSTableAdapters.LOPTableAdapter()
        Me.TableAdapterManager = New QLSV_VB.DSTableAdapters.TableAdapterManager()
        Me.DIEMTableAdapter = New QLSV_VB.DSTableAdapters.DIEMTableAdapter()
        Me.MONHOCTableAdapter = New QLSV_VB.DSTableAdapters.MONHOCTableAdapter()
        Me.SINHVIENTableAdapter = New QLSV_VB.DSTableAdapters.SINHVIENTableAdapter()
        Me.SINHVIENBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DIEMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.drlTenlop = New System.Windows.Forms.ComboBox()
        Me.MONHOCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.drlTenmh = New System.Windows.Forms.ComboBox()
        Me.drlLan = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtmamh = New DevExpress.XtraEditors.TextEdit()
        Me.txtmalop = New DevExpress.XtraEditors.TextEdit()
        Me.btnnhap = New DevExpress.XtraEditors.SimpleButton()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LOAD_DIEMSVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOAD_DIEMSVTableAdapter = New QLSV_VB.DSTableAdapters.LOAD_DIEMSVTableAdapter()
        Me.GRV_LOAD_DIEMSV = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMASV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHOTEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDIEM = New DevExpress.XtraGrid.Columns.GridColumn()
        MALOPLabel = New System.Windows.Forms.Label()
        MAMHLabel = New System.Windows.Forms.Label()
        LANLabel = New System.Windows.Forms.Label()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SINHVIENBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DIEMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MONHOCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtmamh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtmalop.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOAD_DIEMSVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GRV_LOAD_DIEMSV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MALOPLabel
        '
        MALOPLabel.AutoSize = True
        MALOPLabel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MALOPLabel.Location = New System.Drawing.Point(137, 50)
        MALOPLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        MALOPLabel.Name = "MALOPLabel"
        MALOPLabel.Size = New System.Drawing.Size(57, 15)
        MALOPLabel.TabIndex = 5
        MALOPLabel.Text = "TÊN LỚP"
        '
        'MAMHLabel
        '
        MAMHLabel.AutoSize = True
        MAMHLabel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MAMHLabel.Location = New System.Drawing.Point(416, 50)
        MAMHLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        MAMHLabel.Name = "MAMHLabel"
        MAMHLabel.Size = New System.Drawing.Size(66, 15)
        MAMHLabel.TabIndex = 7
        MAMHLabel.Text = "MÔN HỌC"
        '
        'LANLabel
        '
        LANLabel.AutoSize = True
        LANLabel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LANLabel.Location = New System.Drawing.Point(717, 50)
        LANLabel.Name = "LANLabel"
        LANLabel.Size = New System.Drawing.Size(33, 15)
        LANLabel.TabIndex = 8
        LANLabel.Text = "LẦN"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnghi, Me.btnxoa, Me.btnreload, Me.btnthoat, Me.BarButtonItem5})
        Me.BarManager1.MaxItemId = 5
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnghi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnxoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnreload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem5, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnthoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar1.Offset = 1
        Me.Bar1.Text = "Tools"
        '
        'btnghi
        '
        Me.btnghi.Caption = "GHI"
        Me.btnghi.Glyph = CType(resources.GetObject("btnghi.Glyph"), System.Drawing.Image)
        Me.btnghi.Id = 0
        Me.btnghi.Name = "btnghi"
        '
        'btnxoa
        '
        Me.btnxoa.Caption = "XÓA"
        Me.btnxoa.Glyph = CType(resources.GetObject("btnxoa.Glyph"), System.Drawing.Image)
        Me.btnxoa.Id = 1
        Me.btnxoa.Name = "btnxoa"
        '
        'btnreload
        '
        Me.btnreload.Caption = "RELOAD"
        Me.btnreload.Glyph = CType(resources.GetObject("btnreload.Glyph"), System.Drawing.Image)
        Me.btnreload.Id = 2
        Me.btnreload.Name = "btnreload"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "XUẤT EXCEL"
        Me.BarButtonItem5.Glyph = Global.QLSV_VB.My.Resources.Resources.Carlosjj_Microsoft_Office_2013_Excel1
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'btnthoat
        '
        Me.btnthoat.Caption = "THOÁT"
        Me.btnthoat.Glyph = CType(resources.GetObject("btnthoat.Glyph"), System.Drawing.Image)
        Me.btnthoat.Id = 3
        Me.btnthoat.Name = "btnthoat"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.barDockControlTop.Size = New System.Drawing.Size(979, 47)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 703)
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.barDockControlBottom.Size = New System.Drawing.Size(979, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 47)
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 656)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(979, 47)
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 656)
        '
        'DS
        '
        Me.DS.DataSetName = "DS"
        Me.DS.EnforceConstraints = False
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LOPBindingSource
        '
        Me.LOPBindingSource.DataMember = "LOP"
        Me.LOPBindingSource.DataSource = Me.DS
        '
        'LOPTableAdapter
        '
        Me.LOPTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DIEMTableAdapter = Me.DIEMTableAdapter
        Me.TableAdapterManager.GIANGVIENTableAdapter = Nothing
        Me.TableAdapterManager.LOPTableAdapter = Me.LOPTableAdapter
        Me.TableAdapterManager.MONHOCTableAdapter = Me.MONHOCTableAdapter
        Me.TableAdapterManager.SINHVIENTableAdapter = Me.SINHVIENTableAdapter
        Me.TableAdapterManager.UpdateOrder = QLSV_VB.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DIEMTableAdapter
        '
        Me.DIEMTableAdapter.ClearBeforeFill = True
        '
        'MONHOCTableAdapter
        '
        Me.MONHOCTableAdapter.ClearBeforeFill = True
        '
        'SINHVIENTableAdapter
        '
        Me.SINHVIENTableAdapter.ClearBeforeFill = True
        '
        'SINHVIENBindingSource
        '
        Me.SINHVIENBindingSource.DataMember = "FK_LOP_SINHVIEN"
        Me.SINHVIENBindingSource.DataSource = Me.LOPBindingSource
        '
        'DIEMBindingSource
        '
        Me.DIEMBindingSource.DataMember = "FK_DIEM_SINHVIEN"
        Me.DIEMBindingSource.DataSource = Me.SINHVIENBindingSource
        '
        'drlTenlop
        '
        Me.drlTenlop.DataSource = Me.LOPBindingSource
        Me.drlTenlop.DisplayMember = "TENLOP"
        Me.drlTenlop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.drlTenlop.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drlTenlop.FormattingEnabled = True
        Me.drlTenlop.Location = New System.Drawing.Point(202, 44)
        Me.drlTenlop.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.drlTenlop.Name = "drlTenlop"
        Me.drlTenlop.Size = New System.Drawing.Size(179, 23)
        Me.drlTenlop.TabIndex = 6
        Me.drlTenlop.ValueMember = "MALOP"
        '
        'MONHOCBindingSource
        '
        Me.MONHOCBindingSource.DataMember = "MONHOC"
        Me.MONHOCBindingSource.DataSource = Me.DS
        '
        'drlTenmh
        '
        Me.drlTenmh.DataSource = Me.MONHOCBindingSource
        Me.drlTenmh.DisplayMember = "TENMH"
        Me.drlTenmh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.drlTenmh.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drlTenmh.FormattingEnabled = True
        Me.drlTenmh.Location = New System.Drawing.Point(500, 44)
        Me.drlTenmh.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.drlTenmh.Name = "drlTenmh"
        Me.drlTenmh.Size = New System.Drawing.Size(179, 23)
        Me.drlTenmh.TabIndex = 8
        Me.drlTenmh.ValueMember = "MAMH"
        '
        'drlLan
        '
        Me.drlLan.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIEMBindingSource, "LAN", True))
        Me.drlLan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.drlLan.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drlLan.FormattingEnabled = True
        Me.drlLan.Items.AddRange(New Object() {"1", "2"})
        Me.drlLan.Location = New System.Drawing.Point(769, 44)
        Me.drlLan.Name = "drlLan"
        Me.drlLan.Size = New System.Drawing.Size(106, 23)
        Me.drlLan.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtmamh)
        Me.GroupBox1.Controls.Add(Me.txtmalop)
        Me.GroupBox1.Controls.Add(Me.drlTenmh)
        Me.GroupBox1.Controls.Add(LANLabel)
        Me.GroupBox1.Controls.Add(Me.drlTenlop)
        Me.GroupBox1.Controls.Add(Me.drlLan)
        Me.GroupBox1.Controls.Add(MALOPLabel)
        Me.GroupBox1.Controls.Add(MAMHLabel)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(979, 100)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "NHẬP ĐIỂM"
        '
        'txtmamh
        '
        Me.txtmamh.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.MONHOCBindingSource, "MAMH", True))
        Me.txtmamh.Location = New System.Drawing.Point(500, 16)
        Me.txtmamh.MenuManager = Me.BarManager1
        Me.txtmamh.Name = "txtmamh"
        Me.txtmamh.Size = New System.Drawing.Size(100, 20)
        Me.txtmamh.TabIndex = 12
        '
        'txtmalop
        '
        Me.txtmalop.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LOPBindingSource, "MALOP", True))
        Me.txtmalop.Location = New System.Drawing.Point(202, 16)
        Me.txtmalop.MenuManager = Me.BarManager1
        Me.txtmalop.Name = "txtmalop"
        Me.txtmalop.Size = New System.Drawing.Size(100, 20)
        Me.txtmalop.TabIndex = 11
        '
        'btnnhap
        '
        Me.btnnhap.Image = Global.QLSV_VB.My.Resources.Resources.play_button
        Me.btnnhap.Location = New System.Drawing.Point(488, 0)
        Me.btnnhap.Name = "btnnhap"
        Me.btnnhap.Size = New System.Drawing.Size(102, 45)
        Me.btnnhap.TabIndex = 19
        Me.btnnhap.Text = "BẮT ĐẦU"
        '
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
        '
        'LOAD_DIEMSVBindingSource
        '
        Me.LOAD_DIEMSVBindingSource.DataMember = "LOAD_DIEMSV"
        Me.LOAD_DIEMSVBindingSource.DataSource = Me.DS
        '
        'LOAD_DIEMSVTableAdapter
        '
        Me.LOAD_DIEMSVTableAdapter.ClearBeforeFill = True
        '
        'GRV_LOAD_DIEMSV
        '
        Me.GRV_LOAD_DIEMSV.DataSource = Me.LOAD_DIEMSVBindingSource
        Me.GRV_LOAD_DIEMSV.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GRV_LOAD_DIEMSV.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GRV_LOAD_DIEMSV.Location = New System.Drawing.Point(0, 153)
        Me.GRV_LOAD_DIEMSV.MainView = Me.GridView2
        Me.GRV_LOAD_DIEMSV.MenuManager = Me.BarManager1
        Me.GRV_LOAD_DIEMSV.Name = "GRV_LOAD_DIEMSV"
        Me.GRV_LOAD_DIEMSV.Size = New System.Drawing.Size(979, 550)
        Me.GRV_LOAD_DIEMSV.TabIndex = 29
        Me.GRV_LOAD_DIEMSV.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMASV, Me.colHOTEN, Me.colDIEM})
        Me.GridView2.GridControl = Me.GRV_LOAD_DIEMSV
        Me.GridView2.Name = "GridView2"
        '
        'colMASV
        '
        Me.colMASV.Caption = "MÃ SINH VIÊN"
        Me.colMASV.FieldName = "MASV"
        Me.colMASV.Name = "colMASV"
        Me.colMASV.OptionsColumn.ReadOnly = True
        Me.colMASV.Visible = True
        Me.colMASV.VisibleIndex = 0
        '
        'colHOTEN
        '
        Me.colHOTEN.Caption = "HỌ TÊN"
        Me.colHOTEN.FieldName = "HOTEN"
        Me.colHOTEN.Name = "colHOTEN"
        Me.colHOTEN.OptionsColumn.ReadOnly = True
        Me.colHOTEN.Visible = True
        Me.colHOTEN.VisibleIndex = 1
        '
        'colDIEM
        '
        Me.colDIEM.Caption = "ĐIỂM"
        Me.colDIEM.FieldName = "DIEM"
        Me.colDIEM.Name = "colDIEM"
        Me.colDIEM.Visible = True
        Me.colDIEM.VisibleIndex = 2
        '
        'FrmDIEM
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(979, 703)
        Me.Controls.Add(Me.GRV_LOAD_DIEMSV)
        Me.Controls.Add(Me.btnnhap)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmDIEM"
        Me.Text = "FrmDIEM"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SINHVIENBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DIEMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MONHOCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtmamh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtmalop.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOAD_DIEMSVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GRV_LOAD_DIEMSV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnghi As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnxoa As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnreload As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnthoat As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents LOPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS As QLSV_VB.DS
    Friend WithEvents LOPTableAdapter As QLSV_VB.DSTableAdapters.LOPTableAdapter
    Friend WithEvents TableAdapterManager As QLSV_VB.DSTableAdapters.TableAdapterManager
    Friend WithEvents SINHVIENTableAdapter As QLSV_VB.DSTableAdapters.SINHVIENTableAdapter
    Friend WithEvents SINHVIENBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DIEMTableAdapter As QLSV_VB.DSTableAdapters.DIEMTableAdapter
    Friend WithEvents DIEMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents drlTenlop As System.Windows.Forms.ComboBox
    Friend WithEvents MONHOCTableAdapter As QLSV_VB.DSTableAdapters.MONHOCTableAdapter
    Friend WithEvents MONHOCBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents drlLan As System.Windows.Forms.ComboBox
    Friend WithEvents drlTenmh As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnnhap As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtmalop As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtmamh As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LOAD_DIEMSVBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LOAD_DIEMSVTableAdapter As QLSV_VB.DSTableAdapters.LOAD_DIEMSVTableAdapter
    Friend WithEvents GRV_LOAD_DIEMSV As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colMASV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHOTEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDIEM As DevExpress.XtraGrid.Columns.GridColumn
End Class
