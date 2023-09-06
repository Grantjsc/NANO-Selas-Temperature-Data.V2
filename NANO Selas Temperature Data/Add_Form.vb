Imports System.Data.OleDb
Imports System.Net

Public Class Add_Form

    Public Sub Add()
        Dim myconnection As OleDbConnection = New OleDbConnection
        Dim mycommand As String
        Dim name As String

        name = tbName.Text

        myconnection.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\LF Database\Selas_db.accdb")

        Try
            myconnection.Open()
            mycommand = "INSERT INTO [Associate_tb] ([associate]) VALUES (@name)"
            Using cmd As OleDbCommand = New OleDbCommand(mycommand, myconnection)
                cmd.Parameters.AddWithValue("@name", name)
                cmd.ExecuteNonQuery()
            End Using
            myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)

        Finally
            tbName.Text = ""
            MessageBox.Show("Associate successfully added!", "Add Associate", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If tbName.Text = "" Then
            MessageBox.Show("Please enter associate name", "Add Associate", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Add()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        tbName.Text = ""
        Me.Hide()
        Form1.Show()
    End Sub

End Class