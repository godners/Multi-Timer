<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WinMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WinMain))
        Me.lblNow = New System.Windows.Forms.Label()
        Me.tmrInit = New System.Windows.Forms.Timer(Me.components)
        Me.TmrMain = New System.Windows.Forms.Timer(Me.components)
        Me.btnAllClr = New System.Windows.Forms.Button()
        Me.btnAllON = New System.Windows.Forms.Button()
        Me.btnAllOFF = New System.Windows.Forms.Button()
        Me.ntiMain = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.btnTiny = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNow
        '
        Me.lblNow.AutoSize = True
        Me.lblNow.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNow.Location = New System.Drawing.Point(13, 13)
        Me.lblNow.Margin = New System.Windows.Forms.Padding(4)
        Me.lblNow.Name = "lblNow"
        Me.lblNow.Size = New System.Drawing.Size(395, 37)
        Me.lblNow.TabIndex = 0
        Me.lblNow.Text = "Loading Exact Time..."
        '
        'tmrInit
        '
        Me.tmrInit.Interval = 10
        '
        'TmrMain
        '
        Me.TmrMain.Interval = 1000
        '
        'btnAllClr
        '
        Me.btnAllClr.Enabled = False
        Me.btnAllClr.Location = New System.Drawing.Point(610, 13)
        Me.btnAllClr.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAllClr.Name = "btnAllClr"
        Me.btnAllClr.Size = New System.Drawing.Size(111, 37)
        Me.btnAllClr.TabIndex = 26
        Me.btnAllClr.Text = "ALL CLEAR"
        Me.btnAllClr.UseVisualStyleBackColor = True
        '
        'btnAllON
        '
        Me.btnAllON.Enabled = False
        Me.btnAllON.Location = New System.Drawing.Point(416, 13)
        Me.btnAllON.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAllON.Name = "btnAllON"
        Me.btnAllON.Size = New System.Drawing.Size(85, 37)
        Me.btnAllON.TabIndex = 24
        Me.btnAllON.Text = "ALL ON"
        Me.btnAllON.UseVisualStyleBackColor = True
        '
        'btnAllOFF
        '
        Me.btnAllOFF.Enabled = False
        Me.btnAllOFF.Location = New System.Drawing.Point(509, 13)
        Me.btnAllOFF.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAllOFF.Name = "btnAllOFF"
        Me.btnAllOFF.Size = New System.Drawing.Size(93, 37)
        Me.btnAllOFF.TabIndex = 25
        Me.btnAllOFF.Text = "ALL OFF"
        Me.btnAllOFF.UseVisualStyleBackColor = True
        '
        'ntiMain
        '
        Me.ntiMain.Icon = CType(resources.GetObject("ntiMain.Icon"), System.Drawing.Icon)
        Me.ntiMain.Text = "Multi Timer"
        '
        'btnTiny
        '
        Me.btnTiny.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnTiny.Enabled = False
        Me.btnTiny.Image = Global.MT.My.Resources.Resources.TinyDis
        Me.btnTiny.Location = New System.Drawing.Point(729, 13)
        Me.btnTiny.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTiny.Name = "btnTiny"
        Me.btnTiny.Size = New System.Drawing.Size(37, 37)
        Me.btnTiny.TabIndex = 27
        Me.btnTiny.UseVisualStyleBackColor = True
        '
        'WinMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 358)
        Me.Controls.Add(Me.btnTiny)
        Me.Controls.Add(Me.btnAllOFF)
        Me.Controls.Add(Me.btnAllON)
        Me.Controls.Add(Me.btnAllClr)
        Me.Controls.Add(Me.lblNow)
        Me.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "WinMain"
        Me.Text = "Multi Timer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNow As Label
    Friend WithEvents tmrInit As Timer
    Friend WithEvents TmrMain As Timer
    Friend WithEvents btnAllClr As Button
    Friend WithEvents btnAllON As Button
    Friend WithEvents btnAllOFF As Button
    Friend WithEvents ntiMain As NotifyIcon
    Friend WithEvents btnTiny As Button
End Class
