<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BGColor
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
        Me.changeColor = New System.Windows.Forms.Button()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'changeColor
        '
        Me.changeColor.Location = New System.Drawing.Point(12, 12)
        Me.changeColor.Name = "changeColor"
        Me.changeColor.Size = New System.Drawing.Size(91, 23)
        Me.changeColor.TabIndex = 0
        Me.changeColor.Text = "Change Color"
        Me.changeColor.UseVisualStyleBackColor = True
        '
        'closeButton
        '
        Me.closeButton.Location = New System.Drawing.Point(114, 12)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(91, 23)
        Me.closeButton.TabIndex = 1
        Me.closeButton.Text = "Close"
        Me.closeButton.UseVisualStyleBackColor = True
        '
        'BGColor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(217, 39)
        Me.Controls.Add(Me.closeButton)
        Me.Controls.Add(Me.changeColor)
        Me.Name = "BGColor"
        Me.Text = "BGColor"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents changeColor As System.Windows.Forms.Button
    Friend WithEvents closeButton As System.Windows.Forms.Button
End Class
