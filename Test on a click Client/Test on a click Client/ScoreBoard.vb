Imports System.Data.SqlClient

Public Class ScoreBoard
    Dim userid As Integer
    Dim username As String = DASHBOARD.HtmlLabel2.Text
    Private Sub ScoreBoard_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        DASHBOARD.Show()
    End Sub

    Private Sub ScoreBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSProjectDataSet.Test_Result_tbl' table. You can move, or remove it, as needed.
        Me.Test_Result_tblTableAdapter.Fill(Me.DSProjectDataSet.Test_Result_tbl)
        Dim id As Integer = getUser_id()
        dbconnection.Open()
        Dim sql As String = "Select * from Test_Result_tbl where user_id= '" & id & "'"
        dbadaptor = New SqlDataAdapter(sql, dbconnection)
        ds = New DataSet
        dbadaptor.Fill(ds)
        MetroGrid1.DataSource = ds
    End Sub

    Function getUser_id() As Integer
        dbconnection.Open()
        Dim SQuery As String = "Select user_id from Users_Details_tbl where user_name = @username"
        Selectcommand = New SqlCommand(SQuery, dbconnection)
        Selectcommand.Parameters.AddWithValue("@username", username)
        reader = Selectcommand.ExecuteReader()
        Try
            reader.Read()
            userid = reader.GetInt32(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Selectcommand.Dispose()
        dbconnection.Close()
        Return userid
    End Function
End Class