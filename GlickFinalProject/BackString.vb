Public Class BackString

    Private Sub reverseIt_Click(sender As Object, e As EventArgs) Handles reverseIt.Click
        'Gotta love in-built functions!
        MsgBox(StrReverse(reverserBox.Text))
    End Sub

    Private Sub closeIt_Click(sender As Object, e As EventArgs) Handles closeIt.Click
        'Hide this, open main form.
        Me.Hide()
        reverserBox.Clear()
        AllYourBaseAreBelongToUs.Show()
    End Sub

    Private Sub returnToMain_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Catch use of the X click. Had to stop it from disposing itself!
        e.Cancel = True
        closeIt_Click(Nothing, Nothing)
    End Sub
End Class