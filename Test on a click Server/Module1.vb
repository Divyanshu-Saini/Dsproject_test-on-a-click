Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Runtime
Imports System.Runtime.Remoting
Imports System.Runtime.Remoting.Channels
Imports System.Runtime.Remoting.Channels.Tcp
Module Module1

    Public Sub Main()
        Dim channel As TcpServerChannel = New TcpServerChannel(8978)
        ChannelServices.RegisterChannel(channel, False)

    End Sub

End Module
