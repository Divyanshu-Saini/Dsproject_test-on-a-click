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
Module Module1

    Sub Main()
        Dim tcpChannel As IChannel
        tcpChannel = New TcpServerChannel("8085")
        ChannelServices.RegisterChannel(tcpChannel, False)
        RemotingConfiguration.RegisterWellKnownServiceType(GetType(RemotableObject.RemoteClass), "MyRemoteObject", WellKnownObjectMode.SingleCall)
        Console.WriteLine("Starting server ...")
        Console.WriteLine("Server started.")
        Console.ReadLine()
    End Sub

End Module
