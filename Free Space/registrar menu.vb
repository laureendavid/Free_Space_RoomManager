Public Class registrarform
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles registrarlogout.Click
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

    Private Sub registrarroomsched_Click(sender As Object, e As EventArgs) Handles registrarroomsched.Click
        childform(adminroomsched)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles registrarroomlist.Click
        childform(adminroomlist)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles registrarroomstatus.Click
        childform(adminroomstatus)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles registrarroommanagement.Click
        childform(adminschedmanagement)
    End Sub

    Private Sub registrarform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Button5_Click(adminschedmanagement, EventArgs.Empty)
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
