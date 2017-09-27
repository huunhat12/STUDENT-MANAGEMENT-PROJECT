Public Class FrmDIEM 

    Private Sub LOPBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.LOPBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS)

    End Sub

    Private Sub FrmDIEM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS.SP_LOADDIEM' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DS.SP_DIEM' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DS.MONHOC' table. You can move, or remove it, as needed.
        Me.LOPTableAdapter.Connection.ConnectionString = Mdl_ketnoi.Connstr
        Me.LOPTableAdapter.Fill(Me.DS.LOP)
        Me.SINHVIENTableAdapter.Connection.ConnectionString = Mdl_ketnoi.Connstr
        Me.SINHVIENTableAdapter.Fill(Me.DS.SINHVIEN)
        Me.MONHOCTableAdapter.Connection.ConnectionString = Mdl_ketnoi.Connstr
        Me.MONHOCTableAdapter.Fill(Me.DS.MONHOC)
        'TODO: This line of code loads data into the 'DS.DIEM' table. You can move, or remove it, as needed.
        Me.DIEMTableAdapter.Connection.ConnectionString = Mdl_ketnoi.Connstr
        Me.DIEMTableAdapter.Fill(Me.DS.DIEM)
        'TODO: This line of code loads data into the 'DS.SINHVIEN' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'DS.LOP' table. You can move, or remove it, as needed.
        GRV_LOAD_DIEMSV.Visible = False
        drlTenlop.SelectedIndex = -1
        drlTenmh.SelectedIndex = -1
        drlLan.SelectedIndex = -1
        txtmalop.ReadOnly = True
        txtmamh.ReadOnly = True
    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)

    End Sub


    
    Private Sub btnnhap_Click(sender As Object, e As EventArgs) Handles btnnhap.Click
        Me.LOAD_DIEMSVTableAdapter.Connection.ConnectionString = Mdl_ketnoi.Connstr
        Me.LOAD_DIEMSVTableAdapter.Fill(Me.DS.LOAD_DIEMSV, Convert.ToString(drlTenlop.SelectedValue).Trim, Convert.ToString(drlTenmh.SelectedValue).Trim, Convert.ToInt16(drlLan.SelectedItem))
        GRV_LOAD_DIEMSV.Visible = True
    End Sub


    Private Sub btnghi_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnghi.ItemClick
        If conn.State = ConnectionState.Closed Then
            Mdl_ketnoi.KetNoi("QLSV_VB")
        End If
        Try
            Dim i As Int32
            Dim count As Integer
            count = LOAD_DIEMSVBindingSource.Count()
            If (MsgBox("Bạn muốn lưu bảng điểm này ?", MsgBoxStyle.YesNo, "Thông báo") = MsgBoxResult.Yes) Then
                For i = 0 To count - 1 Step 1
                    Dim cmd_DIEM As New Odbc.OdbcCommand
                    cmd_DIEM.Connection = conn
                    cmd_DIEM.CommandText = "{?= call EDIT_UPDATE_DIEM(?,?,?,?,?)}"
                    cmd_DIEM.CommandType = CommandType.StoredProcedure
                    Dim myParm As Odbc.OdbcParameter
                    '= cmd_DIEM.Parameters.Add("@RETURN_VALUE", Odbc.OdbcType.Int)
                    'myParm.Direction = ParameterDirection.ReturnValue

                    myParm = cmd_DIEM.Parameters.Add("@MALOP", Odbc.OdbcType.NChar, 10)
                    myParm.Direction = ParameterDirection.Input 'hu?ng nh?p vào
                    myParm.Value = txtmalop.Text.Trim ' giá tr? nh?p vào

                    myParm = cmd_DIEM.Parameters.AddWithValue("@MASV", Convert.ToString(GridView2.GetRowCellValue(i, colMASV)))


                    myParm = cmd_DIEM.Parameters.Add("@MAMH", Odbc.OdbcType.NChar, 10)
                    myParm.Direction = ParameterDirection.Input 'hu?ng nh?p vào
                    myParm.Value = txtmamh.Text.Trim ' giá tr? nh?p vào

                    myParm = cmd_DIEM.Parameters.Add("@LAN", Odbc.OdbcType.SmallInt)
                    myParm.Direction = ParameterDirection.Input 'hu?ng nh?p vào
                    myParm.Value = drlLan.SelectedItem ' giá tr? nh?p vào

                    myParm = cmd_DIEM.Parameters.AddWithValue("@DIEM", Convert.ToDouble(GridView2.GetRowCellValue(i, colDIEM)))
                    'myParm.Direction = ParameterDirection.Input 'hu?ng nh?p vào
                    'myParm.Value = txtDiem.Text.Trim ' giá tr? nh?p vào



                    cmd_DIEM.ExecuteNonQuery()
                    LOAD_DIEMSVBindingSource.EndEdit()
                    LOAD_DIEMSVBindingSource.ResetCurrentItem()
                Next
            End If
            MsgBox("Luu thành công!")
        Catch ex As Odbc.OdbcException
            MsgBox("Luu không thành công!")
        End Try
    End Sub


End Class