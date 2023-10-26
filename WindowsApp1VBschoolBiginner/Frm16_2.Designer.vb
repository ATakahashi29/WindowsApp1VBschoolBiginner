<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm16_2
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCount = New System.Windows.Forms.Button()
        Me.lstResult = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnCount
        '
        Me.btnCount.Location = New System.Drawing.Point(43, 54)
        Me.btnCount.Name = "btnCount"
        Me.btnCount.Size = New System.Drawing.Size(191, 53)
        Me.btnCount.TabIndex = 0
        Me.btnCount.Text = "フォルダー選択"
        Me.btnCount.UseVisualStyleBackColor = True
        '
        'lstResult
        '
        Me.lstResult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstResult.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lstResult.FormattingEnabled = True
        Me.lstResult.ItemHeight = 36
        Me.lstResult.Location = New System.Drawing.Point(39, 132)
        Me.lstResult.Name = "lstResult"
        Me.lstResult.Size = New System.Drawing.Size(702, 292)
        Me.lstResult.TabIndex = 1
        '
        'Form16
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstResult)
        Me.Controls.Add(Me.btnCount)
        Me.Name = "Form16"
        Me.Text = "16回２　拡張子の統計"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCount As Button
    Friend WithEvents lstResult As ListBox
End Class
