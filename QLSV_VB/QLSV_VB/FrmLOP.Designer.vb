<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLOP
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
        Dim TENLOPLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLOP))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnthem = New DevExpress.XtraBars.BarButtonItem()
        Me.btghi = New DevExpress.XtraBars.BarButtonItem()
        Me.btnxoa = New DevExpress.XtraBars.BarButtonItem()
        Me.btnsua = New DevExpress.XtraBars.BarButtonItem()
        Me.btnreload = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.btbThoat = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTENLOP = New DevExpress.XtraEditors.TextEdit()
        Me.LOPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS = New QLSV_VB.DS()
        Me.txtMALOP = New DevExpress.XtraEditors.TextEdit()
        Me.LOPTableAdapter = New QLSV_VB.DSTableAdapters.LOPTableAdapter()
        Me.TableAdapterManager = New QLSV_VB.DSTableAdapters.TableAdapterManager()
        Me.LOPGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMALOP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTENLOP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SINHVIENBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SINHVIENTableAdapter = New QLSV_VB.DSTableAdapters.SINHVIENTableAdapter()
        MALOPLabel = New System.Windows.Forms.Label()
        TENLOPLabel = New System.Windows.Forms.Label()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtTENLOP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMALOP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOPGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SINHVIENBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MALOPLabel
        '
        MALOPLabel.AutoSize = True
        MALOPLabel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MALOPLabel.Location = New System.Drawing.Point(123, 60)
        MALOPLabel.Name = "MALOPLabel"
        MALOPLabel.Size = New System.Drawing.Size(61, 15)
        MALOPLabel.TabIndex = 0
        MALOPLabel.Text = "MÃ LỚP :"
        '
        'TENLOPLabel
        '
        TENLOPLabel.AutoSize = True
        TENLOPLabel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TENLOPLabel.Location = New System.Drawing.Point(366, 60)
        TENLOPLabel.Name = "TENLOPLabel"
        TENLOPLabel.Size = New System.Drawing.Size(63, 15)
        TENLOPLabel.TabIndex = 3
        TENLOPLabel.Text = "TÊN LỚP :"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnthem, Me.btghi, Me.btnxoa, Me.btnsua, Me.btnreload, Me.BarButtonItem1, Me.BarEditItem1, Me.btbThoat})
        Me.BarManager1.MaxItemId = 8
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit1})
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnthem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btghi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnxoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnsua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnreload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btbThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar1.Text = "Tools"
        '
        'btnthem
        '
        Me.btnthem.Caption = "THÊM"
        Me.btnthem.Glyph = CType(resources.GetObject("btnthem.Glyph"), System.Drawing.Image)
        Me.btnthem.Id = 0
        Me.btnthem.Name = "btnthem"
        '
        'btghi
        '
        Me.btghi.Caption = "GHI"
        Me.btghi.Glyph = CType(resources.GetObject("btghi.Glyph"), System.Drawing.Image)
        Me.btghi.Id = 1
        Me.btghi.Name = "btghi"
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
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "XUẤT EXECL"
        Me.BarButtonItem1.Glyph = CType(resources.GetObject("BarButtonItem1.Glyph"), System.Drawing.Image)
        Me.BarButtonItem1.Id = 5
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'btbThoat
        '
        Me.btbThoat.Caption = "THOÁT"
        Me.btbThoat.Glyph = CType(resources.GetObject("btbThoat.Glyph"), System.Drawing.Image)
        Me.btbThoat.Id = 7
        Me.btbThoat.Name = "btbThoat"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(913, 47)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 497)
        Me.barDockControlBottom.Size = New System.Drawing.Size(913, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 47)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 450)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(913, 47)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 450)
        '
        'BarEditItem1
        '
        Me.BarEditItem1.Caption = "BarEditItem1"
        Me.BarEditItem1.Edit = Me.RepositoryItemButtonEdit1
        Me.BarEditItem1.Id = 6
        Me.BarEditItem1.Name = "BarEditItem1"
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(TENLOPLabel)
        Me.GroupBox1.Controls.Add(Me.txtTENLOP)
        Me.GroupBox1.Controls.Add(MALOPLabel)
        Me.GroupBox1.Controls.Add(Me.txtMALOP)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(913, 136)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông Tin Lớp"
        '
        'txtTENLOP
        '
        Me.txtTENLOP.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LOPBindingSource, "TENLOP", True))
        Me.txtTENLOP.Location = New System.Drawing.Point(438, 57)
        Me.txtTENLOP.MenuManager = Me.BarManager1
        Me.txtTENLOP.Name = "txtTENLOP"
        Me.txtTENLOP.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTENLOP.Properties.Appearance.Options.UseFont = True
        Me.txtTENLOP.Size = New System.Drawing.Size(256, 22)
        Me.txtTENLOP.TabIndex = 2
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
        'txtMALOP
        '
        Me.txtMALOP.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.LOPBindingSource, "MALOP", True))
        Me.txtMALOP.Location = New System.Drawing.Point(190, 57)
        Me.txtMALOP.MenuManager = Me.BarManager1
        Me.txtMALOP.Name = "txtMALOP"
        Me.txtMALOP.Properties.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMALOP.Properties.Appearance.Options.UseFont = True
        Me.txtMALOP.Size = New System.Drawing.Size(100, 22)
        Me.txtMALOP.TabIndex = 1
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
        Me.TableAdapterManager.SINHVIENTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = QLSV_VB.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LOPGridControl
        '
        Me.LOPGridControl.DataSource = Me.LOPBindingSource
        Me.LOPGridControl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LOPGridControl.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LOPGridControl.Location = New System.Drawing.Point(0, 183)
        Me.LOPGridControl.MainView = Me.GridView1
        Me.LOPGridControl.MenuManager = Me.BarManager1
        Me.LOPGridControl.Name = "LOPGridControl"
        Me.LOPGridControl.Size = New System.Drawing.Size(913, 314)
        Me.LOPGridControl.TabIndex = 14
        Me.LOPGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMALOP, Me.colTENLOP})
        Me.GridView1.GridControl = Me.LOPGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colMALOP, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colMALOP
        '
        Me.colMALOP.AppearanceHeader.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colMALOP.AppearanceHeader.Options.UseFont = True
        Me.colMALOP.Caption = "MÃ LỚP"
        Me.colMALOP.FieldName = "MALOP"
        Me.colMALOP.Name = "colMALOP"
        Me.colMALOP.Visible = True
        Me.colMALOP.VisibleIndex = 0
        Me.colMALOP.Width = 303
        '
        'colTENLOP
        '
        Me.colTENLOP.AppearanceHeader.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colTENLOP.AppearanceHeader.Options.UseFont = True
        Me.colTENLOP.Caption = "TÊN LỚP"
        Me.colTENLOP.FieldName = "TENLOP"
        Me.colTENLOP.Name = "colTENLOP"
        Me.colTENLOP.Visible = True
        Me.colTENLOP.VisibleIndex = 1
        Me.colTENLOP.Width = 408
        '
        'SINHVIENBindingSource
        '
        Me.SINHVIENBindingSource.DataMember = "FK_LOP_SINHVIEN"
        Me.SINHVIENBindingSource.DataSource = Me.LOPBindingSource
        '
        'SINHVIENTableAdapter
        '
        Me.SINHVIENTableAdapter.ClearBeforeFill = True
        '
        'FrmLOP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(930, 469)
        Me.Controls.Add(Me.LOPGridControl)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "FrmLOP"
        Me.Text = "BẢNG LỚP"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtTENLOP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMALOP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOPGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SINHVIENBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnthem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btghi As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnxoa As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnsua As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnreload As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LOPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS As QLSV_VB.DS
    Friend WithEvents LOPTableAdapter As QLSV_VB.DSTableAdapters.LOPTableAdapter
    Friend WithEvents TableAdapterManager As QLSV_VB.DSTableAdapters.TableAdapterManager
    Friend WithEvents LOPGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colMALOP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTENLOP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtTENLOP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMALOP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SINHVIENBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SINHVIENTableAdapter As QLSV_VB.DSTableAdapters.SINHVIENTableAdapter
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents btbThoat As DevExpress.XtraBars.BarButtonItem
End Class
