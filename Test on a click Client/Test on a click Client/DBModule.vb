Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Module DBModule
    Public dbconnection As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("Test_on_a_click_Client.My.MySettings.DSProjectConnectionString").ConnectionString)
    Public dbcommand As SqlCommand
    Public dbadaptor As SqlDataAdapter
    Public reader As SqlDataReader

End Module
