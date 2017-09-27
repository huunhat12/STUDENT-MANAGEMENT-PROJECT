Public Class FrmRp_DIEM_MONHOC 

    Private Sub LOPBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.LOPBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS)

    End Sub

    Private Sub FrmRp_DIEM_MONHOC_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'DS.MONHOC' table. You can move, or remove it, as needed.
        Me.LOPTableAdapter.Connection.ConnectionString = Mdl_ketnoi.Connstr
        Me.LOPTableAdapter.Fill(Me.DS.LOP)
        Me.MONHOCTableAdapter.Connection.ConnectionString = Mdl_ketnoi.Connstr
        Me.MONHOCTableAdapter.Fill(Me.DS.MONHOC)
        'TODO: This line of code loads data into the 'DS.DIEM' table. You can move, or remove it, as needed.
        Me.DIEMTableAdapter.Connection.ConnectionString = Mdl_ketnoi.Connstr
        Me.DIEMTableAdapter.Fill(Me.DS.DIEM)
        'TODO: This line of code loads data into the 'DS.LOP' table. You can move, or remove it, as needed.
        'txtmalop.Visible = False
        'txtmamh.Visible = False


    End Sub

    Private Sub btnin_Click(sender As Object, e As EventArgs) Handles btnin.Click
        Dim objLT As crp_IN_DIEMMH
        objLT = New crp_IN_DIEMMH


        Dim strLenh As String

        strLenh = "EXEC IN_DIEM_MONHOC '" & txtmalop.Text.Trim & "'" & "," & "'" & txtmamh.Text.Trim & "'" & "," & "'" & Convert.ToInt16(droplan.SelectedItem) & "'"
        '& txtmalop.Text.Trim & "," & txtmamh.Text.Trim & "," & droplan.Text.Substring(1, 2)
        Dim MyReadder As Data.Odbc.OdbcDataReader
        Try
            MyReadder = ExecSELECTSQL(strLenh)
            Dim MyTable As New DataTable
            MyTable.Load(MyReadder)
            objLT.SetDataSource(MyTable)
            objLT.SetParameterValue("TENLOP", droptenlop.Text)
            objLT.SetParameterValue("MONHOC", droptenmh.Text)
            objLT.SetParameterValue("LAN", Convert.ToInt16(droplan.SelectedItem))
            CRV.ReportSource = objLT
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class