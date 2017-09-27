<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBACKUP_RESTORE
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
        Me.btnbackup = New System.Windows.Forms.Button()
        Me.btnrestore = New System.Windows.Forms.Button()
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.DS = New QLSV_VB.DS()
        Me.STT_BACKUPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.STT_BACKUPTableAdapter = New QLSV_VB.DSTableAdapters.STT_BACKUPTableAdapter()
        Me.TableAdapterManager = New QLSV_VB.DSTableAdapters.TableAdapterManager()
        Me.CHKinit = New System.Windows.Forms.CheckBox()
        Me.grv_STT_BACKUP = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STT_BACKUPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grv_STT_BACKUP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnbackup
        '
        Me.btnbackup.Location = New System.Drawing.Point(38, 58)
        Me.btnbackup.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnbackup.Name = "btnbackup"
        Me.btnbackup.Size = New System.Drawing.Size(160, 33)
        Me.btnbackup.TabIndex = 0
        Me.btnbackup.Text = "SAO LƯU"
        Me.btnbackup.UseVisualStyleBackColor = True
        '
        'btnrestore
        '
        Me.btnrestore.Location = New System.Drawing.Point(38, 147)
        Me.btnrestore.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnrestore.Name = "btnrestore"
        Me.btnrestore.Size = New System.Drawing.Size(160, 33)
        Me.btnrestore.TabIndex = 1
        Me.btnrestore.Text = "PHỤC HỒI"
        Me.btnrestore.UseVisualStyleBackColor = True
        '
        'btnthoat
        '
        Me.btnthoat.Location = New System.Drawing.Point(38, 236)
        Me.btnthoat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(160, 33)
        Me.btnthoat.TabIndex = 2
        Me.btnthoat.Text = "THOÁT"
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'DS
        '
        Me.DS.DataSetName = "DS"
        Me.DS.EnforceConstraints = False
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'STT_BACKUPBindingSource
        '
        Me.STT_BACKUPBindingSource.DataMember = "STT_BACKUP"
        Me.STT_BACKUPBindingSource.DataSource = Me.DS
        '
        'STT_BACKUPTableAdapter
        '
        Me.STT_BACKUPTableAdapter.ClearBeforeFill = True
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
        'CHKinit
        '
        Me.CHKinit.AutoSize = True
        Me.CHKinit.Location = New System.Drawing.Point(377, 380)
        Me.CHKinit.Name = "CHKinit"
        Me.CHKinit.Size = New System.Drawing.Size(131, 23)
        Me.CHKinit.TabIndex = 5
        Me.CHKinit.Text = "Reset file sao lưu"
        Me.CHKinit.UseVisualStyleBackColor = True
        '
        'grv_STT_BACKUP
        '
        Me.grv_STT_BACKUP.AutoGenerateColumns = False
        Me.grv_STT_BACKUP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grv_STT_BACKUP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.grv_STT_BACKUP.DataSource = Me.STT_BACKUPBindingSource
        Me.grv_STT_BACKUP.Location = New System.Drawing.Point(254, 58)
        Me.grv_STT_BACKUP.Name = "grv_STT_BACKUP"
        Me.grv_STT_BACKUP.Size = New System.Drawing.Size(471, 304)
        Me.grv_STT_BACKUP.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "position"
        Me.DataGridViewTextBoxColumn1.HeaderText = "position"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "backup_start_date"
        Me.DataGridViewTextBoxColumn2.HeaderText = "backup_start_date"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'FrmBACKUP_RESTORE
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 447)
        Me.Controls.Add(Me.grv_STT_BACKUP)
        Me.Controls.Add(Me.CHKinit)
        Me.Controls.Add(Me.btnthoat)
        Me.Controls.Add(Me.btnrestore)
        Me.Controls.Add(Me.btnbackup)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmBACKUP_RESTORE"
        Me.Text = "FrmBACKUP_RESTORE"
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STT_BACKUPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grv_STT_BACKUP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnbackup As System.Windows.Forms.Button
    Friend WithEvents btnrestore As System.Windows.Forms.Button
    Friend WithEvents btnthoat As System.Windows.Forms.Button
    Friend WithEvents DS As QLSV_VB.DS
    Friend WithEvents STT_BACKUPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents STT_BACKUPTableAdapter As QLSV_VB.DSTableAdapters.STT_BACKUPTableAdapter
    Friend WithEvents TableAdapterManager As QLSV_VB.DSTableAdapters.TableAdapterManager
    Friend WithEvents CHKinit As System.Windows.Forms.CheckBox
    Friend WithEvents grv_STT_BACKUP As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
