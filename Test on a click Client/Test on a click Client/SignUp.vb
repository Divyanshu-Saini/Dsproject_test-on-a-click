Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class SignUp
    Dim dbconnections As New SqlConnection
    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            If MetroComboBox1.Text = "Admin" Then
                Dim bit As Boolean = True
                dbconnection.Open()
                Dim SQuery As String = "Select * from Users_Details_tlb where user_name= @username"
                dbcommand = New SqlCommand(SQuery, dbconnection)
                dbcommand.Parameters.AddWithValue("@username", MetroTextBox1.Text)
                If dbconnection.State = ConnectionState.Closed Then
                    dbconnection.Open()
                End If
                reader = dbcommand.ExecuteReader
                If MetroTextBox2.Text = MetroTextBox3.Text Then
                    If reader.Read = True Then
                        MsgBox("Username Name already exist!", 0)
                        reader.Close()
                    Else
                        Dim IQuery As String = "Insert  into  Users_Details_tlb values(@Username,@password,@admin)"
                        dbcommand = New SqlCommand(IQuery, dbconnection)
                        dbcommand.Parameters.AddWithValue("@Username", MetroTextBox1.Text)
                        dbcommand.Parameters.AddWithValue("@password", MetroTextBox2.Text)
                        dbcommand.Parameters.AddWithValue("@admin", bit)
                        dbcommand.ExecuteNonQuery()
                        MsgBox("Admin Register Sucessfully !")
                        dbconnection.Close()
                    End If
                Else
                    MsgBox("Password Incorrect ")
                End If
            ElseIf MetroComboBox1.Text = "Student" Then
                Dim bit As Boolean = False
                dbconnection.Open()
                Dim SQuery As String = "Select * from Users_Details_tlb where user_name= @username"
                dbcommand = New SqlCommand(SQuery, dbconnection)
                dbcommand.Parameters.AddWithValue("@username", MetroTextBox1.Text)
                If dbconnection.State = ConnectionState.Closed Then
                    dbconnection.Open()
                End If
                reader = dbcommand.ExecuteReader
                If MetroTextBox2.Text = MetroTextBox3.Text Then
                    If reader.Read = True Then
                        MsgBox("Username Name already exist!", 0)
                        reader.Close()
                    Else
                        Dim IQuery As String = "Insert  into  Users_Details_tlb values(@Username,@password,@admin,@collegename)"
                        dbcommand = New SqlCommand(IQuery, dbconnection)
                        dbcommand.Parameters.AddWithValue("@Username", MetroTextBox1.Text)
                        dbcommand.Parameters.AddWithValue("@password", MetroTextBox2.Text)
                        dbcommand.Parameters.AddWithValue("@admin", bit)
                        dbcommand.Parameters.AddWithValue("@collegename", MetroTextBox4.Text)
                        dbcommand.ExecuteNonQuery()
                        MsgBox("Student Register Sucessfully !")
                        dbconnection.Close()
                    End If
                Else
                    MsgBox("Password Incorrect ")
                End If
                End If
        Catch ex As Exception
            MsgBox(ex)

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
End Class