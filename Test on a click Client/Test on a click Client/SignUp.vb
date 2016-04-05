Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class SignUp
    Dim localconn As SqlConnection = dbconnection
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            'Addind admin details
            If MetroComboBox1.Text = "Admin" Then
                Dim bit As Boolean = True
                If MetroTextBox2.Text = MetroTextBox3.Text Then
                    Dim IQuery As String = "Insert  into Users_Details_tbl values(@Username,@password,@admin,@collegename)"
                    InsertCommand = New SqlCommand(IQuery, dbconnection)
                    InsertCommand.Parameters.AddWithValue("@Username", MetroTextBox1.Text)
                    InsertCommand.Parameters.AddWithValue("@password", MetroTextBox2.Text)
                    InsertCommand.Parameters.AddWithValue("@admin", bit)
                    InsertCommand.Parameters.AddWithValue("@collegename", MetroTextBox4.Text)
                    If dbconnection.State = ConnectionState.Closed Then
                        dbconnection.Open()
                    End If
                    InsertCommand.ExecuteNonQuery()
                    MsgBox("Admin Register Sucessfully !")
                    Me.Hide()
                    Login.Show()
                    InsertCommand.Dispose()
                    dbconnection.Close()
                Else
                    MsgBox("Password Incorrect ")
                End If

                'adding student details.
            ElseIf MetroComboBox1.Text = "Student" Then
                Dim bit As Boolean = False
                If MetroTextBox2.Text = MetroTextBox3.Text Then
                    Dim IQuery As String = "Insert  into Users_Details_tbl values(@Username,@password,@admin,@collegename)"
                    InsertCommand = New SqlCommand(IQuery, dbconnection)
                    InsertCommand.Parameters.AddWithValue("@Username", MetroTextBox1.Text)
                    InsertCommand.Parameters.AddWithValue("@password", MetroTextBox2.Text)
                    InsertCommand.Parameters.AddWithValue("@admin", bit)
                    InsertCommand.Parameters.AddWithValue("@collegename", MetroTextBox4.Text)
                    If dbconnection.State = ConnectionState.Closed Then
                        dbconnection.Open()
                    End If
                    InsertCommand.ExecuteNonQuery()
                    MsgBox("Student Register Sucessfully !")
                    Me.Hide()
                    Login.Show()
                    InsertCommand.Dispose()
                    dbconnection.Close()
                Else
                    MsgBox("Password Incorrect ")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub MetroComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroComboBox1.SelectedIndexChanged
        If MetroComboBox1.Text = "Admin" Then
            MetroTile5.Hide()
            MetroTextBox4.Hide()
        ElseIf MetroComboBox1.Text = "Student" Then
            MetroTile5.Show()
            MetroTextBox4.Show()
        End If
    End Sub

    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class