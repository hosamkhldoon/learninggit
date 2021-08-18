<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class squre_of_chraticstic
    Inherits System.Windows.Forms.Form

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
        Me.charTextBox1 = New System.Windows.Forms.TextBox()
        Me.DisplayButton1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lengthUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.printTextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.lengthUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'charTextBox1
        '
        Me.charTextBox1.Location = New System.Drawing.Point(311, 92)
        Me.charTextBox1.Name = "charTextBox1"
        Me.charTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.charTextBox1.TabIndex = 0
        '
        'DisplayButton1
        '
        Me.DisplayButton1.Location = New System.Drawing.Point(483, 95)
        Me.DisplayButton1.Name = "DisplayButton1"
        Me.DisplayButton1.Size = New System.Drawing.Size(122, 23)
        Me.DisplayButton1.TabIndex = 2
        Me.DisplayButton1.Text = "Display squre"
        Me.DisplayButton1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(201, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter fill charcter :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(204, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Enter side Length :"
        '
        'lengthUpDown1
        '
        Me.lengthUpDown1.Location = New System.Drawing.Point(311, 128)
        Me.lengthUpDown1.Name = "lengthUpDown1"
        Me.lengthUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.lengthUpDown1.TabIndex = 6
        '
        'printTextBox1
        '
        Me.printTextBox1.Location = New System.Drawing.Point(138, 211)
        Me.printTextBox1.Multiline = True
        Me.printTextBox1.Name = "printTextBox1"
        Me.printTextBox1.Size = New System.Drawing.Size(308, 162)
        Me.printTextBox1.TabIndex = 7
        '
        'squre_of_chraticstic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.printTextBox1)
        Me.Controls.Add(Me.lengthUpDown1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DisplayButton1)
        Me.Controls.Add(Me.charTextBox1)
        Me.Name = "squre_of_chraticstic"
        Me.Text = "squre_of_chraticstic"
        CType(Me.lengthUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents charTextBox1 As TextBox
    Friend WithEvents DisplayButton1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lengthUpDown1 As NumericUpDown
    Friend WithEvents printTextBox1 As TextBox
End Class
