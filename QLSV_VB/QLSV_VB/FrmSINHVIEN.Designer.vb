<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSINHVIEN
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
        Dim MASVLabel As System.Windows.Forms.Label
        Dim HOLabel As System.Windows.Forms.Label
        Dim TENLabel As System.Windows.Forms.Label
        Dim PHAILabel As System.Windows.Forms.Label
        Dim NGAYSINHLabel As System.Windows.Forms.Label
        Dim NOISINHLabel As System.Windows.Forms.Label
        Dim DIACHILabel As System.Windows.Forms.Label
        Dim GHICHULabel As System.Windows.Forms.Label
        Dim NGHIHOCLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim HINHLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSINHVIEN))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnthem = New DevExpress.XtraBars.BarButtonItem()
        Me.btnghi = New DevExpress.XtraBars.BarButtonItem()
        Me.btnGhi_tk = New DevExpress.XtraBars.BarButtonItem()
        Me.btnxoa = New DevExpress.XtraBars.BarButtonItem()
        Me.btnsua = New DevExpress.XtraBars.BarButtonItem()
        Me.btnreload = New DevExpress.XtraBars.BarButtonItem()
        Me.btnxuatexcel = New DevExpress.XtraBars.BarButtonItem()
        Me.btnthoat = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txttenlop = New DevExpress.XtraEditors.TextEdit()
        Me.LOPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS = New QLSV_VB.DS()
        Me.txthinh = New DevExpress.XtraEditors.TextEdit()
        Me.SINHVIENBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.NGHIHOCCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.txtghichu = New DevExpress.XtraEditors.TextEdit()
        Me.txtdiachi = New DevExpress.XtraEditors.TextEdit()
        Me.txtnoisinh = New DevExpress.XtraEditors.TextEdit()
        Me.dtngaysinh = New DevExpress.XtraEditors.DateEdit()
        Me.PHAICheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.txtten = New DevExpress.XtraEditors.TextEdit()
        Me.txtho = New DevExpress.XtraEditors.TextEdit()
        Me.txtmasv = New DevExpress.XtraEditors.TextEdit()
        Me.btnhinh = New DevExpress.XtraEditors.ButtonEdit()
        Me.LOPTableAdapter = New QLSV_VB.DSTableAdapters.LOPTableAdapter()
        Me.TableAdapterManager = New QLSV_VB.DSTableAdapters.TableAdapterManager()
        Me.SINHVIENTableAdapter = New QLSV_VB.DSTableAdapters.SINHVIENTableAdapter()
        Me.SINHVIENGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMASV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMALOP1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPHAI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNGAYSINH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOISINH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDIACHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGHICHU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNGHIHOC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHINH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LOPGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMALOP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTENLOP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DIEMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DIEMTableAdapter = New QLSV_VB.DSTableAdapters.DIEMTableAdapter()
        MASVLabel = New System.Windows.Forms.Label()
        HOLabel = New System.Windows.Forms.Label()
        TENLabel = New System.Windows.Forms.Label()
        PHAILabel = New System.Windows.Forms.Label()
        NGAYSINHLabel = New System.Windows.Forms.Label()
        NOISINHLabel = New System.Windows.Forms.Label()
        DIACHILabel = New System.Windows.Forms.Label()
        GHICHULabel = New System.Windows.Forms.Label()
        NGHIHOCLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        HINHLabel = New System.Windows.Forms.Label()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txttenlop.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txthinh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SINHVIENBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NGHIHOCCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtghichu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdiachi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtnoisinh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtngaysinh.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtngaysinh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PHAICheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtten.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtho.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtmasv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnhinh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SINHVIENGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOPGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DIEMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MASVLabel
        '
        MASVLabel.AutoSize = True
        MASVLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MASVLabel.Location = New System.Drawing.Point(154, 55)
        MASVLabel.Name = "MASVLabel"
        MASVLabel.Size = New System.Drawing.Size(116, 19)
        MASVLabel.TabIndex = 4
        MASVLabel.Text = "MÃ SINH VIÊN"
        '
        'HOLabel
        '
        HOLabel.AutoSize = True
        HOLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HOLabel.Location = New System.Drawing.Point(154, 99)
        HOLabel.Name = "HOLabel"
        HOLabel.Size = New System.Drawing.Size(32, 19)
        HOLabel.TabIndex = 6
        HOLabel.Text = "HỌ"
        '
        'TENLabel
        '
        TENLabel.AutoSize = True
        TENLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TENLabel.Location = New System.Drawing.Point(419, 99)
        TENLabel.Name = "TENLabel"
        TENLabel.Size = New System.Drawing.Size(39, 19)
        TENLabel.TabIndex = 8
        TENLabel.Text = "TÊN"
        '
        'PHAILabel
        '
        PHAILabel.AutoSize = True
        PHAILabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PHAILabel.Location = New System.Drawing.Point(154, 145)
        PHAILabel.Name = "PHAILabel"
        PHAILabel.Size = New System.Drawing.Size(45, 19)
        PHAILabel.TabIndex = 10
        PHAILabel.Text = "PHÁI"
        '
        'NGAYSINHLabel
        '
        NGAYSINHLabel.AutoSize = True
        NGAYSINHLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NGAYSINHLabel.Location = New System.Drawing.Point(419, 145)
        NGAYSINHLabel.Name = "NGAYSINHLabel"
        NGAYSINHLabel.Size = New System.Drawing.Size(94, 19)
        NGAYSINHLabel.TabIndex = 12
        NGAYSINHLabel.Text = "NGÀY SINH"
        '
        'NOISINHLabel
        '
        NOISINHLabel.AutoSize = True
        NOISINHLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NOISINHLabel.Location = New System.Drawing.Point(154, 188)
        NOISINHLabel.Name = "NOISINHLabel"
        NOISINHLabel.Size = New System.Drawing.Size(79, 19)
        NOISINHLabel.TabIndex = 14
        NOISINHLabel.Text = "NƠI SINH"
        '
        'DIACHILabel
        '
        DIACHILabel.AutoSize = True
        DIACHILabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DIACHILabel.Location = New System.Drawing.Point(154, 230)
        DIACHILabel.Name = "DIACHILabel"
        DIACHILabel.Size = New System.Drawing.Size(66, 19)
        DIACHILabel.TabIndex = 16
        DIACHILabel.Text = "ĐỊA CHỈ"
        '
        'GHICHULabel
        '
        GHICHULabel.AutoSize = True
        GHICHULabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GHICHULabel.Location = New System.Drawing.Point(154, 271)
        GHICHULabel.Name = "GHICHULabel"
        GHICHULabel.Size = New System.Drawing.Size(73, 19)
        GHICHULabel.TabIndex = 18
        GHICHULabel.Text = "GHI CHÚ"
        '
        'NGHIHOCLabel
        '
        NGHIHOCLabel.AutoSize = True
        NGHIHOCLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NGHIHOCLabel.Location = New System.Drawing.Point(154, 315)
        NGHIHOCLabel.Name = "NGHIHOCLabel"
        NGHIHOCLabel.Size = New System.Drawing.Size(86, 19)
        NGHIHOCLabel.TabIndex = 20
        NGHIHOCLabel.Text = "NGHỈ HỌC"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(416, 55)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(73, 19)
        Label1.TabIndex = 23
        Label1.Text = "TÊN LỚP"
        '
        'HINHLabel
        '
        HINHLabel.AutoSize = True
        HINHLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HINHLabel.Location = New System.Drawing.Point(154, 357)
        HINHLabel.Name = "HINHLabel"
        HINHLabel.Size = New System.Drawing.Size(74, 19)
        HINHLabel.TabIndex = 25
        HINHLabel.Text = "File HÌNH"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnthem, Me.btnghi, Me.btnxoa, Me.btnsua, Me.btnreload, Me.btnxuatexcel, Me.btnthoat, Me.btnGhi_tk})
        Me.BarManager1.MaxItemId = 8
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnthem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnghi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnGhi_tk, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnxoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnsua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnreload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnxuatexcel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnthoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar1.Text = "Tools"
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
        'btnGhi_tk
        '
        Me.btnGhi_tk.Caption = "GHI"
        Me.btnGhi_tk.Glyph = CType(resources.GetObject("btnGhi_tk.Glyph"), System.Drawing.Image)
        Me.btnGhi_tk.Id = 7
        Me.btnGhi_tk.Name = "btnGhi_tk"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(1273, 47)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 733)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1273, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 47)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 686)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1273, 47)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 686)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txttenlop)
        Me.GroupBox1.Controls.Add(HINHLabel)
        Me.GroupBox1.Controls.Add(Me.txthinh)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(NGHIHOCLabel)
        Me.GroupBox1.Controls.Add(Me.NGHIHOCCheckEdit)
        Me.GroupBox1.Controls.Add(GHICHULabel)
        Me.GroupBox1.Controls.Add(Me.txtghichu)
        Me.GroupBox1.Controls.Add(DIACHILabel)
        Me.GroupBox1.Controls.Add(Me.txtdiachi)
        Me.GroupBox1.Controls.Add(NOISINHLabel)
        Me.GroupBox1.Controls.Add(Me.txtnoisinh)
        Me.GroupBox1.Controls.Add(NGAYSINHLabel)
        Me.GroupBox1.Controls.Add(Me.dtngaysinh)
        Me.GroupBox1.Controls.Add(PHAILabel)
        Me.GroupBox1.Controls.Add(Me.PHAICheckEdit)
        Me.GroupBox1.Controls.Add(TENLabel)
        Me.GroupBox1.Controls.Add(Me.txtten)
        Me.GroupBox1.Controls.Add(HOLabel)
        Me.GroupBox1.Controls.Add(Me.txtho)
        Me.GroupBox1.Controls.Add(MASVLabel)
        Me.GroupBox1.Controls.Add(Me.txtmasv)
        Me.GroupBox1.Controls.Add(Me.btnhinh)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(754, 400)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "THÔNG TIN SINH VIÊN"
        '
        'txttenlop
        '
        Me.txttenlop.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LOPBindingSource, "TENLOP", True))
        Me.txttenlop.Location = New System.Drawing.Point(528, 54)
        Me.txttenlop.MenuManager = Me.BarManager1
        Me.txttenlop.Name = "txttenlop"
        Me.txttenlop.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttenlop.Properties.Appearance.Options.UseFont = True
        Me.txttenlop.Size = New System.Drawing.Size(180, 26)
        Me.txttenlop.TabIndex = 28
        '
        'LOPBindingSource
        '
        Me.LOPBindingSource.DataMember = "LOP"
        Me.LOPBindingSource.DataSource = Me.DS
        '
        'DS
        '
        Me.DS.DataSetName = "DS"
        Me.DS.EnforceConstraints = False
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txthinh
        '
        Me.txthinh.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SINHVIENBindingSource, "HINH", True))
        Me.txthinh.Location = New System.Drawing.Point(263, 358)
        Me.txthinh.MenuManager = Me.BarManager1
        Me.txthinh.Name = "txthinh"
        Me.txthinh.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthinh.Properties.Appearance.Options.UseFont = True
        Me.txthinh.Size = New System.Drawing.Size(401, 22)
        Me.txthinh.TabIndex = 26
        '
        'SINHVIENBindingSource
        '
        Me.SINHVIENBindingSource.DataMember = "FK_LOP_SINHVIEN"
        Me.SINHVIENBindingSource.DataSource = Me.LOPBindingSource
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(18, 55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(113, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'NGHIHOCCheckEdit
        '
        Me.NGHIHOCCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SINHVIENBindingSource, "NGHIHOC", True))
        Me.NGHIHOCCheckEdit.Location = New System.Drawing.Point(263, 313)
        Me.NGHIHOCCheckEdit.MenuManager = Me.BarManager1
        Me.NGHIHOCCheckEdit.Name = "NGHIHOCCheckEdit"
        Me.NGHIHOCCheckEdit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NGHIHOCCheckEdit.Properties.Appearance.Options.UseFont = True
        Me.NGHIHOCCheckEdit.Properties.Caption = "CÓ"
        Me.NGHIHOCCheckEdit.Size = New System.Drawing.Size(75, 23)
        Me.NGHIHOCCheckEdit.TabIndex = 21
        '
        'txtghichu
        '
        Me.txtghichu.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SINHVIENBindingSource, "GHICHU", True))
        Me.txtghichu.Location = New System.Drawing.Point(263, 268)
        Me.txtghichu.MenuManager = Me.BarManager1
        Me.txtghichu.Name = "txtghichu"
        Me.txtghichu.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtghichu.Properties.Appearance.Options.UseFont = True
        Me.txtghichu.Size = New System.Drawing.Size(401, 26)
        Me.txtghichu.TabIndex = 19
        '
        'txtdiachi
        '
        Me.txtdiachi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SINHVIENBindingSource, "DIACHI", True))
        Me.txtdiachi.Location = New System.Drawing.Point(263, 227)
        Me.txtdiachi.MenuManager = Me.BarManager1
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdiachi.Properties.Appearance.Options.UseFont = True
        Me.txtdiachi.Size = New System.Drawing.Size(401, 26)
        Me.txtdiachi.TabIndex = 17
        '
        'txtnoisinh
        '
        Me.txtnoisinh.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SINHVIENBindingSource, "NOISINH", True))
        Me.txtnoisinh.Location = New System.Drawing.Point(263, 185)
        Me.txtnoisinh.MenuManager = Me.BarManager1
        Me.txtnoisinh.Name = "txtnoisinh"
        Me.txtnoisinh.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnoisinh.Properties.Appearance.Options.UseFont = True
        Me.txtnoisinh.Size = New System.Drawing.Size(401, 26)
        Me.txtnoisinh.TabIndex = 15
        '
        'dtngaysinh
        '
        Me.dtngaysinh.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SINHVIENBindingSource, "NGAYSINH", True))
        Me.dtngaysinh.EditValue = Nothing
        Me.dtngaysinh.Location = New System.Drawing.Point(528, 142)
        Me.dtngaysinh.MenuManager = Me.BarManager1
        Me.dtngaysinh.Name = "dtngaysinh"
        Me.dtngaysinh.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtngaysinh.Properties.Appearance.Options.UseFont = True
        Me.dtngaysinh.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtngaysinh.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtngaysinh.Size = New System.Drawing.Size(136, 26)
        Me.dtngaysinh.TabIndex = 13
        '
        'PHAICheckEdit
        '
        Me.PHAICheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SINHVIENBindingSource, "PHAI", True))
        Me.PHAICheckEdit.Location = New System.Drawing.Point(227, 145)
        Me.PHAICheckEdit.MenuManager = Me.BarManager1
        Me.PHAICheckEdit.Name = "PHAICheckEdit"
        Me.PHAICheckEdit.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PHAICheckEdit.Properties.Appearance.Options.UseFont = True
        Me.PHAICheckEdit.Properties.Caption = "NAM"
        Me.PHAICheckEdit.Size = New System.Drawing.Size(75, 23)
        Me.PHAICheckEdit.TabIndex = 11
        '
        'txtten
        '
        Me.txtten.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SINHVIENBindingSource, "TEN", True))
        Me.txtten.Location = New System.Drawing.Point(527, 96)
        Me.txtten.MenuManager = Me.BarManager1
        Me.txtten.Name = "txtten"
        Me.txtten.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtten.Properties.Appearance.Options.UseFont = True
        Me.txtten.Size = New System.Drawing.Size(137, 26)
        Me.txtten.TabIndex = 9
        '
        'txtho
        '
        Me.txtho.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SINHVIENBindingSource, "HO", True))
        Me.txtho.Location = New System.Drawing.Point(202, 96)
        Me.txtho.MenuManager = Me.BarManager1
        Me.txtho.Name = "txtho"
        Me.txtho.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtho.Properties.Appearance.Options.UseFont = True
        Me.txtho.Size = New System.Drawing.Size(175, 26)
        Me.txtho.TabIndex = 7
        '
        'txtmasv
        '
        Me.txtmasv.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SINHVIENBindingSource, "MASV", True))
        Me.txtmasv.Location = New System.Drawing.Point(277, 52)
        Me.txtmasv.MenuManager = Me.BarManager1
        Me.txtmasv.Name = "txtmasv"
        Me.txtmasv.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmasv.Properties.Appearance.Options.UseFont = True
        Me.txtmasv.Size = New System.Drawing.Size(100, 26)
        Me.txtmasv.TabIndex = 5
        '
        'btnhinh
        '
        Me.btnhinh.Location = New System.Drawing.Point(670, 358)
        Me.btnhinh.MenuManager = Me.BarManager1
        Me.btnhinh.Name = "btnhinh"
        Me.btnhinh.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhinh.Properties.Appearance.Options.UseFont = True
        Me.btnhinh.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.btnhinh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        Me.btnhinh.Size = New System.Drawing.Size(24, 18)
        Me.btnhinh.TabIndex = 27
        '
        'LOPTableAdapter
        '
        Me.LOPTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DIEMTableAdapter = Nothing
        Me.TableAdapterManager.GIANGVIENTableAdapter = Nothing
        Me.TableAdapterManager.LOPTableAdapter = Me.LOPTableAdapter
        Me.TableAdapterManager.MONHOCTableAdapter = Nothing
        Me.TableAdapterManager.SINHVIENTableAdapter = Me.SINHVIENTableAdapter
        Me.TableAdapterManager.UpdateOrder = QLSV_VB.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SINHVIENTableAdapter
        '
        Me.SINHVIENTableAdapter.ClearBeforeFill = True
        '
        'SINHVIENGridControl
        '
        Me.SINHVIENGridControl.DataSource = Me.SINHVIENBindingSource
        Me.SINHVIENGridControl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SINHVIENGridControl.Location = New System.Drawing.Point(0, 463)
        Me.SINHVIENGridControl.MainView = Me.GridView1
        Me.SINHVIENGridControl.MenuManager = Me.BarManager1
        Me.SINHVIENGridControl.Name = "SINHVIENGridControl"
        Me.SINHVIENGridControl.Size = New System.Drawing.Size(1273, 270)
        Me.SINHVIENGridControl.TabIndex = 5
        Me.SINHVIENGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMASV, Me.colHO, Me.colTEN, Me.colMALOP1, Me.colPHAI, Me.colNGAYSINH, Me.colNOISINH, Me.colDIACHI, Me.colGHICHU, Me.colNGHIHOC, Me.colHINH})
        Me.GridView1.GridControl = Me.SINHVIENGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsFind.AlwaysVisible = True
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
        'colHO
        '
        Me.colHO.Caption = "HỌ"
        Me.colHO.FieldName = "HO"
        Me.colHO.Name = "colHO"
        Me.colHO.OptionsColumn.ReadOnly = True
        Me.colHO.Visible = True
        Me.colHO.VisibleIndex = 1
        '
        'colTEN
        '
        Me.colTEN.Caption = "TÊN"
        Me.colTEN.FieldName = "TEN"
        Me.colTEN.Name = "colTEN"
        Me.colTEN.OptionsColumn.ReadOnly = True
        Me.colTEN.Visible = True
        Me.colTEN.VisibleIndex = 2
        '
        'colMALOP1
        '
        Me.colMALOP1.Caption = "MÃ LỚP"
        Me.colMALOP1.FieldName = "MALOP"
        Me.colMALOP1.Name = "colMALOP1"
        Me.colMALOP1.OptionsColumn.ReadOnly = True
        Me.colMALOP1.Visible = True
        Me.colMALOP1.VisibleIndex = 3
        '
        'colPHAI
        '
        Me.colPHAI.Caption = "PHÁI"
        Me.colPHAI.FieldName = "PHAI"
        Me.colPHAI.Name = "colPHAI"
        Me.colPHAI.OptionsColumn.ReadOnly = True
        Me.colPHAI.Visible = True
        Me.colPHAI.VisibleIndex = 4
        '
        'colNGAYSINH
        '
        Me.colNGAYSINH.Caption = "NGÀY SINH"
        Me.colNGAYSINH.FieldName = "NGAYSINH"
        Me.colNGAYSINH.Name = "colNGAYSINH"
        Me.colNGAYSINH.OptionsColumn.ReadOnly = True
        Me.colNGAYSINH.Visible = True
        Me.colNGAYSINH.VisibleIndex = 5
        '
        'colNOISINH
        '
        Me.colNOISINH.Caption = "NƠI SINH"
        Me.colNOISINH.FieldName = "NOISINH"
        Me.colNOISINH.Name = "colNOISINH"
        Me.colNOISINH.OptionsColumn.ReadOnly = True
        Me.colNOISINH.Visible = True
        Me.colNOISINH.VisibleIndex = 6
        '
        'colDIACHI
        '
        Me.colDIACHI.Caption = "ĐỊA CHỈ"
        Me.colDIACHI.FieldName = "DIACHI"
        Me.colDIACHI.Name = "colDIACHI"
        Me.colDIACHI.OptionsColumn.ReadOnly = True
        Me.colDIACHI.Visible = True
        Me.colDIACHI.VisibleIndex = 7
        '
        'colGHICHU
        '
        Me.colGHICHU.Caption = "GHI CHÚ"
        Me.colGHICHU.FieldName = "GHICHU"
        Me.colGHICHU.Name = "colGHICHU"
        Me.colGHICHU.OptionsColumn.ReadOnly = True
        Me.colGHICHU.Visible = True
        Me.colGHICHU.VisibleIndex = 8
        '
        'colNGHIHOC
        '
        Me.colNGHIHOC.Caption = "NGHỈ HỌC"
        Me.colNGHIHOC.FieldName = "NGHIHOC"
        Me.colNGHIHOC.Name = "colNGHIHOC"
        Me.colNGHIHOC.OptionsColumn.ReadOnly = True
        Me.colNGHIHOC.Visible = True
        Me.colNGHIHOC.VisibleIndex = 9
        '
        'colHINH
        '
        Me.colHINH.Caption = "HÌNH ẢNH"
        Me.colHINH.FieldName = "HINH"
        Me.colHINH.Name = "colHINH"
        Me.colHINH.OptionsColumn.ReadOnly = True
        Me.colHINH.Visible = True
        Me.colHINH.VisibleIndex = 10
        '
        'LOPGridControl
        '
        Me.LOPGridControl.DataSource = Me.LOPBindingSource
        Me.LOPGridControl.Location = New System.Drawing.Point(16, 25)
        Me.LOPGridControl.MainView = Me.GridView2
        Me.LOPGridControl.MenuManager = Me.BarManager1
        Me.LOPGridControl.Name = "LOPGridControl"
        Me.LOPGridControl.Size = New System.Drawing.Size(464, 321)
        Me.LOPGridControl.TabIndex = 18
        Me.LOPGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMALOP, Me.colTENLOP})
        Me.GridView2.GridControl = Me.LOPGridControl
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsFind.AlwaysVisible = True
        '
        'colMALOP
        '
        Me.colMALOP.Caption = "MÃ LỚP"
        Me.colMALOP.FieldName = "MALOP"
        Me.colMALOP.Name = "colMALOP"
        Me.colMALOP.Visible = True
        Me.colMALOP.VisibleIndex = 0
        '
        'colTENLOP
        '
        Me.colTENLOP.Caption = "TÊN LỚP"
        Me.colTENLOP.FieldName = "TENLOP"
        Me.colTENLOP.Name = "colTENLOP"
        Me.colTENLOP.Visible = True
        Me.colTENLOP.VisibleIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LOPGridControl)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(750, 53)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(486, 352)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DANH SÁCH LỚP"
        '
        'DIEMBindingSource
        '
        Me.DIEMBindingSource.DataMember = "FK_DIEM_SINHVIEN"
        Me.DIEMBindingSource.DataSource = Me.SINHVIENBindingSource
        '
        'DIEMTableAdapter
        '
        Me.DIEMTableAdapter.ClearBeforeFill = True
        '
        'FrmSINHVIEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1273, 733)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.SINHVIENGridControl)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "FrmSINHVIEN"
        Me.Text = "FrmSINHVIEN"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txttenlop.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txthinh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SINHVIENBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NGHIHOCCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtghichu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdiachi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtnoisinh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtngaysinh.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtngaysinh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PHAICheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtten.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtho.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtmasv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnhinh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SINHVIENGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOPGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DIEMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnthem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnghi As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnxoa As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnsua As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnreload As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnxuatexcel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnthoat As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LOPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS As QLSV_VB.DS
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LOPTableAdapter As QLSV_VB.DSTableAdapters.LOPTableAdapter
    Friend WithEvents TableAdapterManager As QLSV_VB.DSTableAdapters.TableAdapterManager
    Friend WithEvents SINHVIENTableAdapter As QLSV_VB.DSTableAdapters.SINHVIENTableAdapter
    Friend WithEvents SINHVIENBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SINHVIENGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NGHIHOCCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtghichu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtdiachi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtnoisinh As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtngaysinh As DevExpress.XtraEditors.DateEdit
    Friend WithEvents PHAICheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtten As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtho As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtmasv As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LOPGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colMALOP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTENLOP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMASV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMALOP1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPHAI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNGAYSINH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOISINH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDIACHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGHICHU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNGHIHOC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHINH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txthinh As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DIEMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DIEMTableAdapter As QLSV_VB.DSTableAdapters.DIEMTableAdapter
    Friend WithEvents txttenlop As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnhinh As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents btnGhi_tk As DevExpress.XtraBars.BarButtonItem
End Class
