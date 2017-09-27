Public Class FrmMONHOC 

    Private Sub MONHOCBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MONHOCBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS)

    End Sub

    Private Sub FrmMONHOC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS.DIEM' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DS.MONHOC' table. You can move, or remove it, as needed.
        Me.MONHOCTableAdapter.Connection.ConnectionString = Mdl_ketnoi.Connstr
        Me.MONHOCTableAdapter.Fill(Me.DS.MONHOC)
        Me.DIEMTableAdapter.Connection.ConnectionString = Mdl_ketnoi.Connstr
        Me.DIEMTableAdapter.Fill(Me.DS.DIEM)
        txtmamh.ReadOnly = True
        txttenmh.ReadOnly = True
        txtSTCLT.ReadOnly = True
        txtSOTCTH.ReadOnly = True
    End Sub

    Private Sub TENMHTextEdit_EditValueChanged(sender As Object, e As EventArgs) Handles txttenmh.EditValueChanged

    End Sub

    Private Sub btnthem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnthem.ItemClick
        MONHOCBindingSource.AddNew()
        btnxoa.Enabled = False
        btnsua.Enabled = False
        btnxuatexcel.Enabled = False
        txtmamh.ReadOnly = False
        txttenmh.ReadOnly = False
        txtSTCLT.ReadOnly = False
        txtSOTCTH.ReadOnly = False
        txtmamh.Focus()
    End Sub

    Private Sub btnghi_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnghi.ItemClick
        If txtmamh.Text.Trim = "" Then
            MsgBox("Mã Môn Học Không Được Để Trống", MsgBoxStyle.OkOnly)
            txtmamh.Focus()
            Exit Sub
        End If

        If txttenmh.Text.Trim = "" Then
            MsgBox("Tên Môn Học không được để rỗng", MsgBoxStyle.OkOnly)
            txttenmh.Focus()
            Exit Sub
        End If
        If txtSTCLT.Text.Trim = "" Then
            MsgBox("Số Tín Chỉ Lý Thyết không được để trống", MsgBoxStyle.OkOnly)
            txtSTCLT.Focus()
            Exit Sub
        End If
        If txtSOTCTH.Text.Trim = "" Then
            MsgBox("Số Tín Chỉ Thực Hành không được để trống", MsgBoxStyle.OkOnly)
            txtSOTCTH.Focus()
            Exit Sub
        End If
        Try
            MONHOCBindingSource.EndEdit()
            MONHOCBindingSource.ResetCurrentItem()
            Me.MONHOCTableAdapter.Update(Me.DS.MONHOC)
        Catch ex As Exception
            MsgBox("Mã Môn Học không được trùng")
        End Try
        btnsua.Enabled = True
        btnxoa.Enabled = True
        btnthem.Enabled = True
    End Sub

    Private Sub btnxoa_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnxoa.ItemClick
        If DIEMBindingSource.Count > 0 Then
            MsgBox("Môn Học đã có điểm sinh viên.Bạn không thể xóa.!", MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        If MsgBox("Bạn chắc chắn xóa Môn Học này.!", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                MONHOCBindingSource.RemoveCurrent()
                Me.MONHOCTableAdapter.Update(Me.DS.MONHOC)
                MessageBox.Show("Xóa thành công")
            Catch ex As Exception
                MessageBox.Show("Xóa không thành công !")


            End Try
        End If
    End Sub

    Private Sub btnsua_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnsua.ItemClick
        btnthem.Enabled = False
        btnxoa.Enabled = False
        txtmamh.ReadOnly = False
        txttenmh.ReadOnly = False
        txtSTCLT.ReadOnly = False
        txtSOTCTH.ReadOnly = False
        txtmamh.Focus()
    End Sub

    Private Sub btnthoat_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnthoat.ItemClick
        Close()
    End Sub

    Private Sub btnreload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnreload.ItemClick
        MONHOCBindingSource.CancelEdit()
        Me.MONHOCTableAdapter.Fill(Me.DS.MONHOC)
        btnthem.Enabled = True
        btnxoa.Enabled = True
        btnghi.Enabled = True
        btnsua.Enabled = True
        btnreload.Enabled = True
        btnxuatexcel.Enabled = True
    End Sub
End Class