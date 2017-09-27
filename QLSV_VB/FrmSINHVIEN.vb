Public Class FrmSINHVIEN 

    Private Sub LOPBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.LOPBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS)

    End Sub

    Private Sub FrmSINHVIEN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS.DIEM' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DS.SINHVIEN' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DS.LOP' table. You can move, or remove it, as needed.
        Me.LOPTableAdapter.Connection.ConnectionString = Mdl_ketnoi.Connstr
        Me.LOPTableAdapter.Fill(Me.DS.LOP)
        Me.SINHVIENTableAdapter.Connection.ConnectionString = Mdl_ketnoi.Connstr
        Me.SINHVIENTableAdapter.Fill(Me.DS.SINHVIEN)
        Me.DIEMTableAdapter.Connection.ConnectionString = Mdl_ketnoi.Connstr
        Me.DIEMTableAdapter.Fill(Me.DS.DIEM)
        btnghi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        btnGhi_tk.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        txtmasv.ReadOnly = True
        txtho.ReadOnly = True
        txttenlop.ReadOnly = True
        txtten.ReadOnly = True
        PHAICheckEdit.ReadOnly = True
        dtngaysinh.ReadOnly = True
        txtdiachi.ReadOnly = True
        txtghichu.ReadOnly = True
        NGHIHOCCheckEdit.ReadOnly = True
        txthinh.ReadOnly = True
        btnhinh.Height = 22
        txtmasv.Focus()
        PictureBox1.Image = Image.FromFile("D:\HUUNHAT\VB.Net\VB_HOCLAI\QLSV_VB\QLSV_VB\Images_SV\daidien.jpg")
    End Sub


    Private Sub btnreload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnreload.ItemClick
        FrmSINHVIEN_Load(sender, e)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub txtmasv_TextChanged(sender As Object, e As EventArgs) Handles txtmasv.TextChanged
        If txtmasv.Text.Trim = "" Then Exit Sub
        On Error GoTo Loi
        PictureBox1.Image = Image.FromFile(txthinh.Text)
        Exit Sub
Loi:
        PictureBox1.Image = Image.FromFile("D:\HUUNHAT\VB.Net\VB_HOCLAI\QLSV_VB\QLSV_VB\Images_SV\daidien.jpg")

    End Sub


    Private Sub btnhinh_Click(sender As Object, e As EventArgs) Handles btnhinh.Click
        Dim path As String
        Dim ofd As OpenFileDialog = New OpenFileDialog()
        ofd.InitialDirectory = Mdl_ketnoi.strDefaultPath

        ofd.Title = "Chọn file hình để mở"
        ofd.Filter = "JPG, BMP|*.jpg;*.bmp"
        If (ofd.ShowDialog() = DialogResult.OK) Then
            path = ofd.FileName
            txthinh.Text = path
        End If
        On Error GoTo Loi
        PictureBox1.Image = Image.FromFile(txthinh.Text)
        Exit Sub
