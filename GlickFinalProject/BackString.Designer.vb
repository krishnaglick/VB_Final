<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BackString
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.reverserBox = New System.Windows.Forms.TextBox()
        Me.reverseIt = New System.Windows.Forms.Button()
        Me.closeIt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter a string to be reversed!"
        '
        'reverserBox
        '
        Me.reverserBox.Location = New System.Drawing.Point(12, 25)
        Me.reverserBox.Name = "reverserBox"
        Me.reverserBox.Size = New System.Drawing.Size(143, 20)
        Me.reverserBox.TabIndex = 1
        '
        'reverseIt
        '
        Me.reverseIt.Location = New System.Drawing.Point(15, 46)
        Me.reverseIt.Name = "reverseIt"
        Me.reverseIt.Size = New System.Drawing.Size(75, 23)
        Me.reverseIt.TabIndex = 2
        Me.reverseIt.Text = "Reverse!"
        Me.reverseIt.UseVisualStyleBackColor = True
        '
        'closeIt
        '
        Me.closeIt.Location = New System.Drawing.Point(96, 46)
        Me.closeIt.Name = "closeIt"
        Me.closeIt.Size = New System.Drawing.Size(75, 23)
        Me.closeIt.TabIndex = 3
        Me.closeIt.Text = "Close"
        Me.closeIt.UseVisualStyleBackColor = True
        '
        'BackString
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(247, 81)
        Me.Controls.Add(Me.closeIt)
        Me.Controls.Add(Me.reverseIt)
        Me.Controls.Add(Me.reverserBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BackString"
        Me.Text = "BackStringBoys"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents reverserBox As System.Windows.Forms.TextBox
    Friend WithEvents reverseIt As System.Windows.Forms.Button
    Friend WithEvents closeIt As System.Windows.Forms.Button
End Class
