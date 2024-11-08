Imports MySql.Data.MySqlClient
Public Class moduleforms
    Dim conn As New MySqlConnection




    Public Sub ConnectDatabase()
        Dim DatabaseName As String = "freespace"
        Dim server As String = "localhost"
        Dim userName As String = "root"
        Dim password As String = "password"

        If Not conn Is Nothing Then conn.Close()
        conn.ConnectionString = "server=" & server & ";user id=" & userName & ";" &
                            "password=" & password & ";database=" & DatabaseName & ""

        Try
            conn.Open()
            MsgBox("Connected")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ConnectDatabase()
    End Sub
End Class