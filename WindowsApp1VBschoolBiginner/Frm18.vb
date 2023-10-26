Public Class Frm18
    'タプル＝１つの変数に複数の値(要素)の組み合わせを持つ、呼び出しは「Item」を活用



    Private Sub Frm18_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x = ("あいうえお", 12345, "ABC")
        Debug.WriteLine(x.Item1) 'あいうえお と表示されます。
        Debug.WriteLine(x.Item2) '12345 と表示されます。
        Debug.WriteLine(x.Item3) 'ABC と表示されます。
    End Sub

    'タプルの命名→「:=」の使用、タグ的意味合い
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ieyasu = (Name:="徳川家康", Age:=23)

        Debug.WriteLine(ieyasu.Name) '徳川家康 と表示されます。
        Debug.WriteLine(ieyasu.Age) '23 と表示されます。
    End Sub

    'タプルの実体　＝フレームワークのValueTuple型。
    '→Tupleクラスもある。使いたい場合は、一般のフレームワークのクラスとして呼び出す必要
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ieyasu As New Tuple(Of String, Integer)("徳川家康", 23)

        Debug.WriteLine(ieyasu.Item1) '徳川家康 と表示されます。
        Debug.WriteLine(ieyasu.Item2) '23 と表示されます。
    End Sub



    '構造体＝　タプルと異なり、あらかじめ名前をつけて定義→「型」として使用
    '構造体の初期化＝ New 型名 With { }
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ieyasu As New Person
        ieyasu.Name = "徳川家康"
        ieyasu.Age = 23

        Debug.WriteLine(ieyasu.Name) '徳川家康 と表示されます。
        Debug.WriteLine(ieyasu.Age) '23 と表示されます。
    End Sub

    '構造体の初期化＝ New 型名 With { }
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim ieyasu As New With {
            .Name = "徳川家康",
            .Age = 23
        }

        Debug.WriteLine(ieyasu.Name) '徳川家康 と表示されます。
        Debug.WriteLine(ieyasu.Age) '23 と表示されます。
    End Sub
End Class