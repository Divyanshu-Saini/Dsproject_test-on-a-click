Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class AddQuestion
    Private Sub AddQuestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            Dim IQuery As String = "Insert  into Question_Answer_tbl values(@Question,@opt1,@opt2,@opt3,@opt4,@ans)"
            InsertCommand = New SqlCommand(IQuery, dbconnection)
            InsertCommand.Parameters.AddWithValue("@Question", RichTextBox1.Text)
            InsertCommand.Parameters.AddWithValue("@opt1", MetroTextBox1.Text)
            InsertCommand.Parameters.AddWithValue("@opt2", MetroTextBox2.Text)
            InsertCommand.Parameters.AddWithValue("@opt3", MetroTextBox3.Text)
            InsertCommand.Parameters.AddWithValue("@opt4", MetroTextBox4.Text)
            InsertCommand.Parameters.AddWithValue("@ans", MetroTextBox5.Text)
            If dbconnection.State = ConnectionState.Closed Then
                dbconnection.Open()
            End If
            InsertCommand.ExecuteNonQuery()
            MsgBox("Question added Sucessfully !")
            Me.Hide()
            Login.Show()
            InsertCommand.Dispose()
            dbconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class