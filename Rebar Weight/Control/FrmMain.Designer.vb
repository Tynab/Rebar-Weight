<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lblRsltM = New System.Windows.Forms.Label()
        Me.lblRsltY = New System.Windows.Forms.Label()
        Me.lblRsltL = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblHaunchW = New System.Windows.Forms.Label()
        Me.lblHaunchL = New System.Windows.Forms.Label()
        Me.tgClose = New YANF.Control.YANTg()
        Me.tgPin = New YANF.Control.YANTg()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.nudDeg = New System.Windows.Forms.NumericUpDown()
        Me.lblDeg = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.nudH = New System.Windows.Forms.NumericUpDown()
        Me.lblH = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.nudL = New System.Windows.Forms.NumericUpDown()
        Me.lblL = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.nudD = New System.Windows.Forms.NumericUpDown()
        Me.lblD = New System.Windows.Forms.Label()
        Me.tipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.nudDeg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.nudH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.nudL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.nudD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.tgClose)
        Me.Panel1.Controls.Add(Me.tgPin)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(460, 170)
        Me.Panel1.TabIndex = 0
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Controls.Add(Me.lblRsltM)
        Me.Panel7.Controls.Add(Me.lblRsltY)
        Me.Panel7.Controls.Add(Me.lblRsltL)
        Me.Panel7.Location = New System.Drawing.Point(180, 70)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Padding = New System.Windows.Forms.Padding(11)
        Me.Panel7.Size = New System.Drawing.Size(270, 90)
        Me.Panel7.TabIndex = 0
        '
        'lblRsltM
        '
        Me.lblRsltM.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblRsltM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRsltM.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.lblRsltM.ForeColor = System.Drawing.Color.Yellow
        Me.lblRsltM.Location = New System.Drawing.Point(11, 32)
        Me.lblRsltM.Name = "lblRsltM"
        Me.lblRsltM.Size = New System.Drawing.Size(244, 22)
        Me.lblRsltM.TabIndex = 0
        Me.lblRsltM.Text = "m = 999"
        Me.lblRsltM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRsltY
        '
        Me.lblRsltY.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblRsltY.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblRsltY.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.lblRsltY.ForeColor = System.Drawing.Color.Yellow
        Me.lblRsltY.Location = New System.Drawing.Point(11, 54)
        Me.lblRsltY.Name = "lblRsltY"
        Me.lblRsltY.Size = New System.Drawing.Size(244, 21)
        Me.lblRsltY.TabIndex = 0
        Me.lblRsltY.Text = "Y = 999"
        Me.lblRsltY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRsltL
        '
        Me.lblRsltL.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblRsltL.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRsltL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.lblRsltL.ForeColor = System.Drawing.Color.Yellow
        Me.lblRsltL.Location = New System.Drawing.Point(11, 11)
        Me.lblRsltL.Name = "lblRsltL"
        Me.lblRsltL.Size = New System.Drawing.Size(244, 21)
        Me.lblRsltL.TabIndex = 0
        Me.lblRsltL.Text = "999 + 999 + 999 + 999 + 999"
        Me.lblRsltL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Controls.Add(Me.lblHaunchW)
        Me.Panel6.Controls.Add(Me.lblHaunchL)
        Me.Panel6.Location = New System.Drawing.Point(70, 100)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(8)
        Me.Panel6.Size = New System.Drawing.Size(100, 60)
        Me.Panel6.TabIndex = 0
        '
        'lblHaunchW
        '
        Me.lblHaunchW.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblHaunchW.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblHaunchW.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.lblHaunchW.ForeColor = System.Drawing.Color.Yellow
        Me.lblHaunchW.Location = New System.Drawing.Point(8, 28)
        Me.lblHaunchW.Name = "lblHaunchW"
        Me.lblHaunchW.Size = New System.Drawing.Size(80, 20)
        Me.lblHaunchW.TabIndex = 0
        Me.lblHaunchW.Text = "W = 9999"
        Me.lblHaunchW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHaunchL
        '
        Me.lblHaunchL.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblHaunchL.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHaunchL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.lblHaunchL.ForeColor = System.Drawing.Color.Yellow
        Me.lblHaunchL.Location = New System.Drawing.Point(8, 8)
        Me.lblHaunchL.Name = "lblHaunchL"
        Me.lblHaunchL.Size = New System.Drawing.Size(80, 20)
        Me.lblHaunchL.TabIndex = 0
        Me.lblHaunchL.Text = "L = 9999"
        Me.lblHaunchL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tgClose
        '
        Me.tgClose.AutoSize = True
        Me.tgClose.Checked = True
        Me.tgClose.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tgClose.Location = New System.Drawing.Point(10, 138)
        Me.tgClose.MinimumSize = New System.Drawing.Size(45, 22)
        Me.tgClose.Name = "tgClose"
        Me.tgClose.OffBackColor = System.Drawing.Color.Gray
        Me.tgClose.OffToggleColor = System.Drawing.Color.Gainsboro
        Me.tgClose.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.tgClose.OnToggleColor = System.Drawing.Color.WhiteSmoke
        Me.tgClose.Size = New System.Drawing.Size(45, 22)
        Me.tgClose.TabIndex = 0
        Me.tgClose.TabStop = False
        Me.tipMain.SetToolTip(Me.tgClose, "クローズ")
        Me.tgClose.UseVisualStyleBackColor = True
        '
        'tgPin
        '
        Me.tgPin.AutoSize = True
        Me.tgPin.Checked = True
        Me.tgPin.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tgPin.Location = New System.Drawing.Point(10, 100)
        Me.tgPin.MinimumSize = New System.Drawing.Size(45, 22)
        Me.tgPin.Name = "tgPin"
        Me.tgPin.OffBackColor = System.Drawing.Color.Gray
        Me.tgPin.OffToggleColor = System.Drawing.Color.Gainsboro
        Me.tgPin.OnBackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.tgPin.OnToggleColor = System.Drawing.Color.WhiteSmoke
        Me.tgPin.Size = New System.Drawing.Size(45, 22)
        Me.tgPin.TabIndex = 0
        Me.tgPin.TabStop = False
        Me.tipMain.SetToolTip(Me.tgPin, "ピン")
        Me.tgPin.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Panel4)
        Me.GroupBox2.Controls.Add(Me.Panel5)
        Me.GroupBox2.Font = New System.Drawing.Font("Meiryo", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(160, 80)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ハンチ"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.nudDeg)
        Me.Panel4.Controls.Add(Me.lblDeg)
        Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel4.Location = New System.Drawing.Point(10, 50)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(140, 20)
        Me.Panel4.TabIndex = 2
        '
        'nudDeg
        '
        Me.nudDeg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.nudDeg.Location = New System.Drawing.Point(40, 0)
        Me.nudDeg.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
        Me.nudDeg.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudDeg.Name = "nudDeg"
        Me.nudDeg.Size = New System.Drawing.Size(100, 20)
        Me.nudDeg.TabIndex = 1
        Me.nudDeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudDeg.Value = New Decimal(New Integer() {45, 0, 0, 0})
        '
        'lblDeg
        '
        Me.lblDeg.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblDeg.ForeColor = System.Drawing.Color.White
        Me.lblDeg.Location = New System.Drawing.Point(0, 0)
        Me.lblDeg.Name = "lblDeg"
        Me.lblDeg.Size = New System.Drawing.Size(40, 20)
        Me.lblDeg.TabIndex = 0
        Me.lblDeg.Text = "Deg"
        Me.lblDeg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.nudH)
        Me.Panel5.Controls.Add(Me.lblH)
        Me.Panel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel5.Location = New System.Drawing.Point(10, 20)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(140, 20)
        Me.Panel5.TabIndex = 1
        '
        'nudH
        '
        Me.nudH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.nudH.Location = New System.Drawing.Point(40, 0)
        Me.nudH.Maximum = New Decimal(New Integer() {5500, 0, 0, 0})
        Me.nudH.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudH.Name = "nudH"
        Me.nudH.Size = New System.Drawing.Size(100, 20)
        Me.nudH.TabIndex = 1
        Me.nudH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudH.ThousandsSeparator = True
        Me.nudH.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'lblH
        '
        Me.lblH.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblH.ForeColor = System.Drawing.Color.White
        Me.lblH.Location = New System.Drawing.Point(0, 0)
        Me.lblH.Name = "lblH"
        Me.lblH.Size = New System.Drawing.Size(40, 20)
        Me.lblH.TabIndex = 0
        Me.lblH.Text = "H"
        Me.lblH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Font = New System.Drawing.Font("Meiryo", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(180, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(270, 50)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "重量"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.nudL)
        Me.Panel3.Controls.Add(Me.lblL)
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel3.Location = New System.Drawing.Point(140, 20)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(120, 20)
        Me.Panel3.TabIndex = 2
        '
        'nudL
        '
        Me.nudL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.nudL.Location = New System.Drawing.Point(20, 0)
        Me.nudL.Maximum = New Decimal(New Integer() {5500, 0, 0, 0})
        Me.nudL.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudL.Name = "nudL"
        Me.nudL.Size = New System.Drawing.Size(100, 20)
        Me.nudL.TabIndex = 1
        Me.nudL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudL.ThousandsSeparator = True
        Me.nudL.Value = New Decimal(New Integer() {5500, 0, 0, 0})
        '
        'lblL
        '
        Me.lblL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblL.Location = New System.Drawing.Point(0, 0)
        Me.lblL.Name = "lblL"
        Me.lblL.Size = New System.Drawing.Size(20, 20)
        Me.lblL.TabIndex = 0
        Me.lblL.Text = "L"
        Me.lblL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.nudD)
        Me.Panel2.Controls.Add(Me.lblD)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel2.Location = New System.Drawing.Point(10, 20)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(120, 20)
        Me.Panel2.TabIndex = 1
        '
        'nudD
        '
        Me.nudD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.nudD.Location = New System.Drawing.Point(20, 0)
        Me.nudD.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudD.Name = "nudD"
        Me.nudD.Size = New System.Drawing.Size(100, 20)
        Me.nudD.TabIndex = 1
        Me.nudD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudD.Value = New Decimal(New Integer() {16, 0, 0, 0})
        '
        'lblD
        '
        Me.lblD.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblD.Location = New System.Drawing.Point(0, 0)
        Me.lblD.Name = "lblD"
        Me.lblD.Size = New System.Drawing.Size(20, 20)
        Me.lblD.TabIndex = 0
        Me.lblD.Text = "D"
        Me.lblD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(460, 170)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMain"
        Me.Opacity = 0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rebar Weight"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.nudDeg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.nudH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.nudL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.nudD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents nudL As NumericUpDown
    Friend WithEvents lblL As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents nudD As NumericUpDown
    Friend WithEvents lblD As Label
    Friend WithEvents tgPin As YANF.Control.YANTg
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents nudDeg As NumericUpDown
    Friend WithEvents lblDeg As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents nudH As NumericUpDown
    Friend WithEvents lblH As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lblRsltM As Label
    Friend WithEvents lblRsltY As Label
    Friend WithEvents lblRsltL As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lblHaunchW As Label
    Friend WithEvents lblHaunchL As Label
    Friend WithEvents tgClose As YANF.Control.YANTg
    Friend WithEvents tipMain As ToolTip
End Class
