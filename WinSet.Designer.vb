<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WinSet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WinSet))
        Me.RdbTime = New System.Windows.Forms.RadioButton()
        Me.RdbInteval = New System.Windows.Forms.RadioButton()
        Me.NudHour = New System.Windows.Forms.NumericUpDown()
        Me.NudMinute = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NudSecond = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnON = New System.Windows.Forms.Button()
        Me.BtnSet = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        CType(Me.NudHour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudMinute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudSecond, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RdbTime
        '
        Me.RdbTime.AutoSize = True
        Me.RdbTime.Checked = True
        Me.RdbTime.Location = New System.Drawing.Point(13, 13)
        Me.RdbTime.Margin = New System.Windows.Forms.Padding(4)
        Me.RdbTime.Name = "RdbTime"
        Me.RdbTime.Size = New System.Drawing.Size(99, 23)
        Me.RdbTime.TabIndex = 1
        Me.RdbTime.TabStop = True
        Me.RdbTime.Tag = "0"
        Me.RdbTime.Text = "&Alarming"
        Me.RdbTime.UseVisualStyleBackColor = True
        '
        'RdbInteval
        '
        Me.RdbInteval.AutoSize = True
        Me.RdbInteval.Location = New System.Drawing.Point(126, 13)
        Me.RdbInteval.Margin = New System.Windows.Forms.Padding(4)
        Me.RdbInteval.Name = "RdbInteval"
        Me.RdbInteval.Size = New System.Drawing.Size(90, 23)
        Me.RdbInteval.TabIndex = 2
        Me.RdbInteval.Tag = "1"
        Me.RdbInteval.Text = "&Inteval"
        Me.RdbInteval.UseVisualStyleBackColor = True
        '
        'NudHour
        '
        Me.NudHour.Location = New System.Drawing.Point(13, 44)
        Me.NudHour.Margin = New System.Windows.Forms.Padding(4)
        Me.NudHour.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.NudHour.Name = "NudHour"
        Me.NudHour.Size = New System.Drawing.Size(45, 26)
        Me.NudHour.TabIndex = 3
        Me.NudHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NudMinute
        '
        Me.NudMinute.Location = New System.Drawing.Point(92, 44)
        Me.NudMinute.Margin = New System.Windows.Forms.Padding(4)
        Me.NudMinute.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.NudMinute.Name = "NudMinute"
        Me.NudMinute.Size = New System.Drawing.Size(45, 26)
        Me.NudMinute.TabIndex = 4
        Me.NudMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = ":"
        '
        'NudSecond
        '
        Me.NudSecond.Location = New System.Drawing.Point(171, 44)
        Me.NudSecond.Margin = New System.Windows.Forms.Padding(4)
        Me.NudSecond.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.NudSecond.Name = "NudSecond"
        Me.NudSecond.Size = New System.Drawing.Size(45, 26)
        Me.NudSecond.TabIndex = 6
        Me.NudSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(145, 46)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = ":"
        '
        'BtnON
        '
        Me.BtnON.Location = New System.Drawing.Point(13, 78)
        Me.BtnON.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnON.Name = "BtnON"
        Me.BtnON.Size = New System.Drawing.Size(62, 27)
        Me.BtnON.TabIndex = 8
        Me.BtnON.Text = "&ON"
        Me.BtnON.UseVisualStyleBackColor = True
        '
        'BtnSet
        '
        Me.BtnSet.Location = New System.Drawing.Point(83, 78)
        Me.BtnSet.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSet.Name = "BtnSet"
        Me.BtnSet.Size = New System.Drawing.Size(62, 27)
        Me.BtnSet.TabIndex = 9
        Me.BtnSet.Text = "&SET"
        Me.BtnSet.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(153, 78)
        Me.BtnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(63, 27)
        Me.BtnClear.TabIndex = 10
        Me.BtnClear.Text = "&CLEAR"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'WinSet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(229, 118)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnSet)
        Me.Controls.Add(Me.BtnON)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NudSecond)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NudMinute)
        Me.Controls.Add(Me.NudHour)
        Me.Controls.Add(Me.RdbInteval)
        Me.Controls.Add(Me.RdbTime)
        Me.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WinSet"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "WinSet"
        CType(Me.NudHour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudMinute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudSecond, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RdbTime As RadioButton
    Friend WithEvents RdbInteval As RadioButton
    Friend WithEvents NudHour As NumericUpDown
    Friend WithEvents NudMinute As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents NudSecond As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnON As Button
    Friend WithEvents BtnSet As Button
    Friend WithEvents BtnClear As Button
End Class
