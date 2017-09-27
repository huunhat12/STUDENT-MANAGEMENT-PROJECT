Partial Public Class FrmMain
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.ĐA = New DevExpress.XtraBars.BarButtonItem()
        Me.ItemDSGV = New DevExpress.XtraBars.BarButtonItem()
        Me.ItemDSLOP = New DevExpress.XtraBars.BarButtonItem()
        Me.ItemDSSV = New DevExpress.XtraBars.BarButtonItem()
        Me.ItemDSMH = New DevExpress.XtraBars.BarButtonItem()
        Me.ItemDSDiem = New DevExpress.XtraBars.BarButtonItem()
        Me.Item_IN_DSSV = New DevExpress.XtraBars.BarButtonItem()
        Me.Item_IN_DIEMMH = New DevExpress.XtraBars.BarButtonItem()
        Me.Item_IN_PHIEUDIEM = New DevExpress.XtraBars.BarButtonItem()
        Me.Item_BACKUP = New DevExpress.XtraBars.BarButtonItem()
        Me.Item_dangnhap = New DevExpress.XtraBars.BarButtonItem()
        Me.Item_logout = New DevExpress.XtraBars.BarButtonItem()
        Me.Item_taologin = New DevExpress.XtraBars.BarButtonItem()
        Me.RB_HETHONG = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RB_DANHMUC = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RB_baocao = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RB_nghiepvu = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RB_quantri = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.BTNDANGNHAP = New DevExpress.XtraBars.BarButtonItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TT_MAGV = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TT_HOTEN = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TT_NHOM = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ribbonControl1
        '
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.BarSubItem1, Me.ĐA, Me.ItemDSGV, Me.ItemDSLOP, Me.ItemDSSV, Me.ItemDSMH, Me.ItemDSDiem, Me.Item_IN_DSSV, Me.Item_IN_DIEMMH, Me.Item_IN_PHIEUDIEM, Me.Item_BACKUP, Me.Item_dangnhap, Me.Item_logout, Me.Item_taologin})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 1
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RB_HETHONG, Me.RB_DANHMUC, Me.RB_baocao, Me.RB_nghiepvu, Me.RB_quantri})
        Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.ribbonControl1.Size = New System.Drawing.Size(822, 143)
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "BarSubItem1"
        Me.BarSubItem1.Id = 1
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'ĐA
        '
        Me.ĐA.Caption = "BarButtonItem1"
        Me.ĐA.Id = 2
        Me.ĐA.Name = "ĐA"
        '
        'ItemDSGV
        '
        Me.ItemDSGV.Caption = "Danh Sách Giảng Viên"
        Me.ItemDSGV.Glyph = Global.QLSV_VB.My.Resources.Resources.tasks
        Me.ItemDSGV.Id = 4
        Me.ItemDSGV.LargeGlyph = Global.QLSV_VB.My.Resources.Resources.tasks
        Me.ItemDSGV.Name = "ItemDSGV"
        '
        'ItemDSLOP
        '
        Me.ItemDSLOP.Caption = "Danh Sách Lớp"
        Me.ItemDSLOP.Glyph = Global.QLSV_VB.My.Resources.Resources.clipboard
        Me.ItemDSLOP.Id = 5
        Me.ItemDSLOP.LargeGlyph = Global.QLSV_VB.My.Resources.Resources.presentation
        Me.ItemDSLOP.Name = "ItemDSLOP"
        '
        'ItemDSSV
        '
        Me.ItemDSSV.Caption = "Danh Sách Sinh Viên"
        Me.ItemDSSV.Id = 6
        Me.ItemDSSV.LargeGlyph = Global.QLSV_VB.My.Resources.Resources.student
        Me.ItemDSSV.Name = "ItemDSSV"
        '
        'ItemDSMH
        '
        Me.ItemDSMH.Caption = "Danh Sách Môn Học"
        Me.ItemDSMH.Id = 7
        Me.ItemDSMH.LargeGlyph = Global.QLSV_VB.My.Resources.Resources.translator
        Me.ItemDSMH.Name = "ItemDSMH"
        '
        'ItemDSDiem
        '
        Me.ItemDSDiem.ActAsDropDown = True
        Me.ItemDSDiem.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.ItemDSDiem.Caption = "Danh Sách Điểm Sinh Viên"
        Me.ItemDSDiem.Glyph = Global.QLSV_VB.My.Resources.Resources.test
        Me.ItemDSDiem.Id = 8
        Me.ItemDSDiem.LargeGlyph = Global.QLSV_VB.My.Resources.Resources.test1
        Me.ItemDSDiem.Name = "ItemDSDiem"
        '
        'Item_IN_DSSV
        '
        Me.Item_IN_DSSV.Caption = "IN_DANH SÁCH SINH VIÊN"
        Me.Item_IN_DSSV.Id = 9
        Me.Item_IN_DSSV.LargeGlyph = Global.QLSV_VB.My.Resources.Resources.clipboard__3_
        Me.Item_IN_DSSV.Name = "Item_IN_DSSV"
        '
        'Item_IN_DIEMMH
        '
        Me.Item_IN_DIEMMH.Caption = "IN_ĐIỂM_MÔN HỌC"
        Me.Item_IN_DIEMMH.Id = 10
        Me.Item_IN_DIEMMH.LargeGlyph = Global.QLSV_VB.My.Resources.Resources.list
        Me.Item_IN_DIEMMH.Name = "Item_IN_DIEMMH"
        '
        'Item_IN_PHIEUDIEM
        '
        Me.Item_IN_PHIEUDIEM.Caption = "IN_PHIẾU ĐIỂM"
        Me.Item_IN_PHIEUDIEM.Id = 11
        Me.Item_IN_PHIEUDIEM.LargeGlyph = Global.QLSV_VB.My.Resources.Resources.test1
        Me.Item_IN_PHIEUDIEM.Name = "Item_IN_PHIEUDIEM"
        '
        'Item_BACKUP
        '
        Me.Item_BACKUP.Caption = "BACKUP_RESTORE"
        Me.Item_BACKUP.Id = 12
        Me.Item_BACKUP.LargeGlyph = Global.QLSV_VB.My.Resources.Resources.storing
        Me.Item_BACKUP.Name = "Item_BACKUP"
        '
        'Item_dangnhap
        '
        Me.Item_dangnhap.Caption = "ĐĂNG NHẬP"
        Me.Item_dangnhap.Id = 14
        Me.Item_dangnhap.LargeGlyph = Global.QLSV_VB.My.Resources.Resources.login__2_
        Me.Item_dangnhap.Name = "Item_dangnhap"
        '
        'Item_logout
        '
        Me.Item_logout.Caption = "ĐĂNG XUẤT"
        Me.Item_logout.Id = 15
        Me.Item_logout.LargeGlyph = Global.QLSV_VB.My.Resources.Resources.LOG_off
        Me.Item_logout.Name = "Item_logout"
        '
        'Item_taologin
        '
        Me.Item_taologin.Caption = "TẠO LOGIN"
        Me.Item_taologin.Id = 16
        Me.Item_taologin.LargeGlyph = Global.QLSV_VB.My.Resources.Resources.login1
        Me.Item_taologin.Name = "Item_taologin"
        '
        'RB_HETHONG
        '
        Me.RB_HETHONG.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup4})
        Me.RB_HETHONG.Name = "RB_HETHONG"
        Me.RB_HETHONG.Text = "HỆ THỐNG"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.Item_dangnhap)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.Item_logout)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        '
        'RB_DANHMUC
        '
        Me.RB_DANHMUC.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RB_DANHMUC.Name = "RB_DANHMUC"
        Me.RB_DANHMUC.Text = "DANH MỤC"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.ItemDSGV)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.ItemDSLOP)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.ItemDSMH)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.ItemDSSV)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.ItemDSDiem)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        '
        'RB_baocao
        '
        Me.RB_baocao.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2})
        Me.RB_baocao.Name = "RB_baocao"
        Me.RB_baocao.Text = "Báo Cáo"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.Item_IN_DSSV)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.Item_IN_DIEMMH)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.Item_IN_PHIEUDIEM)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        '
        'RB_nghiepvu
        '
        Me.RB_nghiepvu.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup3})
        Me.RB_nghiepvu.Name = "RB_nghiepvu"
        Me.RB_nghiepvu.Text = "Nghiệp Vụ"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.Item_BACKUP)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        '
        'RB_quantri
        '
        Me.RB_quantri.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup5})
        Me.RB_quantri.Name = "RB_quantri"
        Me.RB_quantri.Text = "Quản Trị"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.ItemLinks.Add(Me.Item_taologin)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.MdiParent = Me
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "Quản Trị"
        '
        'BTNDANGNHAP
        '
        Me.BTNDANGNHAP.Caption = "Đăng Nhập"
        Me.BTNDANGNHAP.Glyph = Global.QLSV_VB.My.Resources.Resources.login__2_
        Me.BTNDANGNHAP.Id = 3
        Me.BTNDANGNHAP.LargeGlyph = Global.QLSV_VB.My.Resources.Resources.login__2_
        Me.BTNDANGNHAP.Name = "BTNDANGNHAP"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TT_MAGV, Me.TT_HOTEN, Me.TT_NHOM})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 488)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(822, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TT_MAGV
        '
        Me.TT_MAGV.Name = "TT_MAGV"
        Me.TT_MAGV.Size = New System.Drawing.Size(44, 17)
        Me.TT_MAGV.Text = "MÃ GV"
        '
        'TT_HOTEN
        '
        Me.TT_HOTEN.Name = "TT_HOTEN"
        Me.TT_HOTEN.Size = New System.Drawing.Size(50, 17)
        Me.TT_HOTEN.Text = "HỌ TÊN"
        '
        'TT_NHOM
        '
        Me.TT_NHOM.Name = "TT_NHOM"
        Me.TT_NHOM.Size = New System.Drawing.Size(45, 17)
        Me.TT_NHOM.Text = "NHÓM"
        '
        'FrmMain
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[False]
        Me.ClientSize = New System.Drawing.Size(822, 510)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ribbonControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "FrmMain"
        Me.Ribbon = Me.ribbonControl1
        Me.Text = "QUẢN LÝ SINH VIÊN"
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private WithEvents ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents ĐA As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents ItemDSGV As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ItemDSLOP As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ItemDSSV As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ItemDSMH As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ItemDSDiem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RB_nghiepvu As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RB_baocao As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RB_quantri As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents Item_IN_DSSV As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents Item_IN_DIEMMH As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Item_IN_PHIEUDIEM As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Item_BACKUP As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RB_HETHONG As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents BTNDANGNHAP As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Item_dangnhap As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Item_logout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RB_DANHMUC As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents TT_MAGV As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TT_HOTEN As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TT_NHOM As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Item_taologin As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
End Class
