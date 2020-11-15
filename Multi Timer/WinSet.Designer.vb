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
        Me.rdoInt = New System.Windows.Forms.RadioButton()
        Me.rdoTime = New System.Windows.Forms.RadioButton()
        Me.TxtH = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtM = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtS = New System.Windows.Forms.TextBox()
        Me.BtnSet = New System.Windows.Forms.Button()
        Me.btnClr = New System.Windows.Forms.Button()
        Me.BtnON = New System.Windows.Forms.Button()
        Me.lblShown = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'rdoInt
        '
        Me.rdoInt.AutoSize = True
        Me.rdoInt.Location = New System.Drawing.Point(101, 40)
        Me.rdoInt.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoInt.Name = "rdoInt"
        Me.rdoInt.Size = New System.Drawing.Size(99, 23)
        Me.rdoInt.TabIndex = 7
        Me.rdoInt.Text = "Interval"
        Me.rdoInt.UseVisualStyleBackColor = True
        '
        'rdoTime
        '
        Me.rdoTime.AutoSize = True
        Me.rdoTime.Checked = True
        Me.rdoTime.Location = New System.Drawing.Point(13, 40)
        Me.rdoTime.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoTime.Name = "rdoTime"
        Me.rdoTime.Size = New System.Drawing.Size(63, 23)
        Me.rdoTime.TabIndex = 6
        Me.rdoTime.TabStop = True
        Me.rdoTime.Text = "Time"
        Me.rdoTime.UseVisualStyleBackColor = True
        '
        'TxtH
        '
        Me.TxtH.Location = New System.Drawing.Point(13, 71)
        Me.TxtH.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtH.Name = "TxtH"
        Me.TxtH.Size = New System.Drawing.Size(40, 26)
        Me.TxtH.TabIndex = 0
        Me.TxtH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 74)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = ":"
        '
        'TxtM
        '
        Me.TxtM.Location = New System.Drawing.Point(84, 71)
        Me.TxtM.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtM.Name = "TxtM"
        Me.TxtM.Size = New System.Drawing.Size(40, 26)
        Me.TxtM.TabIndex = 1
        Me.TxtM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(132, 74)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = ":"
        '
        'TxtS
        '
        Me.TxtS.Location = New System.Drawing.Point(160, 71)
        Me.TxtS.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtS.Name = "TxtS"
        Me.TxtS.Size = New System.Drawing.Size(40, 26)
        Me.TxtS.TabIndex = 2
        Me.TxtS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnSet
        '
        Me.BtnSet.Location = New System.Drawing.Point(63, 105)
        Me.BtnSet.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSet.Name = "BtnSet"
        Me.BtnSet.Size = New System.Drawing.Size(55, 29)
        Me.BtnSet.TabIndex = 4
        Me.BtnSet.Text = "SET"
        Me.BtnSet.UseVisualStyleBackColor = True
        '
        'btnClr
        '
        Me.btnClr.Location = New System.Drawing.Point(126, 105)
        Me.btnClr.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClr.Name = "btnClr"
        Me.btnClr.Size = New System.Drawing.Size(74, 29)
        Me.btnClr.TabIndex = 5
        Me.btnClr.Text = "CLEAR"
        Me.btnClr.UseVisualStyleBackColor = True
        '
        'BtnON
        '
        Me.BtnON.Location = New System.Drawing.Point(13, 105)
        Me.BtnON.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnON.Name = "BtnON"
        Me.BtnON.Size = New System.Drawing.Size(42, 29)
        Me.BtnON.TabIndex = 3
        Me.BtnON.Text = "ON"
        Me.BtnON.UseVisualStyleBackColor = True
        '
        'lblShown
        '
        Me.lblShown.AutoSize = True
        Me.lblShown.Location = New System.Drawing.Point(13, 13)
        Me.lblShown.Margin = New System.Windows.Forms.Padding(4)
        Me.lblShown.Name = "lblShown"
        Me.lblShown.Size = New System.Drawing.Size(189, 19)
        Me.lblShown.TabIndex = 8
        Me.lblShown.Text = "Shown Time: 88:88:88"
        '
        'WinSet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(213, 147)
        Me.Controls.Add(Me.lblShown)
        Me.Controls.Add(Me.BtnON)
        Me.Controls.Add(Me.btnClr)
        Me.Controls.Add(Me.BtnSet)
        Me.Controls.Add(Me.TxtS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtM)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtH)
        Me.Controls.Add(Me.rdoTime)
        Me.Controls.Add(Me.rdoInt)
        Me.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WinSet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Set 0 - Multi Timer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rdoInt As RadioButton
    Friend WithEvents rdoTime As RadioButton
    Friend WithEvents TxtH As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtM As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtS As TextBox
    Friend WithEvents BtnSet As Button
    Friend WithEvents btnClr As Button
    Friend WithEvents BtnON As Button
    Friend WithEvents lblShown As Label
End Class
