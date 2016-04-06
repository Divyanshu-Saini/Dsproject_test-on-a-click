Public Class Login
    Private Sub signupbtn_Click(sender As Object, e As EventArgs) Handles signupbtn.Click
        SignUp.Show()
        Me.Hide()
    End Sub
    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        Try
            If MetroComboBox1.Text = "Admin" Then
                Call Admin_login()
                dbconnection.Close()

            ElseIf MetroComboBox1.Text = "Student" Then
                Call Studen_login()
                dbconnection.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub Admin_login()
        dbconnection.Open()
        Dim Query As String = "Select * from Users_Details_tbl where user_name ='" & MetroTextBox1.Text & "' and password='" & MetroTextBox2.Text & "'"
        dbadaptor = New SqlClient.SqlDataAdapter(Query, dbconnection)
        Dim dset As New DataSet
        dbadaptor.Fill(dset)
        Dim count = dset.Tables(0).Rows.Count
        If count > 0 Then
            DASHBOARD.HtmlLabel2.Text = MetroTextBox1.Text
            DASHBOARD.Show()
            Me.Hide()
        Else
            MsgBox("Invalid  Login Creentials ", Microsoft.VisualBasic.MsgBoxStyle.Critical)
        End If
        dbconnection.Close()
    End Sub

    Sub Studen_login()
        dbconnection.Open()
        Dim Query As String = "Select * from Users_Details_tbl where user_name ='" & MetroTextBox1.Text & "' and password='" & MetroTextBox2.Text & "'"
        dbadaptor = New SqlClient.SqlDataAdapter(Query, dbconnection)
        Dim dset As New DataSet
        dbadaptor.Fill(dset)
        Dim count = dset.Tables(0).Rows.Count
        If count > 0 Then
            DASHBOARD.HtmlLabel2.Text = MetroTextBox1.Text
            DASHBOARD.adq.Enabled = False
            DASHBOARD.adu.Enabled = False
            DASHBOARD.rmu.Enabled = False
            DASHBOARD.Show()
            Me.Hide()
        Else
            MsgBox("Invalid  Login Creentials ", Microsoft.VisualBasic.MsgBoxStyle.Critical)
        End If
        dbconnection.Close()
    End Sub


End Class