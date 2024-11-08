Imports MySql.Data.MySqlClient

Public Class addsched

    Private selectedRoom As String


    Public Sub New()

        InitializeComponent()
    End Sub


    Private Sub addsched_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Sunday")
        ComboBox1.Items.Add("Monday")
        ComboBox1.Items.Add("Tuesday")
        ComboBox1.Items.Add("Wednesday")
        ComboBox1.Items.Add("Thursday")
        ComboBox1.Items.Add("Friday")
        ComboBox1.Items.Add("Saturday")

        ComboBox2.Items.Clear()
        ComboBox2.Items.Add("A101")
        ComboBox2.Items.Add("B102")
        ComboBox2.Items.Add("B103")
        ComboBox2.Items.Add("B104")
        ComboBox2.Items.Add("B105")
        ComboBox2.Items.Add("B201")
        ComboBox2.Items.Add("B202")
        ComboBox2.Items.Add("B203")
        ComboBox2.Items.Add("B204")
        ComboBox2.Items.Add("B205")
        ComboBox2.Items.Add("AM101")
        ComboBox2.Items.Add("AM102")
        ComboBox2.Items.Add("AM103")
        ComboBox2.Items.Add("AM201")
        ComboBox2.Items.Add("AM202")
        ComboBox2.Items.Add("ARETEHALL")
        ComboBox2.Items.Add("DISCUSSIONROOM")
        ComboBox2.Items.Add("SIMULATIONROOM")
        ComboBox2.Items.Add("INSPERAREROBOTICSLAB")
        ComboBox2.Items.Add("NAXUS")
        ComboBox2.Items.Add("SANDBOX")
        ComboBox2.Items.Add("EDTECH")
        ComboBox2.Items.Add("PYSCH")
        ComboBox2.Items.Add("RESOURCESROOM")
        ComboBox2.Items.Add("ANATOMY")
        ComboBox2.Items.Add("PHYSICS")
        ComboBox2.Items.Add("MICROBIOLOGY")
        ComboBox2.Items.Add("CHEMISTRY")
        ComboBox2.Items.Add("AMPHITHEATER")
        ComboBox2.Items.Add("SKILLSLAB")
        ComboBox2.Items.Add("SCIENTIAHALL1")
        ComboBox2.Items.Add("SCIENTIAHALL2")


        DateTimePicker1.Format = DateTimePickerFormat.Time
        DateTimePicker1.ShowUpDown = True

        DateTimePicker2.Format = DateTimePickerFormat.Time
        DateTimePicker2.ShowUpDown = True
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub


    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

        If ComboBox2.SelectedItem IsNot Nothing Then
            selectedRoom = ComboBox2.SelectedItem.ToString()
        End If
    End Sub


    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click

        Dim building As String = buildingtxt.Text
        Dim roomNumber As String = roomno.Text
        Dim subject As String = subjecttxt.Text
        Dim teacher As String = teachertxt.Text

        Dim startTime As DateTime = DateTimePicker1.Value
        Dim endTime As DateTime = DateTimePicker2.Value
        Dim dayOfWeek As String = If(ComboBox1.SelectedItem IsNot Nothing, ComboBox1.SelectedItem.ToString(), String.Empty)

        If String.IsNullOrEmpty(building) OrElse String.IsNullOrEmpty(roomNumber) OrElse String.IsNullOrEmpty(subject) OrElse
           String.IsNullOrEmpty(teacher) OrElse String.IsNullOrEmpty(dayOfWeek) OrElse
           startTime = DateTime.MinValue OrElse endTime = DateTime.MinValue Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If


        Dim id As Integer = GetNewId()


        AddScheduleToDatabase(id, building, roomNumber, subject, teacher, startTime, endTime, dayOfWeek)


        Me.Hide()
    End Sub


    Private Function GetNewId() As Integer

        Return New Random().Next(1, 1000)
    End Function


    Private Sub AddScheduleToDatabase(id As Integer, building As String, roomNumber As String, subject As String, teacher As String, startTime As DateTime, endTime As DateTime, dayOfWeek As String)
        Try

            If String.IsNullOrEmpty(selectedRoom) Then
                MessageBox.Show("Please select a room from the ComboBox first.")
                Return
            End If


            Dim checkQuery As String = "SELECT COUNT(*) FROM " & selectedRoom & " WHERE day_of_week = @dayOfWeek AND ((start_time <= @endTime AND start_time >= @startTime) OR (end_time <= @endTime AND end_time >= @startTime))"
            Dim insertQuery As String = "INSERT INTO " & selectedRoom & " (id, building, room_no, subject, teacher, start_time, end_time, day_of_week) VALUES (@id, @building, @roomNumber, @subject, @teacher, @startTime, @endTime, @dayOfWeek)"

            Using conn As New MySqlConnection("server=localhost;user id=root;password=password;database=freespace")
                conn.Open()


                Using checkCmd As New MySqlCommand(checkQuery, conn)
                    checkCmd.Parameters.AddWithValue("@dayOfWeek", dayOfWeek)
                    checkCmd.Parameters.AddWithValue("@startTime", startTime)
                    checkCmd.Parameters.AddWithValue("@endTime", endTime)

                    Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("Cannot add schedule. The room will be occupied within this time.")
                        Return
                    End If
                End Using


                Using insertCmd As New MySqlCommand(insertQuery, conn)
                    insertCmd.Parameters.AddWithValue("@id", id)
                    insertCmd.Parameters.AddWithValue("@building", building)
                    insertCmd.Parameters.AddWithValue("@roomNumber", roomNumber)
                    insertCmd.Parameters.AddWithValue("@subject", subject)
                    insertCmd.Parameters.AddWithValue("@teacher", teacher)
                    insertCmd.Parameters.AddWithValue("@startTime", startTime)
                    insertCmd.Parameters.AddWithValue("@endTime", endTime)
                    insertCmd.Parameters.AddWithValue("@dayOfWeek", dayOfWeek)

                    insertCmd.ExecuteNonQuery()
                    MessageBox.Show("Class schedule added successfully to " & selectedRoom & "!")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        buildingtxt.Clear()
        roomno.Clear()
        subjecttxt.Clear()
        teachertxt.Clear()


        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1


        DateTimePicker1.Value = DateTime.Now
        DateTimePicker2.Value = DateTime.Now


        selectedRoom = String.Empty
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
