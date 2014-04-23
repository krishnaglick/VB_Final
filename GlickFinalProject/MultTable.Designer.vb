<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MultTable
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
        Me.comboH = New System.Windows.Forms.ComboBox()
        Me.comboV = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.generateTable = New System.Windows.Forms.Button()
        Me.returnToMain = New System.Windows.Forms.Button()
        Me.tableBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'comboH
        '
        Me.comboH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboH.FormattingEnabled = True
        Me.comboH.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.comboH.Location = New System.Drawing.Point(142, 34)
        Me.comboH.Name = "comboH"
        Me.comboH.Size = New System.Drawing.Size(121, 21)
        Me.comboH.TabIndex = 0
        '
        'comboV
        '
        Me.comboV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboV.FormattingEnabled = True
        Me.comboV.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.comboV.Location = New System.Drawing.Point(15, 34)
        Me.comboV.Name = "comboV"
        Me.comboV.Size = New System.Drawing.Size(121, 21)
        Me.comboV.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Vertical Row"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(139, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Horizontal Row"
        '
        'generateTable
        '
        Me.generateTable.Location = New System.Drawing.Point(288, 34)
        Me.generateTable.Name = "generateTable"
        Me.generateTable.Size = New System.Drawing.Size(75, 23)
        Me.generateTable.TabIndex = 4
        Me.generateTable.Text = "Make Table"
        Me.generateTable.UseVisualStyleBackColor = True
        '
        'returnToMain
        '
        Me.returnToMain.Location = New System.Drawing.Point(379, 34)
        Me.returnToMain.Name = "returnToMain"
        Me.returnToMain.Size = New System.Drawing.Size(75, 23)
        Me.returnToMain.TabIndex = 5
        Me.returnToMain.Text = "Close"
        Me.returnToMain.UseVisualStyleBackColor = True
        '
        'tableBox
        '
        Me.tableBox.FormattingEnabled = True
        Me.tableBox.Location = New System.Drawing.Point(15, 62)
        Me.tableBox.Name = "tableBox"
        Me.tableBox.Size = New System.Drawing.Size(454, 290)
        Me.tableBox.TabIndex = 6
        '
        'MultTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 364)
        Me.Controls.Add(Me.tableBox)
        Me.Controls.Add(Me.returnToMain)
        Me.Controls.Add(Me.generateTable)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.comboV)
        Me.Controls.Add(Me.comboH)
        Me.Name = "MultTable"
        Me.Text = "MultTable"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents comboH As System.Windows.Forms.ComboBox
    Friend WithEvents comboV As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents generateTable As System.Windows.Forms.Button
    Friend WithEvents returnToMain As System.Windows.Forms.Button
    Friend WithEvents tableBox As System.Windows.Forms.ListBox
End Class
