<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Table_Multiply
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
        Me.showbutton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.numberTextBox1 = New System.Windows.Forms.TextBox()
        Me.tableTextBox1 = New System.Windows.Forms.TextBox()
        Me.counterLabel2 = New System.Windows.Forms.Label()
        Me.counterButton1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'showbutton
        '
        Me.showbutton.Location = New System.Drawing.Point(420, 91)
        Me.showbutton.Name = "showbutton"
        Me.showbutton.Size = New System.Drawing.Size(134, 23)
        Me.showbutton.TabIndex = 0
        Me.showbutton.Text = "Show the table"
        Me.showbutton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "enter number to get table multiply"
        '
        'numberTextBox1
        '
        Me.numberTextBox1.Location = New System.Drawing.Point(251, 93)
        Me.numberTextBox1.Name = "numberTextBox1"
        Me.numberTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.numberTextBox1.TabIndex = 2
        '
        'tableTextBox1
        '
        Me.tableTextBox1.Location = New System.Drawing.Point(304, 144)
        Me.tableTextBox1.Multiline = True
        Me.tableTextBox1.Name = "tableTextBox1"
        Me.tableTextBox1.Size = New System.Drawing.Size(100, 250)
        Me.tableTextBox1.TabIndex = 3
        '
        'counterLabel2
        '
        Me.counterLabel2.AutoSize = True
        Me.counterLabel2.Location = New System.Drawing.Point(526, 174)
        Me.counterLabel2.Name = "counterLabel2"
        Me.counterLabel2.Size = New System.Drawing.Size(39, 13)
        Me.counterLabel2.TabIndex = 4
        Me.counterLabel2.Text = "Label2"
        '
        'counterButton1
        '
        Me.counterButton1.Location = New System.Drawing.Point(504, 142)
        Me.counterButton1.Name = "counterButton1"
        Me.counterButton1.Size = New System.Drawing.Size(75, 23)
        Me.counterButton1.TabIndex = 5
        Me.counterButton1.Text = "print"
        Me.counterButton1.UseVisualStyleBackColor = True
        '
        'Table_Multiply
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.counterLabel2)
        Me.Controls.Add(Me.counterButton1)
        Me.Controls.Add(Me.tableTextBox1)
        Me.Controls.Add(Me.numberTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.showbutton)
        Me.Name = "Table_Multiply"
        Me.Text = "Table_Multiply"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents showbutton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents numberTextBox1 As TextBox
    Friend WithEvents tableTextBox1 As TextBox
    Friend WithEvents counterLabel2 As Label
    Friend WithEvents counterButton1 As Button
End Class
