Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'MsgBox("Hello! World")

        '↓書き換え
        Dim message As String
        message = "Hello! World"

        MsgBox(message)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ''文字列型
        'Dim userName As String
        'userName = "冨田勲"

        ''数値型(整数型)
        'Dim accessCount As Integer
        'accessCount = 12

        ''日付型
        'Dim birthDay As Date
        'birthDay = #4/22/1932#

        '一行で入力可能
        '文字列型
        Dim userName As String = "冨田勲"

        '数値型(整数型)
        Dim accessCount As Integer = 12

        '日付型
        Dim birthDay As Date = #4/22/1932#

        '整数型
        Dim x As Integer
        x = 1 + 2
        x = 12 * 3

        '倍精度浮動小数点型(小数を扱える数値型)
        Dim y As Double
        y = 9 / 2 '4.5
        y = Math.Sqrt(81) '81の平方根の9

        '文字列型
        Dim st As String
        st = "A" & "B" 'ABになります。

        '日付型
        Dim day As Date
        day = #6/27/2020#.AddDays(1) '2020/6/28になります。

        '変数初期化処理
        Dim userName2 As String = ""
        MsgBox(userName2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '宣言
        Dim userName As String
        '代入
        userName = "徳川家康"
        '参照
        MsgBox(userName)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Const userName As String = "豊臣秀吉"
        MsgBox(userName)
    End Sub

    'Private Sub Button5_Click(sender As Object, e As EventArgs)
    '   TextBox1.TextAlign = HorizontalAlignment.Right
    'End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox1.TextAlign = HorizontalAlignment.Right
    End Sub
End Class