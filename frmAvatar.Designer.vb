<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChooseAvatar
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
        Me.lblAvaterMsg = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picKingPentacles = New System.Windows.Forms.PictureBox()
        Me.picKingWands = New System.Windows.Forms.PictureBox()
        Me.picKingCups = New System.Windows.Forms.PictureBox()
        Me.picKingSwords = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKingPentacles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKingWands, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKingCups, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKingSwords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAvaterMsg
        '
        Me.lblAvaterMsg.AutoSize = True
        Me.lblAvaterMsg.BackColor = System.Drawing.Color.Transparent
        Me.lblAvaterMsg.Font = New System.Drawing.Font("Cooper Black", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvaterMsg.ForeColor = System.Drawing.Color.Yellow
        Me.lblAvaterMsg.Location = New System.Drawing.Point(644, 465)
        Me.lblAvaterMsg.Name = "lblAvaterMsg"
        Me.lblAvaterMsg.Size = New System.Drawing.Size(420, 34)
        Me.lblAvaterMsg.TabIndex = 8
        Me.lblAvaterMsg.Text = "Player 1, chose your Oracle!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Baskerville Old Face", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(714, 250)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(242, 54)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "of TAROT"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Oracles.My.Resources.Resources.LOGO
        Me.PictureBox2.Location = New System.Drawing.Point(21, 658)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(184, 120)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Oracles.My.Resources.Resources.Oracles
        Me.PictureBox1.Location = New System.Drawing.Point(525, 87)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(588, 160)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'picKingPentacles
        '
        Me.picKingPentacles.BackColor = System.Drawing.Color.Black
        Me.picKingPentacles.Image = Global.Oracles.My.Resources.Resources.kip
        Me.picKingPentacles.Location = New System.Drawing.Point(858, 521)
        Me.picKingPentacles.Name = "picKingPentacles"
        Me.picKingPentacles.Size = New System.Drawing.Size(125, 208)
        Me.picKingPentacles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picKingPentacles.TabIndex = 6
        Me.picKingPentacles.TabStop = False
        '
        'picKingWands
        '
        Me.picKingWands.BackColor = System.Drawing.Color.Black
        Me.picKingWands.Image = Global.Oracles.My.Resources.Resources.kiw
        Me.picKingWands.Location = New System.Drawing.Point(714, 521)
        Me.picKingWands.Name = "picKingWands"
        Me.picKingWands.Size = New System.Drawing.Size(125, 208)
        Me.picKingWands.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picKingWands.TabIndex = 4
        Me.picKingWands.TabStop = False
        '
        'picKingCups
        '
        Me.picKingCups.BackColor = System.Drawing.Color.Black
        Me.picKingCups.Image = Global.Oracles.My.Resources.Resources.kic
        Me.picKingCups.Location = New System.Drawing.Point(1002, 521)
        Me.picKingCups.Name = "picKingCups"
        Me.picKingCups.Size = New System.Drawing.Size(125, 208)
        Me.picKingCups.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picKingCups.TabIndex = 2
        Me.picKingCups.TabStop = False
        '
        'picKingSwords
        '
        Me.picKingSwords.BackColor = System.Drawing.Color.Black
        Me.picKingSwords.Image = Global.Oracles.My.Resources.Resources.kis
        Me.picKingSwords.Location = New System.Drawing.Point(569, 521)
        Me.picKingSwords.Name = "picKingSwords"
        Me.picKingSwords.Size = New System.Drawing.Size(125, 208)
        Me.picKingSwords.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picKingSwords.TabIndex = 0
        Me.picKingSwords.TabStop = False
        '
        'frmChooseAvatar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1287, 806)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblAvaterMsg)
        Me.Controls.Add(Me.picKingPentacles)
        Me.Controls.Add(Me.picKingWands)
        Me.Controls.Add(Me.picKingCups)
        Me.Controls.Add(Me.picKingSwords)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmChooseAvatar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choose Your Avatar"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKingPentacles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKingWands, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKingCups, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKingSwords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picKingSwords As PictureBox
    Friend WithEvents picKingCups As PictureBox
    Friend WithEvents picKingPentacles As PictureBox
    Friend WithEvents picKingWands As PictureBox
    Friend WithEvents lblAvaterMsg As Label

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
