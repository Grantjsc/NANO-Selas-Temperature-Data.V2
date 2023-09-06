Imports System.Data.OleDb

Public Class Add_PartNumber
    Public Sub Add()
        Dim myconnection As OleDbConnection = New OleDbConnection
        Dim mycommand As String
        Dim part_no As String

        part_no = tbPartNum.Text

        myconnection.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\LF Database\Selas_db.accdb")

        Try
            myconnection.Open()
            mycommand = "INSERT INTO [PartNo_tb] ([part_no]) VALUES (@part_no)"
            Using cmd As OleDbCommand = New OleDbCommand(mycommand, myconnection)
                cmd.Parameters.AddWithValue("@part_no", part_no)
                cmd.ExecuteNonQuery()
            End Using
            myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)

        Finally
            tbPartNum.Text = ""
            MessageBox.Show("Part number successfully added!", "Part number", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If tbPartNum.Text = "" Then
            MessageBox.Show("Please enter the part number", "Part number", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Add()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        tbPartNum.Text = ""
        Me.Hide()
        Form1.Show()
    End Sub

End Class