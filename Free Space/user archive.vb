Imports MySql.Data.MySqlClient

Public Class userarchive

    Dim conn As New MySqlConnection("server=localhost;user id=root;password=password;database=freespace")


    Private gridfacultyForm As New gridfaculty()
    Private gridadminForm As New gridadmin()
    Private gridstudentForm As New gridstudent()
    Private gridregistrarForm As New gridregistrar()

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UPDATEUSER.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        Panel4.Controls.Clear()


        Select Case ComboBox1.SelectedItem.ToString()
            Case "Faculty"
                ShowChildForm(gridfacultyForm)
                PopulateGridFaculty()
            Case "Admin"
                ShowChildForm(gridadminForm)
                PopulateGridAdmin()
            Case "Student"
                ShowChildForm(gridstudentForm)
                PopulateGridStudent()
            Case "Registrar"
                ShowChildForm(gridregistrarForm)
                PopulateGridRegistrar()
        End Select
    End Sub


    Private Sub ShowChildForm(ByVal childForm As Form)
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        Panel4.Controls.Add(childForm)
        childForm.Show()
    End Sub


    Private Sub userarchive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Faculty")
        ComboBox1.Items.Add("Admin")
        ComboBox1.Items.Add("Student")
        ComboBox1.Items.Add("Registrar")
    End Sub


    Private Sub PopulateGridFaculty()
        Dim query As String = "SELECT id, username, password FROM faculty"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        gridfacultyForm.DataGridView1.DataSource = table
    End Sub

    Private Sub PopulateGridAdmin()
        Dim query As String = "SELECT id, username, password FROM adminn"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        gridadminForm.DataGridView1.DataSource = table
    End Sub

    Private Sub PopulateGridStudent()
        Dim query As String = "SELECT id, username, password FROM student"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        gridstudentForm.DataGridView1.DataSource = table
    End Sub

    Private Sub PopulateGridRegistrar()
        Dim query As String = "SELECT id, username, password FROM registrar"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        gridregistrarForm.DataGridView1.DataSource = table
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim selectedRow As DataGridViewRow = Nothing


        If Panel4.Controls.Contains(gridfacultyForm) Then
            selectedRow = gridfacultyForm.DataGridView1.CurrentRow
            DeleteRecord("faculty", selectedRow)
        ElseIf Panel4.Controls.Contains(gridadminForm) Then
            selectedRow = gridadminForm.DataGridView1.CurrentRow
            DeleteRecord("adminn", selectedRow)
        ElseIf Panel4.Controls.Contains(gridstudentForm) Then
            selectedRow = gridstudentForm.DataGridView1.CurrentRow
            DeleteRecord("student", selectedRow)
        ElseIf Panel4.Controls.Contains(gridregistrarForm) Then
            selectedRow = gridregistrarForm.DataGridView1.CurrentRow
            DeleteRecord("registrar", selectedRow)
        End If
    End Sub


    Private Sub DeleteRecord(tableName As String, selectedRow As DataGridViewRow)
        If selectedRow Is Nothing Then
            MessageBox.Show("Please select a record to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim id As Integer = Convert.ToInt32(selectedRow.Cells("id").Value)
        Dim query As String = $"DELETE FROM {tableName} WHERE id = @id"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@id", id)

        Try
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Record deleted successfully.")


            selectedRow.DataGridView.Rows.Remove(selectedRow)
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If Panel4.Controls.Contains(gridfacultyForm) Then
            PopulateGridFaculty()
        ElseIf Panel4.Controls.Contains(gridadminForm) Then
            PopulateGridAdmin()
        ElseIf Panel4.Controls.Contains(gridstudentForm) Then
            PopulateGridStudent()
        ElseIf Panel4.Controls.Contains(gridregistrarForm) Then
            PopulateGridRegistrar()
        End If
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
