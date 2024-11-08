Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class adminroomstatus
    Private conn As New MySqlConnection("server=localhost;user id=root;password=password;database=freespace")

    Private Sub adminroomstatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadData()
    End Sub

    Private Sub LoadData()
        Try
            conn.Open()
            Dim query As String = "SELECT Building, RoomNo, Status FROM RoomList"
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table


            For Each column As DataGridViewColumn In DataGridView1.Columns
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Next

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        LoadData()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim dv As DataView = CType(DataGridView1.DataSource, DataTable).DefaultView
        dv.RowFilter = String.Format("RoomNo LIKE '%{0}%' OR Status LIKE '%{0}%'", TextBox1.Text)
    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If DataGridView1.Columns(e.ColumnIndex).Name = "Status" Then
            If e.Value IsNot Nothing Then
                If e.Value.ToString() = "Occupied" Then
                    e.CellStyle.BackColor = Color.Red
                ElseIf e.Value.ToString() = "Available" Then
                    e.CellStyle.BackColor = Color.Green
                End If
            End If
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub



    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        reports.Show()
        Dim cryRpt As New ReportDocument
        cryRpt.Load("C:\Users\luka\source\repos\Free Space\Free Space\roomstatus.rpt")

        reports.CrystalReportViewer1.ReportSource = cryRpt
    End Sub
End Class
