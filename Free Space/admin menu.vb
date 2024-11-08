Public Class adminform
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles adminsched.Click
        childform(adminschedmanagement)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Login.Show()
            Me.Hide()
        End If
    End Sub

    Sub childform(ByVal panel As Form)
        Panel2.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        Panel2.AutoScroll = True
        Panel2.Controls.Add(panel)
        panel.Show()
        Panel2.PerformLayout()
        Panel2.Refresh()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles adminuser.Click
        childform(createuser)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles adminroom.Click
        childform(adminroomsched)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles adminlist.Click
        childform(adminroomlist)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles adminstatus.Click
        childform(adminroomstatus)
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
    End Sub

    Private Sub adminform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Button5_Click(adminschedmanagement, EventArgs.Empty)
    End Sub

    Private Sub facultyreservation_Click(sender As Object, e As EventArgs) Handles facultyreservation.Click
        childform(reservation)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
