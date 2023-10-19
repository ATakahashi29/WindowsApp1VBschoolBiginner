<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.btnAnswer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Meiryo UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(158, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1173, 61)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "元禄16年に出版された「曽根崎心中」の作者は誰でしょう？"
        '
        'txtAnswer
        '
        Me.txtAnswer.Font = New System.Drawing.Font("Meiryo UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtAnswer.Location = New System.Drawing.Point(396, 349)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(729, 68)
        Me.txtAnswer.TabIndex = 1
        '
        'btnAnswer
        '
        Me.btnAnswer.Font = New System.Drawing.Font("Meiryo UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnAnswer.Location = New System.Drawing.Point(632, 457)
        Me.btnAnswer.Name = "btnAnswer"
        Me.btnAnswer.Size = New System.Drawing.Size(238, 69)
        Me.btnAnswer.TabIndex = 2
        Me.btnAnswer.Text = "回答する"
        Me.btnAnswer.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1440, 766)
        Me.Controls.Add(Me.btnAnswer)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form5"
        Me.Text = "クイズ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents btnAnswer As Button
End Class
