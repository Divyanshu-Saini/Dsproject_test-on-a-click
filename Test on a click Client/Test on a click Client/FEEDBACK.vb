Public Class FEEDBACK

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Try
            dbconnection.Open()
            Dim Iquery As String = "Insert into feedback values(@name,@email,@contno,@suggestion)"
            InsertCommand = New SqlClient.SqlCommand(Iquery, dbconnection)
            InsertCommand.Parameters.AddWithValue("@name", textBox1.Text)
            InsertCommand.Parameters.AddWithValue("@email", textBox2.Text)
            InsertCommand.Parameters.AddWithValue("@contno", textBox3.Text)
            InsertCommand.Parameters.AddWithValue("@Suggestion", richTextBox1.Text)
            InsertCommand.ExecuteNonQuery()
            MsgBox("Thank you for ur feedback")
            InsertCommand.Dispose()
            dbconnection.Close()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class