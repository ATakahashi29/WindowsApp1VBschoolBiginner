Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form15
    '配列とコレクションの違い
    '配列は使う前に要素数を決める必要,コレクションは自動的に要素数を拡張するため何もする必要なし(ReDim)


    Private Sub Form15_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim buttonsList As New List(Of Control)
        'Dim buttonsList As New List(Of Button)

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
End Class