Imports System
Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports System.Net

Public Class RemoteObject
    Inherits MarshalByRefObject
    Public dbconnection As New SqlConnection("Data Source=DESKTOP-ILJDUI5;Initial Catalog=DSProject;Integrated Security=True")

    Public Function OpenConnection() As SqlConnection
        Dim str As String = "Data Source=DESKTOP-ILJDUI5;Initial Catalog=DSProject;Integrated Security=True"
        Dim con As SqlConnection = New SqlConnection(str)
        con.Open()
        Return con
    End Function

End Class
