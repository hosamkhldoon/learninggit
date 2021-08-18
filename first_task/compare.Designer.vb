<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class compare
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
        Me.numberTextBox1 = New System.Windows.Forms.TextBox()
        Me.numberTextBox2 = New System.Windows.Forms.TextBox()
        Me.compareButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.resultcompare = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'numberTextBox1
        '
        Me.numberTextBox1.Location = New System.Drawing.Point(189, 91)
        Me.numberTextBox1.Name = "numberTextBox1"
        Me.numberTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.numberTextBox1.TabIndex = 0
        '
        'numberTextBox2
        '
        Me.numberTextBox2.Location = New System.Drawing.Point(189, 148)
        Me.numberTextBox2.Name = "numberTextBox2"
        Me.numberTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.numberTextBox2.TabIndex = 1
        '
        'compareButton
        '
        Me.compareButton.Location = New System.Drawing.Point(458, 148)
        Me.compareButton.Name = "compareButton"
        Me.compareButton.Size = New System.Drawing.Size(75, 23)
        Me.compareButton.TabIndex = 2
        Me.compareButton.Text = "compare"
        Me.compareButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(189, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter first number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(189, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "enter seconed number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(191, 277)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Result of comparing two integer"
        '
        'resultcompare
        '
        Me.resultcompare.Location = New System.Drawing.Point(192, 303)
        Me.resultcompare.Multiline = True
        Me.resultcompare.Name = "resultcompare"
        Me.resultcompare.Size = New System.Drawing.Size(223, 104)
        Me.resultcompare.TabIndex = 6
        '
        'compare
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.resultcompare)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.compareButton)
        Me.Controls.Add(Me.numberTextBox2)
        Me.Controls.Add(Me.numberTextBox1)
        Me.Name = "compare"
        Me.Text = "compare"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents numberTextBox1 As TextBox
    Friend WithEvents numberTextBox2 As TextBox
    Friend WithEvents compareButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents resultcompare As TextBox
End Class
