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
Module DBModule
    Public dbconnection As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("Test_on_a_click_Client.My.MySettings.DSProjectConnectionString").ConnectionString)
    Public Selectcommand As SqlCommand
    Public InsertCommand As SqlCommand
    Public UpdateCommand As SqlCommand
    Public DeleteCommand As SqlCommand
    Public dbadaptor As SqlDataAdapter
    Public reader As SqlDataReader
    Public dt As DataTable
    Public dr As DataRow
    Public ds As DataSet
    Public RemObj As New RemotableObject.RemoteClass
    Public Sub RemoteSub()
        RemotingConfiguration.RegisterWellKnownClientType(GetType(RemotableObject.RemoteClass), "tcp://localhost:8085/MyRemoteObject.rem")
    End Sub

End Module
