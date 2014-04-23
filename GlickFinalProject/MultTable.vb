Public Class MultTable

    Private Sub generateTable_Click(sender As Object, e As EventArgs) Handles generateTable.Click
        'This was the hardest to do.
        Dim vert As Integer = CInt(comboV.Text)
        Dim horz As Integer = CInt(comboH.Text)

        'Clear out all the crap lying in the table
        tableBox.Items.Clear()

        Dim r As String = ""
        'Had to manually add the first row otherwise it was just ugly and I didn't
        'get that nice tab in the top left
        For i As Integer = 1 To horz
            r &= vbTab + CStr(i)
        Next
        tableBox.Items.Add(r)

        'Now this was fun. Set the first item in the list to our target number
        'Then add the multiplicatives.
        'Not converting made it act weird
        Dim row As String = ""
        For i As Integer = 1 To vert
            row &= i
            For q As Integer = 1 To horz
                row &= vbTab + CStr(q * i)
            Next
            'Add our row!
            tableBox.Items.Add(row)
            row = ""
        Next

        tableBox.Show()
    End Sub

    Private Sub returnToMain_Click(sender As Object, e As EventArgs) Handles returnToMain.Click
        'Hide this, open main form.
        Me.Hide()
        comboH.SelectedIndex = 0
        comboV.SelectedIndex = 0
        tableBox.Items.Clear()
        AllYourBaseAreBelongToUs.Show()
    End Sub

    Private Sub MultTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Default selection is not what I like. :(
        comboH.SelectedIndex = 0
        comboV.SelectedIndex = 0
    End Sub

    Private Sub returnToMain_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Catch use of the X click. Had to stop it from disposing itself!
        e.Cancel = True
        returnToMain_Click(Nothing, Nothing)
    End Sub
End Class