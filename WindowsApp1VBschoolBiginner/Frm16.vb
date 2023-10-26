Imports System.Windows.Forms.AxHost
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Frm16
    '配列とコレクションの違い
    '配列は使う前に要素数を決める必要,コレクションは自動的に要素数を拡張するため何もする必要なし(ReDim)


    Private Sub Frm16_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myList As New List(Of String)
        Dim myList2 As New List(Of Integer)

        Dim countries As New List(Of String) From {"アラビア", "インド", "ウズベキスタン"}

        Dim stars As New List(Of String)
        Dim s As New List(Of String)


        stars.Add("地球")
        stars.Add("火星")
        stars.Add("スピカ")
        stars.Add("ベテルギウス")

        'Listの内容を表示
        Debug.WriteLine(String.Join(Environment.NewLine, stars.ToArray))

        'フォームメンバのグループ化
        'Dim buttonsList As New List(Of Control)
        Dim buttonsList As New List(Of System.Windows.Forms.Button)

        buttonsList.Add(Button1)
        buttonsList.Add(Button2)
        buttonsList.Add(Button3)

        'Listに格納されているボタンをすべて無効にする。(この行はVB2005では動きません。)
        'buttons.ForEach(Sub(button) button.Enabled = False)

        'ボタン以外の混合グループ化
        Dim controlList As New List(Of Control)

        controlList.Add(Button4)
        controlList.Add(TextBox1)
        controlList.Add(ListBox1)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        'AddRange　＝複数をまとめて追加
        Dim planets As New List(Of String)
        planets.Add("地球")
        planets.Add("火星")

        Dim fixedStars As New List(Of String)
        fixedStars.Add("スピカ")
        fixedStars.Add("ベテルギウス")

        Dim stars As New List(Of String)
        stars.AddRange(planets)
        stars.AddRange(fixedStars)

        Debug.WriteLine(stars(0)) '火星と表示されます。
        'Insert = 項目挿入
        stars.Insert(0, "地球") '先頭に「地球」を挿入
        Debug.WriteLine(stars(0)) '地球と表示されます。
        'Remove = 項目削除
        stars.Remove("火星")
        'インデックス指定で削除も可能
        stars.RemoveAt(2)
        'Listの内容を表示
        Debug.WriteLine(String.Join(Environment.NewLine, stars.ToArray))


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim stars3 As New List(Of String)

        stars3.Add("地球")
        stars3.Add("火星")
        stars3.Add("スピカ")
        stars3.Add("ベテルギウス")

        Dim myStar As String
        'myStar = stars.Item(1)
        '.Itemは省略可能
        myStar = stars3(1)


        Debug.WriteLine(myStar)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'Dim 変数　As　New Dictionary(Of キーの型,値の型) From
        '{キーと値を格納}　→　初期化
        Dim names As New Dictionary(Of String, String) From
    {
        {"A", "Apple"},
        {"B", "Banana"},
        {"C", "Cat"}
    }

        '追加　Add使う 
        Dim names2 As New Dictionary(Of String, String)

        names2.Add("江戸幕府", "徳川家康")
        names2.Add("室町幕府", "足利尊氏")
        names2.Add("鎌倉幕府", "源頼朝")
        names2.Add("大和朝廷", "神武天皇")

        '源頼朝 を表示します。
        Debug.WriteLine(names2("鎌倉幕府"))

        'Itemsプロパティを活用した追加(省略可能)
        'names2.Item("江戸幕府") = "徳川家康"
        names2("江戸幕府２") = "徳川家康２"

        '値の変更
        names2("大和朝廷") = "雄略天皇"
        '雄略天皇 を表示します。
        Debug.WriteLine(names2("大和朝廷"))

        '削除　Remove
        'キー「室町幕府」を使って、「足利尊氏」を削除
        names2.Remove("室町幕府")

        '値の一覧を表示。(徳川家康、源頼朝、神武天皇)
        Debug.WriteLine(String.Join(Environment.NewLine, names2.Values.ToArray))

        '値の一つを取得 →Itemプロパティにキーを指定する。
        Dim edoStarter As String
        edoStarter = names2("江戸幕府")

        '徳川家康
        Debug.WriteLine(edoStarter)

        'Dictionaryは同じキーで項目を追加不可  ContainsKeyメソッド使用で活用可能
        Dim names3 As New Dictionary(Of String, String)

        names3.Add("江戸幕府", "徳川家康")
        names3.Add("室町幕府", "足利尊氏")
        names3.Add("鎌倉幕府", "源頼朝")
        names3.Add("大和朝廷", "神武天皇")

        If names3.ContainsKey("鎌倉幕府") Then
            Debug.WriteLine("鎌倉幕府は既にnamesに登録されています。")
        End If

        'キーの一覧を表示 (江戸幕府、室町幕府、…)
        Debug.WriteLine(String.Join(",", names3.Keys.ToArray))

        '値の一覧を表示 (徳川家康、足利尊氏、…)
        Debug.WriteLine(String.Join(",", names3.Values.ToArray))
    End Sub
End Class