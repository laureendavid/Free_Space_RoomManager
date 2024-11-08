Imports MySql.Data.MySqlClient

Public Class UpdateSchedule
    Public Property Id As Integer
    Public Property Building As String
    Public Property RoomNumber As String
    Public Property Subject As String
    Public Property Teacher As String
    Public Property StartTime As DateTime
    Public Property EndTime As DateTime
    Public Property DayOfWeek As String
    Public Property SelectedRoomDataGrid As String

    Private Sub UpdateScheduleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        buildingtxt.Text = Building
        roomno.Text = RoomNumber
        subjecttxt.Text = Subject
        teachertxt.Text = Teacher
        DateTimePicker1.Value = StartTime
        DateTimePicker2.Value = EndTime


        DateTimePicker1.Format = DateTimePickerFormat.Time
        DateTimePicker1.ShowUpDown = True
        DateTimePicker2.Format = DateTimePickerFormat.Time
        DateTimePicker2.ShowUpDown = True


        PopulateDayOfWeekComboBox()


        ComboBox1.SelectedItem = DayOfWeek
    End Sub

    Private Sub PopulateDayOfWeekComboBox()
        ComboBox1.Items.Clear()
        ComboBox1.Items.AddRange(New String() {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles add.Click

        If String.IsNullOrEmpty(SelectedRoomDataGrid) Then
            MessageBox.Show("Selected room is not set.")
            Return
        End If


        Dim updatedBuilding As String = buildingtxt.Text
        Dim updatedRoomNumber As String = roomno.Text
        Dim updatedSubject As String = subjecttxt.Text
        Dim updatedTeacher As String = teachertxt.Text
        Dim updatedStartTime As DateTime = DateTimePicker1.Value
        Dim updatedEndTime As DateTime = DateTimePicker2.Value
        Dim updatedDayOfWeek As String = ComboBox1.SelectedItem.ToString()


        If IsTimeConflict(updatedStartTime, updatedEndTime, updatedDayOfWeek) Then
            MessageBox.Show("Cannot update schedule. The room will be occupied within this time.", "Schedule Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        UpdateScheduleInDatabase(updatedBuilding, updatedRoomNumber, updatedSubject, updatedTeacher, updatedStartTime, updatedEndTime, updatedDayOfWeek)


        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Function IsTimeConflict(updatedStartTime As DateTime, updatedEndTime As DateTime, updatedDayOfWeek As String) As Boolean
        Dim conflictQuery As String = "SELECT COUNT(*) FROM " & SelectedRoomDataGrid & " WHERE day_of_week = @dayOfWeek AND id <> @id AND ((start_time < @endTime AND end_time > @startTime) OR (start_time <= @startTime AND end_time >= @endTime))"
        Using conn As New MySqlConnection("server=localhost;user id=root;password=password;database=freespace")
            conn.Open()
            Using cmd As New MySqlCommand(conflictQuery, conn)
                cmd.Parameters.AddWithValue("@dayOfWeek", updatedDayOfWeek)
                cmd.Parameters.AddWithValue("@startTime", updatedStartTime)
                cmd.Parameters.AddWithValue("@endTime", updatedEndTime)
                cmd.Parameters.AddWithValue("@id", Id)

                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function

    Private Sub UpdateScheduleInDatabase(building As String, roomNumber As String, subject As String, teacher As String, startTime As DateTime, endTime As DateTime, dayOfWeek As String)
        Dim connectionString As String = "Server=localhost; Database=FREESPACE; Uid=root; Pwd=password;"
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "UPDATE " & SelectedRoomDataGrid & " SET building = @building, room_no = @roomNumber, subject = @subject, teacher = @teacher, start_time = @startTime, end_time = @endTime, day_of_week = @dayOfWeek WHERE id = @id"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@building", building)
                    command.Parameters.AddWithValue("@roomNumber", roomNumber)
                    command.Parameters.AddWithValue("@subject", subject)
                    command.Parameters.AddWithValue("@teacher", teacher)
                    command.Parameters.AddWithValue("@startTime", startTime)
                    command.Parameters.AddWithValue("@endTime", endTime)
                    command.Parameters.AddWithValue("@dayOfWeek", dayOfWeek)
                    command.Parameters.AddWithValue("@id", Id)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Schedule updated successfully!")
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        buildingtxt.Clear()
        roomno.Clear()
        subjecttxt.Clear()
        teachertxt.Clear()


        ComboBox1.SelectedIndex = -1


        DateTimePicker1.Value = DateTime.Now
        DateTimePicker2.Value = DateTime.Now
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
