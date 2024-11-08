<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reservation
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ENDTIME = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ROOMNO = New System.Windows.Forms.ComboBox()
        Me.DAY = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.STARTTIME = New System.Windows.Forms.DateTimePicker()
        Me.SUBJTXT = New System.Windows.Forms.TextBox()
        Me.NAMETXT = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel3.BackgroundImage = Global.Free_Space.My.Resources.Resources._14
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.ENDTIME)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.ROOMNO)
        Me.Panel3.Controls.Add(Me.DAY)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.STARTTIME)
        Me.Panel3.Controls.Add(Me.SUBJTXT)
        Me.Panel3.Controls.Add(Me.NAMETXT)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1229, 653)
        Me.Panel3.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("MV Boli", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Indigo
        Me.Label5.Location = New System.Drawing.Point(365, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(488, 79)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "RESERVATION "
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Indigo
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("MV Boli", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(737, 453)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 34)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "CLEAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ENDTIME
        '
        Me.ENDTIME.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.ENDTIME.Location = New System.Drawing.Point(329, 401)
        Me.ENDTIME.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ENDTIME.Name = "ENDTIME"
        Me.ENDTIME.Size = New System.Drawing.Size(200, 23)
        Me.ENDTIME.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Indigo
        Me.Label4.Location = New System.Drawing.Point(193, 398)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 26)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "END TIME:"
        '
        'ROOMNO
        '
        Me.ROOMNO.FormattingEnabled = True
        Me.ROOMNO.Location = New System.Drawing.Point(368, 281)
        Me.ROOMNO.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ROOMNO.Name = "ROOMNO"
        Me.ROOMNO.Size = New System.Drawing.Size(121, 25)
        Me.ROOMNO.TabIndex = 19
        '
        'DAY
        '
        Me.DAY.FormattingEnabled = True
        Me.DAY.Location = New System.Drawing.Point(329, 463)
        Me.DAY.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DAY.Name = "DAY"
        Me.DAY.Size = New System.Drawing.Size(200, 25)
        Me.DAY.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Indigo
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("MV Boli", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(863, 453)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 34)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "ENTER"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'STARTTIME
        '
        Me.STARTTIME.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.STARTTIME.Location = New System.Drawing.Point(329, 340)
        Me.STARTTIME.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.STARTTIME.Name = "STARTTIME"
        Me.STARTTIME.Size = New System.Drawing.Size(200, 23)
        Me.STARTTIME.TabIndex = 15
        '
        'SUBJTXT
        '
        Me.SUBJTXT.Location = New System.Drawing.Point(815, 380)
        Me.SUBJTXT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SUBJTXT.Name = "SUBJTXT"
        Me.SUBJTXT.Size = New System.Drawing.Size(156, 23)
        Me.SUBJTXT.TabIndex = 11
        '
        'NAMETXT
        '
        Me.NAMETXT.Location = New System.Drawing.Point(815, 305)
        Me.NAMETXT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NAMETXT.Name = "NAMETXT"
        Me.NAMETXT.Size = New System.Drawing.Size(156, 23)
        Me.NAMETXT.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Indigo
        Me.Label9.Location = New System.Drawing.Point(224, 462)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 26)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "DAY:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Indigo
        Me.Label8.Location = New System.Drawing.Point(167, 338)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(156, 26)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "START TIME:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Indigo
        Me.Label7.Location = New System.Drawing.Point(224, 281)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 26)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "ROOM NO:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("MV Boli", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Indigo
        Me.Label6.Location = New System.Drawing.Point(220, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(238, 40)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "RESERVATION"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Indigo
        Me.Label3.Location = New System.Drawing.Point(683, 380)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "SUBJECT:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Indigo
        Me.Label2.Location = New System.Drawing.Point(713, 302)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NAME:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Indigo
        Me.Label1.Location = New System.Drawing.Point(717, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INFORMATION"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1232, 674)
        Me.Panel1.TabIndex = 0
        '
        'reservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1221, 652)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "reservation"
        Me.Text = "RESERVATION"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents STARTTIME As DateTimePicker
    Friend WithEvents SUBJTXT As TextBox
    Friend WithEvents NAMETXT As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ROOMNO As ComboBox
    Friend WithEvents DAY As ComboBox
    Friend WithEvents ENDTIME As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
End Class
