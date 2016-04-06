Imports System
Imports System.Data
Imports System.Runtime
Imports System.Linq
Imports System.Text
Imports System.Configuration
Imports System.Threading.Tasks
Imports System.Collections.Generic
Imports System.Data.SqlClient
Imports System.Runtime.Remoting
Imports System.Runtime.Remoting.Channels
Imports System.Runtime.Remoting.Channels.Tcp
Imports RemotableObject
Imports MetroFramework

Public Class Test
    Dim qs(10) As Integer
    Dim qs_no As Integer = 1
    Dim score As Integer = 0
    Dim temp As String
    Dim userid As Integer
    Private Sub Test_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        DASHBOARD.Show()
        MsgBox(score)
    End Sub

    Private Sub Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtusername.Text = DASHBOARD.HtmlLabel2.Text
        RemoteSub()
        qs = RemObj.createQs()
        reader = RemObj.generateQsAns(qs, qs_no)
        qs_no = qs_no + 1
        Try
            reader.Read()
            txtqno.Text = reader.GetInt32(0)
            txtquestion.Text = reader.GetString(1)
            txta.Text = reader.GetString(2)
            txtb.Text = reader.GetString(3)
            txtc.Text = reader.GetString(4)
            txtd.Text = reader.GetString(5)
            temp = reader.GetString(6)

        Catch ex As Exception
            MetroMessageBox.Show(Me, ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtans.Text = temp Then
            score = score + 1
        End If
        reader = RemObj.generateQsAns(qs, qs_no)
        qs_no = qs_no + 1
        Try
            reader.Read()
            txtqno.Text = reader.GetInt32(0)
            txtquestion.Text = reader.GetString(1)
            txta.Text = reader.GetString(2)
            txtb.Text = reader.GetString(3)
            txtc.Text = reader.GetString(4)
            txtd.Text = reader.GetString(5)
            temp = reader.GetString(6)
        Catch ex As Exception
            MetroMessageBox.Show(Me, ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim id As Integer = getUser_id()
        dbconnection.Open()
        Dim IQuery As String = "Insert into Test_Result_tbl values(@userid,@score)"
        InsertCommand = New SqlCommand(IQuery, dbconnection)
        InsertCommand.Parameters.AddWithValue("@userid", id)
        InsertCommand.Parameters.AddWithValue("@score", score)
        InsertCommand.ExecuteNonQuery()
        InsertCommand.Dispose()
        dbconnection.Close()
        MetroMessageBox.Show(Me, "Result Updated ", "Scoreboard", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
    Function getUser_id() As Integer
        dbconnection.Open()
        Dim SQuery As String = "Select user_id from Users_Details_tbl where user_name = @username"
        Selectcommand = New SqlCommand(SQuery, dbconnection)
        Selectcommand.Parameters.AddWithValue("@username", txtusername.Text)
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