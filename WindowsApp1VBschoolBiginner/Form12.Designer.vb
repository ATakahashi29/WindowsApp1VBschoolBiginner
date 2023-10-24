<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form12
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
        Me.components = New System.ComponentModel.Container()
        Me.lblCpu = New System.Windows.Forms.Label()
        Me.picCpu = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picCpu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCpu
        '
        Me.lblCpu.AutoSize = True
        Me.lblCpu.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCpu.Location = New System.Drawing.Point(34, 183)
        Me.lblCpu.Name = "lblCpu"
        Me.lblCpu.Size = New System.Drawing.Size(47, 59)
        Me.lblCpu.TabIndex = 0
        Me.lblCpu.Text = "-"
        '
        'picCpu
        '
        Me.picCpu.BackColor = System.Drawing.Color.LimeGreen
        Me.picCpu.Location = New System.Drawing.Point(147, 148)
        Me.picCpu.Name = "picCpu"
        Me.picCpu.Size = New System.Drawing.Size(558, 135)
        Me.picCpu.TabIndex = 1
        Me.picCpu.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'Form12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.picCpu)
        Me.Controls.Add(Me.lblCpu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form12"
        Me.Text = "CPUメーター"
        CType(Me.picCpu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCpu As Label
    Friend WithEvents picCpu As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
