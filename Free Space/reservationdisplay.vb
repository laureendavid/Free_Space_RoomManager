Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class reservationdisplay
    Private Sub reservationdisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadReservations()
    End Sub

    Private Sub LoadReservations()
        Dim connectionString As String = "Server=localhost; Database=FREESPACE; Uid=root; Pwd=password;"
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT * FROM Reservations"
                Dim adapter As New MySqlDataAdapter(query, connection)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)
                DataGridView1.DataSource = dataTable


                If DataGridView1.Columns("ReservationID") IsNot Nothing Then
                    DataGridView1.Columns("ReservationID").Visible = False
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        DeleteSelectedReservation()

        LoadReservations()
    End Sub

    Private Sub DeleteSelectedReservation()
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim reservationId As Integer = Convert.ToInt32(selectedRow.Cells("ReservationID").Value)

            Dim connectionString As String = "Server=localhost; Database=FREESPACE; Uid=root; Pwd=password;"
            Using connection As New MySqlConnection(connectionString)
                Try
                    connection.Open()
                    Dim query As String = "DELETE FROM Reservations WHERE ReservationID = @reservationId"
                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@reservationId", reservationId)
                        command.ExecuteNonQuery()
                        MessageBox.Show("Reservation deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using
                Catch ex As Exception
                    MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        Else
            MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        LoadReservations()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        addsched.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        reports.Show()
        Dim cryRpt As New ReportDocument
        cryRpt.Load("C:\Users\luka\source\repos\Free Space\Free Space\reservationreports.rpt")

        reports.CrystalReportViewer1.ReportSource = cryRpt
    End Sub
End Class
