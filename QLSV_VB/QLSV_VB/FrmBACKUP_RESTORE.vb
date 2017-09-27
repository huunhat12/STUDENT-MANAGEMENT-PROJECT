Public Class FrmBACKUP_RESTORE 
    Dim mPosition As Integer
    Private Sub Chon(ByVal dong As Integer)
        Dim i As Integer

        For i = 1 To STT_BACKUPBindingSource.Count
            If (i <> dong) Then
                grv_STT_BACKUP.Item(0, i - 1).Value = 0
            Else
                grv_STT_BACKUP.Item(0, i - 1).Value = i
            End If
        Next
    End Sub

    Private Sub FrmBACKUP_RESTORE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS.STT_BACKUP' table. You can move, or remove it, as needed.
        Me.STT_BACKUPTableAdapter.Connection.ConnectionString = Mdl_ketnoi.Connstr
        Me.STT_BACKUPTableAdapter.Fill(Me.DS.STT_BACKUP)

        mPosition = 0

        If (STT_BACKUPBindingSource.Count <> 0) Then
            Chon(STT_BACKUPBindingSource.Count)
            mPosition = STT_BACKUPBindingSource.Count
        End If
        If STT_BACKUPBindingSource.Count = 0 Then
            Grv_STT_BACKUP.ReadOnly = True
            'btnrestore.Enabled = False
        End If

    End Sub

    Private Sub btnbackup_Click(sender As Object, e As EventArgs) Handles btnbackup.Click
        Dim strLenh As String
        If CHKinit.Checked = False Then
            strLenh = "BACKUP DATABASE QLSV_VB TO DEVICE_QLSV_VB"
        Else
            strLenh = "BACKUP DATABASE QLSV_VB TO DEVICE_QLSV_VB WITH INIT "

        End If


        Mdl_ketnoi.ExecNONQUERY(strLenh)
        Me.STT_BACKUPTableAdapter.Fill(Me.DS.STT_BACKUP)

    End Sub

    Private Sub btnrestore_Click(sender As Object, e As EventArgs) Handles btnrestore.Click
        If (STT_BACKUPBindingSource.Count = 0) Then
            MsgBox("Chưa có bản sao lưu để phục hồi.", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        If (mPosition = 0) Then

            MsgBox("Chưa chọn một bản sao lưu để phục hồi.", MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        If (conn.State = ConnectionState.Open) Then
            conn.Close()
        End If
        Dim strRestore As String
        strRestore = "ALTER DATABASE QLSV_VB SET SINGLE_USER WITH ROLLBACK IMMEDIATE  " & _
                     "USE tempdb " & _
                     "RESTORE DATABASE QLSV_VB FROM DEVICE_QLSV_VB WITH FILE= " & mPosition & ", REPLACE  " & _
                     "ALTER DATABASE QLSV_VB SET MULTI_USER "
        Try
            ExecNONQUERY(strRestore)
        Catch ex As Exception
            MsgBox("Lỗi Restore cơ sở dữ liệu ", MsgBoxStyle.OkOnly)
            Exit Sub
        End Try
        MsgBox("Đã phục hồi xong cơ sở dữ liệu. Bạn đăng nhập lại.", MsgBoxStyle.OkOnly)
        FrmMain.Item_logout.PerformClick()
        Close()
    End Sub

    Private Sub grv_STT_BACKUP_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grv_STT_BACKUP.CellContentClick
        If (e.RowIndex = -1) Then Exit Sub
        If (e.ColumnIndex <> 0) Then Exit Sub
        Chon(e.RowIndex + 1)

    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        If MsgBox("Bạn có thật sự muốn thoát ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Close()
        End If

    End Sub
End Class