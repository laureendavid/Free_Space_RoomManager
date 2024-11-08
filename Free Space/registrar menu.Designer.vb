<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class registrarform
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
        Me.registrarroommanagement = New System.Windows.Forms.Button()
        Me.registrarroomstatus = New System.Windows.Forms.Button()
        Me.registrarroomsched = New System.Windows.Forms.Button()
        Me.registrarlogout = New System.Windows.Forms.Button()
        Me.registrarroomlist = New System.Windows.Forms.Button()
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
        Me.Panel2.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.BackgroundImage = Global.Free_Space.My.Resources.Resources.pngtree_climber_and_purple_mountain_background_image_389792
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.registrarroommanagement)
        Me.Panel1.Controls.Add(Me.registrarroomstatus)
        Me.Panel1.Controls.Add(Me.registrarroomsched)
        Me.Panel1.Controls.Add(Me.registrarlogout)
        Me.Panel1.Controls.Add(Me.registrarroomlist)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-3, -1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1227, 198)
        Me.Panel1.TabIndex = 2
        '
        'registrarroommanagement
        '
        Me.registrarroommanagement.BackColor = System.Drawing.Color.Transparent
        Me.registrarroommanagement.BackgroundImage = Global.Free_Space.My.Resources.Resources.time_management
        Me.registrarroommanagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.registrarroommanagement.FlatAppearance.BorderSize = 0
        Me.registrarroommanagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.registrarroommanagement.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registrarroommanagement.ForeColor = System.Drawing.Color.Transparent
        Me.registrarroommanagement.Location = New System.Drawing.Point(789, 95)
        Me.registrarroommanagement.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.registrarroommanagement.Name = "registrarroommanagement"
        Me.registrarroommanagement.Size = New System.Drawing.Size(83, 80)
        Me.registrarroommanagement.TabIndex = 4
        Me.registrarroommanagement.UseVisualStyleBackColor = False
        '
        'registrarroomstatus
        '
        Me.registrarroomstatus.BackColor = System.Drawing.Color.Transparent
        Me.registrarroomstatus.BackgroundImage = Global.Free_Space.My.Resources.Resources.clipboard
        Me.registrarroomstatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.registrarroomstatus.FlatAppearance.BorderSize = 0
        Me.registrarroomstatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.registrarroomstatus.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registrarroomstatus.ForeColor = System.Drawing.Color.White
        Me.registrarroomstatus.Location = New System.Drawing.Point(641, 96)
        Me.registrarroomstatus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.registrarroomstatus.Name = "registrarroomstatus"
        Me.registrarroomstatus.Size = New System.Drawing.Size(96, 78)
        Me.registrarroomstatus.TabIndex = 2
        Me.registrarroomstatus.UseVisualStyleBackColor = False
        '
        'registrarroomsched
        '
        Me.registrarroomsched.BackColor = System.Drawing.Color.Transparent
        Me.registrarroomsched.BackgroundImage = Global.Free_Space.My.Resources.Resources.clock
        Me.registrarroomsched.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.registrarroomsched.Cursor = System.Windows.Forms.Cursors.Default
        Me.registrarroomsched.FlatAppearance.BorderSize = 0
        Me.registrarroomsched.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.registrarroomsched.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registrarroomsched.ForeColor = System.Drawing.SystemColors.Window
        Me.registrarroomsched.Location = New System.Drawing.Point(355, 89)
        Me.registrarroomsched.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.registrarroomsched.Name = "registrarroomsched"
        Me.registrarroomsched.Size = New System.Drawing.Size(95, 92)
        Me.registrarroomsched.TabIndex = 3
        Me.registrarroomsched.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.registrarroomsched.UseVisualStyleBackColor = False
        '
        'registrarlogout
        '
        Me.registrarlogout.BackColor = System.Drawing.Color.Transparent
        Me.registrarlogout.BackgroundImage = Global.Free_Space.My.Resources.Resources.logout
        Me.registrarlogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.registrarlogout.FlatAppearance.BorderSize = 0
        Me.registrarlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.registrarlogout.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registrarlogout.ForeColor = System.Drawing.Color.White
        Me.registrarlogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.registrarlogout.Location = New System.Drawing.Point(1156, 137)
        Me.registrarlogout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.registrarlogout.Name = "registrarlogout"
        Me.registrarlogout.Size = New System.Drawing.Size(56, 44)
        Me.registrarlogout.TabIndex = 6
        Me.registrarlogout.UseVisualStyleBackColor = False
        '
        'registrarroomlist
        '
        Me.registrarroomlist.BackColor = System.Drawing.Color.Transparent
        Me.registrarroomlist.BackgroundImage = Global.Free_Space.My.Resources.Resources.classroom
        Me.registrarroomlist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.registrarroomlist.FlatAppearance.BorderSize = 0
        Me.registrarroomlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.registrarroomlist.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registrarroomlist.ForeColor = System.Drawing.Color.White
        Me.registrarroomlist.Location = New System.Drawing.Point(509, 96)
        Me.registrarroomlist.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.registrarroomlist.Name = "registrarroomlist"
        Me.registrarroomlist.Size = New System.Drawing.Size(89, 78)
        Me.registrarroomlist.TabIndex = 1
        Me.registrarroomlist.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Free_Space.My.Resources.Resources.FreeSpace_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(503, -15)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(235, 135)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'registrarform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1221, 838)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "registrarform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REGISTRAR"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents registrarroommanagement As Button
    Friend WithEvents registrarroomstatus As Button
    Friend WithEvents registrarroomsched As Button
    Friend WithEvents registrarlogout As Button
    Friend WithEvents registrarroomlist As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
