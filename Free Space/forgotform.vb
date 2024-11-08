Imports MySql.Data.MySqlClient

Public Class forgotform
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub USERNAME_TextChanged(sender As Object, e As EventArgs) Handles USERNAME.TextChanged

    End Sub

    Private Sub OLDPASS_TextChanged(sender As Object, e As EventArgs) Handles OLDPASS.TextChanged

    End Sub

    Private Sub NEWPASS_TextChanged(sender As Object, e As EventArgs) Handles NEWPASS.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim usernamea As String = USERNAME.Text
        Dim oldPassa As String = OLDPASS.Text
        Dim newPassa As String = NEWPASS.Text
        Dim selectedRole As String = ComboBox1.SelectedItem.ToString()

        If String.IsNullOrEmpty(usernamea) OrElse String.IsNullOrEmpty(oldPassa) OrElse String.IsNullOrEmpty(newPassa) OrElse String.IsNullOrEmpty(selectedRole) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        Dim connectionString As String = "Server=localhost; Database=FREESPACE; Uid=root; Pwd=password;"


        Using connection As New MySqlConnection(connectionString)
            Try

                connection.Open()

                Dim query As String = ""
                Select Case selectedRole
                    Case "admin"
                        query = "SELECT COUNT(*) FROM adminn WHERE username = @username AND password = @oldPass"
                    Case "faculty"
                        query = "SELECT COUNT(*) FROM faculty WHERE username = @username AND password = @oldPass"
                    Case "registrar"
                        query = "SELECT COUNT(*) FROM registrar WHERE username = @username AND password = @oldPass"
                    Case "student"
                        query = "SELECT COUNT(*) FROM student WHERE username = @username AND password = @oldPass"
                    Case Else
                        MessageBox.Show("Invalid role selected.")
                        Return
                End Select

                Using validateCommand As New MySqlCommand(query, connection)
                    validateCommand.Parameters.AddWithValue("@username", usernamea)
                    validateCommand.Parameters.AddWithValue("@oldPass", oldPassa)


                    Dim userExists As Integer = Convert.ToInt32(validateCommand.ExecuteScalar())

                    If userExists = 1 Then

                        Select Case selectedRole
                            Case "admin"
                                query = "UPDATE adminn SET password = @newPass WHERE username = @username"
                            Case "faculty"
                                query = "UPDATE faculty SET password = @newPass WHERE username = @username"
                            Case "registrar"
                                query = "UPDATE registrar SET password = @newPass WHERE username = @username"
                            Case "student"
                                query = "UPDATE student SET password = @newPass WHERE username = @username"
                        End Select


                        Using updateCommand As New MySqlCommand(query, connection)
                            updateCommand.Parameters.AddWithValue("@newPass", newPassa)
                            updateCommand.Parameters.AddWithValue("@username", usernamea)


                            updateCommand.ExecuteNonQuery()


                            MessageBox.Show("Password changed successfully!")
                        End Using
                    Else

                        MessageBox.Show("Wrong password")
                    End If
                End Using
            Catch ex As Exception

                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub forgotform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        USERNAME.Clear()
        OLDPASS.Clear()
        NEWPASS.Clear()


        ComboBox1.SelectedIndex = -1

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
