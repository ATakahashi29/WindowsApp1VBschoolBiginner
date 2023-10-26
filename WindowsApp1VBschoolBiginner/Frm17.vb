Public Class Frm17

    'Dim Stroke As List(Of Point)
    '複数残したいときは
    Dim Strokes As New Stack(Of List(Of Point))

    Private Sub Form17_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim animals As New Stack(Of String)

        '項目追加　→Pushメソッド
        animals.Push("アメンボ")
        animals.Push("イノシシ")
        animals.Push("ウマ")
        '項目取り出し(取得)　→Popメソッド　　取り出したらStackからは削除される
        Dim result1 As String = animals.Pop()
        Debug.WriteLine(result1) 'ウマ

        Dim result2 As String = animals.Pop()
        Debug.WriteLine(result2) 'イノシシ
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown

        'Stroke = New List(Of Point)
        Strokes.Push(New List(Of Point))

    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove

        '何かしらマウスのボタンが押されている場合
        If Control.MouseButtons <> MouseButtons.None Then
            'Stroke.Add(e.Location) 'マウスの位置を最新のストロークに追加
            Strokes.Peek.Add(e.Location) 'マウスの位置を最新のストロークに追加
            PictureBox1.Invalidate() 'PictureBox1の再描画を促す
            btnUndo.Enabled = True '元に戻すボタンを有効化
        End If

    End Sub
    Dim drawPen As New Pen(Color.FromArgb(140, Color.Red), 12)

    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint

        'If Stroke IsNot Nothing Then
        '    'ストロークに含まれるすべてのPointを線で結んだ図形を生成
        '    Dim path As New Drawing2D.GraphicsPath(Stroke.ToArray, Enumerable.Repeat(Of Byte)(1, Stroke.Count).ToArray)
        '    e.Graphics.DrawPath(Pens.Red, path) '生成した図形を描画
        'End If

        'For Each stroke As List(Of Point) In Strokes
        '    'ストロークに含まれるすべてのPointを線で結んだ図形を生成
        '    Dim path As New Drawing2D.GraphicsPath(stroke.ToArray, Enumerable.Repeat(Of Byte)(1, stroke.Count).ToArray)
        '    e.Graphics.DrawPath(drawPen, path) '生成した図形を描画
        'Next

        For Each stroke As List(Of Point) In Strokes

            If stroke.Count <= 1 Then
                '座標が１つ以下のストロークは無視します。
                Continue For
            End If

            'ストロークに含まれるすべてのPointを線で結んだ図形を生成
            Dim path As New Drawing2D.GraphicsPath(stroke.ToArray, Enumerable.Repeat(Of Byte)(1, stroke.Count).ToArray)
            e.Graphics.DrawPath(drawPen, path) '生成した図形を描画
        Next

    End Sub
    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        Strokes.Pop() '最新のストロークを捨てる
        PictureBox1.Invalidate() 'PictureBox1の再描画を促す

        If Strokes.Count = 0 Then
            ''すべてのストロークが捨てられた場合、元に戻すボタンを無効化
            btnUndo.Enabled = False
        End If
    End Sub

End Class