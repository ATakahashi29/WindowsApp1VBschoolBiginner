Public Class Frm6
    Private Sub Frm6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.AppendText("Hello!")
        Dim pos As Point = TextBox.MousePosition
        MsgBox(pos)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class