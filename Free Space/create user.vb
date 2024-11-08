Imports MySql.Data.MySqlClient

Public Class createuser
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim selectedRole As String = ComboBox1.SelectedItem.ToString()


        Dim username As String = usertxt.Text
        Dim password As String = passtxt.Text

        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) OrElse String.IsNullOrEmpty(selectedRole) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        Dim connectionString As String = "Server=localhost; Database=FREESPACE; Uid=root; Pwd=password;"


        Using connection As New MySqlConnection(connectionString)
            Try

                connection.Open()


                Dim checkQuery As String = "SELECT COUNT(*) FROM ( " &
                                           "SELECT username FROM adminn UNION " &
                                           "SELECT username FROM faculty UNION " &
                                           "SELECT username FROM registrar UNION " &
                                           "SELECT username FROM student ) AS all_users WHERE username = @username"


                Using checkCmd As New MySqlCommand(checkQuery, connection)
                    checkCmd.Parameters.AddWithValue("@username", username)
                    Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("Username already exists.")
                        Return
                    End If
                End Using


                Dim insertQuery As String = ""

                Select Case selectedRole
                    Case "admin"
                        insertQuery = "INSERT INTO adminn (username, password) VALUES (@username, @password)"
                    Case "faculty"
                        insertQuery = "INSERT INTO faculty (username, password) VALUES (@username, @password)"
                    Case "registrar"
                        insertQuery = "INSERT INTO registrar (username, password) VALUES (@username, @password)"
                    Case "student"
                        insertQuery = "INSERT INTO student (username, password) VALUES (@username, @password)"
                    Case Else
                        MessageBox.Show("Invalid role selected.")
                        Return
                End Select


                Using command As New MySqlCommand(insertQuery, connection)
                    command.Parameters.AddWithValue("@username", username)
                    command.Parameters.AddWithValue("@password", password)


                    command.ExecuteNonQuery()


                    MessageBox.Show("User successfully created.")
                End Using
            Catch ex As Exception

                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub usertxt_TextChanged(sender As Object, e As EventArgs) Handles usertxt.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        userarchive.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        usertxt.Clear()
        passtxt.Clear()
        ComboBox1.SelectedIndex = -1
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
