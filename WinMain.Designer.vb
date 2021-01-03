<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WinMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WinMain))
        Me.DtsMain = New System.Data.DataSet()
        Me.DttConfig = New System.Data.DataTable()
        Me.DtcIDc = New System.Data.DataColumn()
        Me.DtcValueInteval = New System.Data.DataColumn()
        Me.DtcValueTime = New System.Data.DataColumn()
        Me.DtcAsInteval = New System.Data.DataColumn()
        Me.DtcEnable = New System.Data.DataColumn()
        Me.DtcTag = New System.Data.DataColumn()
        Me.DtcConfiged = New System.Data.DataColumn()
        Me.DttStatus = New System.Data.DataTable()
        Me.DtcIDs = New System.Data.DataColumn()
        Me.DtcStatus = New System.Data.DataColumn()
        Me.DtcSpan = New System.Data.DataColumn()
        Me.LblNow = New System.Windows.Forms.Label()
        Me.BtnAllOn = New System.Windows.Forms.Button()
        Me.BtnAllOff = New System.Windows.Forms.Button()
        Me.BtnAllClear = New System.Windows.Forms.Button()
        Me.BtnTinyClock = New System.Windows.Forms.Button()
        Me.BtnLoad = New System.Windows.Forms.Button()
        Me.TmrInit = New System.Windows.Forms.Timer(Me.components)
        Me.TmrMain = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.SfdMain = New System.Windows.Forms.SaveFileDialog()
        Me.OfdMain = New System.Windows.Forms.OpenFileDialog()
        Me.BtnWordClock = New System.Windows.Forms.Button()
        Me.BtnAuthor = New System.Windows.Forms.Button()
        Me.NtiMain = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.BtnSave = New System.Windows.Forms.Button()
        CType(Me.DtsMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DttConfig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DttStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DtsMain
        '
        Me.DtsMain.DataSetName = "DtsMain"
        Me.DtsMain.Tables.AddRange(New System.Data.DataTable() {Me.DttConfig, Me.DttStatus})
        '
        'DttConfig
        '
        Me.DttConfig.Columns.AddRange(New System.Data.DataColumn() {Me.DtcIDc, Me.DtcValueInteval, Me.DtcValueTime, Me.DtcAsInteval, Me.DtcEnable, Me.DtcTag, Me.DtcConfiged})
        Me.DttConfig.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("DtctConfigChar", New String() {"DtcTag"}, False), New System.Data.UniqueConstraint("CtctIDc", New String() {"DtcIDc"}, True)})
        Me.DttConfig.PrimaryKey = New System.Data.DataColumn() {Me.DtcIDc}
        Me.DttConfig.TableName = "DttConfig"
        '
        'DtcIDc
        '
        Me.DtcIDc.AllowDBNull = False
        Me.DtcIDc.Caption = "DtcIDc"
        Me.DtcIDc.ColumnName = "DtcIDc"
        Me.DtcIDc.DataType = GetType(Byte)
        '
        'DtcValueInteval
        '
        Me.DtcValueInteval.Caption = "DtcValueInteval"
        Me.DtcValueInteval.ColumnName = "DtcValueInteval"
        Me.DtcValueInteval.DataType = GetType(System.TimeSpan)
        '
        'DtcValueTime
        '
        Me.DtcValueTime.Caption = "DtcValueTime"
        Me.DtcValueTime.ColumnName = "DtcValueTime"
        Me.DtcValueTime.DataType = GetType(Date)
        '
        'DtcAsInteval
        '
        Me.DtcAsInteval.Caption = "DtcAsInteval"
        Me.DtcAsInteval.ColumnName = "DtcAsInteval"
        Me.DtcAsInteval.DataType = GetType(Boolean)
        '
        'DtcEnable
        '
        Me.DtcEnable.Caption = "DtcEnable"
        Me.DtcEnable.ColumnName = "DtcEnable"
        Me.DtcEnable.DataType = GetType(Boolean)
        '
        'DtcTag
        '
        Me.DtcTag.Caption = "DtcTag"
        Me.DtcTag.ColumnName = "DtcTag"
        Me.DtcTag.DataType = GetType(Char)
        '
        'DtcConfiged
        '
        Me.DtcConfiged.Caption = "DtcConfiged"
        Me.DtcConfiged.ColumnName = "DtcConfiged"
        Me.DtcConfiged.DataType = GetType(Boolean)
        '
        'DttStatus
        '
        Me.DttStatus.Columns.AddRange(New System.Data.DataColumn() {Me.DtcIDs, Me.DtcStatus, Me.DtcSpan})
        Me.DttStatus.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("DtctIDs", New String() {"DtcIDs"}, True)})
        Me.DttStatus.PrimaryKey = New System.Data.DataColumn() {Me.DtcIDs}
        Me.DttStatus.TableName = "DttStatus"
        '
        'DtcIDs
        '
        Me.DtcIDs.AllowDBNull = False
        Me.DtcIDs.Caption = "DtcIDs"
        Me.DtcIDs.ColumnName = "DtcIDs"
        Me.DtcIDs.DataType = GetType(Byte)
        '
        'DtcStatus
        '
        Me.DtcStatus.Caption = "DtcStatus"
        Me.DtcStatus.ColumnName = "DtcStatus"
        Me.DtcStatus.DataType = GetType(Byte)
        '
        'DtcSpan
        '
        Me.DtcSpan.Caption = "DtcSpan"
        Me.DtcSpan.ColumnName = "DtcSpan"
        Me.DtcSpan.DataType = GetType(System.TimeSpan)
        '
        'LblNow
        '
        Me.LblNow.AutoSize = True
        Me.LblNow.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNow.Location = New System.Drawing.Point(13, 13)
        Me.LblNow.Margin = New System.Windows.Forms.Padding(4)
        Me.LblNow.Name = "LblNow"
        Me.LblNow.Size = New System.Drawing.Size(467, 37)
        Me.LblNow.TabIndex = 0
        Me.LblNow.Text = "Adjusting Time: 000 ms..."
        '
        'BtnAllOn
        '
        Me.BtnAllOn.Enabled = False
        Me.BtnAllOn.Location = New System.Drawing.Point(778, 113)
        Me.BtnAllOn.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAllOn.Name = "BtnAllOn"
        Me.BtnAllOn.Size = New System.Drawing.Size(112, 42)
        Me.BtnAllOn.TabIndex = 95
        Me.BtnAllOn.Tag = "True"
        Me.BtnAllOn.Text = "ALL ON"
        Me.BtnAllOn.UseVisualStyleBackColor = True
        '
        'BtnAllOff
        '
        Me.BtnAllOff.Enabled = False
        Me.BtnAllOff.Location = New System.Drawing.Point(778, 163)
        Me.BtnAllOff.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAllOff.Name = "BtnAllOff"
        Me.BtnAllOff.Size = New System.Drawing.Size(112, 42)
        Me.BtnAllOff.TabIndex = 96
        Me.BtnAllOff.Tag = "False"
        Me.BtnAllOff.Text = "ALL OFF"
        Me.BtnAllOff.UseVisualStyleBackColor = True
        '
        'BtnAllClear
        '
        Me.BtnAllClear.Enabled = False
        Me.BtnAllClear.Location = New System.Drawing.Point(778, 213)
        Me.BtnAllClear.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAllClear.Name = "BtnAllClear"
        Me.BtnAllClear.Size = New System.Drawing.Size(112, 42)
        Me.BtnAllClear.TabIndex = 97
        Me.BtnAllClear.Text = "ALL CLEAR"
        Me.BtnAllClear.UseVisualStyleBackColor = True
        '
        'BtnTinyClock
        '
        Me.BtnTinyClock.Enabled = False
        Me.BtnTinyClock.Location = New System.Drawing.Point(778, 63)
        Me.BtnTinyClock.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnTinyClock.Name = "BtnTinyClock"
        Me.BtnTinyClock.Size = New System.Drawing.Size(112, 42)
        Me.BtnTinyClock.TabIndex = 94
        Me.BtnTinyClock.Text = "TINY CLOCK"
        Me.BtnTinyClock.UseVisualStyleBackColor = True
        '
        'BtnLoad
        '
        Me.BtnLoad.Enabled = False
        Me.BtnLoad.Location = New System.Drawing.Point(778, 263)
        Me.BtnLoad.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnLoad.Name = "BtnLoad"
        Me.BtnLoad.Size = New System.Drawing.Size(112, 43)
        Me.BtnLoad.TabIndex = 98
        Me.BtnLoad.Text = "LOAD ALARM"
        Me.BtnLoad.UseVisualStyleBackColor = True
        '
        'TmrInit
        '
        Me.TmrInit.Interval = 10
        '
        'TmrMain
        '
        Me.TmrMain.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "#"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(131, 58)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 19)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Distance"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 58)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 19)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Alarming"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(423, 58)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 19)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Alarming"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(512, 58)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 19)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Distance"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(397, 58)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(18, 19)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "#"
        '
        'SfdMain
        '
        Me.SfdMain.DefaultExt = "xml"
        Me.SfdMain.Filter = "XML File (*.xml)|*.xml"
        Me.SfdMain.Title = "Save Alarm - Multi Timer"
        '
        'OfdMain
        '
        Me.OfdMain.Filter = "XML File (*.xml)|*.xml"
        Me.OfdMain.Title = "Load Alarm - Multi Timer"
        '
        'BtnWordClock
        '
        Me.BtnWordClock.Enabled = False
        Me.BtnWordClock.Location = New System.Drawing.Point(778, 13)
        Me.BtnWordClock.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnWordClock.Name = "BtnWordClock"
        Me.BtnWordClock.Size = New System.Drawing.Size(112, 42)
        Me.BtnWordClock.TabIndex = 93
        Me.BtnWordClock.Text = "WORD CLOCK"
        Me.BtnWordClock.UseVisualStyleBackColor = True
        '
        'BtnAuthor
        '
        Me.BtnAuthor.Location = New System.Drawing.Point(632, 13)
        Me.BtnAuthor.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAuthor.Name = "BtnAuthor"
        Me.BtnAuthor.Size = New System.Drawing.Size(138, 42)
        Me.BtnAuthor.TabIndex = 100
        Me.BtnAuthor.Text = "AUTHOR INFO"
        Me.BtnAuthor.UseVisualStyleBackColor = True
        '
        'NtiMain
        '
        Me.NtiMain.Icon = CType(resources.GetObject("NtiMain.Icon"), System.Drawing.Icon)
        Me.NtiMain.Text = "Multi Timer"
        '
        'BtnSave
        '
        Me.BtnSave.Enabled = False
        Me.BtnSave.Location = New System.Drawing.Point(778, 314)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(112, 43)
        Me.BtnSave.TabIndex = 99
        Me.BtnSave.Text = "SAVE ALARM"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'WinMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 370)
        Me.Controls.Add(Me.BtnAuthor)
        Me.Controls.Add(Me.BtnWordClock)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnLoad)
        Me.Controls.Add(Me.BtnTinyClock)
        Me.Controls.Add(Me.BtnAllClear)
        Me.Controls.Add(Me.BtnAllOff)
        Me.Controls.Add(Me.BtnAllOn)
        Me.Controls.Add(Me.LblNow)
        Me.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "WinMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Multi Timer"
        CType(Me.DtsMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DttConfig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DttStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DtsMain As DataSet
    Friend WithEvents DttConfig As DataTable
    Friend WithEvents DtcIDc As DataColumn
    Friend WithEvents DtcValueInteval As DataColumn
    Friend WithEvents DtcValueTime As DataColumn
    Friend WithEvents DtcAsInteval As DataColumn
    Friend WithEvents DtcEnable As DataColumn
    Friend WithEvents DtcTag As DataColumn
    Friend WithEvents LblNow As Label
    Friend WithEvents BtnAllOn As Button
    Friend WithEvents BtnAllOff As Button
    Friend WithEvents BtnAllClear As Button
    Friend WithEvents BtnTinyClock As Button
    Friend WithEvents BtnLoad As Button
    Friend WithEvents TmrInit As Timer
    Friend WithEvents TmrMain As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents DtcConfiged As DataColumn
    Friend WithEvents SfdMain As SaveFileDialog
    Friend WithEvents OfdMain As OpenFileDialog
    Friend WithEvents DttStatus As DataTable
    Friend WithEvents DtcIDs As DataColumn
    Friend WithEvents DtcStatus As DataColumn
    Friend WithEvents DtcSpan As DataColumn
    Friend WithEvents BtnWordClock As Button
    Friend WithEvents BtnAuthor As Button
    Friend WithEvents NtiMain As NotifyIcon
    Friend WithEvents BtnSave As Button
End Class
