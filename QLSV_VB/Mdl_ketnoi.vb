Imports System.Data.Odbc

Module Mdl_ketnoi
    Public conn As New OdbcConnection
    Public strconn As String
    Public Connstr As String
    Public mlogin As String = ""
    Public mpass As String = ""
    Public mUser As String = ""
    Public strDSN As String = "QLSV_VB"
    Public mHoTen As String
    Public mGroup As String


    Public Function KetNoi(ByVal mDSN As String) As Int32
        If conn.State = ConnectionState.Open Then conn.Close()
        Try
            Connstr = "Dsn=QLSV_VB;uid=" & mlogin.Trim & ";pwd=" & mpass.Trim
            conn.ConnectionString = Connstr
            conn.Open()
            KetNoi = 1
        Catch ex As Exception

            MsgBox(" lỗi kết nối  cơ sở dữ liệu." & vbCrLf & _
                   "Bạn xem lại User name và password.")
            KetNoi = 0
        End Try
    End Function
    Public Function ExecSELECTSQL(ByVal strlenh As String) As System.Data.Odbc.OdbcDataReader
        Dim cmd As New System.Data.Odbc.OdbcCommand
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = strlenh
        cmd.CommandTimeout = 300
        If conn.State = ConnectionState.Closed Then
            Mdl_ketnoi.KetNoi("QLSV_VB")

        End If
        Try
            ExecSELECTSQL = cmd.ExecuteReader()

        Catch ex As OdbcException

        End Try
    End Function

    Public Function ExecNONQUERY(ByVal strlenh As String) As System.Data.Odbc.OdbcDataReader
        Dim cmd As New System.Data.Odbc.OdbcCommand
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = strlenh
        cmd.CommandTimeout = 300
        If conn.State = ConnectionState.Closed Then
            Mdl_ketnoi.KetNoi("QLSV_VB")

        End If
        Try
            cmd.ExecuteNonQuery()

        Catch ex As OdbcException

        End Try
    End Function

    Public strDefaultPath As String = "D:\HUUNHAT\VB.Net\VB_HOCLAI\QLSV_VB\QLSV_VB\Images_SV"
    Public strNoPicture As String = strDefaultPath + "\daidien.jpg"

End Module
