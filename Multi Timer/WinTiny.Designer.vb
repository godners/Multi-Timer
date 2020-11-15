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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WinTiny))
        Me.LblNow = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblNow
        '
        Me.LblNow.AutoSize = True
        Me.LblNow.Location = New System.Drawing.Point(14, 275)
        Me.LblNow.Margin = New System.Windows.Forms.Padding(4)
        Me.LblNow.Name = "LblNow"
        Me.LblNow.Size = New System.Drawing.Size(198, 19)
        Me.LblNow.TabIndex = 17
        Me.LblNow.Text = "Loading Exact Time..."
        '
        'WinTiny
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(226, 307)
        Me.Controls.Add(Me.LblNow)
        Me.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WinTiny"
        Me.Text = "Multi Timer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents LblNow As Label
End Class
