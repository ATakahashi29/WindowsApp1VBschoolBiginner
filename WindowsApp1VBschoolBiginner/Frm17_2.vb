Public Class Frm17_2
    Private Sub Frm17_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim animals As New Queue(Of String)
        '項目追加 = Enqueue　
        animals.Enqueue("アメンボ")
        animals.Enqueue("イノシシ")
        animals.Enqueue("ウマ")

        '項目取り出し = Dequeue Dequeueで取り出した項目はQueueからは削除
        Dim result1 As String = animals.Dequeue
        Debug.WriteLine(result1) 'アメンボ

        Dim result2 As String = animals.Dequeue
        Debug.WriteLine(result2) 'イノシシ
        '値を取り出さずに先頭の項目を取得するPeekメソッド
    End Sub

    '列挙　For　Next文
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim kanjis As New List(Of String)

        kanjis.Add("国")
        kanjis.Add("学")
        kanjis.Add("宝")
        kanjis.Add("殴")

#If NETCOREAPP Then
    '.NET Core/.NET 5以降の場合
    System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance)
#End If

        For Each kanji As String In kanjis
            Dim newType As String '新字体
            Dim oldType As String '旧字体

            newType = kanji
            oldType = StrConv(kanji, VbStrConv.TraditionalChinese)
            Debug.WriteLine(newType & " - " & oldType)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dic1 As New Dictionary(Of String, String)
        dic1.Add("あ", "あめんぼ")
        dic1.Add("い", "いのしし")
        dic1.Add("う", "うま")

        Dim dic2 As New Dictionary(Of String, String)
        dic2.Add("あ", "あめんぼ")
        dic2.Add("か", "からす")
        dic2.Add("う", "うぐいす")

        'dic1の中でdic2に含まれていないものだけを取得
        Dim results = dic1.Except(dic2)

        For Each result In results
            Debug.WriteLine(result)
        Next
    End Sub
End Class