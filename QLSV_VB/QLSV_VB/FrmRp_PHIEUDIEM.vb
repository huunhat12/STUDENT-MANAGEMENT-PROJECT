Public Class FrmRp_PHIEUDIEM 

    Private Sub btnin_Click(sender As Object, e As EventArgs) Handles btnin.Click
        Dim objLT As crp_IN_PHIEUDIEM
        objLT = New crp_IN_PHIEUDIEM


        Dim strLenh As String

        strLenh = "EXEC IN_PHIEUDIEM_TEST '" & txtmasv.Text.Trim & "'"
        Dim MyReadder As Data.Odbc.OdbcDataReader
        Try
            MyReadder = ExecSELECTSQL(strLenh)
            'Dim count As Integer = 0
            'Dim Tongdiem As Double = 0
            'Dim tb As Double

            'While MyReadder.Read()
            '    Tongdiem += Convert.ToDouble(MyReadder.GetValue(1).ToString)

            '    count = count + 1
            'End While
            'tb = Tongdiem / count
            Dim MyTable As New DataTable
            MyTable.Load(MyReadder)
            objLT.SetDataSource(MyTable)
            objLT.SetParameterValue("LOP", txttenlop.Text)
            objLT.SetParameterValue("HOTEN", txthoten.Text)
            objLT.SetParameterValue("MASV", txtmasv.Text)
            CRV.ReportSource = objLT

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class