Public Class FrmLOP 

    Private Sub LOPBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.LOPBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS)

    End Sub

    Private Sub FrmLOP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS.SINHVIEN' table. You can move, or remove it, as needed.


        'TODO: This line of code loads data into the 'DS.SINHVIEN' table. You can move, or remove it, as needed.
        
        'TODO: This line of code loads data into the 'DS.LOP' table. You can move, or remove it, as needed.
        Me.LOPTableAdapter.Connection.ConnectionString = Mdl_ketnoi.Connstr
        Me.LOPTableAdapter.Fill(Me.DS.LOP)
        Me.SINHVIENTableAdapter.Connection.ConnectionString = Mdl_ketnoi.Connstr
        Me.SINHVIENTableAdapter.Fill(Me.DS.SINHVIEN)
        txtMALOP.ReadOnly = True
        txtTENLOP.ReadOnly = True


    End Sub

    Private Sub btnthem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnthem.ItemClick
        

        LOPBindingSource.AddNew()
        txtMALOP.ReadOnly = False
        txtTENLOP.ReadOnly = False
        btnxoa.Enabled = False
        btnsua.Enabled = False
        txtMALOP.Focus()
    End Sub

  

    Private Sub btghi_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btghi.ItemClick
        If txtMALOP.Text.Trim = "" Then
            MsgBox("Mã Lớp Không Được Để Trống", MsgBoxStyle.OkOnly)
            txtMALOP.Focus()
            Exit Sub
        End If

        If txtTENLOP.Text.Trim = "" Then
            MsgBox("Tên không được để rỗng", MsgBoxStyle.OkOnly)
            txtTENLOP.Focus()
            Exit Sub
        End If

        Try
            LOPBindingSource.EndEdit()
            LOPBindingSource.ResetCurrentItem()
            Me.LOPTableAdapter.Update(Me.DS.LOP)
        Catch ex As Exception
            MsgBox("Mã Lớp không được trùng")
        End Try
        btnsua.Enabled = True
        btnxoa.Enabled = True
        btnthem.Enabled = True
    End Sub

    Private Sub btnxoa_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnxoa.ItemClick
        If SINHVIENBindingSource.Count > 0 Then
            MsgBox("Lớp đã có sinh viên..Bạn không thể xóa lớp này !", MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        If MsgBox("Bạn chắc chắn xóa Lớp này.!", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                LOPBindingSource.RemoveCurrent()
                Me.LOPTableAdapter.Update(Me.DS.LOP)
                MessageBox.Show("Xóa thành công")
            Catch ex As Exception
                MessageBox.Show("Xóa không thành công !" & vbCrLf & ex.Message)


            End Try

        End If
    End Sub



    Private Sub btnsua_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnsua.ItemClick
        btnthem.Enabled = False
        btnxoa.Enabled = False
        txtMALOP.ReadOnly = False
        txtTENLOP.ReadOnly = False
        txtMALOP.Focus()
        'LOPBindingSource.EndEdit()
        'LOPBindingSource.ResetCurrentItem()
        'Me.LOPTableAdapter.Update(Me.DS.LOP)
        
    End Sub

    Private Sub btnreload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnreload.ItemClick
        btnthem.Enabled = True
        btghi.Enabled = True
        btnxoa.Enabled = True
        btnsua.Enabled = True
        Me.LOPTableAdapter.Fill(Me.DS.LOP)



    End Sub


    Private Sub btbThoat_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btbThoat.ItemClick
        Close()
    End Sub
End Class