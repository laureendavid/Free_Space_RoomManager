Imports MySql.Data.MySqlClient

Public Class UPDATEUSER
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim oldUsername As String = TextBox1.Text
        Dim newUsername As String = TextBox2.Text
        Dim newPassword As String = TextBox3.Text
        Dim selectedRole As String = ComboBox1.SelectedItem.ToString()


        If String.IsNullOrEmpty(oldUsername) OrElse String.IsNullOrEmpty(selectedRole) Then
            MessageBox.Show("Please fill in the old username and select a role.")
            Return
        End If


        Dim connectionString As String = "Server=localhost; Database=FREESPACE; Uid=root; Pwd=password;"


        Using connection As New MySqlConnection(connectionString)
            Try

                connection.Open()


                Dim query As New Text.StringBuilder("UPDATE ")
                Select Case selectedRole
                    Case "admin"
                        query.Append("adminn ")
                    Case "faculty"
                        query.Append("faculty ")
                    Case "registrar"
                        query.Append("registrar ")
                    Case "student"
                        query.Append("student ")
                    Case Else
                        MessageBox.Show("Invalid role selected.")
                        Return
                End Select
                query.Append("SET ")


                Dim parameters As New List(Of MySqlParameter)


                If Not String.IsNullOrEmpty(newUsername) Then
                    query.Append("username = @newUsername, ")
                    parameters.Add(New MySqlParameter("@newUsername", newUsername))
                End If

                If Not String.IsNullOrEmpty(newPassword) Then
                    query.Append("password = @newPassword, ")
                    parameters.Add(New MySqlParameter("@newPassword", newPassword))
                End If


                If parameters.Count > 0 Then
                    query.Length -= 2
                Else
                    MessageBox.Show("No new data to update.")
                    Return
                End If

                query.Append(" WHERE username = @oldUsername")
                parameters.Add(New MySqlParameter("@oldUsername", oldUsername))


                Using command As New MySqlCommand(query.ToString(), connection)
                    command.Parameters.AddRange(parameters.ToArray())


                    command.ExecuteNonQuery()


                    MessageBox.Show("User information successfully updated.")
                End Using
            Catch ex As Exception

                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub UPDATEUSER_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()


        ComboBox1.SelectedIndex = -1


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
