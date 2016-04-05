Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Module DBModule
    Public dbconnection As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("Test_on_a_click_Client.My.MySettings.DSProjectConnectionString").ConnectionString)
    Public Selectcommand As SqlCommand
    Public InsertCommand As SqlCommand
    Public UpdateCommand As SqlCommand
    Public DeleteCommand As SqlCommand
    Public dbadaptor As SqlDataAdapter
    Public reader As SqlDataReader

End Module
