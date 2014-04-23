<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AllYourBaseAreBelongToUs
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
        Me.bkString = New System.Windows.Forms.Button()
        Me.bgColour = New System.Windows.Forms.Button()
        Me.multTable = New System.Windows.Forms.Button()
        Me.mathMagic = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bkString
        '
        Me.bkString.Location = New System.Drawing.Point(12, 22)
        Me.bkString.Name = "bkString"
        Me.bkString.Size = New System.Drawing.Size(113, 23)
        Me.bkString.TabIndex = 0
        Me.bkString.Text = "Backwards String"
        Me.bkString.UseVisualStyleBackColor = True
        '
        'bgColour
        '
        Me.bgColour.Location = New System.Drawing.Point(159, 22)
        Me.bgColour.Name = "bgColour"
        Me.bgColour.Size = New System.Drawing.Size(110, 23)
        Me.bgColour.TabIndex = 1
        Me.bgColour.Text = "Background Colour"
        Me.bgColour.UseVisualStyleBackColor = True
        '
        'multTable
        '
        Me.multTable.Location = New System.Drawing.Point(12, 64)
        Me.multTable.Name = "multTable"
        Me.multTable.Size = New System.Drawing.Size(113, 23)
        Me.multTable.TabIndex = 2
        Me.multTable.Text = "Multiplication Table"
        Me.multTable.UseVisualStyleBackColor = True
        '
        'mathMagic
        '
        Me.mathMagic.Location = New System.Drawing.Point(159, 64)
        Me.mathMagic.Name = "mathMagic"
        Me.mathMagic.Size = New System.Drawing.Size(110, 23)
        Me.mathMagic.TabIndex = 3
        Me.mathMagic.Text = "Math Magic"
        Me.mathMagic.UseVisualStyleBackColor = True
        '
        'AllYourBaseAreBelongToUs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 106)
        Me.Controls.Add(Me.mathMagic)
        Me.Controls.Add(Me.multTable)
        Me.Controls.Add(Me.bgColour)
        Me.Controls.Add(Me.bkString)
        Me.Name = "AllYourBaseAreBelongToUs"
        Me.Text = "AllYourFormAreBelongToUs"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bkString As System.Windows.Forms.Button
    Friend WithEvents bgColour As System.Windows.Forms.Button
    Friend WithEvents multTable As System.Windows.Forms.Button
    Friend WithEvents mathMagic As System.Windows.Forms.Button

End Class
