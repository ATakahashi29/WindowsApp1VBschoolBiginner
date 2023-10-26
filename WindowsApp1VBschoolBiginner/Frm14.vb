Public Class Frm14
    'For～Next　→　回数指定処理
    'Do～Loop　→　無限ループの可能性　(条件指定必須)
    'For Each ～ Next →　コレクションや配列の要素ごとに繰り返し
    Dim cpuCounter As New PerformanceCounter("Processor", "% Processor Time", "_Total")


    Private Sub Form3_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'PerformanceCounterクラス　=　指標を取得　引数にコンストラクター
        'Dim cpuCounter As New PerformanceCounter("Processor", "% Processor Time", "_Total")

        Using cpuCounter As New PerformanceCounter("Processor", "% Processor Time", "_Total")
            cpuCounter.NextValue() '1回目は必ず 0なので呼び出すだけで何もしない。

            Do While Me.Visible
                '0.5秒間なにもしない
                Task.Delay(500).Wait()

                '0.5秒間の間に採取された値を取得
                Dim cpuValue As Integer = CInt(cpuCounter.NextValue())
                'MsgBox("現在のCPU使用率は " & cpuValue.ToString & " %")

                'Disposeメソッド リソースの解放　　PerformanceCounterクラスの解放に必須
                'cpuCounter.Dispose()

                'Usingを活用することでDisposeの自動呼び出しにより簡略化できる
                'ラベルにCPU使用率を表示　→見やすさでボックスサイズをCPU使用率の5倍の幅
                picCpu.Width = cpuValue * 5
                lblCpu.Text = cpuValue.ToString

                Application.DoEvents()
            Loop
        End Using


    End Sub
End Class