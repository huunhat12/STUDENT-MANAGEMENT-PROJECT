<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTAO_TAIKHOAN
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DS = New QLSV_VB.DS()
        Me.SELECT_HOTEN_GVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SELECT_HOTEN_GVTableAdapter = New QLSV_VB.DSTableAdapters.SELECT_HOTEN_GVTableAdapter()
        Me.TableAdapterManager = New QLSV_VB.DSTableAdapters.TableAdapterManager()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btntaologin = New System.Windows.Forms.Button()
        Me.txtmagv = New System.Windows.Forms.TextBox()
        Me.drlHoten = New System.Windows.Forms.ComboBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtLoginname = New System.Windows.Forms.TextBox()
        Me.drlNhomquyen = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SELECT_HOTEN_GVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DS
        '
        Me.DS.DataSetName = "DS"
        Me.DS.EnforceConstraints = False
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SELECT_HOTEN_GVBindingSource
        '
        Me.SELECT_HOTEN_GVBindingSource.DataMember = "SELECT_HOTEN_GV"
        Me.SELECT_HOTEN_GVBindingSource.DataSource = Me.DS
        '
        'SELECT_HOTEN_GVTableAdapter
        '
        Me.SELECT_HOTEN_GVTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.DIEMTableAdapter = Nothing
        Me.TableAdapterManager.GIANGVIENTableAdapter = Nothing
        Me.TableAdapterManager.LOPTableAdapter = Nothing
        Me.TableAdapterManager.MONHOCTableAdapter = Nothing
        Me.TableAdapterManager.SINHVIENTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = QLSV_VB.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnthoat)
        Me.GroupBox1.Controls.Add(Me.btnxoa)
        Me.GroupBox1.Controls.Add(Me.btntaologin)
        Me.GroupBox1.Controls.Add(Me.txtmagv)
        Me.GroupBox1.Controls.Add(Me.drlHoten)
        Me.GroupBox1.Controls.Add(Me.txtpass)
        Me.GroupBox1.Controls.Add(Me.txtLoginname)
        Me.GroupBox1.Controls.Add(Me.drlNhomquyen)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(730, 454)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'btnthoat
        '
        Me.btnthoat.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnthoat.Location = New System.Drawing.Point(491, 342)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(78, 35)
        Me.btnthoat.TabIndex = 27
        Me.btnthoat.Text = "THOÁT"
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnxoa.Location = New System.Drawing.Point(354, 342)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(79, 35)
        Me.btnxoa.TabIndex = 26
        Me.btnxoa.Text = "XÓA"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btntaologin
        '
        Me.btntaologin.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntaologin.Location = New System.Drawing.Point(137, 342)
        Me.btntaologin.Name = "btntaologin"
        Me.btntaologin.Size = New System.Drawing.Size(144, 35)
        Me.btntaologin.TabIndex = 25
        Me.btntaologin.Text = "TẠO USERNAME"
        Me.btntaologin.UseVisualStyleBackColor = True
        '
        'txtmagv
        '
        Me.txtmagv.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SELECT_HOTEN_GVBindingSource, "MAGV", True))
        Me.txtmagv.Location = New System.Drawing.Point(508, 134)
        Me.txtmagv.Name = "txtmagv"
        Me.txtmagv.ReadOnly = True
        Me.txtmagv.Size = New System.Drawing.Size(100, 21)
        Me.txtmagv.TabIndex = 24
        '
        'drlHoten
        '
        Me.drlHoten.DataSource = Me.SELECT_HOTEN_GVBindingSource
        Me.drlHoten.DisplayMember = "HOTEN"
        Me.drlHoten.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.drlHoten.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drlHoten.FormattingEnabled = True
        Me.drlHoten.Location = New System.Drawing.Point(280, 128)
        Me.drlHoten.Name = "drlHoten"
        Me.drlHoten.Size = New System.Drawing.Size(190, 27)
        Me.drlHoten.TabIndex = 23
        Me.drlHoten.ValueMember = "MAGV"
        '
        'txtpass
        '
        Me.txtpass.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.Location = New System.Drawing.Point(280, 226)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(121, 26)
        Me.txtpass.TabIndex = 22
        '
        'txtLoginname
        '
        Me.txtLoginname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoginname.Location = New System.Drawing.Point(280, 175)
        Me.txtLoginname.Name = "txtLoginname"
        Me.txtLoginname.Size = New System.Drawing.Size(121, 26)
        Me.txtLoginname.TabIndex = 21
        '
        'drlNhomquyen
        '
        Me.drlNhomquyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.drlNhomquyen.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drlNhomquyen.FormattingEnabled = True
        Me.drlNhomquyen.Items.AddRange(New Object() {"ADMIN", "GIANGVIEN"})
        Me.drlNhomquyen.Location = New System.Drawing.Point(280, 269)
        Me.drlNhomquyen.Name = "drlNhomquyen"
        Me.drlNhomquyen.Size = New System.Drawing.Size(121, 27)
        Me.drlNhomquyen.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(123, 277)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 19)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "NHÓM QUYỀN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(123, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 19)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "MẬT KHẨU"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(123, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 19)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "LOGIN NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(123, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 19)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "HỌ TÊN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(207, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(308, 24)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "TẠO TÀI KHOẢN GIẢNG VIÊN"
        '
        'FrmTAO_TAIKHOAN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 454)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmTAO_TAIKHOAN"
        Me.Text = "FrmTAO_TAIKHOAN"
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SELECT_HOTEN_GVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DS As QLSV_VB.DS
    Friend WithEvents SELECT_HOTEN_GVBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SELECT_HOTEN_GVTableAdapter As QLSV_VB.DSTableAdapters.SELECT_HOTEN_GVTableAdapter
    Friend WithEvents TableAdapterManager As QLSV_VB.DSTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnthoat As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btntaologin As System.Windows.Forms.Button
    Friend WithEvents txtmagv As System.Windows.Forms.TextBox
    Friend WithEvents drlHoten As System.Windows.Forms.ComboBox
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents txtLoginname As System.Windows.Forms.TextBox
    Friend WithEvents drlNhomquyen As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
