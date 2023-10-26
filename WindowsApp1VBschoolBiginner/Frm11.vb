Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Frm11
    'Trueになります。
    Dim b1 As Boolean = (1 + 2 = 3)

    'Falseになります。
    Dim b2 As Boolean = (1 + 2 = 4)

    'Falseになります。ABCは３文字なので。
    Dim b3 As Boolean = (Len("ABC") = 0)

    'Trueになります。
    Dim b4 As Boolean = (Len("") = 0)

    'TextBox1の入力内容によってTrueまたはFalseになります。
    Dim b5 As Boolean = (Len(TextBox1.Text) = 0)

    Dim saikoro As Random

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'TextBox1の入力内容によってTrueまたはFalseになります。
        Dim b5 As Boolean = (Len(TextBox1.Text) = 0)
        If b5 Then
            MsgBox("何か入力してください。")
        End If

        If Now.Hour >= 20 Then
            MsgBox("8時を過ぎていますね。もう寝ましょう。")
        End If

        'マウスのボタンの数が5であるか判断する。
        If SystemInformation.MouseButtons = 5 Then
            MsgBox("5ボタンのマウスを使っていますね！")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            MsgBox("チェックされています。")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click
        'sender =イベントを発生させたオブジェクト(コントロール)を指す引数　複数のボタン処理表記は可能だが、良い例ではない→イベントごとに分けて書く　Button1.Click, Button2.Click
        If sender Is Button1 Then
            MsgBox("Button1がクリックされました。")
        Else
            MsgBox("Button2がクリックされました。")
        End If

        'CType(sender, Button).BackColor = Color.Red
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If saikoro Is Nothing Then
            saikoro = New Random
        End If

        MsgBox(saikoro.Next(1, 7))
    End Sub
End Class