<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WinTiny
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WinTiny))
        Me.BtnAuthor = New System.Windows.Forms.Button()
        Me.BtnRichClock = New System.Windows.Forms.Button()
        Me.BtnWordClock = New System.Windows.Forms.Button()
        Me.TltTiny = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'BtnAuthor
        '
        Me.BtnAuthor.Location = New System.Drawing.Point(137, 275)
        Me.BtnAuthor.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAuthor.Name = "BtnAuthor"
        Me.BtnAuthor.Size = New System.Drawing.Size(76, 37)
        Me.BtnAuthor.TabIndex = 117
        Me.BtnAuthor.Text = "AUTHOR"
        Me.BtnAuthor.UseVisualStyleBackColor = True
        '
        'BtnRichClock
        '
        Me.BtnRichClock.Location = New System.Drawing.Point(13, 275)
        Me.BtnRichClock.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnRichClock.Name = "BtnRichClock"
        Me.BtnRichClock.Size = New System.Drawing.Size(54, 37)
        Me.BtnRichClock.TabIndex = 115
        Me.BtnRichClock.Text = "RICH"
        Me.BtnRichClock.UseVisualStyleBackColor = True
        '
        'BtnWordClock
        '
        Me.BtnWordClock.Location = New System.Drawing.Point(75, 275)
        Me.BtnWordClock.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnWordClock.Name = "BtnWordClock"
        Me.BtnWordClock.Size = New System.Drawing.Size(54, 37)
        Me.BtnWordClock.TabIndex = 116
        Me.BtnWordClock.Text = "WORD"
        Me.BtnWordClock.UseVisualStyleBackColor = True
        '
        'WinTiny
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(226, 325)
        Me.Controls.Add(Me.BtnAuthor)
        Me.Controls.Add(Me.BtnRichClock)
        Me.Controls.Add(Me.BtnWordClock)
        Me.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WinTiny"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Multi Timer"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnAuthor As Button
    Friend WithEvents BtnRichClock As Button
    Friend WithEvents BtnWordClock As Button
    Friend WithEvents TltTiny As ToolTip
End Class
