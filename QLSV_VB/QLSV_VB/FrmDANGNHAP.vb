Public Class FrmDANGNHAP


    Private Sub btndangnhap_Click(sender As Object, e As EventArgs) Handles btndangnhap.Click
        mlogin = txttaikhoan.Text.Trim()
        mpass = txtpass.Text.Trim()

        If Mdl_ketnoi.KetNoi("QLSV_VB") = 0 Then
            Exit Sub
        End If

        Dim myReader As Odbc.OdbcDataReader

        Dim strLenh As String
        strLenh = "exec SP_DANGNHAP '" & mlogin.Trim & "'"
        myReader = Mdl_ketnoi.ExecSELECTSQL(strlenh)
        myReader.Read()
        mUser = myReader.GetString(0).Trim
        If IsDBNull(mUser) Then


            MsgBox("Login bạn nhập không có quyền truy cập." & vbCrLf _
            & "bạn xem lại username của cơ sở dữ liệu", MsgBoxStyle.OkOnly, "thông báo")
            Exit Sub
        End If
        mHoTen = myReader.GetString(1).Trim
        mGroup = myReader.GetString(2).Trim
        myReader.Close()
     
        FrmMain.TT_MAGV.Text = "MÃ GV: " & mUser
        FrmMain.TT_HOTEN.Text = "HỌ TÊN: " & mHoTen
        FrmMain.TT_NHOM.Text = "NHÓM: " & mGroup

        'FrmMain.KiemtraLogin()
        If mGroup = "ADMIN" Then
            FrmMain.RB_HETHONG.Visible = True
            FrmMain.RB_quantri.Visible = True
            FrmMain.RB_nghiepvu.Visible = True
            FrmMain.RB_baocao.Visible = True
            FrmMain.RB_DANHMUC.Visible = True
        End If
        If mGroup = "GIANGVIEN" Then
            FrmMain.RB_HETHONG.Visible = True
            FrmMain.Item_dangnhap.Enabled = False
            FrmMain.Item_logout.Enabled = True
            FrmMain.RB_DANHMUC.Visible = True
            FrmMain.ItemDSDiem.Enabled = True
            FrmMain.ItemDSGV.Enabled = False
            FrmMain.ItemDSLOP.Enabled = False
            FrmMain.ItemDSMH.Enabled = False
            FrmMain.ItemDSSV.Enabled = False
            'FrmMain.RB_nghiepvu.Visible = False
            FrmMain.RB_baocao.Visible = True
            'FrmMain.RB_quantri.Visible = False
        End If
        If mGroup = "SINHVIEN" Then
            FrmMain.RB_HETHONG.Visible = True
            FrmMain.Item_dangnhap.Enabled = False
            FrmMain.Item_logout.Enabled = True
            FrmMain.RB_baocao.Visible = True
        End If
        Me.Close()
    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click

        'FrmMain.ItemDSGV.Enabled = False
        'FrmMain.ItemDSLOP.Enabled = False
        'FrmMain.ItemDSMH.Enabled = False
        'FrmMain.ItemDSSV.Enabled = False
        'FrmMain.ItemDSDiem.Enabled = False
        'FrmMain.RB_nghiepvu.Visible = False
        'FrmMain.RB_baocao.Visible = False
        'FrmMain.RB_quantri.Visible = False
        Close()
    End Sub
End Class