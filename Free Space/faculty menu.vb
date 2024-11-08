Public Class facultyform
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles facultylogout.Click
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles facultyroomsched.Click
        childform(adminroomsched)
    End Sub

    Private Sub facultyroomlist_Click(sender As Object, e As EventArgs) Handles facultyroomlist.Click
        childform(adminroomlist)
    End Sub

    Private Sub facultyroomstatus_Click(sender As Object, e As EventArgs) Handles facultyroomstatus.Click
        childform(adminroomstatus)
    End Sub

    Private Sub facultyreservation_Click(sender As Object, e As EventArgs) Handles facultyreservation.Click
        childform(reservation)
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
    End Sub

    Private Sub facultyform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        facultyroomlist_Click(adminroomlist, EventArgs.Empty)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
