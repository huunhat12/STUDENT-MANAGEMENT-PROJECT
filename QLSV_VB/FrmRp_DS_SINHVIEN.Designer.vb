<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRp_DS_SINHVIEN
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnin = New System.Windows.Forms.Button()
        Me.txtMalop = New System.Windows.Forms.TextBox()
        Me.LOPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS = New QLSV_VB.DS()
        Me.dropLan = New System.Windows.Forms.ComboBox()
        Me.dtNgayin = New DevExpress.XtraEditors.DateEdit()
        Me.drptenlop = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LOPTableAdapter = New QLSV_VB.DSTableAdapters.LOPTableAdapter()
        Me.TableAdapterManager = New QLSV_VB.DSTableAdapters.TableAdapterManager()
        Me.CRV = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.crp_IN_DSSV1 = New QLSV_VB.crp_IN_DSSV()
        Me.GroupBox1.SuspendLayout()
        CType(Me.LOPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtNgayin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtNgayin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(325, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DANH SÁCH SINH VIÊN"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnin)
        Me.GroupBox1.Controls.Add(Me.txtMalop)
        Me.GroupBox1.Controls.Add(Me.dropLan)
        Me.GroupBox1.Controls.Add(Me.dtNgayin)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.drptenlop)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(798, 188)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'btnin
        '
        Me.btnin.Location = New System.Drawing.Point(499, 105)
        Me.btnin.Name = "btnin"
        Me.btnin.Size = New System.Drawing.Size(84, 37)
        Me.btnin.TabIndex = 8
        Me.btnin.Text = "IN"
        Me.btnin.UseVisualStyleBackColor = True
        '
        'txtMalop
        '
        Me.txtMalop.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LOPBindingSource, "MALOP", True))
        Me.txtMalop.Location = New System.Drawing.Point(586, 60)
        Me.txtMalop.Name = "txtMalop"
        Me.txtMalop.ReadOnly = True
        Me.txtMalop.Size = New System.Drawing.Size(100, 21)
        Me.txtMalop.TabIndex = 7
        '
        'LOPBindingSource
        '
        Me.LOPBindingSource.DataMember = "LOP"
        Me.LOPBindingSource.DataSource = Me.DS
        '
        'DS
        '
        Me.DS.DataSetName = "DS"
        Me.DS.EnforceConstraints = False
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dropLan
        '
        Me.dropLan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dropLan.FormattingEnabled = True
        Me.dropLan.Items.AddRange(New Object() {"1", "2"})
        Me.dropLan.Location = New System.Drawing.Point(324, 121)
        Me.dropLan.Name = "dropLan"
        Me.dropLan.Size = New System.Drawing.Size(121, 21)
        Me.dropLan.TabIndex = 6
        '
        'dtNgayin
        '
        Me.dtNgayin.EditValue = Nothing
        Me.dtNgayin.Location = New System.Drawing.Point(323, 92)
        Me.dtNgayin.Name = "dtNgayin"
        Me.dtNgayin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtNgayin.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtNgayin.Size = New System.Drawing.Size(122, 20)
        Me.dtNgayin.TabIndex = 5
        '
        'drptenlop
        '
        Me.drptenlop.DataSource = Me.LOPBindingSource
        Me.drptenlop.DisplayMember = "TENLOP"
        Me.drptenlop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.drptenlop.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drptenlop.FormattingEnabled = True
        Me.drptenlop.Location = New System.Drawing.Point(323, 58)
        Me.drptenlop.Name = "drptenlop"
        Me.drptenlop.Size = New System.Drawing.Size(247, 23)
        Me.drptenlop.TabIndex = 4
        Me.drptenlop.ValueMember = "MALOP"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(229, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 19)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "LẦN THI"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(229, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "NGÀY IN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(229, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "TÊN LỚP"
        '
        'LOPTableAdapter
        '
        Me.LOPTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DIEMTableAdapter = Nothing
        Me.TableAdapterManager.GIANGVIENTableAdapter = Nothing
        Me.TableAdapterManager.LOPTableAdapter = Me.LOPTableAdapter
        Me.TableAdapterManager.MONHOCTableAdapter = Nothing
        Me.TableAdapterManager.SINHVIENTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = QLSV_VB.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CRV
        '
        Me.CRV.ActiveViewIndex = -1
        Me.CRV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRV.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRV.Location = New System.Drawing.Point(0, 188)
        Me.CRV.Name = "CRV"
        Me.CRV.Size = New System.Drawing.Size(798, 399)
        Me.CRV.TabIndex = 2
        Me.CRV.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'FrmRp_DS_SINHVIEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 587)
        Me.Controls.Add(Me.CRV)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmRp_DS_SINHVIEN"
        Me.Text = "FrmRp_DS_SINHVIEN"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.LOPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtNgayin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtNgayin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DS As QLSV_VB.DS
    Friend WithEvents LOPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LOPTableAdapter As QLSV_VB.DSTableAdapters.LOPTableAdapter
    Friend WithEvents TableAdapterManager As QLSV_VB.DSTableAdapters.TableAdapterManager
    Friend WithEvents dropLan As System.Windows.Forms.ComboBox
    Friend WithEvents dtNgayin As DevExpress.XtraEditors.DateEdit
    Friend WithEvents drptenlop As System.Windows.Forms.ComboBox
    Friend WithEvents txtMalop As System.Windows.Forms.TextBox
    Friend WithEvents CRV As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents crp_IN_DSSV1 As QLSV_VB.crp_IN_DSSV
    Friend WithEvents btnin As System.Windows.Forms.Button
End Class
