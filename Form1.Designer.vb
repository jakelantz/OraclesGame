<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChoosePN
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
        Me.btn1Player = New System.Windows.Forms.Button()
        Me.btn2Player = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn1Player
        '
        Me.btn1Player.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn1Player.Font = New System.Drawing.Font("Mistral", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1Player.Location = New System.Drawing.Point(35, 28)
        Me.btn1Player.Name = "btn1Player"
        Me.btn1Player.Size = New System.Drawing.Size(247, 117)
        Me.btn1Player.TabIndex = 0
        Me.btn1Player.Text = "1 Player"
        Me.btn1Player.UseVisualStyleBackColor = False
        '
        'btn2Player
        '
        Me.btn2Player.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn2Player.Font = New System.Drawing.Font("Mistral", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2Player.Location = New System.Drawing.Point(35, 197)
        Me.btn2Player.Name = "btn2Player"
        Me.btn2Player.Size = New System.Drawing.Size(247, 117)
        Me.btn2Player.TabIndex = 1
        Me.btn2Player.Text = "2 Players"
        Me.btn2Player.UseVisualStyleBackColor = False
        '
        'frmChoosePN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(322, 368)
        Me.Controls.Add(Me.btn2Player)
        Me.Controls.Add(Me.btn1Player)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmChoosePN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Oracles of Tarot"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn1Player As Button
    Friend WithEvents btn2Player As Button
End Class
