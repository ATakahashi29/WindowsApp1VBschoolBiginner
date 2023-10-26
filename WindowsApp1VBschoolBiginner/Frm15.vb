Public Class Frm15
    Dim number1 As Integer
    Dim number2 As Integer
    Dim number3 As Integer

    Private Sub Frm15_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        number1 = 101
        number2 = 25
        number3 = 3


        '配列
        Dim number(2) As Integer
        number(0) = 100
        number(1) = 25
        number(2) = 5

        Debug.WriteLine(number1 + number2 + number3)
        Debug.WriteLine(number(0) + number(1) + number(2))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '配列の初期化
        'Dim nations() As String = {"カンボジア", "ミャンマー", "ラオス", "ブルネイ", "パラオ"}
        Dim lines() As String = {"カンボジア", "ミャンマー", "ラオス", "ブルネイ", "パラオ"}

        'Dim numbers() As Integer = {101, 25, 3}
        IO.File.AppendAllLines("D:\temp\test.txt", lines)

        Dim message As String = "この１行を追記したい。"
        IO.File.AppendAllLines("C:\temp\test.txt", {message})
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim nations(4) As String

        nations(0) = "カンボジア"
        nations(1) = "ミャンマー"
        nations(2) = "ラオス"
        nations(3) = "ブルネイ"
        nations(4) = "パラオ"

        For i As Integer = 0 To nations.Length - 1
            Debug.WriteLine(nations(i))
        Next
    End Sub


    Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click
        Dim nations(4) As String

        nations(0) = "カンボジア"
        nations(1) = "ミャンマー"
        nations(2) = "ラオス"
        nations(3) = "ブルネイ"
        nations(4) = "パラオ"

        ListBox1.Items.AddRange(nations)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim names() As String

        ReDim names(2)
        names(0) = "後醍醐天皇"
        Debug.WriteLine(names(0)) '後醍醐天皇 と出力されます。

        ReDim Preserve names(3)
        Debug.WriteLine(names(0)) '後醍醐天皇 と出力されます。
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim nations(4) As String

        nations(0) = "カンボジア"
        nations(1) = "ミャンマー"
        nations(2) = "ラオス"
        nations(3) = "ブルネイ"
        nations(4) = "パラオ"

        For Each nation As String In nations
            Debug.WriteLine(nation)
        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim namesA() As String = {"後醍醐天皇", "カイ・ハンセン", "スタンダ－ル"}
        Dim namesB() As String = namesA.ToArray

        namesA(1) = "ガンジー"

        Debug.WriteLine(namesB(1)) 'カイ・ハンセンと表示されます。
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        '配列リテラルで初期化しているので、宣言時には添字を記述しません-> カンマだけ残る
        Dim cities(,) = {
            {"ニューヨーク", "東京", "エッセン", "大阪", "パリ"},
            {"ニューヨーク", "東京", "エッセン", "大阪", "パリ"},
            {"ニューヨーク", "東京", "大阪", "エッセン", "メキシコシティ"},
            {"東京", "ニューヨーク", "メキシコシティ", "大阪", "サンパウロ"},
            {"東京", "ニューヨーク", "ソウル", "メキシコシティ", "大阪"},
            {"東京", "ニューヨーク", "ソウル", "メキシコシティ", "ジャカルタ"},
            {"東京", "ニューヨーク", "ソウル", "メキシコシティ", "ジャカルタ"}
        }
        Debug.WriteLine(cities(0, 0)) 'ニューヨーク
        Debug.WriteLine(cities(2, 3)) 'エッセン
        Debug.WriteLine(cities(6, 4)) 'ジャカルタ
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'Arrayクラスの主なメンバ
        'Length     レンクス	配列の要素の数を表します。
        'Rank       ランク	    配列の次元の数を表します。
        'GetLength  ゲットレンクス	特定の次元の要素の数を返します。
        'IndexOf    インデックスオブ	前方から要素を検索します。
        'LastIndexOfラストインデックスオブ	後方から要素を検索します。
        'Sort       ソート	要素を並び替えます。

        Dim states(5) As String
        states(0) = "カリフォルニア"
        states(1) = "テキサス"
        states(2) = "ニューヨーク"
        states(3) = "ニューヨーク"
        states(4) = "カリフォルニア"
        states(5) = "ミシシッピ"

        Dim index As Integer
        index = Array.IndexOf(states, "ニューヨーク") '2を返します。

        Dim lastIndex As Integer
        lastIndex = Array.LastIndexOf(states, "カリフォルニア") '4を返します。

        Dim noneIndex As Integer
        noneIndex = Array.LastIndexOf(states, "兵庫") '値が見つからない→　-1を返します。

        Dim names() As String = {"イノシシ", "ウマ", "アメンボ", "オットセイ", "エビ"}

        '配列を結合して１つの文字列に
        Dim line As String = String.Join(",", names)
        Debug.WriteLine(line) 'イノシシ,ウマ,アメンボ,オットセイ,エビ と表示されます。

        '改行付き
        Dim names2() As String = {"イノシシ", "ウマ", "アメンボ", "オットセイ", "エビ"}

        Dim line2 As String = String.Join(Environment.NewLine, names2)
        Debug.WriteLine(line) '５行で出力されます。


        '並べ替え
        '国名と対応する首都名の配列を作成します。
        Dim nations() As String = {"日本", "アメリカ", "韓国", "イギリス"} '国名
        Dim cities() As String = {"東京", "ワシントン", "ソウル", "ロンドン"} '首都名

        '国名を並び替えます。(連動して首都名も並び変わります。)
        Array.Sort(nations, cities)

        '結果を表示します。
        For i As Integer = 0 To nations.Length - 1
            Debug.WriteLine(nations(i) & " の首都は " & cities(i))
        Next
    End Sub
End Class