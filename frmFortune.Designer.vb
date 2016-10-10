<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFortune
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.picPic4 = New System.Windows.Forms.PictureBox()
        Me.picPic2 = New System.Windows.Forms.PictureBox()
        Me.picPic3 = New System.Windows.Forms.PictureBox()
        Me.picPic1 = New System.Windows.Forms.PictureBox()
        Me.picReplace = New System.Windows.Forms.PictureBox()
        CType(Me.picPic4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPic3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picReplace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(378, 480)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(184, 67)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Do not replace"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.BackColor = System.Drawing.Color.Black
        Me.lblMsg.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.ForeColor = System.Drawing.Color.White
        Me.lblMsg.Location = New System.Drawing.Point(333, 9)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(266, 24)
        Me.lblMsg.TabIndex = 19
        Me.lblMsg.Text = "Choose a card to replace"
        '
        'picPic4
        '
        Me.picPic4.BackColor = System.Drawing.Color.Black
        Me.picPic4.Location = New System.Drawing.Point(479, 266)
        Me.picPic4.Name = "picPic4"
        Me.picPic4.Size = New System.Drawing.Size(125, 208)
        Me.picPic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPic4.TabIndex = 18
        Me.picPic4.TabStop = False
        '
        'picPic2
        '
        Me.picPic2.BackColor = System.Drawing.Color.Black
        Me.picPic2.Location = New System.Drawing.Point(479, 39)
        Me.picPic2.Name = "picPic2"
        Me.picPic2.Size = New System.Drawing.Size(125, 208)
        Me.picPic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPic2.TabIndex = 17
        Me.picPic2.TabStop = False
        '
        'picPic3
        '
        Me.picPic3.BackColor = System.Drawing.Color.Black
        Me.picPic3.Location = New System.Drawing.Point(337, 266)
        Me.picPic3.Name = "picPic3"
        Me.picPic3.Size = New System.Drawing.Size(125, 208)
        Me.picPic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPic3.TabIndex = 16
        Me.picPic3.TabStop = False
        '
        'picPic1
        '
        Me.picPic1.BackColor = System.Drawing.Color.Black
        Me.picPic1.Location = New System.Drawing.Point(337, 39)
        Me.picPic1.Name = "picPic1"
        Me.picPic1.Size = New System.Drawing.Size(125, 208)
        Me.picPic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPic1.TabIndex = 15
        Me.picPic1.TabStop = False
        '
        'picReplace
        '
        Me.picReplace.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.picReplace.Location = New System.Drawing.Point(12, 12)
        Me.picReplace.Name = "picReplace"
        Me.picReplace.Size = New System.Drawing.Size(293, 517)
        Me.picReplace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picReplace.TabIndex = 21
        Me.picReplace.TabStop = False
        '
        'frmFortune
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(620, 556)
        Me.Controls.Add(Me.picReplace)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.picPic4)
        Me.Controls.Add(Me.picPic2)
        Me.Controls.Add(Me.picPic3)
        Me.Controls.Add(Me.picPic1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmFortune"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.TopMost = True
        CType(Me.picPic4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPic3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picReplace, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents lblMsg As Label
    Friend WithEvents picPic4 As PictureBox
    Friend WithEvents picPic2 As PictureBox
    Friend WithEvents picPic3 As PictureBox
    Friend WithEvents picPic1 As PictureBox
    Friend WithEvents picReplace As PictureBox
End Class
