<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WinAuthor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WinAuthor))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LlbURL = New System.Windows.Forms.LinkLabel()
        Me.PtbAuthor = New System.Windows.Forms.PictureBox()
        Me.PtbITSS = New System.Windows.Forms.PictureBox()
        Me.PtbITIL = New System.Windows.Forms.PictureBox()
        Me.PtbRHCE = New System.Windows.Forms.PictureBox()
        Me.PtbOCP = New System.Windows.Forms.PictureBox()
        Me.PtbVCP = New System.Windows.Forms.PictureBox()
        Me.DtsAuthor = New System.Data.DataSet()
        Me.DttLogo = New System.Data.DataTable()
        Me.DtcIDl = New System.Data.DataColumn()
        Me.DtcTitle = New System.Data.DataColumn()
        Me.DtcContent = New System.Data.DataColumn()
        CType(Me.PtbAuthor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PtbITSS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PtbITIL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PtbRHCE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PtbOCP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PtbVCP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsAuthor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DttLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mr. Tianyue Ren"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 84)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "City: Beijing, China"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 57)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Born: Jan. 1987"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 138)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Certification:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 376)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 19)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Open Source:"
        '
        'LlbURL
        '
        Me.LlbURL.AutoSize = True
        Me.LlbURL.Location = New System.Drawing.Point(42, 403)
        Me.LlbURL.Margin = New System.Windows.Forms.Padding(4)
        Me.LlbURL.Name = "LlbURL"
        Me.LlbURL.Size = New System.Drawing.Size(351, 19)
        Me.LlbURL.TabIndex = 11
        Me.LlbURL.TabStop = True
        Me.LlbURL.Text = "https://github.com/godners/Multi-Timer"
        '
        'PtbAuthor
        '
        Me.PtbAuthor.Location = New System.Drawing.Point(210, 57)
        Me.PtbAuthor.Margin = New System.Windows.Forms.Padding(4)
        Me.PtbAuthor.Name = "PtbAuthor"
        Me.PtbAuthor.Size = New System.Drawing.Size(183, 100)
        Me.PtbAuthor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PtbAuthor.TabIndex = 12
        Me.PtbAuthor.TabStop = False
        Me.PtbAuthor.Tag = "1"
        '
        'PtbITSS
        '
        Me.PtbITSS.Image = Global.Multi_Timer.My.Resources.Resources.ITSS
        Me.PtbITSS.Location = New System.Drawing.Point(217, 301)
        Me.PtbITSS.Margin = New System.Windows.Forms.Padding(4)
        Me.PtbITSS.Name = "PtbITSS"
        Me.PtbITSS.Size = New System.Drawing.Size(176, 67)
        Me.PtbITSS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PtbITSS.TabIndex = 9
        Me.PtbITSS.TabStop = False
        Me.PtbITSS.Tag = "4"
        '
        'PtbITIL
        '
        Me.PtbITIL.Image = Global.Multi_Timer.My.Resources.Resources.ITIL
        Me.PtbITIL.Location = New System.Drawing.Point(13, 301)
        Me.PtbITIL.Margin = New System.Windows.Forms.Padding(4)
        Me.PtbITIL.Name = "PtbITIL"
        Me.PtbITIL.Size = New System.Drawing.Size(196, 67)
        Me.PtbITIL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PtbITIL.TabIndex = 8
        Me.PtbITIL.TabStop = False
        Me.PtbITIL.Tag = "3"
        '
        'PtbRHCE
        '
        Me.PtbRHCE.Image = Global.Multi_Timer.My.Resources.Resources.RHCE
        Me.PtbRHCE.Location = New System.Drawing.Point(13, 165)
        Me.PtbRHCE.Margin = New System.Windows.Forms.Padding(4)
        Me.PtbRHCE.Name = "PtbRHCE"
        Me.PtbRHCE.Size = New System.Drawing.Size(108, 128)
        Me.PtbRHCE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PtbRHCE.TabIndex = 7
        Me.PtbRHCE.TabStop = False
        Me.PtbRHCE.Tag = "2"
        '
        'PtbOCP
        '
        Me.PtbOCP.Image = Global.Multi_Timer.My.Resources.Resources.OCP
        Me.PtbOCP.Location = New System.Drawing.Point(265, 165)
        Me.PtbOCP.Margin = New System.Windows.Forms.Padding(4)
        Me.PtbOCP.Name = "PtbOCP"
        Me.PtbOCP.Size = New System.Drawing.Size(128, 128)
        Me.PtbOCP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PtbOCP.TabIndex = 6
        Me.PtbOCP.TabStop = False
        Me.PtbOCP.Tag = "1"
        '
        'PtbVCP
        '
        Me.PtbVCP.Image = CType(resources.GetObject("PtbVCP.Image"), System.Drawing.Image)
        Me.PtbVCP.Location = New System.Drawing.Point(129, 165)
        Me.PtbVCP.Margin = New System.Windows.Forms.Padding(4)
        Me.PtbVCP.Name = "PtbVCP"
        Me.PtbVCP.Size = New System.Drawing.Size(128, 128)
        Me.PtbVCP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PtbVCP.TabIndex = 5
        Me.PtbVCP.TabStop = False
        Me.PtbVCP.Tag = "0"
        '
        'DtsAuthor
        '
        Me.DtsAuthor.DataSetName = "DtsAuthor"
        Me.DtsAuthor.Tables.AddRange(New System.Data.DataTable() {Me.DttLogo})
        '
        'DttLogo
        '
        Me.DttLogo.Columns.AddRange(New System.Data.DataColumn() {Me.DtcIDl, Me.DtcTitle, Me.DtcContent})
        Me.DttLogo.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"DtcIDl"}, True)})
        Me.DttLogo.PrimaryKey = New System.Data.DataColumn() {Me.DtcIDl}
        Me.DttLogo.TableName = "DttLogo"
        '
        'DtcIDl
        '
        Me.DtcIDl.AllowDBNull = False
        Me.DtcIDl.Caption = "DtcIDl"
        Me.DtcIDl.ColumnName = "DtcIDl"
        Me.DtcIDl.DataType = GetType(Byte)
        '
        'DtcTitle
        '
        Me.DtcTitle.Caption = "DtcTitle"
        Me.DtcTitle.ColumnName = "DtcTitle"
        '
        'DtcContent
        '
        Me.DtcContent.Caption = "DtcContent"
        Me.DtcContent.ColumnName = "DtcContent"
        '
        'WinAuthor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 435)
        Me.Controls.Add(Me.PtbAuthor)
        Me.Controls.Add(Me.LlbURL)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PtbITSS)
        Me.Controls.Add(Me.PtbITIL)
        Me.Controls.Add(Me.PtbRHCE)
        Me.Controls.Add(Me.PtbOCP)
        Me.Controls.Add(Me.PtbVCP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WinAuthor"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Author - Multi Timer"
        CType(Me.PtbAuthor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PtbITSS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PtbITIL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PtbRHCE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PtbOCP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PtbVCP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsAuthor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DttLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PtbVCP As PictureBox
    Friend WithEvents PtbOCP As PictureBox
    Friend WithEvents PtbRHCE As PictureBox
    Friend WithEvents PtbITIL As PictureBox
    Friend WithEvents PtbITSS As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LlbURL As LinkLabel
    Friend WithEvents PtbAuthor As PictureBox
    Friend WithEvents DtsAuthor As DataSet
    Friend WithEvents DttLogo As DataTable
    Friend WithEvents DtcIDl As DataColumn
    Friend WithEvents DtcTitle As DataColumn
    Friend WithEvents DtcContent As DataColumn
End Class
