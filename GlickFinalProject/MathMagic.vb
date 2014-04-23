Public Class MathMagic

    Private Sub btnByRef_Click(sender As Object, e As EventArgs) Handles btnByRef.Click
        'Passing value by ref
        calcByRef(inputMathMagic.Value)
    End Sub

    Sub calcByRef(ByRef input As Double)
        'Square input, convert to string, pop it up.
        'Conversion is because.
        MsgBox(CStr(input ^ 2))
    End Sub

    Private Sub closeMe_Click(sender As Object, e As EventArgs) Handles closeMe.Click
        'Hide this, open main form.
        Me.Hide()
        inputMathMagic.Value = 0
        AllYourBaseAreBelongToUs.Show()
    End Sub

    Private Sub btnByFunction_Click(sender As Object, e As EventArgs) Handles btnByFunction.Click
        'Just square raw input.
        'Kinda a cop-out using numericUpDown but
        'it was that or catching user input in a text box
        'with e.input and why not just use this?
        MsgBox(inputMathMagic.Value ^ 2)
    End Sub

    Private Sub MathMagic_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Catch use of the X click. Had to stop it from disposing itself!
        e.Cancel = True
        closeMe_Click(Nothing, Nothing)
    End Sub
End Class