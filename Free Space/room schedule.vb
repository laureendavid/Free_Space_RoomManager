Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class adminroomsched
    Private selectedRoomDataGrid As DataGridView

    Private Sub adminroomsched_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PopulateComboBox1()
        PopulateComboBox2()
    End Sub

    Private Sub PopulateComboBox1()
        ComboBox1.Items.Clear()
        ComboBox1.Items.AddRange(New String() {
            "A101", "B102", "B103", "B104", "B105", "B201", "B202", "B203", "B204", "B205", "AM101", "AM102", "AM103", "AM201", "AM202",
            "ARETEHALL", "DISCUSSIONROOM", "SIMULATIONROOM", "INSPERAREROBOTICSLAB",
            "NAXUS", "SANDBOX", "EDTECH", "PYSCH", "RESOURCESROOM", "ANATOMY",
            "PHYSICS", "MICROBIOLOGY", "CHEMISTRY", "AMPHITHEATER", "SKILLSLAB",
            "SCIENTIAHALL1", "SCIENTIAHALL2"
        })
    End Sub

    Private Sub PopulateComboBox2()
        ComboBox2.Items.Clear()
        ComboBox2.Items.AddRange(New String() {
        "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "All"
    })
        ComboBox1.SelectedIndex = -1
    End Sub


    Public Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        Panel5.Controls.Clear()

        Select Case ComboBox1.SelectedItem.ToString()
            Case "A101"
                ShowChildForm(A101)
                PopulateGridView("A101", A101.DataGridView1)
            Case "B102"
                ShowChildForm(B102)
                PopulateGridView("B102", B102.DataGridView1)
            Case "B103"
                ShowChildForm(B103)
                PopulateGridView("B103", B103.DataGridView1)
            Case "B104"
                ShowChildForm(B104)
                PopulateGridView("B104", B104.DataGridView1)
            Case "B105"
                ShowChildForm(B105)
                PopulateGridView("B105", B105.DataGridView1)
            Case "B201"
                ShowChildForm(B201)
                PopulateGridView("B201", B201.DataGridView1)
            Case "B202"
                ShowChildForm(B202)
                PopulateGridView("B202", B202.DataGridView1)
            Case "B203"
                ShowChildForm(B203)
                PopulateGridView("B203", B203.DataGridView1)
            Case "B204"
                ShowChildForm(B204)
                PopulateGridView("B204", B204.DataGridView1)
            Case "B205"
                ShowChildForm(B205)
                PopulateGridView("B205", B205.DataGridView1)
            Case "AM101"
                ShowChildForm(AM101)
                PopulateGridView("AM101", AM101.DataGridView1)
            Case "AM102"
                ShowChildForm(AM102)
                PopulateGridView("AM102", AM102.DataGridView1)
            Case "AM103"
                ShowChildForm(AM103)
                PopulateGridView("AM103", AM103.DataGridView1)
            Case "AM201"
                ShowChildForm(AM201)
                PopulateGridView("AM201", AM201.DataGridView1)
            Case "AM202"
                ShowChildForm(AM202)
                PopulateGridView("AM202", AM202.DataGridView1)
            Case "ARETEHALL"
                ShowChildForm(ARETEHALL)
                PopulateGridView("ARETEHALL", ARETEHALL.DataGridView1)
            Case "DISCUSSIONROOM"
                ShowChildForm(DISCUSSIONROOM)
                PopulateGridView("DISCUSSIONROOM", DISCUSSIONROOM.DataGridView1)
            Case "SIMULATIONROOM"
                ShowChildForm(SIMULATIONROOM)
                PopulateGridView("SIMULATIONROOM", SIMULATIONROOM.DataGridView1)
            Case "INSPERAREROBOTICSLAB"
                ShowChildForm(INSPERAREROBOTICSLAB)
                PopulateGridView("INSPERAREROBOTICSLAB", INSPERAREROBOTICSLAB.DataGridView1)
            Case "NAXUS"
                ShowChildForm(NAXUS)
                PopulateGridView("NAXUS", NAXUS.DataGridView1)
            Case "SANDBOX"
                ShowChildForm(SANDBOX)
                PopulateGridView("SANDBOX", SANDBOX.DataGridView1)
            Case "EDTECH"
                ShowChildForm(EDTECH)
                PopulateGridView("EDTECH", EDTECH.DataGridView1)
            Case "PYSCH"
                ShowChildForm(PYSCH)
                PopulateGridView("PYSCH", PYSCH.DataGridView1)
            Case "RESOURCESROOM"
                ShowChildForm(RESOURCEROOM)
                PopulateGridView("RESOURCESROOM", RESOURCEROOM.DataGridView1)
            Case "ANATOMY"
                ShowChildForm(ANATOMY)
                PopulateGridView("ANATOMY", ANATOMY.DataGridView1)
            Case "PHYSICS"
                ShowChildForm(PHYSICS)
                PopulateGridView("PHYSICS", PHYSICS.DataGridView1)
            Case "MICROBIOLOGY"
                ShowChildForm(MICROBIOLOGY)
                PopulateGridView("MICROBIOLOGY", MICROBIOLOGY.DataGridView1)
            Case "CHEMISTRY"
                ShowChildForm(CHEMISTRY)
                PopulateGridView("CHEMISTRY", CHEMISTRY.DataGridView1)
            Case "AMPHITHEATER"
                ShowChildForm(AMPITHEATER)
                PopulateGridView("AMPHITHEATER", AMPITHEATER.DataGridView1)
            Case "SKILLSLAB"
                ShowChildForm(SKILLSLAB)
                PopulateGridView("SKILLSLAB", SKILLSLAB.DataGridView1)
            Case "SCIENTIAHALL1"
                ShowChildForm(SCIENTIAHALL1)
                PopulateGridView("SCIENTIAHALL1", SCIENTIAHALL1.DataGridView1)
            Case "SCIENTIAHALL2"
                ShowChildForm(SCIENTIAHALL2)
                PopulateGridView("SCIENTIAHALL2", SCIENTIAHALL2.DataGridView1)

            Case Else
                selectedRoomDataGrid = Nothing
                MessageBox.Show("Room not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub

    Private Sub ShowChildForm(ByVal childForm As Form)
        Panel5.AutoScroll = True
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.None
        Panel5.Controls.Add(childForm)
        childForm.Show()
    End Sub

    Private Sub PopulateGridView(tableName As String, dataGridView As DataGridView)
        Dim dayFilter As String = String.Empty

        ' Check if ComboBox2 has a selected day
        If ComboBox2.SelectedItem IsNot Nothing Then
            dayFilter = ComboBox2.SelectedItem.ToString()
        End If

        ' Modify the query to include the day filter if necessary
        Dim query As String = "SELECT building, room_no, subject, teacher, start_time, end_time, day_of_week, id FROM " & tableName

        ' If a specific day is selected (other than "All"), add a WHERE clause
        If Not String.IsNullOrEmpty(dayFilter) AndAlso dayFilter <> "All" Then
            query &= " WHERE day_of_week = '" & dayFilter & "'"
        End If

        ' Order by day of week and start time
        query &= " ORDER BY FIELD(day_of_week, 'Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'), start_time"

        Dim connectionString As String = "Server=localhost; Database=FREESPACE; Uid=root; Pwd=password;"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim adapter As New MySqlDataAdapter(query, connection)
                Dim table As New DataTable()
                adapter.Fill(table)
                dataGridView.DataSource = table
                dataGridView.Columns("id").Visible = False
            Catch ex As Exception
                MessageBox.Show("An error occurred while populating the grid: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If ComboBox1.SelectedItem IsNot Nothing Then
            Dim selectedRoom As String = ComboBox1.SelectedItem.ToString()
            Select Case selectedRoom
                Case "A101"
                    PopulateGridView("A101", A101.DataGridView1)

                Case "B102"
                    PopulateGridView("B102", B102.DataGridView1)
                Case "B103"
                    PopulateGridView("B103", B103.DataGridView1)
                Case "B104"
                    PopulateGridView("B104", B104.DataGridView1)
                Case "B105"
                    PopulateGridView("B105", B105.DataGridView1)
                Case "B201"
                    PopulateGridView("B201", B201.DataGridView1)
                Case "B202"
                    PopulateGridView("B202", B202.DataGridView1)
                Case "B203"
                    PopulateGridView("B203", B203.DataGridView1)
                Case "B204"
                    PopulateGridView("B204", B204.DataGridView1)
                Case "B205"
                    PopulateGridView("B205", B205.DataGridView1)
                Case "AM101"
                    PopulateGridView("AM101", AM101.DataGridView1)
                Case "AM102"
                    PopulateGridView("AM102", AM102.DataGridView1)
                Case "AM103"
                    PopulateGridView("AM103", AM103.DataGridView1)
                Case "AM201"
                    PopulateGridView("AM201", AM201.DataGridView1)
                Case "AM202"
                    PopulateGridView("AM202", AM202.DataGridView1)
                Case "ARETEHALL"
                    PopulateGridView("ARETEHALL", ARETEHALL.DataGridView1)
                Case "DISCUSSIONROOM"
                    PopulateGridView("DISCUSSIONROOM", DISCUSSIONROOM.DataGridView1)
                Case "SIMULATIONROOM"
                    PopulateGridView("SIMULATIONROOM", SIMULATIONROOM.DataGridView1)
                Case "INSPERAREROBOTICSLAB"
                    PopulateGridView("INSPERAREROBOTICSLAB", INSPERAREROBOTICSLAB.DataGridView1)
                Case "NAXUS"
                    PopulateGridView("NAXUS", NAXUS.DataGridView1)
                Case "SANDBOX"
                    PopulateGridView("SANDBOX", SANDBOX.DataGridView1)
                Case "EDTECH"
                    PopulateGridView("EDTECH", EDTECH.DataGridView1)
                Case "PYSCH"
                    PopulateGridView("PYSCH", PYSCH.DataGridView1)
                Case "RESOURCESROOM"
                    PopulateGridView("RESOURCEROOM", RESOURCEROOM.DataGridView1)
                Case "ANATOMY"
                    PopulateGridView("ANATOMY", ANATOMY.DataGridView1)
                Case "PHYSICS"
                    PopulateGridView("PHYSICS", PHYSICS.DataGridView1)
                Case "MICROBIOLOGY"
                    PopulateGridView("MICROBIOLOGY", MICROBIOLOGY.DataGridView1)
                Case "CHEMISTRY"
                    PopulateGridView("CHEMISTRY", CHEMISTRY.DataGridView1)
                Case "AMPHITHEATER"
                    PopulateGridView("AMPITHEATER", AMPITHEATER.DataGridView1)
                Case "SKILLSLAB"
                    PopulateGridView("SKILLSLAB", SKILLSLAB.DataGridView1)
                Case "SCIENTIAHALL1"
                    PopulateGridView("SCIENTIAHALL1", SCIENTIAHALL1.DataGridView1)
                Case "SCIENTIAHALL2"
                    PopulateGridView("SCIENTIAHALL2", SCIENTIAHALL2.DataGridView1)
                Case Else
                    MessageBox.Show("Room not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a room first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim selectedRoom As String = ComboBox1.SelectedItem.ToString()
        Dim reportPath As String = ""

        ' Map the selected room to the appropriate Crystal Report file
        Select Case selectedRoom
            Case "A101"
                reportPath = "C:\Users\luka\source\repos\Free Space\Free Space\A101reports.rpt"
            Case "B102"
                reportPath = "C:\Users\luka\source\repos\Free Space\Free Space\B102reports.rpt"
            Case "B103"
                reportPath = "C:\Users\luka\source\repos\Free Space\Free Space\B103reports.rpt"
            Case "B104"
                reportPath = "C:\Users\luka\source\repos\Free Space\Free Space\B104reports.rpt"
            Case "B105"
                reportPath = "C:\Users\luka\source\repos\Free Space\Free Space\B105reports.rpt"
            Case "B201"
                reportPath = "C:\Users\luka\source\repos\Free Space\Free Space\B201reports.rpt"
            Case "B202"
                reportPath = "C:\Users\luka\source\repos\Free Space\Free Space\B202reports.rpt"
            Case "B203"
                reportPath = "C:\Users\luka\source\repos\Free Space\Free Space\B203reports.rpt"
            Case "B204"
                reportPath = "C:\Users\luka\source\repos\Free Space\Free Space\B204reports.rpt"
            Case "B205"
                reportPath = "C:\Users\luka\source\repos\Free Space\Free Space\B205reports.rpt"
            Case "AM101"
                reportPath = "C:\Users\luka\source\repos\Free Space\Free Space\AM101reports.rpt"
            Case "AM102"
                reportPath = "C:\Users\luka\source\repos\Free Space\Free Space\AM102reports.rpt"
            Case "AM103"
                reportPath = "C:\Users\luka\source\repos\Free Space\Free Space\AM103reports.rpt"
            Case "AM201"
                reportPath = "C:\Users\luka\source\repos\Free Space\Free Space\AM201reports.rpt"
            Case "AM202"
                reportPath = "C:\Users\luka\source\repos\Free Space\Free Space\AM202reports.rpt"
            Case "ARETEHALL"
                reportPath = "C:\Users\luka\source\repos\Free Space\Free Space\ARETEHALLreports.rpt"
            Case "DISCUSSIONROOM"
                reportPath = "C:\Users\luka\source\repos\Free Space\Free Space\discussionroomreports.rpt"
            Case "SIMULATIONROOM"
                reportPath = "C:\Users\luka\source\repos\Free Space\Free Space\simulationroomreports.rpt"
            Case "INSPERAREROBOTICSLAB"
                reportPath = "C:\Users\luka\source\repos\Free Space\Free Space\INSPERAREROBOTICSLABreports.rpt"
            Case "NAXUS"
                reportPath = "C:\Users\luka\source\repos\Free Space\Free Space\NAXUSreports.rpt"
            Case "SANDBOX"
                reportPath = "C:\Users\luka\source\repos\Free Space\Free Space\SANDBOXreports.rpt"
            Case "EDTECH"
                reportPath = "C:\Users\luka\source\repos\Free Space\Free Space\EDTECHreports.rpt"
            Case "PYSCH"
                reportPath = "C:\Users\luka\source\repos\Free Space\Free Space\PYSCHreports.rpt"
            Case "RESOURCESROOM"
                reportPath = "C:\Users\luka\source\repos\Free Space\Free Space\RESOURCESROOMreports.rpt"
            Case "ANATOMY"
                reportPath = "C:\Users\luka\source\repos\Free Space\Free Space\ANATOMYreports.rpt"
            Case "PHYSICS"
                reportPath = "C:\Users\luka\source\repos\Free Space\Free Space\PHYSICSreports.rpt"
            Case "MICROBIOLOGY"
                reportPath = "C:\Users\luka\source\repos\Free Space\Free Space\MICROBIOLOGYreports.rpt"
            Case "CHEMISTRY"
                reportPath = "C:\Users\luka\source\repos\Free Space\Free Space\CHEMISTRYreports.rpt"
            Case "AMPHITHEATER"
                reportPath = "C:\Users\luka\source\repos\Free Space\Free Space\AMPHITHEATERreports.rpt"
            Case "SKILLSLAB"
                reportPath = "C:\Users\luka\source\repos\Free Space\Free Space\SKILLSLABreports.rpt"
            Case "SCIENTIAHALL1"
                reportPath = "C:\Users\luka\source\repos\Free Space\Free Space\SCIENTIAHALL1reports.rpt"
            Case "SCIENTIAHALL2"
                reportPath = "C:\Users\luka\source\repos\Free Space\Free Space\SCIENTIAHALL2reports.rpt"


                ' Add cases for other rooms as needed
            Case Else
                MessageBox.Show("No report available for the selected room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
        End Select

        ' Check if the report file exists
        If Not IO.File.Exists(reportPath) Then
            MessageBox.Show("Report file not found: " & reportPath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Load and display the report
        Try
            Dim cryRpt As New ReportDocument()
            cryRpt.Load(reportPath)
            reports.CrystalReportViewer1.ReportSource = cryRpt
            reports.Show()
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading the report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox1.SelectedItem IsNot Nothing Then
            Dim selectedRoom As String = ComboBox1.SelectedItem.ToString()
            Select Case selectedRoom
                Case "A101"
                    PopulateGridView("A101", A101.DataGridView1)
                Case "B102"
                    PopulateGridView("B102", B102.DataGridView1)
                Case "B103"
                    PopulateGridView("B103", B103.DataGridView1)
                Case "B104"
                    PopulateGridView("B104", B104.DataGridView1)
                Case "B105"
                    PopulateGridView("B105", B105.DataGridView1)
                Case "B201"
                    PopulateGridView("B201", B201.DataGridView1)
                Case "B202"
                    PopulateGridView("B202", B202.DataGridView1)
                Case "B203"
                    PopulateGridView("B203", B203.DataGridView1)
                Case "B204"
                    PopulateGridView("B204", B204.DataGridView1)
                Case "B205"
                    PopulateGridView("B205", B205.DataGridView1)
                Case "AM101"
                    PopulateGridView("AM101", AM101.DataGridView1)
                Case "AM102"
                    PopulateGridView("AM102", AM102.DataGridView1)
                Case "AM103"
                    PopulateGridView("AM103", AM103.DataGridView1)
                Case "AM201"
                    PopulateGridView("AM201", AM201.DataGridView1)
                Case "AM202"
                    PopulateGridView("AM202", AM202.DataGridView1)
                Case "ARETEHALL"
                    PopulateGridView("ARETEHALL", ARETEHALL.DataGridView1)
                Case "DISCUSSIONROOM"
                    PopulateGridView("DISCUSSIONROOM", DISCUSSIONROOM.DataGridView1)
                Case "SIMULATIONROOM"
                    PopulateGridView("SIMULATIONROOM", SIMULATIONROOM.DataGridView1)
                Case "INSPERAREROBOTICSLAB"
                    PopulateGridView("INSPERAREROBOTICSLAB", INSPERAREROBOTICSLAB.DataGridView1)
                Case "NAXUS"
                    PopulateGridView("NAXUS", NAXUS.DataGridView1)
                Case "SANDBOX"
                    PopulateGridView("SANDBOX", SANDBOX.DataGridView1)
                Case "EDTECH"
                    PopulateGridView("EDTECH", EDTECH.DataGridView1)
                Case "PYSCH"
                    PopulateGridView("PYSCH", PYSCH.DataGridView1)
                Case "RESOURCESROOM"
                    PopulateGridView("RESOURCESROOM", RESOURCEROOM.DataGridView1)
                Case "ANATOMY"
                    PopulateGridView("ANATOMY", ANATOMY.DataGridView1)
                Case "PHYSICS"
                    PopulateGridView("PHYSICS", PHYSICS.DataGridView1)
                Case "MICROBIOLOGY"
                    PopulateGridView("MICROBIOLOGY", MICROBIOLOGY.DataGridView1)
                Case "CHEMISTRY"
                    PopulateGridView("CHEMISTRY", CHEMISTRY.DataGridView1)
                Case "AMPHITHEATER"
                    PopulateGridView("AMPHITHEATER", AMPITHEATER.DataGridView1)
                Case "SKILLSLAB"
                    PopulateGridView("SKILLSLAB", SKILLSLAB.DataGridView1)
                Case "SCIENTIAHALL1"
                    PopulateGridView("SCIENTIAHALL1", SCIENTIAHALL1.DataGridView1)
                Case "SCIENTIAHALL2"
                    PopulateGridView("SCIENTIAHALL2", SCIENTIAHALL2.DataGridView1)
                    ' Add more rooms as necessary...
                Case Else
                    MessageBox.Show("Please select a valid room", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        End If
    End Sub

End Class