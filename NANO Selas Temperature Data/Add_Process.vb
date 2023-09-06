Imports System.Data.OleDb
Public Class Add_Process
    Public Sub Add()
        Dim myconnection As OLEDBConnection = New OLEDBConnection
        Dim mycommand As String
        Dim process As String

        process = tbProcess.Text

        myconnection.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\LF Database\Selas_db.accdb")

        Try
            myconnection.Open()
            mycommand = "INSERT INTO [Process_tb] ([process]) VALUES (@process)"
            Using cmd As OleDbCommand = New OleDbCommand(mycommand, myconnection)
                cmd.Parameters.AddWithValue("@process", process)
                cmd.ExecuteNonQuery()
            End Using
            myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)

        Finally
            tbProcess.Text = ""
            MessageBox.Show("Process successfully added!", "Add Process", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If tbProcess.Text = "" Then
            MessageBox.Show("Please enter the process", "Add Process", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Add()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        tbProcess.Text = ""
        Me.Hide()
        Form1.Show()
    End Sub

End Class