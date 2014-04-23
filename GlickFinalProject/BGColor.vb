Public Class BGColor

    Private main As AllYourBaseAreBelongToUs

    Sub New(ByRef base As AllYourBaseAreBelongToUs)
        'Hold the reference to the main form, also
        'init components was required here. Don't know why though.
        InitializeComponent()
        main = base
    End Sub

    Private Sub changeColor_Click(sender As Object, e As EventArgs) Handles changeColor.Click
        Dim cDialog As New ColorDialog()
        'Create a new color dialog and let the user pick what color
        'they want to use. I don't know if you had your heart set on
        'radio buttons but I hope this will do. Seemed a better way to do things. :)
        cDialog.Color = Me.BackColor()

        If (cDialog.ShowDialog() = DialogResult.OK) Then
            Me.BackColor = cDialog.Color
        End If

        'There doesn't seem to be a good event handle for showing a form
        'that I could get to work right so I just manually set stuff. :(
        main.baseColor = Me.BackColor
        main.BackColor = main.baseColor
    End Sub

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        'Hide this, open main form.
        Me.Hide()
        AllYourBaseAreBelongToUs.Show()
    End Sub

    Private Sub returnToMain_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Catch use of the X click. Had to stop it from disposing itself!
        e.Cancel = True
        closeButton_Click(Nothing, Nothing)
    End Sub
End Class