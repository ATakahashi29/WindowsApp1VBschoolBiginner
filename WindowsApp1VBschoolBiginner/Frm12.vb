Public Class Frm12
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'If TextBox1.Text = "夏目漱石" Then
        '    MsgBox("代表作は「吾輩は猫である」")
        'ElseIf TextBox1.Text = "森鴎外" Then
        '    MsgBox("代表作は「舞姫」")
        'ElseIf TextBox1.Text = "志賀直哉" Then
        '    MsgBox("代表作は「城の崎にて」")
        'ElseIf TextBox1.Text = "太宰治" Then
        '    MsgBox("代表作は「走れメロス」")
        'Else
        '    MsgBox("データベースに該当項目がありません。")
        'End If

        '↓If文でかくと
        Select Case TextBox1.Text
            Case "夏目漱石"
                MsgBox("代表作は「吾輩は猫である」")
            Case "森鴎外"
                MsgBox("代表作は「舞姫」")
            Case "志賀直哉"
                MsgBox("代表作は「城の崎にて」")
            Case "太宰治"
                MsgBox("代表作は「走れメロス」")
            Case Else
                MsgBox("データベースに該当項目がありません。")
        End Select
    End Sub
End Class