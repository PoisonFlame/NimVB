<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnPickStones = New System.Windows.Forms.Button()
        Me.lblStones = New System.Windows.Forms.Label()
        Me.tmrUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.captComp = New System.Windows.Forms.Label()
        Me.captYou = New System.Windows.Forms.Label()
        Me.lblYourPick = New System.Windows.Forms.Label()
        Me.lblCompPick = New System.Windows.Forms.Label()
        Me.txtStones = New System.Windows.Forms.TextBox()
        Me.lblO = New System.Windows.Forms.Label()
        Me.lblComp = New System.Windows.Forms.Label()
        Me.lblYou = New System.Windows.Forms.Label()
        Me.lblGameover = New System.Windows.Forms.Label()
        Me.picEndGame = New System.Windows.Forms.PictureBox()
        Me.lblMode = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.captHTP = New System.Windows.Forms.Label()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.tmrTime = New System.Windows.Forms.Timer(Me.components)
        Me.tmrShowUp = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picEndGame, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPlay
        '
        Me.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlay.ForeColor = System.Drawing.Color.Red
        Me.btnPlay.Location = New System.Drawing.Point(12, 227)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(75, 23)
        Me.btnPlay.TabIndex = 0
        Me.btnPlay.Text = "Play Game"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnPickStones
        '
        Me.btnPickStones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPickStones.ForeColor = System.Drawing.Color.Red
        Me.btnPickStones.Location = New System.Drawing.Point(197, 227)
        Me.btnPickStones.Name = "btnPickStones"
        Me.btnPickStones.Size = New System.Drawing.Size(75, 23)
        Me.btnPickStones.TabIndex = 1
        Me.btnPickStones.Text = "Pick Stones"
        Me.btnPickStones.UseVisualStyleBackColor = True
        Me.btnPickStones.Visible = False
        '
        'lblStones
        '
        Me.lblStones.AutoSize = True
        Me.lblStones.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStones.ForeColor = System.Drawing.Color.Yellow
        Me.lblStones.Location = New System.Drawing.Point(110, 103)
        Me.lblStones.Name = "lblStones"
        Me.lblStones.Size = New System.Drawing.Size(57, 39)
        Me.lblStones.TabIndex = 2
        Me.lblStones.Text = "21"
        Me.lblStones.Visible = False
        '
        'tmrUpdate
        '
        '
        'captComp
        '
        Me.captComp.AutoSize = True
        Me.captComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.captComp.ForeColor = System.Drawing.Color.Red
        Me.captComp.Location = New System.Drawing.Point(9, 9)
        Me.captComp.Name = "captComp"
        Me.captComp.Size = New System.Drawing.Size(152, 16)
        Me.captComp.TabIndex = 4
        Me.captComp.Text = "Computer's PickUps:"
        Me.captComp.Visible = False
        '
        'captYou
        '
        Me.captYou.AutoSize = True
        Me.captYou.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.captYou.ForeColor = System.Drawing.Color.Red
        Me.captYou.Location = New System.Drawing.Point(9, 24)
        Me.captYou.Name = "captYou"
        Me.captYou.Size = New System.Drawing.Size(110, 16)
        Me.captYou.TabIndex = 5
        Me.captYou.Text = "Your PickUps: "
        Me.captYou.Visible = False
        '
        'lblYourPick
        '
        Me.lblYourPick.AutoSize = True
        Me.lblYourPick.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYourPick.ForeColor = System.Drawing.Color.Red
        Me.lblYourPick.Location = New System.Drawing.Point(160, 24)
        Me.lblYourPick.Name = "lblYourPick"
        Me.lblYourPick.Size = New System.Drawing.Size(0, 16)
        Me.lblYourPick.TabIndex = 6
        '
        'lblCompPick
        '
        Me.lblCompPick.AutoSize = True
        Me.lblCompPick.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompPick.ForeColor = System.Drawing.Color.Red
        Me.lblCompPick.Location = New System.Drawing.Point(160, 9)
        Me.lblCompPick.Name = "lblCompPick"
        Me.lblCompPick.Size = New System.Drawing.Size(0, 16)
        Me.lblCompPick.TabIndex = 7
        '
        'txtStones
        '
        Me.txtStones.Enabled = False
        Me.txtStones.Location = New System.Drawing.Point(143, 229)
        Me.txtStones.MaxLength = 1
        Me.txtStones.Name = "txtStones"
        Me.txtStones.Size = New System.Drawing.Size(48, 20)
        Me.txtStones.TabIndex = 8
        Me.txtStones.Visible = False
        '
        'lblO
        '
        Me.lblO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblO.Location = New System.Drawing.Point(69, 47)
        Me.lblO.Name = "lblO"
        Me.lblO.Size = New System.Drawing.Size(133, 64)
        Me.lblO.TabIndex = 9
        Me.lblO.Text = "O O O O O O O O O O O O O O O O O O O O O"
        Me.lblO.Visible = False
        '
        'lblComp
        '
        Me.lblComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComp.ForeColor = System.Drawing.Color.Red
        Me.lblComp.Location = New System.Drawing.Point(31, 159)
        Me.lblComp.Name = "lblComp"
        Me.lblComp.Size = New System.Drawing.Size(220, 25)
        Me.lblComp.TabIndex = 10
        Me.lblComp.Text = "Computer Takes X Stones"
        Me.lblComp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblComp.Visible = False
        '
        'lblYou
        '
        Me.lblYou.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYou.ForeColor = System.Drawing.Color.Red
        Me.lblYou.Location = New System.Drawing.Point(31, 184)
        Me.lblYou.Name = "lblYou"
        Me.lblYou.Size = New System.Drawing.Size(220, 25)
        Me.lblYou.TabIndex = 11
        Me.lblYou.Text = "You Takes X Stones"
        Me.lblYou.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblYou.Visible = False
        '
        'lblGameover
        '
        Me.lblGameover.BackColor = System.Drawing.Color.Transparent
        Me.lblGameover.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblGameover.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameover.ForeColor = System.Drawing.Color.Red
        Me.lblGameover.Location = New System.Drawing.Point(0, 0)
        Me.lblGameover.Name = "lblGameover"
        Me.lblGameover.Size = New System.Drawing.Size(284, 262)
        Me.lblGameover.TabIndex = 12
        Me.lblGameover.Text = "GAME OVER"
        Me.lblGameover.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblGameover.Visible = False
        '
        'picEndGame
        '
        Me.picEndGame.BackColor = System.Drawing.Color.Transparent
        Me.picEndGame.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picEndGame.Location = New System.Drawing.Point(0, 0)
        Me.picEndGame.Name = "picEndGame"
        Me.picEndGame.Size = New System.Drawing.Size(284, 262)
        Me.picEndGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEndGame.TabIndex = 13
        Me.picEndGame.TabStop = False
        Me.picEndGame.Visible = False
        '
        'lblMode
        '
        Me.lblMode.AutoSize = True
        Me.lblMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMode.ForeColor = System.Drawing.Color.Red
        Me.lblMode.Location = New System.Drawing.Point(9, 40)
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(51, 16)
        Me.lblMode.TabIndex = 14
        Me.lblMode.Text = "Mode:"
        Me.lblMode.Visible = False
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Yellow
        Me.lblTitle.Location = New System.Drawing.Point(3, 2)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(281, 23)
        Me.lblTitle.TabIndex = 15
        Me.lblTitle.Text = "Welcome To Nim Game"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'captHTP
        '
        Me.captHTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.captHTP.ForeColor = System.Drawing.Color.Yellow
        Me.captHTP.Location = New System.Drawing.Point(8, 67)
        Me.captHTP.Name = "captHTP"
        Me.captHTP.Size = New System.Drawing.Size(269, 23)
        Me.captHTP.TabIndex = 16
        Me.captHTP.Text = "How to Play:"
        Me.captHTP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInstructions
        '
        Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.ForeColor = System.Drawing.Color.Yellow
        Me.lblInstructions.Location = New System.Drawing.Point(3, 90)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(281, 136)
        Me.lblInstructions.TabIndex = 17
        Me.lblInstructions.Text = resources.GetString("lblInstructions.Text")
        Me.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrTime
        '
        Me.tmrTime.Interval = 1000
        '
        'tmrShowUp
        '
        Me.tmrShowUp.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.captHTP)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picEndGame)
        Me.Controls.Add(Me.lblMode)
        Me.Controls.Add(Me.lblGameover)
        Me.Controls.Add(Me.lblYou)
        Me.Controls.Add(Me.lblComp)
        Me.Controls.Add(Me.lblO)
        Me.Controls.Add(Me.txtStones)
        Me.Controls.Add(Me.lblCompPick)
        Me.Controls.Add(Me.lblYourPick)
        Me.Controls.Add(Me.captYou)
        Me.Controls.Add(Me.captComp)
        Me.Controls.Add(Me.lblStones)
        Me.Controls.Add(Me.btnPickStones)
        Me.Controls.Add(Me.btnPlay)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ForeColor = System.Drawing.Color.Lime
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "NIM"
        CType(Me.picEndGame, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents btnPickStones As System.Windows.Forms.Button
    Friend WithEvents lblStones As System.Windows.Forms.Label
    Friend WithEvents tmrUpdate As System.Windows.Forms.Timer
    Friend WithEvents captComp As System.Windows.Forms.Label
    Friend WithEvents captYou As System.Windows.Forms.Label
    Friend WithEvents lblYourPick As System.Windows.Forms.Label
    Friend WithEvents lblCompPick As System.Windows.Forms.Label
    Friend WithEvents txtStones As System.Windows.Forms.TextBox
    Friend WithEvents lblO As System.Windows.Forms.Label
    Friend WithEvents lblComp As System.Windows.Forms.Label
    Friend WithEvents lblYou As System.Windows.Forms.Label
    Friend WithEvents lblGameover As System.Windows.Forms.Label
    Friend WithEvents picEndGame As System.Windows.Forms.PictureBox
    Friend WithEvents lblMode As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents captHTP As System.Windows.Forms.Label
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents tmrTime As System.Windows.Forms.Timer
    Friend WithEvents tmrShowUp As System.Windows.Forms.Timer

End Class
