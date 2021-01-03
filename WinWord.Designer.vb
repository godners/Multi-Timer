<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WinWord
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WinWord))
        Me.BtnRichClock = New System.Windows.Forms.Button()
        Me.BtnTinyClock = New System.Windows.Forms.Button()
        Me.LblNow = New System.Windows.Forms.Label()
        Me.BtnAuthor = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnRichClock
        '
        Me.BtnRichClock.Location = New System.Drawing.Point(13, 120)
        Me.BtnRichClock.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnRichClock.Name = "BtnRichClock"
        Me.BtnRichClock.Size = New System.Drawing.Size(54, 37)
        Me.BtnRichClock.TabIndex = 95
        Me.BtnRichClock.Text = "RICH"
        Me.BtnRichClock.UseVisualStyleBackColor = True
        '
        'BtnTinyClock
        '
        Me.BtnTinyClock.Location = New System.Drawing.Point(75, 120)
        Me.BtnTinyClock.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnTinyClock.Name = "BtnTinyClock"
        Me.BtnTinyClock.Size = New System.Drawing.Size(54, 37)
        Me.BtnTinyClock.TabIndex = 96
        Me.BtnTinyClock.Text = "TINY"
        Me.BtnTinyClock.UseVisualStyleBackColor = True
        '
        'LblNow
        '
        Me.LblNow.AutoSize = True
        Me.LblNow.Font = New System.Drawing.Font("Consolas", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNow.Location = New System.Drawing.Point(19, 13)
        Me.LblNow.Margin = New System.Windows.Forms.Padding(4)
        Me.LblNow.Name = "LblNow"
        Me.LblNow.Size = New System.Drawing.Size(188, 45)
        Me.LblNow.TabIndex = 97
        Me.LblNow.Text = "--:--:--"
        '
        'BtnAuthor
        '
        Me.BtnAuthor.Location = New System.Drawing.Point(137, 120)
        Me.BtnAuthor.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAuthor.Name = "BtnAuthor"
        Me.BtnAuthor.Size = New System.Drawing.Size(76, 37)
        Me.BtnAuthor.TabIndex = 114
        Me.BtnAuthor.Text = "AUTHOR"
        Me.BtnAuthor.UseVisualStyleBackColor = True
        '
        'WinWord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(226, 170)
        Me.Controls.Add(Me.BtnAuthor)
        Me.Controls.Add(Me.LblNow)
        Me.Controls.Add(Me.BtnRichClock)
        Me.Controls.Add(Me.BtnTinyClock)
        Me.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WinWord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Multi Timer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnRichClock As Button
    Friend WithEvents BtnTinyClock As Button
    Friend WithEvents LblNow As Label
    Friend WithEvents BtnAuthor As Button
End Class
