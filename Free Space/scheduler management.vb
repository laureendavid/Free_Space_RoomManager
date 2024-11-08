Imports MySql.Data.MySqlClient
Public Class adminschedmanagement

    Dim conn As New MySqlConnection("server=localhost;user id=root;password=password;database=freespace")

    Private selectedRoom As String
    Public selectedRoomDataGrid As DataGridView

    Private A101Form As New A101()
    Private B102Form As New B102()
    Private B103Form As New B103()
    Private B104Form As New B104()
    Private B105Form As New B105()
    Private B201Form As New B201()
    Private B202Form As New B202()
    Private B203Form As New B203()
    Private B204Form As New B204()
    Private B205Form As New B205()
    Private AM101Form As New AM101()
    Private AM102Form As New AM102()
    Private AM103Form As New AM103()
    Private AM201Form As New AM201()
    Private AM202Form As New AM202()
    Private ARETEHALLForm As New ARETEHALL()
    Private DISCUSSIONROOMForm As New DISCUSSIONROOM()
    Private SIMULATIONROOMForm As New SIMULATIONROOM()
    Private INSPERAREROBOTICSLABForm As New INSPERAREROBOTICSLAB()
    Private NAXUSForm As New NAXUS()
    Private SANDBOXForm As New SANDBOX()
    Private EDTECHForm As New EDTECH()
    Private PYSCHForm As New PYSCH()
    Private RESOURCESROOMForm As New RESOURCEROOM()
    Private ANATOMYForm As New ANATOMY()
    Private PHYSICSForm As New PHYSICS()
    Private MICROBIOLOGYForm As New MICROBIOLOGY()
    Private CHEMISTRYForm As New CHEMISTRY()
    Private AMPHITHEATERForm As New AMPITHEATER()
    Private SKILLSLABForm As New SKILLSLAB()
    Private SCIENTIAHALL1Form As New SCIENTIAHALL1()
    Private SCIENTIAHALL2Form As New SCIENTIAHALL2()

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Public Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

        Panel5.Controls.Clear()


        Select Case ComboBox2.SelectedItem.ToString()
            Case "A101"
                ShowChildForm(A101Form)
                PopulateGridA101()
                PopulateGridView("A101", A101Form.DataGridView1)
                selectedRoomDataGrid = A101Form.DataGridView1
            Case "B102"
                ShowChildForm(B102Form)
                PopulateGridB102()
                PopulateGridView("B102", B102Form.DataGridView1)
                selectedRoomDataGrid = B102Form.DataGridView1
            Case "B103"
                ShowChildForm(B103Form)
                PopulateGridB103()
                PopulateGridView("B103", B103Form.DataGridView1)
                selectedRoomDataGrid = B103Form.DataGridView1
            Case "B104"
                ShowChildForm(B104Form)
                PopulateGridB104()
                PopulateGridView("B104", B104Form.DataGridView1)
                selectedRoomDataGrid = B104Form.DataGridView1
            Case "B105"
                ShowChildForm(B105Form)
                PopulateGridB105()
                PopulateGridView("B105", B105Form.DataGridView1)
                selectedRoomDataGrid = B105Form.DataGridView1
            Case "B201"
                ShowChildForm(B201Form)
                PopulateGridB201()
                PopulateGridView("B201", B201Form.DataGridView1)
                selectedRoomDataGrid = B201Form.DataGridView1
            Case "B202"
                ShowChildForm(B202Form)
                PopulateGridB202()
                PopulateGridView("B202", B202Form.DataGridView1)
                selectedRoomDataGrid = B202Form.DataGridView1
            Case "B203"
                ShowChildForm(B203Form)
                PopulateGridB203()
                PopulateGridView("B203", B203Form.DataGridView1)
                selectedRoomDataGrid = B203Form.DataGridView1
            Case "B204"
                ShowChildForm(B204Form)
                PopulateGridB204()
                PopulateGridView("B204", B204Form.DataGridView1)
                selectedRoomDataGrid = B204Form.DataGridView1
            Case "B205"
                ShowChildForm(B205Form)
                PopulateGridB205()
                PopulateGridView("B205", B205Form.DataGridView1)
                selectedRoomDataGrid = B205Form.DataGridView1
            Case "AM101"
                ShowChildForm(AM101Form)
                PopulateGridAM101()
                PopulateGridView("AM101", AM101Form.DataGridView1)
                selectedRoomDataGrid = AM101Form.DataGridView1
            Case "AM102"
                ShowChildForm(AM102Form)
                PopulateGridAM102()
                PopulateGridView("AM102", AM102Form.DataGridView1)
                selectedRoomDataGrid = AM102Form.DataGridView1
            Case "AM103"
                ShowChildForm(AM103Form)
                PopulateGridAM103()
                PopulateGridView("AM103", AM103Form.DataGridView1)
                selectedRoomDataGrid = AM103Form.DataGridView1
            Case "AM201"
                ShowChildForm(AM201Form)
                PopulateGridAM201()
                PopulateGridView("AM201", AM201Form.DataGridView1)
                selectedRoomDataGrid = AM201Form.DataGridView1
            Case "AM202"
                ShowChildForm(AM202Form)
                PopulateGridAM202()
                PopulateGridView("AM202", AM202Form.DataGridView1)
                selectedRoomDataGrid = AM202Form.DataGridView1
            Case "ARETEHALL"
                ShowChildForm(ARETEHALLForm)
                PopulateGridARETEHALL()
                PopulateGridView("ARETEHALL", ARETEHALLForm.DataGridView1)
                selectedRoomDataGrid = ARETEHALLForm.DataGridView1
            Case "DISCUSSIONROOM"
                ShowChildForm(DISCUSSIONROOMForm)
                PopulateGridDISCUSSIONROOM()
                PopulateGridView("DISCUSSIONROOM", DISCUSSIONROOMForm.DataGridView1)
                selectedRoomDataGrid = DISCUSSIONROOMForm.DataGridView1
            Case "SIMULATIONROOM"
                ShowChildForm(SIMULATIONROOMForm)
                PopulateGridSIMULATIONROOM()
                PopulateGridView("SIMULATIONROOM", SIMULATIONROOMForm.DataGridView1)
                selectedRoomDataGrid = SIMULATIONROOMForm.DataGridView1
            Case "INSPERAREROBOTICSLAB"
                ShowChildForm(INSPERAREROBOTICSLABForm)
                PopulateGridINSPERAREROBOTICSLAB()
                PopulateGridView("INSPERAREROBOTICSLAB", INSPERAREROBOTICSLABForm.DataGridView1)
                selectedRoomDataGrid = INSPERAREROBOTICSLABForm.DataGridView1
            Case "NAXUS"
                ShowChildForm(NAXUSForm)
                PopulateGridNAXUS()
                PopulateGridView("NAXUS", NAXUSForm.DataGridView1)
                selectedRoomDataGrid = NAXUSForm.DataGridView1
            Case "SANDBOX"
                ShowChildForm(SANDBOXForm)
                PopulateGridSANDBOX()
                PopulateGridView("SANDBOX", SANDBOXForm.DataGridView1)
                selectedRoomDataGrid = SANDBOXForm.DataGridView1
            Case "EDTECH"
                ShowChildForm(EDTECHForm)
                PopulateGridEDTECH()
                PopulateGridView("EDTECH", EDTECHForm.DataGridView1)
                selectedRoomDataGrid = EDTECHForm.DataGridView1
            Case "PYSCH"
                ShowChildForm(PYSCHForm)
                PopulateGridPYSCH()
                PopulateGridView("PYSCH", PYSCHForm.DataGridView1)
                selectedRoomDataGrid = PYSCHForm.DataGridView1
            Case "RESOURCESROOM"
                ShowChildForm(RESOURCESROOMForm)
                PopulateGridRESOURCESROOM()
                PopulateGridView("RESOURCESROOM", RESOURCESROOMForm.DataGridView1)
                selectedRoomDataGrid = RESOURCESROOMForm.DataGridView1
            Case "ANATOMY"
                ShowChildForm(ANATOMYForm)
                PopulateGridANATOMY()
                PopulateGridView("ANATOMY", ANATOMYForm.DataGridView1)
                selectedRoomDataGrid = ANATOMYForm.DataGridView1
            Case "PHYSICS"
                ShowChildForm(PHYSICSForm)
                PopulateGridPHYSICS()
                PopulateGridView("PHYSICS", PHYSICSForm.DataGridView1)
                selectedRoomDataGrid = PHYSICSForm.DataGridView1
            Case "MICROBIOLOGY"
                ShowChildForm(MICROBIOLOGYForm)
                PopulateGridMICROBIOLOGY()
                PopulateGridView("MICROBIOLOGY", MICROBIOLOGYForm.DataGridView1)
                selectedRoomDataGrid = MICROBIOLOGYForm.DataGridView1
            Case "CHEMISTRY"
                ShowChildForm(CHEMISTRYForm)
                PopulateGridCHEMISTRY()
                PopulateGridView("CHEMISTRY", CHEMISTRYForm.DataGridView1)
                selectedRoomDataGrid = CHEMISTRYForm.DataGridView1
            Case "AMPHITHEATER"
                ShowChildForm(AMPHITHEATERForm)
                PopulateGridAMPHITHEATER()
                PopulateGridView("AMPHITHEATER", AMPHITHEATERForm.DataGridView1)
                selectedRoomDataGrid = AMPHITHEATERForm.DataGridView1
            Case "SKILLSLAB"
                ShowChildForm(SKILLSLABForm)
                PopulateGridSKILLSLAB()
                PopulateGridView("SKILLSLAB", SKILLSLABForm.DataGridView1)
                selectedRoomDataGrid = SKILLSLABForm.DataGridView1
            Case "SCIENTIAHALL1"
                ShowChildForm(SCIENTIAHALL1Form)
                PopulateGridSCIENTIAHALL1()
                PopulateGridView("SCIENTIAHALL1", SCIENTIAHALL1Form.DataGridView1)
                selectedRoomDataGrid = SCIENTIAHALL1Form.DataGridView1
            Case "SCIENTIAHALL2"
                ShowChildForm(SCIENTIAHALL2Form)
                PopulateGridSCIENTIAHALL2()
                PopulateGridView("SCIENTIAHALL2", SCIENTIAHALL2Form.DataGridView1)
                selectedRoomDataGrid = SCIENTIAHALL2Form.DataGridView1
            Case Else
                selectedRoomDataGrid = Nothing
                MessageBox.Show("Room not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select



        If selectedRoomDataGrid Is Nothing Then
            MessageBox.Show("Please select a room first.", "No Room Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub





    Private Sub ShowChildForm(ByVal childForm As Form)
        Panel5.AutoScroll = True
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.None
        Panel5.Controls.Add(childForm)
        childForm.Show()
    End Sub



    Private Sub PopulateGridA101()
        Dim query As String = "SELECT building, room_no, subject, teacher, start_time, end_time, day_of_week, id FROM A101 ORDER BY FIELD(day_of_week, 'Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'), start_time"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        A101Form.DataGridView1.DataSource = table
        A101Form.DataGridView1.Columns("id").Visible = False
    End Sub

    Private Sub PopulateGridB102()
        Dim query As String = "SELECT building, room_no, subject, teacher, start_time, end_time, day_of_week, id FROM B102 ORDER BY FIELD(day_of_week, 'Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'), start_time"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        B102Form.DataGridView1.DataSource = table
        B102Form.DataGridView1.Columns("id").Visible = False
    End Sub

    Private Sub PopulateGridB103()
        Dim query As String = "SELECT building, room_no, subject, teacher, start_time, end_time, day_of_week, id FROM B103 ORDER BY FIELD(day_of_week, 'Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'), start_time"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        B103Form.DataGridView1.DataSource = table
        B103Form.DataGridView1.Columns("id").Visible = False
    End Sub

    Private Sub PopulateGridB104()
        Dim query As String = "SELECT building, room_no, subject, teacher, start_time, end_time, day_of_week, id FROM B104 ORDER BY FIELD(day_of_week, 'Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'), start_time"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        B104Form.DataGridView1.DataSource = table
        B104Form.DataGridView1.Columns("id").Visible = False
    End Sub

    Private Sub PopulateGridB105()
        Dim query As String = "SELECT building, room_no, subject, teacher, start_time, end_time, day_of_week, id FROM B105 ORDER BY FIELD(day_of_week, 'Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'), start_time"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        B105Form.DataGridView1.DataSource = table
        B105Form.DataGridView1.Columns("id").Visible = False
    End Sub

    Private Sub PopulateGridB201()
        Dim query As String = "SELECT building, room_no, subject, teacher, start_time, end_time, day_of_week, id FROM B201 ORDER BY FIELD(day_of_week, 'Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'), start_time"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        B201Form.DataGridView1.DataSource = table
        B201Form.DataGridView1.Columns("id").Visible = False
    End Sub

    Private Sub PopulateGridB202()
        Dim query As String = "SELECT building, room_no, subject, teacher, start_time, end_time, day_of_week, id FROM B202 ORDER BY FIELD(day_of_week, 'Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'), start_time"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        B202Form.DataGridView1.DataSource = table
        B202Form.DataGridView1.Columns("id").Visible = False
    End Sub

    Private Sub PopulateGridB203()
        Dim query As String = "SELECT building, room_no, subject, teacher, start_time, end_time, day_of_week, id FROM B203 ORDER BY FIELD(day_of_week, 'Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'), start_time"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        B203Form.DataGridView1.DataSource = table
        B203Form.DataGridView1.Columns("id").Visible = False
    End Sub

    Private Sub PopulateGridB204()
        Dim query As String = "SELECT building, room_no, subject, teacher, start_time, end_time, day_of_week, id FROM B204 ORDER BY FIELD(day_of_week, 'Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'), start_time"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        B204Form.DataGridView1.DataSource = table
        B204Form.DataGridView1.Columns("id").Visible = False
    End Sub

    Private Sub PopulateGridB205()
        Dim query As String = "SELECT building, room_no, subject, teacher, start_time, end_time, day_of_week, id FROM B205 ORDER BY FIELD(day_of_week, 'Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'), start_time"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        B205Form.DataGridView1.DataSource = table
        B205Form.DataGridView1.Columns("id").Visible = False
    End Sub

    Private Sub PopulateGridAM101()
        Dim query As String = "SELECT building, room_no, subject, teacher, start_time, end_time, day_of_week, id FROM AM101 ORDER BY FIELD(day_of_week, 'Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'), start_time"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        AM101Form.DataGridView1.DataSource = table
        AM101Form.DataGridView1.Columns("id").Visible = False
    End Sub

    Private Sub PopulateGridAM102()
        Dim query As String = "SELECT building, room_no, subject, teacher, start_time, end_time, day_of_week, id FROM AM102 ORDER BY FIELD(day_of_week, 'Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'), start_time"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        AM102Form.DataGridView1.DataSource = table
        AM102Form.DataGridView1.Columns("id").Visible = False
    End Sub

    Private Sub PopulateGridAM103()
        Dim query As String = "SELECT building, room_no, subject, teacher, start_time, end_time, day_of_week, id FROM AM103 ORDER BY FIELD(day_of_week, 'Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'), start_time"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        AM103Form.DataGridView1.DataSource = table
        AM103Form.DataGridView1.Columns("id").Visible = False
    End Sub

    Private Sub PopulateGridAM201()
        Dim query As String = "SELECT building, room_no, subject, teacher, start_time, end_time, day_of_week, id FROM AM201 ORDER BY FIELD(day_of_week, 'Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'), start_time"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        AM201Form.DataGridView1.DataSource = table
        AM201Form.DataGridView1.Columns("id").Visible = False
    End Sub

    Private Sub PopulateGridAM202()
        Dim query As String = "SELECT building, room_no, subject, teacher, start_time, end_time, day_of_week, id FROM AM202 ORDER BY FIELD(day_of_week, 'Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'), start_time"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        AM202Form.DataGridView1.DataSource = table
        AM202Form.DataGridView1.Columns("id").Visible = False
    End Sub



    Private Sub PopulateGridARETEHALL()
        Dim query As String = "SELECT building, room_no, subject, teacher, start_time, end_time, day_of_week, id FROM ARETEHALL ORDER BY FIELD(day_of_week, 'Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'), start_time"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        ARETEHALLForm.DataGridView1.DataSource = table
        ARETEHALLForm.DataGridView1.Columns("id").Visible = False
    End Sub

    Private Sub PopulateGridDISCUSSIONROOM()
        Dim query As String = "SELECT building, room_no, subject, teacher, start_time, end_time, day_of_week, id FROM DISCUSSIONROOM ORDER BY FIELD(day_of_week, 'Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'), start_time"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        DISCUSSIONROOMForm.DataGridView1.DataSource = table
        DISCUSSIONROOMForm.DataGridView1.Columns("id").Visible = False
    End Sub

    Private Sub PopulateGridSIMULATIONROOM()
        Dim query As String = "SELECT building, room_no, subject, teacher, start_time, end_time, day_of_week, id FROM SIMULATIONROOM ORDER BY FIELD(day_of_week, 'Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'), start_time"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        SIMULATIONROOMForm.DataGridView1.DataSource = table
        SIMULATIONROOMForm.DataGridView1.Columns("id").Visible = False
    End Sub

    Private Sub PopulateGridINSPERAREROBOTICSLAB()
        Dim query As String = "SELECT building, room_no, subject, teacher, start_time, end_time, day_of_week, id FROM INSPERAREROBOTICSLAB ORDER BY FIELD(day_of_week, 'Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'), start_time"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        INSPERAREROBOTICSLABForm.DataGridView1.DataSource = table
        INSPERAREROBOTICSLABForm.DataGridView1.Columns("id").Visible = False
    End Sub

    Private Sub PopulateGridNAXUS()
        Dim query As String = "SELECT building, room_no, subject, teacher, start_time, end_time, day_of_week, id FROM NAXUS ORDER BY FIELD(day_of_week, 'Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'), start_time"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        NAXUSForm.DataGridView1.DataSource = table
        NAXUSForm.DataGridView1.Columns("id").Visible = False
    End Sub

    Private Sub PopulateGridSANDBOX()
        Dim query As String = "SELECT building, room_no, subject, teacher, start_time, end_time, day_of_week, id FROM SANDBOX ORDER BY FIELD(day_of_week, 'Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'), start_time"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        SANDBOXForm.DataGridView1.DataSource = table
        SANDBOXForm.DataGridView1.Columns("id").Visible = False
    End Sub

    Private Sub PopulateGridEDTECH()
        Dim query As String = "SELECT building, room_no, subject, teacher, start_time, end_time, day_of_week, id FROM EDTECH ORDER BY FIELD(day_of_week, 'Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'), start_time"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        EDTECHForm.DataGridView1.DataSource = table
        EDTECHForm.DataGridView1.Columns("id").Visible = False
    End Sub

    Private Sub PopulateGridPYSCH()
        Dim query As String = "SELECT building, room_no, subject, teacher, start_time, end_time, day_of_week, id FROM PYSCH ORDER BY FIELD(day_of_week, 'Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'), start_time"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        PYSCHForm.DataGridView1.DataSource = table
        PYSCHForm.DataGridView1.Columns("id").Visible = False
    End Sub

    Private Sub PopulateGridRESOURCESROOM()
        Dim query As String = "SELECT building, room_no, subject, teacher, start_time, end_time, day_of_week, id FROM RESOURCESROOM ORDER BY FIELD(day_of_week, 'Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'), start_time"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        RESOURCESROOMForm.DataGridView1.DataSource = table
        RESOURCESROOMForm.DataGridView1.Columns("id").Visible = False
    End Sub

    Private Sub PopulateGridANATOMY()
        Dim query As String = "SELECT building, room_no, subject, teacher, start_time, end_time, day_of_week, id FROM ANATOMY ORDER BY FIELD(day_of_week, 'Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'), start_time"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        ANATOMYForm.DataGridView1.DataSource = table
        ANATOMYForm.DataGridView1.Columns("id").Visible = False
    End Sub

    Private Sub PopulateGridPHYSICS()
        Dim query As String = "SELECT building, room_no, subject, teacher, start_time, end_time, day_of_week, id FROM PHYSICS ORDER BY FIELD(day_of_week, 'Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'), start_time"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        PHYSICSForm.DataGridView1.DataSource = table
        PHYSICSForm.DataGridView1.Columns("id").Visible = False
    End Sub

    Private Sub PopulateGridMICROBIOLOGY()
        Dim query As String = "SELECT building, room_no, subject, teacher, start_time, end_time, day_of_week, id FROM MICROBIOLOGY ORDER BY FIELD(day_of_week, 'Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'), start_time"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        MICROBIOLOGYForm.DataGridView1.DataSource = table
        MICROBIOLOGYForm.DataGridView1.Columns("id").Visible = False
    End Sub

    Private Sub PopulateGridCHEMISTRY()
        Dim query As String = "SELECT building, room_no, subject, teacher, start_time, end_time, day_of_week, id FROM CHEMISTRY ORDER BY FIELD(day_of_week, 'Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'), start_time"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        CHEMISTRYForm.DataGridView1.DataSource = table
        CHEMISTRYForm.DataGridView1.Columns("id").Visible = False
    End Sub



    Private Sub PopulateGridAMPHITHEATER()
        Dim query As String = "SELECT building, room_no, subject, teacher, start_time, end_time, day_of_week, id FROM AMPHITHEATER ORDER BY FIELD(day_of_week, 'Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'), start_time"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        AMPHITHEATERForm.DataGridView1.DataSource = table
        AMPHITHEATERForm.DataGridView1.Columns("id").Visible = False
    End Sub

    Private Sub PopulateGridSKILLSLAB()
        Dim query As String = "SELECT building, room_no, subject, teacher, start_time, end_time, day_of_week, id FROM SKILLSLAB ORDER BY FIELD(day_of_week, 'Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'), start_time"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        SKILLSLABForm.DataGridView1.DataSource = table
        SKILLSLABForm.DataGridView1.Columns("id").Visible = False
    End Sub

    Private Sub PopulateGridSCIENTIAHALL1()
        Dim query As String = "SELECT building, room_no, subject, teacher, start_time, end_time, day_of_week, id FROM SCIENTIAHALL1 ORDER BY FIELD(day_of_week, 'Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'), start_time"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        SCIENTIAHALL1Form.DataGridView1.DataSource = table
        SCIENTIAHALL1Form.DataGridView1.Columns("id").Visible = False
    End Sub

    Private Sub PopulateGridSCIENTIAHALL2()
        Dim query As String = "SELECT building, room_no, subject, teacher, start_time, end_time, day_of_week, id FROM SCIENTIAHALL2 ORDER BY FIELD(day_of_week, 'Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'), start_time"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        SCIENTIAHALL2Form.DataGridView1.DataSource = table
        SCIENTIAHALL2Form.DataGridView1.Columns("id").Visible = False
    End Sub



    Private Sub adminschedmanagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        ComboBox1.Items.AddRange(New String() {"All", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
        ComboBox1.SelectedIndex = -1


    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        addsched.Show()
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If ComboBox2.SelectedItem.ToString() = "A101" Then
            If Panel5.Controls.Contains(A101Form) Then
                PopulateGridA101()
            End If
        ElseIf ComboBox2.SelectedItem.ToString() = "B102" Then
            If Panel5.Controls.Contains(B102Form) Then
                PopulateGridB102()
            End If
        ElseIf ComboBox2.SelectedItem.ToString() = "B103" Then
            If Panel5.Controls.Contains(B103Form) Then
                PopulateGridB103()
            End If
        ElseIf ComboBox2.SelectedItem.ToString() = "B104" Then
            If Panel5.Controls.Contains(B104Form) Then
                PopulateGridB104()
            End If
        ElseIf ComboBox2.SelectedItem.ToString() = "B105" Then
            If Panel5.Controls.Contains(B105Form) Then
                PopulateGridB105()
            End If
        ElseIf ComboBox2.SelectedItem.ToString() = "B201" Then
            If Panel5.Controls.Contains(B201Form) Then
                PopulateGridB201()
            End If
        ElseIf ComboBox2.SelectedItem.ToString() = "B202" Then
            If Panel5.Controls.Contains(B202Form) Then
                PopulateGridB202()
            End If
        ElseIf ComboBox2.SelectedItem.ToString() = "B203" Then
            If Panel5.Controls.Contains(B203Form) Then
                PopulateGridB203()
            End If
        ElseIf ComboBox2.SelectedItem.ToString() = "B204" Then
            If Panel5.Controls.Contains(B204Form) Then
                PopulateGridB204()
            End If
        ElseIf ComboBox2.SelectedItem.ToString() = "B205" Then
            If Panel5.Controls.Contains(B205Form) Then
                PopulateGridB205()
            End If
        ElseIf ComboBox2.SelectedItem.ToString() = "AM101" Then
            If Panel5.Controls.Contains(AM101Form) Then
                PopulateGridAM101()
            End If
        ElseIf ComboBox2.SelectedItem.ToString() = "AM102" Then
            If Panel5.Controls.Contains(AM102Form) Then
                PopulateGridAM102()
            End If
        ElseIf ComboBox2.SelectedItem.ToString() = "AM103" Then
            If Panel5.Controls.Contains(AM103Form) Then
                PopulateGridAM103()
            End If
        ElseIf ComboBox2.SelectedItem.ToString() = "AM201" Then
            If Panel5.Controls.Contains(AM201Form) Then
                PopulateGridAM201()
            End If
        ElseIf ComboBox2.SelectedItem.ToString() = "AM202" Then
            If Panel5.Controls.Contains(AM202Form) Then
                PopulateGridAM202()
            End If
        ElseIf ComboBox2.SelectedItem.ToString() = "ARETEHALL" Then
            If Panel5.Controls.Contains(ARETEHALLForm) Then
                PopulateGridARETEHALL()
            End If
        ElseIf ComboBox2.SelectedItem.ToString() = "DISCUSSIONROOM" Then
            If Panel5.Controls.Contains(DISCUSSIONROOMForm) Then
                PopulateGridDISCUSSIONROOM()
            End If
        ElseIf ComboBox2.SelectedItem.ToString() = "SIMULATIONROOM" Then
            If Panel5.Controls.Contains(SIMULATIONROOMForm) Then
                PopulateGridSIMULATIONROOM()
            End If
        ElseIf ComboBox2.SelectedItem.ToString() = "INSPERAREROBOTICSLAB" Then
            If Panel5.Controls.Contains(INSPERAREROBOTICSLABForm) Then
                PopulateGridINSPERAREROBOTICSLAB()
            End If
        ElseIf ComboBox2.SelectedItem.ToString() = "NAXUS" Then
            If Panel5.Controls.Contains(NAXUSForm) Then
                PopulateGridNAXUS()
            End If
        ElseIf ComboBox2.SelectedItem.ToString() = "SANDBOX" Then
            If Panel5.Controls.Contains(SANDBOXForm) Then
                PopulateGridSANDBOX()
            End If
        ElseIf ComboBox2.SelectedItem.ToString() = "EDTECH" Then
            If Panel5.Controls.Contains(EDTECHForm) Then
                PopulateGridEDTECH()
            End If
        ElseIf ComboBox2.SelectedItem.ToString() = "PYSCH" Then
            If Panel5.Controls.Contains(PYSCHForm) Then
                PopulateGridPYSCH()
            End If
        ElseIf ComboBox2.SelectedItem.ToString() = "RESOURCESROOM" Then
            If Panel5.Controls.Contains(RESOURCESROOMForm) Then
                PopulateGridRESOURCESROOM()
            End If
        ElseIf ComboBox2.SelectedItem.ToString() = "ANATOMY" Then
            If Panel5.Controls.Contains(ANATOMYForm) Then
                PopulateGridANATOMY()
            End If
        ElseIf ComboBox2.SelectedItem.ToString() = "PHYSICS" Then
            If Panel5.Controls.Contains(PHYSICSForm) Then
                PopulateGridPHYSICS()
            End If
        ElseIf ComboBox2.SelectedItem.ToString() = "MICROBIOLOGY" Then
            If Panel5.Controls.Contains(MICROBIOLOGYForm) Then
                PopulateGridMICROBIOLOGY()
            End If
        ElseIf ComboBox2.SelectedItem.ToString() = "CHEMISTRY" Then
            If Panel5.Controls.Contains(CHEMISTRYForm) Then
                PopulateGridCHEMISTRY()
            End If
        ElseIf ComboBox2.SelectedItem.ToString() = "AMPHITHEATER" Then
            If Panel5.Controls.Contains(AMPHITHEATERForm) Then
                PopulateGridAMPHITHEATER()
            End If
        ElseIf ComboBox2.SelectedItem.ToString() = "SKILLSLAB" Then
            If Panel5.Controls.Contains(SKILLSLABForm) Then
                PopulateGridSKILLSLAB()
            End If
        ElseIf ComboBox2.SelectedItem.ToString() = "SCIENTIAHALL1" Then
            If Panel5.Controls.Contains(SCIENTIAHALL1Form) Then
                PopulateGridSCIENTIAHALL1()
            End If
        ElseIf ComboBox2.SelectedItem.ToString() = "SCIENTIAHALL2" Then
            If Panel5.Controls.Contains(SCIENTIAHALL2Form) Then
                PopulateGridSCIENTIAHALL2()
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        DeleteSelectedRecord()
    End Sub

    Private Sub DeleteSelectedRecord()

        Dim selectedRoom As String = ComboBox2.SelectedItem.ToString()


        If String.IsNullOrEmpty(selectedRoom) Then
            MessageBox.Show("Please select a room first.", "No Room Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        Dim selectedRow As DataGridViewRow = Nothing


        If Panel5.Controls.Contains(A101Form) Then
            selectedRow = A101Form.DataGridView1.CurrentRow
            DeleteRecord("A101", selectedRow)
        ElseIf Panel5.Controls.Contains(B102Form) Then
            selectedRow = B102Form.DataGridView1.CurrentRow
            DeleteRecord("B102", selectedRow)
        ElseIf Panel5.Controls.Contains(B103Form) Then
            selectedRow = B103Form.DataGridView1.CurrentRow
            DeleteRecord("B103", selectedRow)
        ElseIf Panel5.Controls.Contains(B104Form) Then
            selectedRow = B104Form.DataGridView1.CurrentRow
            DeleteRecord("B104", selectedRow)
        ElseIf Panel5.Controls.Contains(B105Form) Then
            selectedRow = B105Form.DataGridView1.CurrentRow
            DeleteRecord("B105", selectedRow)
        ElseIf Panel5.Controls.Contains(B201Form) Then
            selectedRow = B201Form.DataGridView1.CurrentRow
            DeleteRecord("B201", selectedRow)
        ElseIf Panel5.Controls.Contains(B202Form) Then
            selectedRow = B202Form.DataGridView1.CurrentRow
            DeleteRecord("B202", selectedRow)
        ElseIf Panel5.Controls.Contains(B203Form) Then
            selectedRow = B203Form.DataGridView1.CurrentRow
            DeleteRecord("B203", selectedRow)
        ElseIf Panel5.Controls.Contains(B204Form) Then
            selectedRow = B204Form.DataGridView1.CurrentRow
            DeleteRecord("B204", selectedRow)
        ElseIf Panel5.Controls.Contains(B205Form) Then
            selectedRow = B205Form.DataGridView1.CurrentRow
            DeleteRecord("B205", selectedRow)
        ElseIf Panel5.Controls.Contains(AM101Form) Then
            selectedRow = AM101Form.DataGridView1.CurrentRow
            DeleteRecord("AM101", selectedRow)
        ElseIf Panel5.Controls.Contains(AM102Form) Then
            selectedRow = AM102Form.DataGridView1.CurrentRow
            DeleteRecord("AM102", selectedRow)
        ElseIf Panel5.Controls.Contains(AM103Form) Then
            selectedRow = AM103Form.DataGridView1.CurrentRow
            DeleteRecord("AM103", selectedRow)
        ElseIf Panel5.Controls.Contains(AM201Form) Then
            selectedRow = AM201Form.DataGridView1.CurrentRow
            DeleteRecord("AM201", selectedRow)
        ElseIf Panel5.Controls.Contains(AM202Form) Then
            selectedRow = AM202Form.DataGridView1.CurrentRow
            DeleteRecord("AM202", selectedRow)
        ElseIf Panel5.Controls.Contains(ARETEHALLForm) Then
            selectedRow = ARETEHALLForm.DataGridView1.CurrentRow
            DeleteRecord("ARETEHALL", selectedRow)
        ElseIf Panel5.Controls.Contains(DISCUSSIONROOMForm) Then
            selectedRow = DISCUSSIONROOMForm.DataGridView1.CurrentRow
            DeleteRecord("DISCUSSIONROOM", selectedRow)
        ElseIf Panel5.Controls.Contains(SIMULATIONROOMForm) Then
            selectedRow = SIMULATIONROOMForm.DataGridView1.CurrentRow
            DeleteRecord("SIMULATIONROOM", selectedRow)
        ElseIf Panel5.Controls.Contains(INSPERAREROBOTICSLABForm) Then
            selectedRow = INSPERAREROBOTICSLABForm.DataGridView1.CurrentRow
            DeleteRecord("INSPERAREROBOTICSLAB", selectedRow)
        ElseIf Panel5.Controls.Contains(NAXUSForm) Then
            selectedRow = NAXUSForm.DataGridView1.CurrentRow
            DeleteRecord("NAXUS", selectedRow)
        ElseIf Panel5.Controls.Contains(SANDBOXForm) Then
            selectedRow = SANDBOXForm.DataGridView1.CurrentRow
            DeleteRecord("SANDBOX", selectedRow)
        ElseIf Panel5.Controls.Contains(EDTECHForm) Then
            selectedRow = EDTECHForm.DataGridView1.CurrentRow
            DeleteRecord("EDTECH", selectedRow)
        ElseIf Panel5.Controls.Contains(PYSCHForm) Then
            selectedRow = PYSCHForm.DataGridView1.CurrentRow
            DeleteRecord("PYSCH", selectedRow)
        ElseIf Panel5.Controls.Contains(RESOURCESROOMForm) Then
            selectedRow = RESOURCESROOMForm.DataGridView1.CurrentRow
            DeleteRecord("RESOURCESROOM", selectedRow)
        ElseIf Panel5.Controls.Contains(ANATOMYForm) Then
            selectedRow = ANATOMYForm.DataGridView1.CurrentRow
            DeleteRecord("ANATOMY", selectedRow)
        ElseIf Panel5.Controls.Contains(PHYSICSForm) Then
            selectedRow = PHYSICSForm.DataGridView1.CurrentRow
            DeleteRecord("PHYSICS", selectedRow)
        ElseIf Panel5.Controls.Contains(MICROBIOLOGYForm) Then
            selectedRow = MICROBIOLOGYForm.DataGridView1.CurrentRow
            DeleteRecord("MICROBIOLOGY", selectedRow)
        ElseIf Panel5.Controls.Contains(CHEMISTRYForm) Then
            selectedRow = CHEMISTRYForm.DataGridView1.CurrentRow
            DeleteRecord("CHEMISTRY", selectedRow)
        ElseIf Panel5.Controls.Contains(AMPHITHEATERForm) Then
            selectedRow = AMPHITHEATERForm.DataGridView1.CurrentRow
            DeleteRecord("AMPHITHEATER", selectedRow)
        ElseIf Panel5.Controls.Contains(SKILLSLABForm) Then
            selectedRow = SKILLSLABForm.DataGridView1.CurrentRow
            DeleteRecord("SKILLSLAB", selectedRow)
        ElseIf Panel5.Controls.Contains(SCIENTIAHALL1Form) Then
            selectedRow = SCIENTIAHALL1Form.DataGridView1.CurrentRow
            DeleteRecord("SCIENTIAHALL1", selectedRow)
        ElseIf Panel5.Controls.Contains(SCIENTIAHALL2Form) Then
            selectedRow = SCIENTIAHALL2Form.DataGridView1.CurrentRow
            DeleteRecord("SCIENTIAHALL2", selectedRow)
        End If
    End Sub


    Private Sub DeleteRecord(tableName As String, selectedRow As DataGridViewRow)
        If selectedRow Is Nothing Then
            MessageBox.Show("Please select a record to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        For Each column As DataGridViewColumn In selectedRow.DataGridView.Columns
            Console.WriteLine(column.Name)
        Next


        Dim id As Integer = Convert.ToInt32(selectedRow.Cells("id").Value)


        Dim query As String = $"DELETE FROM {tableName} WHERE id = @id"
        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", id)

            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Record deleted successfully.")

                selectedRow.DataGridView.Rows.Remove(selectedRow)
            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UpdateSelectedRecord()
    End Sub

    Private Sub UpdateSelectedRecord()

        Dim selectedRoom As String = ComboBox2.SelectedItem?.ToString()


        If String.IsNullOrEmpty(selectedRoom) Then
            MessageBox.Show("Please select a room first.", "No Room Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        Dim selectedRow As DataGridViewRow = Nothing


        If Panel5.Controls.Contains(A101Form) Then
            selectedRow = A101Form.DataGridView1.CurrentRow
            UpdateRecord("A101", selectedRow)
        ElseIf Panel5.Controls.Contains(B102Form) Then
            selectedRow = B102Form.DataGridView1.CurrentRow
            UpdateRecord("B102", selectedRow)
        ElseIf Panel5.Controls.Contains(B103Form) Then
            selectedRow = B103Form.DataGridView1.CurrentRow
            UpdateRecord("B103", selectedRow)
        ElseIf Panel5.Controls.Contains(B104Form) Then
            selectedRow = B104Form.DataGridView1.CurrentRow
            UpdateRecord("B104", selectedRow)
        ElseIf Panel5.Controls.Contains(B105Form) Then
            selectedRow = B105Form.DataGridView1.CurrentRow
            UpdateRecord("B105", selectedRow)
        ElseIf Panel5.Controls.Contains(B201Form) Then
            selectedRow = B201Form.DataGridView1.CurrentRow
            UpdateRecord("B201", selectedRow)
        ElseIf Panel5.Controls.Contains(B202Form) Then
            selectedRow = B202Form.DataGridView1.CurrentRow
            UpdateRecord("B202", selectedRow)
        ElseIf Panel5.Controls.Contains(B203Form) Then
            selectedRow = B203Form.DataGridView1.CurrentRow
            UpdateRecord("B203", selectedRow)
        ElseIf Panel5.Controls.Contains(B204Form) Then
            selectedRow = B204Form.DataGridView1.CurrentRow
            UpdateRecord("B204", selectedRow)
        ElseIf Panel5.Controls.Contains(B205Form) Then
            selectedRow = B205Form.DataGridView1.CurrentRow
            UpdateRecord("B205", selectedRow)
        ElseIf Panel5.Controls.Contains(AM101Form) Then
            selectedRow = AM101Form.DataGridView1.CurrentRow
            UpdateRecord("AM101", selectedRow)
        ElseIf Panel5.Controls.Contains(AM102Form) Then
            selectedRow = AM102Form.DataGridView1.CurrentRow
            UpdateRecord("AM102", selectedRow)
        ElseIf Panel5.Controls.Contains(AM103Form) Then
            selectedRow = AM103Form.DataGridView1.CurrentRow
            UpdateRecord("AM103", selectedRow)
        ElseIf Panel5.Controls.Contains(AM201Form) Then
            selectedRow = AM201Form.DataGridView1.CurrentRow
            UpdateRecord("AM201", selectedRow)
        ElseIf Panel5.Controls.Contains(AM202Form) Then
            selectedRow = AM202Form.DataGridView1.CurrentRow
            UpdateRecord("AM202", selectedRow)
        ElseIf Panel5.Controls.Contains(ARETEHALLForm) Then
            selectedRow = ARETEHALLForm.DataGridView1.CurrentRow
            UpdateRecord("ARETEHALL", selectedRow)
        ElseIf Panel5.Controls.Contains(DISCUSSIONROOMForm) Then
            selectedRow = DISCUSSIONROOMForm.DataGridView1.CurrentRow
            UpdateRecord("DISCUSSIONROOM", selectedRow)
        ElseIf Panel5.Controls.Contains(SIMULATIONROOMForm) Then
            selectedRow = SIMULATIONROOMForm.DataGridView1.CurrentRow
            UpdateRecord("SIMULATIONROOM", selectedRow)
        ElseIf Panel5.Controls.Contains(INSPERAREROBOTICSLABForm) Then
            selectedRow = INSPERAREROBOTICSLABForm.DataGridView1.CurrentRow
            UpdateRecord("INSPERAREROBOTICSLAB", selectedRow)
        ElseIf Panel5.Controls.Contains(NAXUSForm) Then
            selectedRow = NAXUSForm.DataGridView1.CurrentRow
            UpdateRecord("NAXUS", selectedRow)
        ElseIf Panel5.Controls.Contains(SANDBOXForm) Then
            selectedRow = SANDBOXForm.DataGridView1.CurrentRow
            UpdateRecord("SANDBOX", selectedRow)
        ElseIf Panel5.Controls.Contains(EDTECHForm) Then
            selectedRow = EDTECHForm.DataGridView1.CurrentRow
            UpdateRecord("EDTECH", selectedRow)
        ElseIf Panel5.Controls.Contains(PYSCHForm) Then
            selectedRow = PYSCHForm.DataGridView1.CurrentRow
            UpdateRecord("PYSCH", selectedRow)
        ElseIf Panel5.Controls.Contains(RESOURCESROOMForm) Then
            selectedRow = RESOURCESROOMForm.DataGridView1.CurrentRow
            UpdateRecord("RESOURCESROOM", selectedRow)
        ElseIf Panel5.Controls.Contains(ANATOMYForm) Then
            selectedRow = ANATOMYForm.DataGridView1.CurrentRow
            UpdateRecord("ANATOMY", selectedRow)
        ElseIf Panel5.Controls.Contains(PHYSICSForm) Then
            selectedRow = PHYSICSForm.DataGridView1.CurrentRow
            UpdateRecord("PHYSICS", selectedRow)
        ElseIf Panel5.Controls.Contains(MICROBIOLOGYForm) Then
            selectedRow = MICROBIOLOGYForm.DataGridView1.CurrentRow
            UpdateRecord("MICROBIOLOGY", selectedRow)
        ElseIf Panel5.Controls.Contains(CHEMISTRYForm) Then
            selectedRow = CHEMISTRYForm.DataGridView1.CurrentRow
            UpdateRecord("CHEMISTRY", selectedRow)
        ElseIf Panel5.Controls.Contains(AMPHITHEATERForm) Then
            selectedRow = AMPHITHEATERForm.DataGridView1.CurrentRow
            UpdateRecord("AMPHITHEATER", selectedRow)
        ElseIf Panel5.Controls.Contains(SKILLSLABForm) Then
            selectedRow = SKILLSLABForm.DataGridView1.CurrentRow
            UpdateRecord("SKILLSLAB", selectedRow)
        ElseIf Panel5.Controls.Contains(SCIENTIAHALL1Form) Then
            selectedRow = SCIENTIAHALL1Form.DataGridView1.CurrentRow
            UpdateRecord("SCIENTIAHALL1", selectedRow)
        ElseIf Panel5.Controls.Contains(SCIENTIAHALL2Form) Then
            selectedRow = SCIENTIAHALL2Form.DataGridView1.CurrentRow
            UpdateRecord("SCIENTIAHALL2", selectedRow)
        End If


        If selectedRow Is Nothing Then
            MessageBox.Show("Please select a record to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
    End Sub

    Private Sub UpdateRecord(tableName As String, selectedRow As DataGridViewRow)

        If selectedRow Is Nothing Then
            ' Handle the error as needed without showing a message box
            Return
        End If

        Dim id As Integer = If(selectedRow.Cells("id").Value IsNot Nothing, Convert.ToInt32(selectedRow.Cells("id").Value), -1)
        Dim building As String = If(selectedRow.Cells("building").Value IsNot Nothing, selectedRow.Cells("building").Value.ToString(), String.Empty)
        Dim roomNumber As String = If(selectedRow.Cells("room_no").Value IsNot Nothing, selectedRow.Cells("room_no").Value.ToString(), String.Empty)
        Dim subject As String = If(selectedRow.Cells("subject").Value IsNot Nothing, selectedRow.Cells("subject").Value.ToString(), String.Empty)
        Dim teacher As String = If(selectedRow.Cells("teacher").Value IsNot Nothing, selectedRow.Cells("teacher").Value.ToString(), String.Empty)

        Dim startTime As DateTime
        Dim endTime As DateTime

        If selectedRow.Cells("start_time").Value IsNot Nothing Then
            If TypeOf selectedRow.Cells("start_time").Value Is TimeSpan Then
                Dim startSpan As TimeSpan = CType(selectedRow.Cells("start_time").Value, TimeSpan)
                startTime = DateTime.Today.Add(startSpan)
            Else
                startTime = Convert.ToDateTime(selectedRow.Cells("start_time").Value)
            End If
        Else
            startTime = DateTime.MinValue
        End If

        If selectedRow.Cells("end_time").Value IsNot Nothing Then
            If TypeOf selectedRow.Cells("end_time").Value Is TimeSpan Then
                Dim endSpan As TimeSpan = CType(selectedRow.Cells("end_time").Value, TimeSpan)
                endTime = DateTime.Today.Add(endSpan)
            Else
                endTime = Convert.ToDateTime(selectedRow.Cells("end_time").Value)
            End If
        Else
            endTime = DateTime.MinValue
        End If

        Dim dayOfWeek As String = If(selectedRow.Cells("day_of_week").Value IsNot Nothing, selectedRow.Cells("day_of_week").Value.ToString(), String.Empty)

        If id = -1 OrElse String.IsNullOrEmpty(building) OrElse String.IsNullOrEmpty(roomNumber) OrElse String.IsNullOrEmpty(subject) OrElse String.IsNullOrEmpty(teacher) OrElse startTime = DateTime.MinValue OrElse endTime = DateTime.MinValue OrElse String.IsNullOrEmpty(dayOfWeek) Then
            ' Handle the error as needed without showing a message box
            Return
        End If

        Dim updateForm As New UpdateSchedule()

        ' Assign the values to the form
        updateForm.SelectedRoomDataGrid = tableName
        updateForm.Id = id
        updateForm.Building = building
        updateForm.RoomNumber = roomNumber
        updateForm.Subject = subject
        updateForm.Teacher = teacher
        updateForm.StartTime = startTime
        updateForm.EndTime = endTime
        updateForm.DayOfWeek = dayOfWeek

        updateForm.ShowDialog()

        RefreshDataGridView(tableName)
    End Sub





    Private Sub RefreshDataGridView(tableName As String)
        Dim connectionString As String = "Server=localhost; Database=FREESPACE; Uid=root; Pwd=password;"
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT * FROM " & tableName
                Dim adapter As New MySqlDataAdapter(query, connection)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)


                Select Case tableName
                    Case "A101"
                        A101.DataGridView1.DataSource = dataTable
                    Case "B102"
                        B102.DataGridView1.DataSource = dataTable
                    Case "B103"
                        B103.DataGridView1.DataSource = dataTable
                    Case "B104"
                        B104.DataGridView1.DataSource = dataTable
                    Case "B105"
                        B105.DataGridView1.DataSource = dataTable
                    Case "B201"
                        B201.DataGridView1.DataSource = dataTable
                    Case "B202"
                        B202.DataGridView1.DataSource = dataTable
                    Case "B203"
                        B203.DataGridView1.DataSource = dataTable
                    Case "B204"
                        B204.DataGridView1.DataSource = dataTable
                    Case "B205"
                        B205.DataGridView1.DataSource = dataTable
                    Case "AM101"
                        AM101.DataGridView1.DataSource = dataTable
                    Case "AM102"
                        AM102.DataGridView1.DataSource = dataTable
                    Case "AM103"
                        AM103.DataGridView1.DataSource = dataTable
                    Case "AM201"
                        AM201.DataGridView1.DataSource = dataTable
                    Case "AM202"
                        AM202.DataGridView1.DataSource = dataTable
                    Case "ARETEHALL"
                        ARETEHALL.DataGridView1.DataSource = dataTable
                    Case "DISCUSSIONROOM"
                        DISCUSSIONROOM.DataGridView1.DataSource = dataTable
                    Case "SIMULATIONROOM"
                        SIMULATIONROOM.DataGridView1.DataSource = dataTable
                    Case "INSPERAREROBOTICSLAB"
                        INSPERAREROBOTICSLAB.DataGridView1.DataSource = dataTable
                    Case "NAXUS"
                        NAXUS.DataGridView1.DataSource = dataTable
                    Case "SANDBOX"
                        SANDBOX.DataGridView1.DataSource = dataTable
                    Case "EDTECH"
                        EDTECH.DataGridView1.DataSource = dataTable
                    Case "PYSCH"
                        PYSCH.DataGridView1.DataSource = dataTable
                    Case "RESOURCESROOM"
                        RESOURCEROOM.DataGridView1.DataSource = dataTable
                    Case "ANATOMY"
                        ANATOMY.DataGridView1.DataSource = dataTable
                    Case "PHYSICS"
                        PHYSICS.DataGridView1.DataSource = dataTable
                    Case "MICROBIOLOGY"
                        MICROBIOLOGY.DataGridView1.DataSource = dataTable
                    Case "CHEMISTRY"
                        CHEMISTRY.DataGridView1.DataSource = dataTable
                    Case "AMPHITHEATER"
                        AMPITHEATER.DataGridView1.DataSource = dataTable
                    Case "SKILLSLAB"
                        SKILLSLAB.DataGridView1.DataSource = dataTable
                    Case "SCIENTIAHALL1"
                        SCIENTIAHALL1.DataGridView1.DataSource = dataTable
                    Case "SCIENTIAHALL2"
                        SCIENTIAHALL2.DataGridView1.DataSource = dataTable

                    Case Else
                        MessageBox.Show("Unknown table: " & tableName)
                End Select
            Catch ex As Exception
                MessageBox.Show("An error occurred while refreshing data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        reservationdisplay.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
    Private Sub PopulateGridView(tableName As String, dataGridView As DataGridView)
        Dim query As String = "SELECT building, room_no, subject, teacher, start_time, end_time, day_of_week, id FROM " & tableName &
                          " ORDER BY FIELD(day_of_week, 'Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'), start_time"
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



    Private Sub FilterGridView(selectedDay As String, dataGridView As DataGridView)
        If dataGridView IsNot Nothing AndAlso dataGridView.DataSource IsNot Nothing Then
            Dim dv As DataView = CType(dataGridView.DataSource, DataTable).DefaultView
            If selectedDay = "All" Then
                dv.RowFilter = "" ' Show all days
            Else
                dv.RowFilter = String.Format("day_of_week = '{0}'", selectedDay)
            End If
        End If
    End Sub




    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim selectedDay As String = ComboBox1.SelectedItem.ToString()
        If selectedRoomDataGrid IsNot Nothing Then
            FilterGridView(selectedDay, selectedRoomDataGrid)
        Else
            MessageBox.Show("Selected Room is Nothing", "DAY", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
