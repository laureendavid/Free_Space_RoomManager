<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adminform
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.facultyreservation = New System.Windows.Forms.Button()
        Me.adminuser = New System.Windows.Forms.Button()
        Me.adminsched = New System.Windows.Forms.Button()
        Me.adminstatus = New System.Windows.Forms.Button()
        Me.adminroom = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.adminlist = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(-3, 196)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1229, 644)
        Me.Panel2.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.BackgroundImage = Global.Free_Space.My.Resources.Resources.pngtree_climber_and_purple_mountain_background_image_389792
        Me.Panel1.Controls.Add(Me.facultyreservation)
        Me.Panel1.Controls.Add(Me.adminuser)
        Me.Panel1.Controls.Add(Me.adminsched)
        Me.Panel1.Controls.Add(Me.adminstatus)
        Me.Panel1.Controls.Add(Me.adminroom)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.adminlist)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-3, -1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1227, 198)
        Me.Panel1.TabIndex = 0
        '
        'facultyreservation
        '
        Me.facultyreservation.BackColor = System.Drawing.Color.Transparent
        Me.facultyreservation.BackgroundImage = Global.Free_Space.My.Resources.Resources.reserved
        Me.facultyreservation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.facultyreservation.FlatAppearance.BorderSize = 0
        Me.facultyreservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.facultyreservation.ForeColor = System.Drawing.Color.Transparent
        Me.facultyreservation.Location = New System.Drawing.Point(779, 100)
        Me.facultyreservation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.facultyreservation.Name = "facultyreservation"
        Me.facultyreservation.Size = New System.Drawing.Size(85, 79)
        Me.facultyreservation.TabIndex = 9
        Me.facultyreservation.UseVisualStyleBackColor = False
        '
        'adminuser
        '
        Me.adminuser.BackColor = System.Drawing.Color.Transparent
        Me.adminuser.BackgroundImage = Global.Free_Space.My.Resources.Resources.profile
        Me.adminuser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.adminuser.FlatAppearance.BorderSize = 0
        Me.adminuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.adminuser.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminuser.ForeColor = System.Drawing.Color.White
        Me.adminuser.Location = New System.Drawing.Point(931, 98)
        Me.adminuser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.adminuser.Name = "adminuser"
        Me.adminuser.Size = New System.Drawing.Size(83, 76)
        Me.adminuser.TabIndex = 0
        Me.adminuser.UseVisualStyleBackColor = False
        '
        'adminsched
        '
        Me.adminsched.BackColor = System.Drawing.Color.Transparent
        Me.adminsched.BackgroundImage = Global.Free_Space.My.Resources.Resources.time_management
        Me.adminsched.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.adminsched.FlatAppearance.BorderSize = 0
        Me.adminsched.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.adminsched.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminsched.ForeColor = System.Drawing.Color.Wheat
        Me.adminsched.Location = New System.Drawing.Point(632, 100)
        Me.adminsched.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.adminsched.Name = "adminsched"
        Me.adminsched.Size = New System.Drawing.Size(83, 80)
        Me.adminsched.TabIndex = 4
        Me.adminsched.UseVisualStyleBackColor = False
        '
        'adminstatus
        '
        Me.adminstatus.BackColor = System.Drawing.Color.Transparent
        Me.adminstatus.BackgroundImage = Global.Free_Space.My.Resources.Resources.clipboard
        Me.adminstatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.adminstatus.FlatAppearance.BorderSize = 0
        Me.adminstatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.adminstatus.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminstatus.ForeColor = System.Drawing.Color.White
        Me.adminstatus.Location = New System.Drawing.Point(483, 100)
        Me.adminstatus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.adminstatus.Name = "adminstatus"
        Me.adminstatus.Size = New System.Drawing.Size(96, 78)
        Me.adminstatus.TabIndex = 2
        Me.adminstatus.UseVisualStyleBackColor = False
        '
        'adminroom
        '
        Me.adminroom.BackColor = System.Drawing.Color.Transparent
        Me.adminroom.BackgroundImage = Global.Free_Space.My.Resources.Resources.clock
        Me.adminroom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.adminroom.Cursor = System.Windows.Forms.Cursors.Default
        Me.adminroom.FlatAppearance.BorderSize = 0
        Me.adminroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.adminroom.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminroom.ForeColor = System.Drawing.SystemColors.Window
        Me.adminroom.Location = New System.Drawing.Point(198, 94)
        Me.adminroom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.adminroom.Name = "adminroom"
        Me.adminroom.Size = New System.Drawing.Size(95, 92)
        Me.adminroom.TabIndex = 3
        Me.adminroom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.adminroom.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.BackgroundImage = Global.Free_Space.My.Resources.Resources.logout
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(1156, 130)
        Me.Button6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(56, 44)
        Me.Button6.TabIndex = 6
        Me.Button6.UseVisualStyleBackColor = False
        '
        'adminlist
        '
        Me.adminlist.BackColor = System.Drawing.Color.Transparent
        Me.adminlist.BackgroundImage = Global.Free_Space.My.Resources.Resources.classroom
        Me.adminlist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.adminlist.FlatAppearance.BorderSize = 0
        Me.adminlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.adminlist.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminlist.ForeColor = System.Drawing.Color.White
        Me.adminlist.Location = New System.Drawing.Point(352, 101)
        Me.adminlist.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.adminlist.Name = "adminlist"
        Me.adminlist.Size = New System.Drawing.Size(89, 78)
        Me.adminlist.TabIndex = 1
        Me.adminlist.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.Free_Space.My.Resources.Resources.FreeSpace_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(496, -37)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(219, 181)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'adminform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1221, 838)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "adminform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MAIN PAGE FOR ADMIN"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents adminuser As Button
    Friend WithEvents adminsched As Button
    Friend WithEvents adminroom As Button
    Friend WithEvents adminstatus As Button
    Friend WithEvents adminlist As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents facultyreservation As Button
End Class
