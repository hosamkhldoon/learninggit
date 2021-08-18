<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class calculater
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
        Me.number1textbox = New System.Windows.Forms.TextBox()
        Me.number2textbox = New System.Windows.Forms.TextBox()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Resultaddtwonumber = New System.Windows.Forms.Label()
        Me.multiButton = New System.Windows.Forms.Button()
        Me.subbutton = New System.Windows.Forms.Button()
        Me.divButton = New System.Windows.Forms.Button()
        Me.powButton = New System.Windows.Forms.Button()
        Me.modButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'number1textbox
        '
        Me.number1textbox.Location = New System.Drawing.Point(124, 130)
        Me.number1textbox.Name = "number1textbox"
        Me.number1textbox.Size = New System.Drawing.Size(100, 20)
        Me.number1textbox.TabIndex = 0
        '
        'number2textbox
        '
        Me.number2textbox.Location = New System.Drawing.Point(282, 130)
        Me.number2textbox.Name = "number2textbox"
        Me.number2textbox.Size = New System.Drawing.Size(100, 20)
        Me.number2textbox.TabIndex = 1
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(145, 237)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(99, 23)
        Me.AddButton.TabIndex = 2
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(133, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "enter first number "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(279, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "enter seconed number"
        '
        'Resultaddtwonumber
        '
        Me.Resultaddtwonumber.AutoSize = True
        Me.Resultaddtwonumber.Location = New System.Drawing.Point(370, 351)
        Me.Resultaddtwonumber.Name = "Resultaddtwonumber"
        Me.Resultaddtwonumber.Size = New System.Drawing.Size(0, 13)
        Me.Resultaddtwonumber.TabIndex = 5
        '
        'multiButton
        '
        Me.multiButton.Location = New System.Drawing.Point(253, 237)
        Me.multiButton.Name = "multiButton"
        Me.multiButton.Size = New System.Drawing.Size(88, 23)
        Me.multiButton.TabIndex = 6
        Me.multiButton.Text = "multiply"
        Me.multiButton.UseVisualStyleBackColor = True
        '
        'subbutton
        '
        Me.subbutton.Location = New System.Drawing.Point(145, 206)
        Me.subbutton.Name = "subbutton"
        Me.subbutton.Size = New System.Drawing.Size(99, 23)
        Me.subbutton.TabIndex = 7
        Me.subbutton.Text = "sub"
        Me.subbutton.UseVisualStyleBackColor = True
        '
        'divButton
        '
        Me.divButton.Location = New System.Drawing.Point(253, 266)
        Me.divButton.Name = "divButton"
        Me.divButton.Size = New System.Drawing.Size(88, 23)
        Me.divButton.TabIndex = 8
        Me.divButton.Text = "divsion"
        Me.divButton.UseVisualStyleBackColor = True
        '
        'powButton
        '
        Me.powButton.Location = New System.Drawing.Point(145, 266)
        Me.powButton.Name = "powButton"
        Me.powButton.Size = New System.Drawing.Size(99, 23)
        Me.powButton.TabIndex = 9
        Me.powButton.Text = "power"
        Me.powButton.UseVisualStyleBackColor = True
        '
        'modButton
        '
        Me.modButton.Location = New System.Drawing.Point(253, 206)
        Me.modButton.Name = "modButton"
        Me.modButton.Size = New System.Drawing.Size(88, 23)
        Me.modButton.TabIndex = 10
        Me.modButton.Text = "mod"
        Me.modButton.UseVisualStyleBackColor = True
        '
        'calculater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 450)
        Me.Controls.Add(Me.modButton)
        Me.Controls.Add(Me.powButton)
        Me.Controls.Add(Me.divButton)
        Me.Controls.Add(Me.subbutton)
        Me.Controls.Add(Me.multiButton)
        Me.Controls.Add(Me.Resultaddtwonumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.number2textbox)
        Me.Controls.Add(Me.number1textbox)
        Me.Name = "calculater"
        Me.Text = "calculater"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents number1textbox As TextBox
    Friend WithEvents number2textbox As TextBox
    Friend WithEvents AddButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Resultaddtwonumber As Label
    Friend WithEvents multiButton As Button
    Friend WithEvents subbutton As Button
    Friend WithEvents divButton As Button
    Friend WithEvents powButton As Button
    Friend WithEvents modButton As Button
End Class
