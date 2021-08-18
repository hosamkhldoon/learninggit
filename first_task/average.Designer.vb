<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class average
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
        Me.submitButton1 = New System.Windows.Forms.Button()
        Me.averageButton2 = New System.Windows.Forms.Button()
        Me.gradeListBox1 = New System.Windows.Forms.ListBox()
        Me.gradeTextBox1 = New System.Windows.Forms.TextBox()
        Me.aversageLabel1 = New System.Windows.Forms.Label()
        Me.clearButton3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'submitButton1
        '
        Me.submitButton1.Location = New System.Drawing.Point(377, 129)
        Me.submitButton1.Name = "submitButton1"
        Me.submitButton1.Size = New System.Drawing.Size(109, 23)
        Me.submitButton1.TabIndex = 0
        Me.submitButton1.Text = "submit grade"
        Me.submitButton1.UseVisualStyleBackColor = True
        '
        'averageButton2
        '
        Me.averageButton2.Location = New System.Drawing.Point(377, 158)
        Me.averageButton2.Name = "averageButton2"
        Me.averageButton2.Size = New System.Drawing.Size(109, 23)
        Me.averageButton2.TabIndex = 1
        Me.averageButton2.Text = "comput average"
        Me.averageButton2.UseVisualStyleBackColor = True
        '
        'gradeListBox1
        '
        Me.gradeListBox1.FormattingEnabled = True
        Me.gradeListBox1.Location = New System.Drawing.Point(81, 91)
        Me.gradeListBox1.Name = "gradeListBox1"
        Me.gradeListBox1.Size = New System.Drawing.Size(120, 277)
        Me.gradeListBox1.TabIndex = 2
        '
        'gradeTextBox1
        '
        Me.gradeTextBox1.Location = New System.Drawing.Point(360, 91)
        Me.gradeTextBox1.Name = "gradeTextBox1"
        Me.gradeTextBox1.Size = New System.Drawing.Size(140, 20)
        Me.gradeTextBox1.TabIndex = 3
        '
        'aversageLabel1
        '
        Me.aversageLabel1.AutoSize = True
        Me.aversageLabel1.Location = New System.Drawing.Point(413, 203)
        Me.aversageLabel1.Name = "aversageLabel1"
        Me.aversageLabel1.Size = New System.Drawing.Size(39, 13)
        Me.aversageLabel1.TabIndex = 4
        Me.aversageLabel1.Text = "Label1"
        '
        'clearButton3
        '
        Me.clearButton3.Location = New System.Drawing.Point(377, 242)
        Me.clearButton3.Name = "clearButton3"
        Me.clearButton3.Size = New System.Drawing.Size(109, 23)
        Me.clearButton3.TabIndex = 5
        Me.clearButton3.Text = "clear grade"
        Me.clearButton3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(357, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Enter your grade from 100"
        '
        'average
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.clearButton3)
        Me.Controls.Add(Me.aversageLabel1)
        Me.Controls.Add(Me.gradeTextBox1)
        Me.Controls.Add(Me.gradeListBox1)
        Me.Controls.Add(Me.averageButton2)
        Me.Controls.Add(Me.submitButton1)
        Me.Name = "average"
        Me.Text = "average"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents submitButton1 As Button
    Friend WithEvents averageButton2 As Button
    Friend WithEvents gradeListBox1 As ListBox
    Friend WithEvents gradeTextBox1 As TextBox
    Friend WithEvents aversageLabel1 As Label
    Friend WithEvents clearButton3 As Button
    Friend WithEvents Label1 As Label
End Class
