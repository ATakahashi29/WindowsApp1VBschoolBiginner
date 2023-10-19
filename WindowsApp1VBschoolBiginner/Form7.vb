Public Class Form7



    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("入力してください。")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim Word = Me.TextBox1.SelectedText
        'If  "あざらし" <> "アザラシ" Then
        If Word <> "アザラシ" Then
            '表示されます。
            MsgBox("ひらがなとカタカナは等しくないです。")
        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim Word2 = Me.TextBox2.SelectedText
        'If "VB" <> "vb" Then
        If Word2 <> "vb" Then
            '表示されます。
            MsgBox("英語の大文字と小文字も等しくないです。")
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text Like "*.vb" Then
            MsgBox("vbファイルですね！")
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text = "Apple" OrElse TextBox4.Text = "Banana" Then
            MsgBox("AppleまたはBananaが入力されています。")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'If ComboBox1.Text = "日本" AndAlso NumericUpDown1.Value >= 20 Then
        '    MsgBox("成人です。")
        'ElseIf ComboBox1.Text = "イギリス" AndAlso NumericUpDown1.Value >= 18 Then
        '    MsgBox("成人です。")
        'Else
        '    MsgBox("未成年です。")
        'End If

        '↓20歳以上は両方ともに成人なので国を考慮する必要ない＝簡略化
        If (ComboBox1.Text = "イギリス" AndAlso NumericUpDown1.Value >= 18) OrElse NumericUpDown1.Value >= 20 Then
            MsgBox("成人です。")
        Else
            MsgBox("未成年です。")
        End If
    End Sub
End Class