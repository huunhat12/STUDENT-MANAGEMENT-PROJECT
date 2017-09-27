<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRp_DIEM_MONHOC
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
        Dim MALOPLabel As System.Windows.Forms.Label
        Dim MAMHLabel As System.Windows.Forms.Label
        Dim LANLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtmalop = New System.Windows.Forms.TextBox()
        Me.LOPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS = New QLSV_VB.DS()
        Me.txtmamh = New System.Windows.Forms.TextBox()
        Me.MONHOCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DIEMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnin = New System.Windows.Forms.Button()
        Me.droplan = New System.Windows.Forms.ComboBox()
        Me.droptenmh = New System.Windows.Forms.ComboBox()
        Me.droptenlop = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LOPTableAdapter = New QLSV_VB.DSTableAdapters.LOPTableAdapter()
        Me.TableAdapterManager = New QLSV_VB.DSTableAdapters.TableAdapterManager()
        Me.DIEMTableAdapter = New QLSV_VB.DSTableAdapters.DIEMTableAdapter()
        Me.MONHOCTableAdapter = New QLSV_VB.DSTableAdapters.MONHOCTableAdapter()
        Me.CRV = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        MALOPLabel = New System.Windows.Forms.Label()
        MAMHLabel = New System.Windows.Forms.Label()
        LANLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.LOPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MONHOCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DIEMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MALOPLabel
        '
        MALOPLabel.AutoSize = True
        MALOPLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MALOPLabel.Location = New System.Drawing.Point(234, 58)
        MALOPLabel.Name = "MALOPLabel"
        MALOPLabel.Size = New System.Drawing.Size(73, 19)
        MALOPLabel.TabIndex = 1
        MALOPLabel.Text = "TÊN LỚP"
        '
        'MAMHLabel
        '
        MAMHLabel.AutoSize = True
        MAMHLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MAMHLabel.Location = New System.Drawing.Point(234, 93)
        MAMHLabel.Name = "MAMHLabel"
        MAMHLabel.Size = New System.Drawing.Size(119, 19)
        MAMHLabel.TabIndex = 3
        MAMHLabel.Text = "TÊN MÔN HỌC"
        '
        'LANLabel
        '
        LANLabel.AutoSize = True
        LANLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LANLabel.Location = New System.Drawing.Point(234, 131)
        LANLabel.Name = "LANLabel"
        LANLabel.Size = New System.Drawing.Size(41, 19)
        LANLabel.TabIndex = 5
        LANLabel.Text = "LẦN"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtmalop)
        Me.GroupBox1.Controls.Add(Me.txtmamh)
        Me.GroupBox1.Controls.Add(Me.btnin)
        Me.GroupBox1.Controls.Add(Me.droplan)
        Me.GroupBox1.Controls.Add(LANLabel)
        Me.GroupBox1.Controls.Add(MAMHLabel)
        Me.GroupBox1.Controls.Add(Me.droptenmh)
        Me.GroupBox1.Controls.Add(MALOPLabel)
        Me.GroupBox1.Controls.Add(Me.droptenlop)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(859, 179)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtmalop
        '
        Me.txtmalop.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LOPBindingSource, "MALOP", True))
        Me.txtmalop.Location = New System.Drawing.Point(115, 54)
        Me.txtmalop.Name = "txtmalop"
        Me.txtmalop.ReadOnly = True
        Me.txtmalop.Size = New System.Drawing.Size(100, 21)
        Me.txtmalop.TabIndex = 13
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
        'txtmamh
        '
        Me.txtmamh.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MONHOCBindingSource, "MAMH", True))
        Me.txtmamh.Location = New System.Drawing.Point(115, 90)
        Me.txtmamh.Name = "txtmamh"
        Me.txtmamh.ReadOnly = True
        Me.txtmamh.Size = New System.Drawing.Size(100, 21)
        Me.txtmamh.TabIndex = 12
        '
        'MONHOCBindingSource
        '
        Me.MONHOCBindingSource.DataMember = "MONHOC"
        Me.MONHOCBindingSource.DataSource = Me.DS
        '
        'DIEMBindingSource
        '
        Me.DIEMBindingSource.DataMember = "DIEM"
        Me.DIEMBindingSource.DataSource = Me.DS
        '
        'btnin
        '
        Me.btnin.Location = New System.Drawing.Point(636, 72)
        Me.btnin.Name = "btnin"
        Me.btnin.Size = New System.Drawing.Size(94, 40)
        Me.btnin.TabIndex = 8
        Me.btnin.Text = "IN"
        Me.btnin.UseVisualStyleBackColor = True
        '
        'droplan
        '
        Me.droplan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.droplan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.droplan.FormattingEnabled = True
        Me.droplan.Items.AddRange(New Object() {"1", "2"})
        Me.droplan.Location = New System.Drawing.Point(375, 132)
        Me.droplan.Name = "droplan"
        Me.droplan.Size = New System.Drawing.Size(100, 27)
        Me.droplan.TabIndex = 7
        '
        'droptenmh
        '
        Me.droptenmh.DataSource = Me.MONHOCBindingSource
        Me.droptenmh.DisplayMember = "TENMH"
        Me.droptenmh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.droptenmh.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.droptenmh.FormattingEnabled = True
        Me.droptenmh.Location = New System.Drawing.Point(375, 90)
        Me.droptenmh.Name = "droptenmh"
        Me.droptenmh.Size = New System.Drawing.Size(223, 27)
        Me.droptenmh.TabIndex = 4
        Me.droptenmh.ValueMember = "MAMH"
        '
        'droptenlop
        '
        Me.droptenlop.DataSource = Me.LOPBindingSource
        Me.droptenlop.DisplayMember = "TENLOP"
        Me.droptenlop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.droptenlop.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.droptenlop.FormattingEnabled = True
        Me.droptenlop.Location = New System.Drawing.Point(375, 54)
        Me.droptenlop.Name = "droptenlop"
        Me.droptenlop.Size = New System.Drawing.Size(223, 27)
        Me.droptenlop.TabIndex = 2
        Me.droptenlop.ValueMember = "MALOP"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(269, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BẢNG ĐIỂM MÔN HỌC"
        '
        'LOPTableAdapter
        '
        Me.LOPTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DIEMTableAdapter = Me.DIEMTableAdapter
        Me.TableAdapterManager.GIANGVIENTableAdapter = Nothing
        Me.TableAdapterManager.LOPTableAdapter = Me.LOPTableAdapter
        Me.TableAdapterManager.MONHOCTableAdapter = Me.MONHOCTableAdapter
        Me.TableAdapterManager.SINHVIENTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = QLSV_VB.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DIEMTableAdapter
        '
        Me.DIEMTableAdapter.ClearBeforeFill = True
        '
        'MONHOCTableAdapter
        '
        Me.MONHOCTableAdapter.ClearBeforeFill = True
        '
        'CRV
        '
        Me.CRV.ActiveViewIndex = -1
        Me.CRV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRV.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRV.Location = New System.Drawing.Point(0, 179)
        Me.CRV.Name = "CRV"
        Me.CRV.Size = New System.Drawing.Size(859, 366)
        Me.CRV.TabIndex = 1
        Me.CRV.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'FrmRp_DIEM_MONHOC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 545)
        Me.Controls.Add(Me.CRV)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmRp_DIEM_MONHOC"
        Me.Text = "FrmRp_DIEM_MONHOC"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.LOPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MONHOCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DIEMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DS As QLSV_VB.DS
    Friend WithEvents LOPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LOPTableAdapter As QLSV_VB.DSTableAdapters.LOPTableAdapter
    Friend WithEvents TableAdapterManager As QLSV_VB.DSTableAdapters.TableAdapterManager
    Friend WithEvents droptenlop As System.Windows.Forms.ComboBox
    Friend WithEvents DIEMTableAdapter As QLSV_VB.DSTableAdapters.DIEMTableAdapter
    Friend WithEvents DIEMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents droptenmh As System.Windows.Forms.ComboBox
    Friend WithEvents CRV As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnin As System.Windows.Forms.Button
    Friend WithEvents droplan As System.Windows.Forms.ComboBox
    Friend WithEvents MONHOCTableAdapter As QLSV_VB.DSTableAdapters.MONHOCTableAdapter
    Friend WithEvents MONHOCBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents txtmalop As System.Windows.Forms.TextBox
    Friend WithEvents txtmamh As System.Windows.Forms.TextBox
End Class
