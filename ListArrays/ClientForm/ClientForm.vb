﻿Imports System.Net
Imports System.Net.Sockets
Imports System.Text

Public Class ClientForm
    Private Sub btn_send_Click(sender As Object, e As EventArgs) Handles btn_send.Click
        Dim tcpClient As New System.Net.Sockets.TcpClient()
        tcpClient.Connect("127.0.0.1", 8000)
        Dim networkStream As NetworkStream = tcpClient.GetStream()
        If networkStream.CanWrite And networkStream.CanRead Then
            ' Do a simple write.
            Dim sendBytes As [Byte]() = Encoding.ASCII.GetBytes("Is anybody there")
            networkStream.Write(sendBytes, 0, sendBytes.Length)
            ' Read the NetworkStream into a byte buffer.
            Dim bytes(tcpClient.ReceiveBufferSize) As Byte
            networkStream.Read(bytes, 0, CInt(tcpClient.ReceiveBufferSize))
            ' Output the data received from the host to the console.
            Dim returndata As String = Encoding.ASCII.GetString(bytes)
            Console.WriteLine(("Host returned: " + returndata))
        Else
            If Not networkStream.CanRead Then
                Console.WriteLine("cannot not write data to this stream")
                tcpClient.Close()
            Else
                If Not networkStream.CanWrite Then
                    Console.WriteLine("cannot read data from this stream")
                    tcpClient.Close()
                End If
            End If
        End If
        ' pause so user can view the console output
        Console.ReadLine()
    End Sub
End Class
