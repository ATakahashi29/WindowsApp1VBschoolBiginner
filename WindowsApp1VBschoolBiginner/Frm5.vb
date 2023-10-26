Imports System.IO

Public Class Frm5

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        File.WriteAllText("C:\temp\test.txt", "あいうえお！")
    End Sub
End Class