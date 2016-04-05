<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FEEDBACK
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
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'textBox3
        '
        Me.textBox3.Location = New System.Drawing.Point(259, 154)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(151, 20)
        Me.textBox3.TabIndex = 19
        '
        'textBox2
        '
        Me.textBox2.Location = New System.Drawing.Point(259, 105)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(151, 20)
        Me.textBox2.TabIndex = 18
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(259, 69)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(151, 20)
        Me.textBox1.TabIndex = 17
        '
        'richTextBox1
        '
        Me.richTextBox1.Location = New System.Drawing.Point(259, 211)
        Me.richTextBox1.Name = "richTextBox1"
        Me.richTextBox1.Size = New System.Drawing.Size(224, 96)
        Me.richTextBox1.TabIndex = 16
        Me.richTextBox1.Text = ""
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(394, 332)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(89, 33)
        Me.button2.TabIndex = 15
        Me.button2.Text = "EXIT"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(259, 332)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(86, 33)
        Me.button1.TabIndex = 14
        Me.button1.Text = "FEEDBACK"
        Me.button1.UseVisualStyleBackColor = True
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(121, 214)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(78, 13)
        Me.label4.TabIndex = 13
        Me.label4.Text = "SUGGESTION"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(122, 161)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(77, 13)
        Me.label3.TabIndex = 12
        Me.label3.Text = "CONTACT NO"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(121, 112)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(39, 13)
        Me.label2.TabIndex = 11
        Me.label2.Text = "EMAIL"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(122, 69)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(38, 13)
        Me.label1.TabIndex = 10
        Me.label1.Text = "NAME"
        '
        'FEEDBACK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 399)
        Me.Controls.Add(Me.textBox3)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.richTextBox1)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "FEEDBACK"
        Me.Text = "FEEDBACK"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents textBox3 As System.Windows.Forms.TextBox
    Private WithEvents textBox2 As System.Windows.Forms.TextBox
    Private WithEvents textBox1 As System.Windows.Forms.TextBox
    Private WithEvents richTextBox1 As System.Windows.Forms.RichTextBox
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
End Class
