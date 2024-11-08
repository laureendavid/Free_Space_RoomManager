<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.usertxt = New System.Windows.Forms.TextBox()
        Me.forgotpass = New System.Windows.Forms.Button()
        Me.passtxt = New System.Windows.Forms.TextBox()
        Me.loginbtn = New System.Windows.Forms.Button()
        Me.exitbtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.BackgroundImage = Global.Free_Space.My.Resources.Resources.pngtree_climber_and_purple_mountain_background_image_389792
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.exitbtn)
        Me.Panel1.Location = New System.Drawing.Point(-3, -1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1156, 698)
        Me.Panel1.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.CheckBox1)
        Me.Panel2.Controls.Add(Me.usertxt)
        Me.Panel2.Controls.Add(Me.forgotpass)
        Me.Panel2.Controls.Add(Me.passtxt)
        Me.Panel2.Controls.Add(Me.loginbtn)
        Me.Panel2.Location = New System.Drawing.Point(357, 95)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(437, 526)
        Me.Panel2.TabIndex = 12
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.Free_Space.My.Resources.Resources.pngtree_climber_and_purple_mountain_background_image_389792
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(437, 212)
        Me.Panel3.TabIndex = 12
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.Free_Space.My.Resources.Resources.FreeSpace__1__removebg_preview
        Me.PictureBox3.Location = New System.Drawing.Point(85, 18)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(275, 204)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MediumOrchid
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("MV Boli", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(179, 452)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 34)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "CLEAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox1.BackColor = System.Drawing.Color.MediumOrchid
        Me.CheckBox1.BackgroundImage = Global.Free_Space.My.Resources.Resources.eye
        Me.CheckBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.ForeColor = System.Drawing.Color.Black
        Me.CheckBox1.Image = Global.Free_Space.My.Resources.Resources.eye
        Me.CheckBox1.Location = New System.Drawing.Point(368, 315)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(28, 22)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'usertxt
        '
        Me.usertxt.BackColor = System.Drawing.Color.MediumOrchid
        Me.usertxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.usertxt.Font = New System.Drawing.Font("MV Boli", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usertxt.ForeColor = System.Drawing.Color.White
        Me.usertxt.Location = New System.Drawing.Point(83, 260)
        Me.usertxt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.usertxt.Name = "usertxt"
        Me.usertxt.Size = New System.Drawing.Size(279, 28)
        Me.usertxt.TabIndex = 3
        Me.usertxt.Text = "Username"
        '
        'forgotpass
        '
        Me.forgotpass.BackColor = System.Drawing.Color.Transparent
        Me.forgotpass.FlatAppearance.BorderSize = 0
        Me.forgotpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.forgotpass.Font = New System.Drawing.Font("MV Boli", 4.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.forgotpass.ForeColor = System.Drawing.Color.MediumOrchid
        Me.forgotpass.Location = New System.Drawing.Point(211, 353)
        Me.forgotpass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.forgotpass.Name = "forgotpass"
        Me.forgotpass.Size = New System.Drawing.Size(183, 27)
        Me.forgotpass.TabIndex = 10
        Me.forgotpass.Text = "FORGOT PASSWORD?"
        Me.forgotpass.UseVisualStyleBackColor = False
        '
        'passtxt
        '
        Me.passtxt.BackColor = System.Drawing.Color.MediumOrchid
        Me.passtxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.passtxt.Font = New System.Drawing.Font("MV Boli", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passtxt.ForeColor = System.Drawing.Color.White
        Me.passtxt.Location = New System.Drawing.Point(83, 313)
        Me.passtxt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.passtxt.Name = "passtxt"
        Me.passtxt.Size = New System.Drawing.Size(279, 28)
        Me.passtxt.TabIndex = 4
        Me.passtxt.Text = "Password"
        '
        'loginbtn
        '
        Me.loginbtn.BackColor = System.Drawing.Color.MediumOrchid
        Me.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginbtn.Font = New System.Drawing.Font("MV Boli", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginbtn.ForeColor = System.Drawing.Color.White
        Me.loginbtn.Location = New System.Drawing.Point(85, 398)
        Me.loginbtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.loginbtn.Name = "loginbtn"
        Me.loginbtn.Size = New System.Drawing.Size(275, 36)
        Me.loginbtn.TabIndex = 6
        Me.loginbtn.Text = "LOGIN"
        Me.loginbtn.UseVisualStyleBackColor = False
        '
        'exitbtn
        '
        Me.exitbtn.BackColor = System.Drawing.Color.Indigo
        Me.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exitbtn.Font = New System.Drawing.Font("MV Boli", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitbtn.ForeColor = System.Drawing.Color.White
        Me.exitbtn.Location = New System.Drawing.Point(1033, 638)
        Me.exitbtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.exitbtn.Name = "exitbtn"
        Me.exitbtn.Size = New System.Drawing.Size(89, 34)
        Me.exitbtn.TabIndex = 7
        Me.exitbtn.Text = "EXIT"
        Me.exitbtn.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1141, 695)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents usertxt As TextBox
    Friend WithEvents passtxt As TextBox
    Friend WithEvents loginbtn As Button
    Friend WithEvents exitbtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents forgotpass As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
