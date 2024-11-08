Imports MySql.Data.MySqlClient

Public Class Login
    Dim conn As New MySqlConnection


    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDatabase()
        passtxt.PasswordChar = "*"c

    End Sub

    Public Sub ConnectDatabase()
        Dim DatabaseName As String = "freespace"
        Dim server As String = "localhost"
        Dim userName As String = "root"
        Dim password As String = "password"

        If Not conn Is Nothing Then conn.Close()
        conn.ConnectionString = "server=" & server & ";user id=" & userName & ";" &
                            "password=" & password & ";database=" & DatabaseName & ""

        Try
            conn.Open()
            MsgBox("WELCOME TO FREESPACE")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub passtxt_TextChanged(sender As Object, e As EventArgs) Handles passtxt.TextChanged

    End Sub


    Private Sub exitbtn_Click(sender As Object, e As EventArgs) Handles exitbtn.Click
        Close()

    End Sub

    Private Sub Loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        Dim enteredUsername As String = usertxt.Text
        Dim enteredPassword As String = passtxt.Text

        If ValidateLogin("adminn", enteredUsername, enteredPassword) Then
            MsgBox("Admin login successful!")
            adminform.Show()
            Me.Hide()
        ElseIf ValidateLogin("faculty", enteredUsername, enteredPassword) Then
            MsgBox("Faculty login successful!")
            facultyform.Show()
            Me.Hide()
        ElseIf ValidateLogin("registrar", enteredUsername, enteredPassword) Then
            MsgBox("Registrar login successful!")
            registrarform.Show()
            Me.Hide()
        ElseIf ValidateLogin("student", enteredUsername, enteredPassword) Then
            MsgBox("Student login successful!")
            studentform.Show()
            Me.Hide()
        Else
            MsgBox("Invalid username or password.")
        End If
    End Sub

    Private Function ValidateLogin(tableName As String, username As String, password As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM " & tableName & " WHERE username = @username AND password = @password"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@username", username)
        cmd.Parameters.AddWithValue("@password", password)

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return count > 0
        Catch ex As MySqlException
            MsgBox("Error: " & ex.Message)
            Return False
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Function

    Private Sub usertxt_TextChanged(sender As Object, e As EventArgs) Handles usertxt.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            passtxt.PasswordChar = ControlChars.NullChar
            CheckBox1.Text = "Hide Password"
        Else passtxt.PasswordChar = "*"c
            CheckBox1.Text = "Show Password"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles forgotpass.Click
        forgotform.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        usertxt.Clear()
        passtxt.Clear()





        passtxt.PasswordChar = "*"c
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class