Loi:
        PictureBox1.Image = Image.FromFile("D:\HUUNHAT\VB.Net\VB_HOCLAI\QLSV_VB\QLSV_VB\Images_SV\daidien.jpg")

    End Sub

    Private Sub btnthem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnthem.ItemClick
        SINHVIENBindingSource.AddNew()
        btnGhi_tk.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        txtmasv.ReadOnly = False
        txtho.ReadOnly = False
        txttenlop.ReadOnly = False
        txtten.ReadOnly = False
        PHAICheckEdit.ReadOnly = False
        dtngaysinh.ReadOnly = False
        txtdiachi.ReadOnly = False
        txtghichu.ReadOnly = False
        NGHIHOCCheckEdit.ReadOnly = False
        btnxoa.Enabled = False
        btnsua.Enabled = False
        txtmasv.Focus()
    End Sub

    Private Sub btnghi_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnghi.ItemClick
        If txtmasv.Text.Trim = "" Then
            MsgBox("Mã Lớp Không Được Để Trống", MsgBoxStyle.OkOnly)
            txtmasv.Focus()
            Exit Sub
        End If

        If txttenlop.Text.Trim = "" Then
            MsgBox("Tên không được để trống", MsgBoxStyle.OkOnly)
            txttenlop.Focus()
            Exit Sub
        End If
        If txtho.Text.Trim = "" Then
            MsgBox("Họ không được để trống", MsgBoxStyle.OkOnly)
            txtho.Focus()
            Exit Sub
        End If
        If txtten.Text.Trim = "" Then
            MsgBox("Tên không được để trống", MsgBoxStyle.OkOnly)
            txtten.Focus()
            Exit Sub
        End If
        If dtngaysinh.Text.Trim = "" Then
            MsgBox("Ngày sinh không được để trống", MsgBoxStyle.OkOnly)
            dtngaysinh.Focus()
            Exit Sub
        End If
        If txtdiachi.Text.Trim = "" Then
            MsgBox("Địa chỉ không được để trống", MsgBoxStyle.OkOnly)
            txtdiachi.Focus()
            Exit Sub
        End If
        If txtnoisinh.Text.Trim = "" Then
            MsgBox("Nơi Sinh không được để trống", MsgBoxStyle.OkOnly)
            txtnoisinh.Focus()
            Exit Sub
        End If
        If txthinh.Text.Trim = "" Then
            MsgBox("Hình bắt buộc phải có", MsgBoxStyle.OkOnly)
            txthinh.Focus()
            Exit Sub
        End If
        Try
            SINHVIENBindingSource.EndEdit()
            SINHVIENBindingSource.ResetCurrentItem()
            Me.SINHVIENTableAdapter.Update(Me.DS.SINHVIEN)
            MsgBox("Thêm thành công", MsgBoxStyle.OkOnly)
        Catch ex As Exception
            MsgBox("Mã sinh viên không được trùng")
        End Try
        btnsua.Enabled = True
        btnxoa.Enabled = True
        btnthem.Enabled = True
    End Sub

    Private Sub btnxoa_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnxoa.ItemClick
        If NGHIHOCCheckEdit.Checked = False Then
            MsgBox("Sinh Viên chưa nghỉ học.Bạn không thể xóa.!", MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        If DIEMBindingSource.Count > 0 Then
            MsgBox("Sinh Vien đã có điểm sinh viên.Bạn không thể xóa.!", MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        If MsgBox("Bạn chắc chắn xóa Sinh Vien này.!", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                Dim StrLenh As String
                StrLenh = " exec SP_XOALOGIN '" & txtmasv.Text & "','" & txtmasv.Text & "'"
                Mdl_ketnoi.ExecNONQUERY(StrLenh)
                SINHVIENBindingSource.RemoveCurrent()
                Me.SINHVIENTableAdapter.Update(Me.DS.SINHVIEN)


                MessageBox.Show("Xóa thành công")
            Catch ex As Exception
                MessageBox.Show("Xóa không thành công !")


            End Try
        End If
    End Sub

    Private Sub btnthoat_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnthoat.ItemClick
        Close()
    End Sub

    Private Sub btnGhi_tk_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGhi_tk.ItemClick
        If txtmasv.Text.Trim = "" Then
            MsgBox("Mã Lớp Không Được Để Trống", MsgBoxStyle.OkOnly)
            txtmasv.Focus()
            Exit Sub
        End If

        If txttenlop.Text.Trim = "" Then
            MsgBox("Tên không được để trống", MsgBoxStyle.OkOnly)
            txttenlop.Focus()
            Exit Sub
        End If
        If txtho.Text.Trim = "" Then
            MsgBox("Họ không được để trống", MsgBoxStyle.OkOnly)
            txtho.Focus()
            Exit Sub
        End If
        If txtten.Text.Trim = "" Then
            MsgBox("Tên không được để trống", MsgBoxStyle.OkOnly)
            txtten.Focus()
            Exit Sub
        End If
        If dtngaysinh.Text.Trim = "" Then
            MsgBox("Ngày sinh không được để trống", MsgBoxStyle.OkOnly)
            dtngaysinh.Focus()
            Exit Sub
        End If
        If txtdiachi.Text.Trim = "" Then
            MsgBox("Địa chỉ không được để trống", MsgBoxStyle.OkOnly)
            txtdiachi.Focus()
            Exit Sub
        End If
        If txtnoisinh.Text.Trim = "" Then
            MsgBox("Nơi Sinh không được để trống", MsgBoxStyle.OkOnly)
            txtnoisinh.Focus()
            Exit Sub
        End If
        If txthinh.Text.Trim = "" Then
            MsgBox("Hình bắt buộc phải có", MsgBoxStyle.OkOnly)
            txthinh.Focus()
            Exit Sub
        End If

            If conn.State = ConnectionState.Closed Then
                Mdl_ketnoi.KetNoi("QLSV_VB")
            End If
            Dim cmd_TAOLOGIN As New Odbc.OdbcCommand
            cmd_TAOLOGIN.Connection = conn
            cmd_TAOLOGIN.CommandText = "{?= call TAO_LOGIN_SV(?,?,?,?)}"
            cmd_TAOLOGIN.CommandType = CommandType.StoredProcedure
            Dim myParm As Odbc.OdbcParameter = cmd_TAOLOGIN.Parameters.Add("@RET", Odbc.OdbcType.Int)
            myParm.Direction = ParameterDirection.ReturnValue

            myParm = cmd_TAOLOGIN.Parameters.Add("LGNAME", Odbc.OdbcType.VarChar, 50)
            myParm.Direction = ParameterDirection.Input
            myParm.Value = txtmasv.Text.Trim

            myParm = cmd_TAOLOGIN.Parameters.Add("PASS", Odbc.OdbcType.VarChar, 50)
            myParm.Direction = ParameterDirection.Input
            myParm.Value = "12345"

            myParm = cmd_TAOLOGIN.Parameters.Add("USRNAME", Odbc.OdbcType.VarChar, 50)
            myParm.Direction = ParameterDirection.Input
            myParm.Value = txtmasv.Text.Trim

            myParm = cmd_TAOLOGIN.Parameters.Add("ROLE", Odbc.OdbcType.VarChar, 50)
            myParm.Direction = ParameterDirection.Input
            myParm.Value = "SINHVIEN"

        Try
            SINHVIENBindingSource.EndEdit()
            SINHVIENBindingSource.ResetCurrentItem()
            Me.SINHVIENTableAdapter.Update(Me.DS.SINHVIEN)
            MsgBox("Thêm thành công", MsgBoxStyle.OkOnly)
            cmd_TAOLOGIN.ExecuteScalar()

            'MsgBox("TẠO TÀI KHOẢN THÀNH CÔNG !", MsgBoxStyle.OkOnly)
        Catch ex As Odbc.OdbcException
            MsgBox("Mã sinh viên không được trùng")
            If (cmd_TAOLOGIN.Parameters("@RET").Value = 1) Then
                MsgBox("Username bạn nhập đã có trong Server. Bạn nhập lại username khác.", MsgBoxStyle.OkOnly)
            Else
                MsgBox("Nhân viên bạn chọn đã có username rồi. Bạn chọn nhân viên khác hoặc phải xóa username của nhân viên hiện tại.", MsgBoxStyle.OkOnly)

            End If
        End Try 
        btnsua.Enabled = True
        btnxoa.Enabled = True

        btnthem.Enabled = True
    End Sub

    Private Sub btnsua_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnsua.ItemClick
        btnghi.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        btnGhi_tk.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        txtmasv.ReadOnly = False
        txtho.ReadOnly = False
        txttenlop.ReadOnly = False
        txtten.ReadOnly = False
        PHAICheckEdit.ReadOnly = False
        dtngaysinh.ReadOnly = False
        txtdiachi.ReadOnly = False
        txtghichu.ReadOnly = False
        txthinh.ReadOnly = False
        NGHIHOCCheckEdit.ReadOnly = True
    End Sub

End Class