﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rangeofgrade
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
        Me.gardetextbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.convertButton = New System.Windows.Forms.Button()
        Me.resultTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'gardetextbox
        '
        Me.gardetextbox.Location = New System.Drawing.Point(184, 113)
        Me.gardetextbox.Multiline = True
        Me.gardetextbox.Name = "gardetextbox"
        Me.gardetextbox.Size = New System.Drawing.Size(100, 39)
        Me.gardetextbox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "enter your grade "
        '
        'convertButton
        '
        Me.convertButton.Location = New System.Drawing.Point(336, 116)
        Me.convertButton.Name = "convertButton"
        Me.convertButton.Size = New System.Drawing.Size(75, 20)
        Me.convertButton.TabIndex = 2
        Me.convertButton.Text = "Convert"
        Me.convertButton.UseVisualStyleBackColor = True
        '
        'resultTextBox
        '
        Me.resultTextBox.Location = New System.Drawing.Point(455, 109)
        Me.resultTextBox.Multiline = True
        Me.resultTextBox.Name = "resultTextBox"
        Me.resultTextBox.Size = New System.Drawing.Size(151, 43)
        Me.resultTextBox.TabIndex = 3
        '
        'rangeofgrade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.resultTextBox)
        Me.Controls.Add(Me.convertButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gardetextbox)
        Me.Name = "rangeofgrade"
        Me.Text = "rangeofgrade"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gardetextbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents convertButton As Button
    Friend WithEvents resultTextBox As TextBox
End Class
