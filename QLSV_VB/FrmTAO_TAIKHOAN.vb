Public Class FrmTAO_TAIKHOAN 


    Private Sub FrmTAO_TAIKHOAN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SELECT_HOTEN_GVTableAdapter.Connection.ConnectionString = Mdl_ketnoi.Connstr
        Me.SELECT_HOTEN_GVTableAdapter.Fill(Me.DS.SELECT_HOTEN_GV)
        'TODO: This line of code loads data into the 'DS.GIANGVIEN' table. You can move, or remove it, as neede
        drlHoten.SelectedIndex = 0
    End Sub



    Private Sub btntaologin_Click(sender As Object, e As EventArgs) Handles btntaologin.Click
        If (txtLoginname.Text = "") Then
            MessageBox.Show("Bạn chưa chọn tên user", "THÔNG BÁO", MessageBoxButtons.OK)
            txtLoginname.Focus()
        End If
        If (txtpass.Text = "") Then
            MessageBox.Show("Bạn chưa chọn pass", "THÔNG BÁO", MessageBoxButtons.OK)
            txtpass.Focus()
        End If

        If conn.State = ConnectionState.Closed Then
            Mdl_ketnoi.KetNoi("QLSV_VB")
        End If
        Dim cmd_TAOLOGIN As New Odbc.OdbcCommand
        cmd_TAOLOGIN.Connection = conn
        cmd_TAOLOGIN.CommandText = "{?= call TAO_LOGIN(?,?,?,?)}"
        cmd_TAOLOGIN.CommandType = CommandType.StoredProcedure
        Dim myParm As Odbc.OdbcParameter = cmd_TAOLOGIN.Parameters.Add("@RET", Odbc.OdbcType.Int)
        myParm.Direction = ParameterDirection.ReturnValue

        myParm = cmd_TAOLOGIN.Parameters.Add("LGNAME", Odbc.OdbcType.VarChar, 50)
        myParm.Direction = ParameterDirection.Input
        myParm.Value = txtLoginname.Text.Trim

        myParm = cmd_TAOLOGIN.Parameters.Add("PASS", Odbc.OdbcType.VarChar, 50)
        myParm.Direction = ParameterDirection.Input
        myParm.Value = txtpass.Text

        myParm = cmd_TAOLOGIN.Parameters.Add("USRNAME", Odbc.OdbcType.VarChar, 50)
        myParm.Direction = ParameterDirection.Input
        myParm.Value = txtmagv.Text.Trim

        myParm = cmd_TAOLOGIN.Parameters.Add("ROLE", Odbc.OdbcType.VarChar, 50)
        myParm.Direction = ParameterDirection.Input
        If drlNhomquyen.SelectedIndex = 0 Then
            myParm.Value = "ADMIN"
        Else
            myParm.Value = "GIANGVIEN"
        End If
        If conn.State = ConnectionState.Closed Then
            Mdl_ketnoi.KetNoi("QLSV_VB")
        End If

        Try
            cmd_TAOLOGIN.ExecuteScalar()
            MsgBox("TẠO TÀI KHOẢN THÀNH CÔNG !", MsgBoxStyle.OkOnly)
        Catch ex As Odbc.OdbcException
            If (cmd_TAOLOGIN.Parameters("@RET").Value = 1) Then
                MsgBox("Username bạn nhập đã có trong Server. Bạn nhập lại username khác.", MsgBoxStyle.OkOnly)
            Else
                MsgBox("Nhân viên bạn chọn đã có username rồi. Bạn chọn nhân viên khác hoặc phải xóa username của nhân viên hiện tại.", MsgBoxStyle.OkOnly)

            End If
        End Try

    End Sub

    Private Sub txtmagv_TextChanged(sender As Object, e As EventArgs) Handles txtmagv.TextChanged
        If Mdl_ketnoi.KetNoi("QLSV_VB") = 0 Then
            Exit Sub
        End If

        Dim myReader As Odbc.OdbcDataReader

        Dim strLenh As String
        strLenh = "exec KT_LOGIN_USERNAME '" & txtmagv.Text & "'"
        myReader = Mdl_ketnoi.ExecSELECTSQL(strLenh)
        If (myReader.Read()) Then
            txtLoginname.Text = myReader.GetString(0).Trim
            txtpass.Enabled = False
            btntaologin.Enabled = False
            btnxoa.Enabled = True
            myReader.Close()

            Dim myReader1 As Odbc.OdbcDataReader
            Dim strLenh1 As String = "exec SP_LAY_ROLENAME '" & txtmagv.Text & "'"
            myReader1 = Mdl_ketnoi.ExecSELECTSQL(strLenh1)
            myReader1.Read()
            drlNhomquyen.SelectedItem = myReader1.GetString(0).Trim
            myReader1.Close()
        Else
            txtLoginname.Text = ""
            txtpass.Text = ""
            drlNhomquyen.SelectedIndex = -1
            txtpass.Enabled = True
            btnxoa.Enabled = False
            btntaologin.Enabled = True
        End If
        myReader.Close()

    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim StrLenh As String
        StrLenh = " exec SP_XOALOGIN '" & txtLoginname.Text & "','" & txtmagv.Text & "'"
        If MsgBox("Bạn chắc chắn xóa tài khoản này", MsgBoxStyle.YesNo) = MsgBoxResult.Ok Then
            Try
                Mdl_ketnoi.ExecNONQUERY(StrLenh)
                MsgBox("XÓA TÀI KHOẢN THÀNH CÔNG", MsgBoxStyle.OkOnly)
                FrmTAO_TAIKHOAN_Load(sender, e)
            Catch ex As Exception
                MsgBox("LỖI !", MsgBoxStyle.OkOnly)
            End Try
        End If

    End Sub
End Class