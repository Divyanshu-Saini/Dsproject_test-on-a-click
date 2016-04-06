<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteUser
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.DSProjectDataSet = New Test_on_a_click_Client.DSProjectDataSet()
        Me.DSProjectDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersDetailstblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Users_Details_tblTableAdapter = New Test_on_a_click_Client.DSProjectDataSetTableAdapters.Users_Details_tblTableAdapter()
        CType(Me.DSProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSProjectDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersDetailstblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroTile2
        '
        Me.MetroTile2.ActiveControl = Nothing
        Me.MetroTile2.Location = New System.Drawing.Point(72, 114)
        Me.MetroTile2.Name = "MetroTile2"
        Me.MetroTile2.Size = New System.Drawing.Size(145, 29)
        Me.MetroTile2.TabIndex = 8
        Me.MetroTile2.Text = "Username:"
        Me.MetroTile2.UseSelectable = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(240, 171)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(141, 23)
        Me.MetroButton1.TabIndex = 9
        Me.MetroButton1.Text = "Delete"
        Me.MetroButton1.UseSelectable = True
        '
        'MetroComboBox1
        '
        Me.MetroComboBox1.DataSource = Me.UsersDetailstblBindingSource
        Me.MetroComboBox1.DisplayMember = "user_name"
        Me.MetroComboBox1.FormattingEnabled = True
        Me.MetroComboBox1.ItemHeight = 23
        Me.MetroComboBox1.Location = New System.Drawing.Point(245, 114)
        Me.MetroComboBox1.Name = "MetroComboBox1"
        Me.MetroComboBox1.Size = New System.Drawing.Size(136, 29)
        Me.MetroComboBox1.TabIndex = 10
        Me.MetroComboBox1.UseSelectable = True
        Me.MetroComboBox1.ValueMember = "user_name"
        '
        'DSProjectDataSet
        '
        Me.DSProjectDataSet.DataSetName = "DSProjectDataSet"
        Me.DSProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DSProjectDataSetBindingSource
        '
        Me.DSProjectDataSetBindingSource.DataSource = Me.DSProjectDataSet
        Me.DSProjectDataSetBindingSource.Position = 0
        '
        'UsersDetailstblBindingSource
        '
        Me.UsersDetailstblBindingSource.DataMember = "Users_Details_tbl"
        Me.UsersDetailstblBindingSource.DataSource = Me.DSProjectDataSetBindingSource
        '
        'Users_Details_tblTableAdapter
        '
        Me.Users_Details_tblTableAdapter.ClearBeforeFill = True
        '
        'DeleteUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 300)
        Me.Controls.Add(Me.MetroComboBox1)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.MetroTile2)
        Me.Name = "DeleteUser"
        Me.Text = "DeleteUser"
        CType(Me.DSProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSProjectDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersDetailstblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroComboBox1 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents DSProjectDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSProjectDataSet As Test_on_a_click_Client.DSProjectDataSet
    Friend WithEvents UsersDetailstblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Users_Details_tblTableAdapter As Test_on_a_click_Client.DSProjectDataSetTableAdapters.Users_Details_tblTableAdapter
End Class
