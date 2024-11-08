Imports MySql.Data.MySqlClient

Public Class reservation
    Private Sub reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PopulateDayComboBox()


        PopulateRoomNoComboBox()


        ENDTIME.Format = DateTimePickerFormat.Time
        ENDTIME.ShowUpDown = True

        STARTTIME.Format = DateTimePickerFormat.Time
        STARTTIME.ShowUpDown = True
    End Sub

    Private Sub PopulateDayComboBox()
        DAY.Items.Clear()
        DAY.Items.AddRange(New String() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"})
    End Sub

    Private Sub PopulateRoomNoComboBox()
        ROOMNO.Items.Clear()
        ROOMNO.Items.AddRange(New String() {"A101", "B102", "B103", "B104", "B105", "B201", "B202", "B203", "B204", "B205", "AM101", "AM102", "AM103", "AM201", "AM202", "ARETEHALL", "DISCUSSIONROOM", "SIMULATIONROOM", "INSPERAREROBOTICSLAB", "NAXUS", "SANDBOX", "EDTECH", "PYSCH", "RESOURCESROOM", "ANATOMY", "PHYSICS", "MICROBIOLOGY", "CHEMISTRY", "AMPHITHEATER", "SKILLSLAB", "SCIENTIAHALL1", "SCIENTIAHALL2"})
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim roomNo1 As String = ROOMNO.SelectedItem.ToString()
        Dim day1 As String = DAY.SelectedItem.ToString()
        Dim name As String = NAMETXT.Text
        Dim subject As String = SUBJTXT.Text
        Dim startTime1 As TimeSpan = STARTTIME.Value.TimeOfDay
        Dim endTime1 As TimeSpan = ENDTIME.Value.TimeOfDay


        If String.IsNullOrEmpty(roomNo1) OrElse String.IsNullOrEmpty(day1) OrElse String.IsNullOrEmpty(name) OrElse String.IsNullOrEmpty(subject) Then
            MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        InsertReservation(roomNo1, day1, name, subject, startTime1, endTime1)
    End Sub

    Private Sub InsertReservation(roomNo As String, day As String, name As String, subject As String, startTime As TimeSpan, endTime As TimeSpan)
        Dim connectionString As String = "Server=localhost; Database=FREESPACE; Uid=root; Pwd=password;"
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "INSERT INTO Reservations (RoomNo, StartTime, EndTime, DayOfWeek, facultyName, facultySubject) VALUES (@roomNo, @startTime, @endTime, @dayOfWeek, @name, @subject)"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@roomNo", roomNo)
                    command.Parameters.AddWithValue("@startTime", startTime)
                    command.Parameters.AddWithValue("@endTime", endTime)
                    command.Parameters.AddWithValue("@dayOfWeek", day)
                    command.Parameters.AddWithValue("@name", name)
                    command.Parameters.AddWithValue("@subject", subject)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Reservation added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub ROOMNO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ROOMNO.SelectedIndexChanged

    End Sub

    Private Sub STARTTIME_ValueChanged(sender As Object, e As EventArgs) Handles STARTTIME.ValueChanged

    End Sub

    Private Sub DAY_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DAY.SelectedIndexChanged

    End Sub

    Private Sub NAMETXT_TextChanged(sender As Object, e As EventArgs) Handles NAMETXT.TextChanged

    End Sub

    Private Sub SUBJTXT_TextChanged(sender As Object, e As EventArgs) Handles SUBJTXT.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        NAMETXT.Clear()
        SUBJTXT.Clear()


        ROOMNO.SelectedIndex = -1
        DAY.SelectedIndex = -1


        STARTTIME.Value = DateTime.Now
        ENDTIME.Value = DateTime.Now


    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class
