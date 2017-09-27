Public Class XtraForm1 

    Private Sub LOPBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.LOPBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS)

    End Sub

    Private Sub XtraForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS.LOP' table. You can move, or remove it, as needed.
        Me.LOPTableAdapter.Connection.ConnectionString = Mdl_ketnoi.Connstr
        Me.LOPTableAdapter.Fill(Me.DS.LOP)

    End Sub
End Class