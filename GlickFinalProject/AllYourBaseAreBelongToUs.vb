Public Class AllYourBaseAreBelongToUs

    'Krishna Glick
    'Edwin Harris
    'COP2010, VB
    'Sorry for not having this in the last one.
    'I forgot :(
    'This was a fun class and I wish you the best in the future!
    'Maybe teach a C# one? :D

    'This variable is kinda unnecessary but I like it
    Public baseColor As Color = Me.BackColor

    'New versions of all my forms, gotta keep em synced somehow!
    Dim Multiply As MultTable = New MultTable
    Dim Reverse As BackString = New BackString
    'Need to pass this form over so the BG color is changed. God I hate multiple forms.
    Dim bColor As BGColor = New BGColor(Me)
    Dim Math As MathMagic = New MathMagic

    Private Sub bkString_Click(sender As Object, e As EventArgs) Handles bkString.Click
        'Shows target form and sets it's back color
        Me.Hide()
        Reverse.Show()
        Reverse.BackColor = baseColor
    End Sub

    Private Sub bgColour_Click(sender As Object, e As EventArgs) Handles bgColour.Click
        'Shows target form and sets it's back color
        Me.Hide()
        bColor.Show()
        bColor.BackColor = baseColor
    End Sub

    Private Sub multTable_Click(sender As Object, e As EventArgs) Handles multTable.Click
        'Shows target form and sets it's back color
        Me.Hide()
        Multiply.Show()
        Multiply.BackColor = baseColor
    End Sub

    Private Sub mathMagic_Click(sender As Object, e As EventArgs) Handles mathMagic.Click
        'Shows target form and sets it's back color
        Me.Hide()
        Math.Show()
        Math.BackColor = baseColor
    End Sub
End Class
