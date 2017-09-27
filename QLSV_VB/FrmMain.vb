Imports System.ComponentModel
Imports System.Text


Partial Public Class FrmMain
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
        

    End Sub

   
    Private Function CheckExists(ByVal ftype As Type) As Form
        CheckExists = Me
        Dim f As Form
        For Each f In Me.MdiChildren
            If (f.GetType() = ftype) Then
                CheckExists = f
                Exit Function
            End If
        Next
    End Function

    Private Sub ItemDSGV_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ItemDSGV.ItemClick
        Dim frm As Object
        frm = CheckExists(FrmGIANGVIEN.GetType())
        If (frm.GetType() <> Me.GetType()) Then  ' form đã được mở 
            frm.Activate()              ' nên ta cho active lại
        Else                        ' frmGIANGVIEN chưa mở
            frm = New FrmGIANGVIEN          ' tạo đối/tg frmGIANGVIEN trong bộ nhớ
            frm.MdiParent = Me          ' cho frmMain là form cha
            frm.Show()
        End If
    End Sub

    Private Sub ItemDSLOP_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ItemDSLOP.ItemClick
        Dim frm As Object
        frm = CheckExists(FrmLOP.GetType())
        If (frm.GetType() <> Me.GetType()) Then  ' form đã được mở 
            frm.Activate()              ' nên ta cho active lại
        Else                        ' frmLOP chưa mở
            frm = New FrmLOP         ' tạo đối/tg frmLOP trong bộ nhớ
            frm.MdiParent = Me          ' cho frmMain là form cha
            frm.Show()
        End If
    End Sub

    Private Sub ItemDSMH_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ItemDSMH.ItemClick
        Dim frm As Object
        frm = CheckExists(FrmMONHOC.GetType())
        If (frm.GetType() <> Me.GetType()) Then  ' form đã được mở 
            frm.Activate()              ' nên ta cho active lại
        Else                        ' frmLOP chưa mở
            frm = New FrmMONHOC          ' tạo đối/tg frmLOP trong bộ nhớ
            frm.MdiParent = Me          ' cho frmMain là form cha
            frm.Show()
        End If
    End Sub

    Private Sub ItemDSSV_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ItemDSSV.ItemClick
        Dim frm As Object
        frm = CheckExists(FrmSINHVIEN.GetType())
        If (frm.GetType() <> Me.GetType()) Then  ' form đã được mở 
            frm.Activate()              ' nên ta cho active lại
        Else                        ' frmLOP chưa mở
            frm = New FrmSINHVIEN           ' tạo đối/tg frmLOP trong bộ nhớ
            frm.MdiParent = Me          ' cho frmMain là form cha
            frm.Show()
        End If
    End Sub

    Private Sub ItemDSDiem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ItemDSDiem.ItemClick
        Dim frm As Object
        frm = CheckExists(FrmDIEM.GetType())
        If (frm.GetType() <> Me.GetType()) Then  ' form đã được mở 
            frm.Activate()              ' nên ta cho active lại
        Else                        ' frmLOP chưa mở
            frm = New FrmDIEM          ' tạo đối/tg frmLOP trong bộ nhớ
            frm.MdiParent = Me          ' cho frmMain là form cha
            frm.Show()
        End If
    End Sub

    Private Sub Item_IN_DSSV_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Item_IN_DSSV.ItemClick
        Dim frm As Object
        frm = CheckExists(FrmRp_DS_SINHVIEN.GetType())
        If (frm.GetType() <> Me.GetType()) Then  ' form đã được mở 
            frm.Activate()              ' nên ta cho active lại
        Else                        ' frmLOP chưa mở
            frm = New FrmRp_DS_SINHVIEN           ' tạo đối/tg frmLOP trong bộ nhớ
            frm.MdiParent = Me          ' cho frmMain là form cha
            frm.Show()
        End If
    End Sub

    Private Sub Item_IN_DIEMMH_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Item_IN_DIEMMH.ItemClick
        Dim frm As Object
        frm = CheckExists(FrmRp_DIEM_MONHOC.GetType())
        If (frm.GetType() <> Me.GetType()) Then  ' form đã được mở 
            frm.Activate()              ' nên ta cho active lại
        Else                        ' frmLOP chưa mở
            frm = New FrmRp_DIEM_MONHOC           ' tạo đối/tg frmLOP trong bộ nhớ
            frm.MdiParent = Me          ' cho frmMain là form cha
            frm.Show()
        End If
    End Sub

    Private Sub Item_IN_PHIEUDIEM_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Item_IN_PHIEUDIEM.ItemClick
        Dim frm As Object
        frm = CheckExists(FrmRp_PHIEUDIEM.GetType())
        If (frm.GetType() <> Me.GetType()) Then  ' form đã được mở 
            frm.Activate()              ' nên ta cho active lại
        Else                        ' frmLOP chưa mở
            frm = New FrmRp_PHIEUDIEM
            frm.MdiParent = Me          ' cho frmMain là form cha
            frm.Show()
        End If
    End Sub

    Private Sub Item_BACKUP_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Item_BACKUP.ItemClick
        Dim frm As Object
        frm = CheckExists(FrmBACKUP_RESTORE.GetType())
        If (frm.GetType() <> Me.GetType()) Then  ' form đã được mở 
            frm.Activate()              ' nên ta cho active lại
        Else                        ' frmLOP chưa mở
            frm = New FrmBACKUP_RESTORE
            frm.MdiParent = Me          ' cho frmMain là form cha
            frm.Show()
        End If
    End Sub
    'Đóng tất cả các form con khi nhấn frmDangNhap
    Public Sub closeAllForm()
        For Each frm As Form In MdiChildren
            If frm.GetType() <> GetType(frmDangNhap) Then
                frm.Close()
            End If
        Next
    End Sub

    'Xem form con đã mở chưa nếu chưa thì show()
    Public Sub OpenForm(ByVal typeform As Type)
        For Each frm As Form In MdiChildren
            If frm.GetType() = typeform Then
                frm.Activate()
                Return
            End If
        Next
        Dim f As Form = DirectCast(Activator.CreateInstance(typeform), Form)
        f.MdiParent = Me
        f.Show()
    End Sub

    Public Sub KiemtraLogin()
        If mLogin = "" Then
            Item_dangnhap.Enabled = True
            Item_logout.Enabled = False
            Item_dangnhap.PerformClick()

            RB_quantri.Visible = False
            RB_nghiepvu.Visible = False
            RB_baocao.Visible = False
            RB_DANHMUC.Visible = False
        End If
        'Else
        '    Item_dangnhap.Enabled = False
        '    Item_logout.Enabled = True
        '    If mGroup = "ADMIN" Then
        '        RB_quantri.Visible = True
        '        RB_nghiepvu.Visible = True
        '        RB_baocao.Visible = True
        '        RB_DANHMUC.Visible = True
        '    Else
        '        RB_baocao.Visible = True
        '        RB_DANHMUC.Visible = True
        'ItemDSGV.Enabled = False
        'ItemDSLOP.Enabled = False
        'ItemDSMH.Enabled = False
        'ItemDSSV.Enabled = False
        ' End If
        'End If
    End Sub



    Private Sub Item_logout_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Item_logout.ItemClick
        mlogin = ""
        mpass = ""
        mUser = ""
        mHoTen = ""
        mGroup = ""
        TT_MAGV.Text = ""
        TT_HOTEN.Text = ""
        TT_NHOM.Text = ""
        KiemtraLogin()
        closeAllForm()
        If (conn.State = ConnectionState.Open) Then
            conn.Close()
        End If
    End Sub

    Private Sub Item_dangnhap_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Item_dangnhap.ItemClick
        OpenForm(GetType(FrmDANGNHAP))
        closeAllForm()
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RB_quantri.Visible = False
        RB_nghiepvu.Visible = False
        RB_baocao.Visible = False
        RB_DANHMUC.Visible = False
        'KiemtraLogin()
    End Sub

    Private Sub ribbonControl1_Click(sender As Object, e As EventArgs) Handles ribbonControl1.Click

    End Sub

    Private Sub Item_taologin_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Item_taologin.ItemClick
        Dim frm As Object
        frm = CheckExists(FrmTAO_TAIKHOAN.GetType())
        If (frm.GetType() <> Me.GetType()) Then  ' form đã được mở 
            frm.Activate()              ' nên ta cho active lại
        Else                        ' frmLOP chưa mở
            frm = New FrmTAO_TAIKHOAN
            frm.MdiParent = Me          ' cho frmMain là form cha
            frm.Show()
        End If
    End Sub
End Class
