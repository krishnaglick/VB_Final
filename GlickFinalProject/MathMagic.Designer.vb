<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MathMagic
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
        Me.inputMathMagic = New System.Windows.Forms.NumericUpDown()
        Me.btnByRef = New System.Windows.Forms.Button()
        Me.btnByFunction = New System.Windows.Forms.Button()
        Me.closeMe = New System.Windows.Forms.Button()
        CType(Me.inputMathMagic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'inputMathMagic
        '
        Me.inputMathMagic.Location = New System.Drawing.Point(12, 12)
        Me.inputMathMagic.Maximum = New Decimal(New Integer() {1569325056, 23283064, 0, 0})
        Me.inputMathMagic.Minimum = New Decimal(New Integer() {1569325056, 23283064, 0, -2147483648})
        Me.inputMathMagic.Name = "inputMathMagic"
        Me.inputMathMagic.Size = New System.Drawing.Size(49, 20)
        Me.inputMathMagic.TabIndex = 0
        '
        'btnByRef
        '
        Me.btnByRef.Location = New System.Drawing.Point(67, 12)
        Me.btnByRef.Name = "btnByRef"
        Me.btnByRef.Size = New System.Drawing.Size(75, 23)
        Me.btnByRef.TabIndex = 1
        Me.btnByRef.Text = "Sq By Ref"
        Me.btnByRef.UseVisualStyleBackColor = True
        '
        'btnByFunction
        '
        Me.btnByFunction.Location = New System.Drawing.Point(148, 12)
        Me.btnByFunction.Name = "btnByFunction"
        Me.btnByFunction.Size = New System.Drawing.Size(75, 23)
        Me.btnByFunction.TabIndex = 2
        Me.btnByFunction.Text = "Sq By Func"
        Me.btnByFunction.UseVisualStyleBackColor = True
        '
        'closeMe
        '
        Me.closeMe.Location = New System.Drawing.Point(12, 41)
        Me.closeMe.Name = "closeMe"
        Me.closeMe.Size = New System.Drawing.Size(75, 23)
        Me.closeMe.TabIndex = 3
        Me.closeMe.Text = "Close"
        Me.closeMe.UseVisualStyleBackColor = True
        '
        'MathMagic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(236, 75)
        Me.Controls.Add(Me.closeMe)
        Me.Controls.Add(Me.btnByFunction)
        Me.Controls.Add(Me.btnByRef)
        Me.Controls.Add(Me.inputMathMagic)
        Me.Name = "MathMagic"
        Me.Text = "MathMagic"
        CType(Me.inputMathMagic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents inputMathMagic As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnByRef As System.Windows.Forms.Button
    Friend WithEvents btnByFunction As System.Windows.Forms.Button
    Friend WithEvents closeMe As System.Windows.Forms.Button
End Class
