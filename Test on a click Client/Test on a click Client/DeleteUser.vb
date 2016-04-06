Imports System.Data.SqlClient
Imports MetroFramework
Public Class DeleteUser

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        deleteUser()
    End Sub

    Sub deleteUser()
        Try
            dbconnection.Open()
            Dim delQuery As String = "delete from Users_Details_tbl where user_name=@user"
            DeleteCommand = New SqlClient.SqlCommand(delQuery, dbconnection)
            DeleteCommand.Parameters.AddWithValue("@user", MetroComboBox1.SelectedValue)
            If MetroMessageBox.Show(Me, "Do you want to detet " + MetroComboBox1.SelectedValue + "account ?", "Warning", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
                DeleteCommand.ExecuteNonQuery()
                MsgBox("Your Account has been deleted sucessfully !")
            End If
            DeleteCommand.Dispose()
            dbconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DeleteUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSProjectDataSet.Users_Details_tbl' table. You can move, or remove it, as needed.
        Me.Users_Details_tblTableAdapter.Fill(Me.DSProjectDataSet.Users_Details_tbl)
        'TODO: This line of code loads data into the 'DSProjectDataSet.Users_Details_tbl' table. You can move, or remove it, as needed.
        Me.Users_Details_tblTableAdapter.Fill(Me.DSProjectDataSet.Users_Details_tbl)

    End Sub
End Class