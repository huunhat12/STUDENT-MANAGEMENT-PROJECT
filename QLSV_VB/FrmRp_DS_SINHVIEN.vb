Public Class FrmRp_DS_SINHVIEN 

    Private Sub LOPBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.LOPBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS)

    End Sub

    Private Sub FrmRp_DS_SINHVIEN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS.LOP' table. You can move, or remove it, as needed.
        Me.LOPTableAdapter.Connection.ConnectionString = Mdl_ketnoi.Connstr
        Me.LOPTableAdapter.Fill(Me.DS.LOP)
        txtMalop.Visible = False
    End Sub



    Private Sub btnin_Click(sender As Object, e As EventArgs) Handles btnin.Click
        'Dim objLT As RPT2
        'objLT = New RPT2
        
        'Dim cmd_DIEM As New Odbc.OdbcCommand
        'cmd_DIEM.Connection = conn
        'cmd_DIEM.CommandText = "{?= call IN_DSSV(?)}"
        'cmd_DIEM.CommandType = CommandType.StoredProcedure
        'Dim myParm As Odbc.OdbcParameter = cmd_DIEM.Parameters.Add("@RETURN_VALUE", Odbc.OdbcType.NChar)
        'myParm.Direction = ParameterDirection.ReturnValue
        'myParm = cmd_DIEM.Parameters.Add("@MALOP", Odbc.OdbcType.NChar, 10)
        'myParm.Direction = ParameterDirection.Input 'hu?ng nh?p vào
        'myParm.Value = txtMalop.Text.Trim ' giá tr? nh?p vào
        Dim objLT As crp_IN_DSSV
        objLT = New crp_IN_DSSV

       
        Dim strLenh As String

        strLenh = "EXEC IN_DSSV '" & txtMalop.Text.Trim & "'"
        Dim MyReadder As Data.Odbc.OdbcDataReader
        Try
            MyReadder = ExecSELECTSQL(strLenh)
            Dim MyTable As New DataTable
            MyTable.Load(MyReadder)
            objLT.SetDataSource(MyTable)
            objLT.SetParameterValue("TENLOP", drptenlop.Text)
            objLT.SetParameterValue("NGAYIN", dtNgayin.Text)
            objLT.SetParameterValue("LAN", dropLan.Text)
            CRV.ReportSource = objLT
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

       
    End Sub

    
    Private Sub txtMalop_TextChanged(sender As Object, e As EventArgs) Handles txtMalop.TextChanged

    End Sub
End Class