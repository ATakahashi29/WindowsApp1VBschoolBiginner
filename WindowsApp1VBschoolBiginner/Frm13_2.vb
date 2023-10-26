Public Class Frm13_2
    Private Sub Form13_2_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        e.Graphics.Clear(Color.Black)

        '描画領域の幅を取得
        Dim Yoko As Integer = Me.ClientSize.Width - 1

        '描画領域の高さを取得
        Dim Tate As Integer = Me.ClientSize.Height - 1

        ''５つの緑の同心円を描画します。
        'e.Graphics.DrawEllipse(Pens.Green, 0, 0, Yoko, Tate)
        'e.Graphics.DrawEllipse(Pens.Green, 10, 10, Yoko - 20, Tate - 20)
        'e.Graphics.DrawEllipse(Pens.Green, 20, 20, Yoko - 40, Tate - 40)
        'e.Graphics.DrawEllipse(Pens.Green, 30, 30, Yoko - 60, Tate - 60)
        'e.Graphics.DrawEllipse(Pens.Green, 40, 40, Yoko - 80, Tate - 80)

        '↓For Nextで書き換え
        ''５つの緑の同心円を描画します。
        'For i As Integer = 0 To 50
        '    Dim deltaLocation As Integer = i * 10
        '    Dim deltaSize As Integer = i * 20
        '    e.Graphics.DrawEllipse(Pens.Green, deltaLocation, deltaLocation, Yoko - deltaSize, Tate - deltaSize)
        'Next

        '200個の同心円を色を交え描画します。
        For i As Integer = 0 To 999 Step 5
            Dim deltaLocation As Integer = i * 2
            Dim deltaSize As Integer = i * 4
            Dim color As Color = Color.FromArgb(i Mod 200 + 55, i Mod 160 + 95, i Mod 123 + 122)
            Dim pen As New Pen(color)

            e.Graphics.DrawEllipse(pen, deltaLocation, deltaLocation, Yoko - deltaSize, Tate - deltaSize)
        Next
    End Sub


    Private Sub Form13_2_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Invalidate()
    End Sub
End Class
