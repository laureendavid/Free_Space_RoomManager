<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class facultyform
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
        Me.facultyroomstatus = New System.Windows.Forms.Button()
        Me.facultyroomsched = New System.Windows.Forms.Button()
        Me.facultylogout = New System.Windows.Forms.Button()
        Me.facultyroomlist = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(-3, 194)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1229, 644)
        Me.Panel2.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.BackgroundImage = Global.Free_Space.My.Resources.Resources.pngtree_climber_and_purple_mountain_background_image_389792
        Me.Panel1.Controls.Add(Me.facultyreservation)
        Me.Panel1.Controls.Add(Me.facultyroomstatus)
        Me.Panel1.Controls.Add(Me.facultyroomsched)
        Me.Panel1.Controls.Add(Me.facultylogout)
        Me.Panel1.Controls.Add(Me.facultyroomlist)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-3, -1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1227, 198)
        Me.Panel1.TabIndex = 4
        '
        'facultyreservation
        '
        Me.facultyreservation.BackColor = System.Drawing.Color.Transparent
        Me.facultyreservation.BackgroundImage = Global.Free_Space.My.Resources.Resources.reserved
        Me.facultyreservation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.facultyreservation.FlatAppearance.BorderSize = 0
        Me.facultyreservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.facultyreservation.ForeColor = System.Drawing.Color.Transparent
        Me.facultyreservation.Location = New System.Drawing.Point(765, 110)
        Me.facultyreservation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.facultyreservation.Name = "facultyreservation"
        Me.facultyreservation.Size = New System.Drawing.Size(85, 79)
        Me.facultyreservation.TabIndex = 8
        Me.facultyreservation.UseVisualStyleBackColor = False
        '
        'facultyroomstatus
        '
        Me.facultyroomstatus.BackColor = System.Drawing.Color.Transparent
        Me.facultyroomstatus.BackgroundImage = Global.Free_Space.My.Resources.Resources.clipboard
        Me.facultyroomstatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.facultyroomstatus.FlatAppearance.BorderSize = 0
        Me.facultyroomstatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.facultyroomstatus.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.facultyroomstatus.ForeColor = System.Drawing.Color.White
        Me.facultyroomstatus.Location = New System.Drawing.Point(624, 103)
        Me.facultyroomstatus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.facultyroomstatus.Name = "facultyroomstatus"
        Me.facultyroomstatus.Size = New System.Drawing.Size(96, 78)
        Me.facultyroomstatus.TabIndex = 2
        Me.facultyroomstatus.UseVisualStyleBackColor = False
        '
        'facultyroomsched
        '
        Me.facultyroomsched.BackColor = System.Drawing.Color.Transparent
        Me.facultyroomsched.BackgroundImage = Global.Free_Space.My.Resources.Resources.clock
        Me.facultyroomsched.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.facultyroomsched.Cursor = System.Windows.Forms.Cursors.Default
        Me.facultyroomsched.FlatAppearance.BorderSize = 0
        Me.facultyroomsched.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.facultyroomsched.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.facultyroomsched.ForeColor = System.Drawing.SystemColors.Window
        Me.facultyroomsched.Location = New System.Drawing.Point(339, 97)
        Me.facultyroomsched.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.facultyroomsched.Name = "facultyroomsched"
        Me.facultyroomsched.Size = New System.Drawing.Size(95, 92)
        Me.facultyroomsched.TabIndex = 3
        Me.facultyroomsched.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.facultyroomsched.UseVisualStyleBackColor = False
        '
        'facultylogout
        '
        Me.facultylogout.BackColor = System.Drawing.Color.Transparent
        Me.facultylogout.BackgroundImage = Global.Free_Space.My.Resources.Resources.logout
        Me.facultylogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.facultylogout.FlatAppearance.BorderSize = 0
        Me.facultylogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.facultylogout.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.facultylogout.ForeColor = System.Drawing.Color.White
        Me.facultylogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.facultylogout.Location = New System.Drawing.Point(1147, 138)
        Me.facultylogout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.facultylogout.Name = "facultylogout"
        Me.facultylogout.Size = New System.Drawing.Size(56, 44)
        Me.facultylogout.TabIndex = 6
        Me.facultylogout.UseVisualStyleBackColor = False
        '
        'facultyroomlist
        '
        Me.facultyroomlist.BackColor = System.Drawing.Color.Transparent
        Me.facultyroomlist.BackgroundImage = Global.Free_Space.My.Resources.Resources.classroom
        Me.facultyroomlist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.facultyroomlist.FlatAppearance.BorderSize = 0
        Me.facultyroomlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.facultyroomlist.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.facultyroomlist.ForeColor = System.Drawing.Color.White
        Me.facultyroomlist.Location = New System.Drawing.Point(492, 103)
        Me.facultyroomlist.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.facultyroomlist.Name = "facultyroomlist"
        Me.facultyroomlist.Size = New System.Drawing.Size(89, 78)
        Me.facultyroomlist.TabIndex = 1
        Me.facultyroomlist.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Free_Space.My.Resources.Resources.FreeSpace_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(485, -12)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(235, 135)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'facultyform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1221, 838)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "facultyform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FACULTY"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents facultyroomstatus As Button
    Friend WithEvents facultyroomsched As Button
    Friend WithEvents facultylogout As Button
    Friend WithEvents facultyroomlist As Button
    Friend WithEvents facultyreservation As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
