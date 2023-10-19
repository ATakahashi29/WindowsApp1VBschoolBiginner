Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form8
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '～否定～
        'Trueになります。
        Dim b1 As Boolean = Not False

        'Falseになります。
        Dim b2 As Boolean = Not b1

        'Falseになります。
        Dim b3 As Boolean = Not (1 + 1 = 2)


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'ショートサーキット

        '条件１：TextBoxの行数が0より大きいか判断しています。条件２：１行目が"Hello"であるかを判断
        '条件１がTrueの上で、条件２を判定する(条件１がfalseの場合条件２は判定しない＝ショートサーキット、短縮評価)
        If TextBox1.Lines.Count > 0 AndAlso TextBox1.Lines(0) = "Hello" Then
            MsgBox("１行目は Hello です。")
        End If

        '一方でAnd,OrはTrueかFalseか確定しても、まだ評価していない式が残っていればとりあえず全部評価する。
        '=TextBox1に何も入力されていない場合、２つ目の条件を評価しようとしてエラーに -> 使わない方が良い
    End Sub
End Class