Public Class Frm16_2
    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click
        Dim dialog As New FolderBrowserDialog

        dialog.Description = "拡張子を数えるフォルダーを選択してください。"

        'ここでダイアログが表示されます。ユーザーが選択を完了するまでプログラムはこれ以上進みません。
        Dim result As DialogResult = dialog.ShowDialog

        If result = DialogResult.Cancel Then
            'ユーザーがキャンセルを選択した場合何もしません。
            Return
        End If

        'ユーザーが選択したフォルダー名のパスを表示します。
        MsgBox(dialog.SelectedPath,, "選択されたフォルダーのパス")


        'フォルダー内のファイルのパスの一覧を取得
        Dim fileFullPaths As String() = IO.Directory.GetFiles(dialog.SelectedPath)

        lstResult.Items.Clear()



        '拡張子(文字列)をキーに、カウント(数値)を格納するコレクション
        Dim extensions As New Dictionary(Of String, Integer)

        '拡張子を集計
        For Each fileFullPath As String In fileFullPaths
            Dim extension As String = IO.Path.GetExtension(fileFullPath) '拡張子を取得

            If extensions.ContainsKey(extension) = False Then
                'まだこの拡張子が extensions に追加されていなければ カウント 1 で追加する。
                extensions.Add(extension, 1)
            Else
                '既にこの拡張子が extensions 二登録されている場合は、値に１をプラスする。
                extensions(extension) += 1
            End If
        Next


        'ファイル名を拡張子の一覧を表示
        For Each fileFullPath As String In fileFullPaths
            Dim fileName As String = IO.Path.GetFileName(fileFullPath) 'ファイル名を取得
            Dim extension As String = IO.Path.GetExtension(fileFullPath) '拡張子を取得
            lstResult.Items.Add(fileName & " - " & extension)
        Next
    End Sub
End Class