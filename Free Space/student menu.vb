Public Class studentform
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles studentroomsched.Click
        childform(adminroomsched)
    End Sub




    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles studentlogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


        If result = DialogResult.Yes Then
            Login.Show()
            Me.Hide()
        ElseIf result = DialogResult.No Then

        End If


    End Sub
    Sub childform(ByVal panel As Form)
        Panel2.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        panel.Dock = DockStyle.None
        Panel2.AutoScroll = True
        Panel2.Controls.Add(panel)
        panel.Show()
        Panel2.PerformLayout()
        Panel2.Refresh()
    End Sub

    Private Sub studentroomstatus_Click(sender As Object, e As EventArgs) Handles studentroomstatus.Click
        childform(adminroomstatus)
    End Sub

    Private Sub studentroomlist_Click(sender As Object, e As EventArgs) Handles studentlist.Click
        childform(studentroomlist)
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub pixturepanel_Paint(sender As Object, e As PaintEventArgs) 

    End Sub

    Private Sub studentform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        studentroomlist_Click(studentroomlist, EventArgs.Empty)
    End Sub

    Private Sub Panel2_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class