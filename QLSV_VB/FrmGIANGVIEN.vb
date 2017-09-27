Public Class FrmGIANGVIEN

    Private Sub GIANGVIENBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.GIANGVIENBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS)

    End Sub

    Private Sub FrmGIANGVIEN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS.GIANGVIEN' table. You can move, or remove it, as needed.
        Me.GIANGVIENTableAdapter.Connection.ConnectionString = Mdl_ketnoi.Connstr
        Me.GIANGVIENTableAdapter.Fill(Me.DS.GIANGVIEN)
        txtMagv.ReadOnly = True
        txtHo.ReadOnly = True
        txtTen.ReadOnly = True
        PHAICheckEdit.ReadOnly = True
    End Sub

    Private Sub GIANGVIENGridControl_Click(sender As Object, e As EventArgs) Handles GIANGVIENGridControl.Click

    End Sub

    Private Sub PHAICheckEdit_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btbThem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThem.ItemClick
        GIANGVIENBindingSource.AddNew()
        btnXoa.Enabled = False
        btnsua.Enabled = False
        btnXuatexcel.Enabled = False
        txtMagv.ReadOnly = False
        txtHo.ReadOnly = False
        txtTen.ReadOnly = False
        PHAICheckEdit.ReadOnly = False
        txtMagv.Focus()
    End Sub

    Private Sub btnGhi_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGhi.ItemClick


        If conn.State = ConnectionState.Closed Then
            Mdl_ketnoi.KetNoi("QLSV_VB")
        End If
        Dim odbccmd1 As New Odbc.OdbcCommand
        odbccmd1.Connection = conn
        odbccmd1.CommandText = "{?=call KT_MAGV(?)}"
        odbccmd1.CommandType = CommandType.StoredProcedure
        Dim MYPARM As Odbc.OdbcParameter = odbccmd1.Parameters.Add("@Ret", Odbc.OdbcType.Int)
        MYPARM.Direction = ParameterDirection.ReturnValue
        MYPARM = odbccmd1.Parameters.Add("MAGV", Odbc.OdbcType.NChar, 10)
        MYPARM.Direction = ParameterDirection.Input
        MYPARM.Value = txtMagv.Text.Trim

        Try
            odbccmd1.ExecuteNonQuery()
            If (odbccmd1.Parameters("@Ret").Value = 1) Then
                MsgBox("Mã Giảng Viên bị trùng! Bạn hãy nhập lại." & vbCrLf &
                       "Hãy nhập lại ", MsgBoxStyle.OkOnly)
                Exit Sub
            End If
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message, "Lỗi")
            Return
        End Try


        'If Mdl_ketnoi.KetNoi("QLSV_VB") = 0 Then
        '    Exit Sub
        'End If
        'Dim myReader As Odbc.OdbcDataReader
        'Dim strlenh As String
        'strlenh = "exec KT_MAGV  '" & MAGV & "'"
        'myReader = Mdl_ketnoi.ExecSELECTSQL(strlenh)
        'Try
        '    'TENMH,MAMH,LAN,NGAYTHI, SOCAUTHI, THOIGIAN,TRINHDO, HOTENGV,TENLOP,MALOP
        '    myReader.Read()  'chỉ có 1 dòng 1 user chỉ có 1
        '    tenmonhoc = myReader.GetString(0).Trim



        'Dim ds As New DataSet
        'ds = ExecSELECTSQL("select * from GIAOVIEN where MAGV='" & Trim(txtMagv.Text) & "'")
        'If ds.Tables(0).Rows.Count > 0 Then
        '    XtraMessageBox.Show("Mã giáo viên này đã bị trùng !", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        'End If


        If txtMagv.Text.Trim = "" Then
            MsgBox("Mã Giảng Viên Không Được Để Trống", MsgBoxStyle.OkOnly)
            txtMagv.Focus()
            Exit Sub
        End If

        If txtHo.Text.Trim = "" Then
            MsgBox("Họ không được để rỗng", MsgBoxStyle.OkOnly)
            txtHo.Focus()
            Exit Sub
        End If
        If txtTen.Text.Trim = "" Then
            MsgBox("Tên không được để trống", MsgBoxStyle.OkOnly)
            txtTen.Focus()
            Exit Sub
        End If
        ' Try
        GIANGVIENBindingSource.EndEdit()
        GIANGVIENBindingSource.ResetCurrentItem()
        Me.GIANGVIENTableAdapter.Update(Me.DS.GIANGVIEN)
        'Catch ex As Exception
        '    MsgBox("Mã Giảng Viên không được trùng")
        'End Try
        btnsua.Enabled = True
        btnXoa.Enabled = True
        btnThem.Enabled = True
    End Sub

    Private Sub btnThoat_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThoat.ItemClick
        Close()
    End Sub

    Private Sub btnXoa_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnXoa.ItemClick
        If MsgBox("Bạn chắc chắn xóa Giảng Viên này .!", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                GIANGVIENBindingSource.RemoveCurrent()
                Me.GIANGVIENTableAdapter.Update(Me.DS.GIANGVIEN)
                MessageBox.Show("Xóa Thành Công.!")
            Catch ex As Exception
                MessageBox.Show("Xóa Không Thành Công.!" & vbCrLf & ex.Message)

            End Try
        End If
    End Sub

    Private Sub btnsua_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnsua.ItemClick
        btnThem.Enabled = False
        btnXoa.Enabled = False
        txtMagv.ReadOnly = False
        txtHo.ReadOnly = False
        txtTen.ReadOnly = False
        PHAICheckEdit.ReadOnly = False
        txtMagv.Focus()
    End Sub

    Private Sub btnReload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReload.ItemClick
        GIANGVIENBindingSource.CancelEdit()
        btnThem.Enabled = True
        btnXoa.Enabled = True
        btnGhi.Enabled = True
        btnsua.Enabled = True
        btnReload.Enabled = True
        btnXuatexcel.Enabled = True
    End Sub

End Class