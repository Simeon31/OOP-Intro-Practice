using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace StreamsEx04
{
    /*
     * This example starts a TCP server that listens for connections on port 8080. When a client establishes a connection, 
     * the program reads the data received from the client over the NetworkStream and outputs it to the console.
     */
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TcpListener tcpListener = new(IPAddress.Any, 8080);

                tcpListener.Start();

                Console.WriteLine("The server is started. Connecting...");

                TcpClient tcpClient = tcpListener.AcceptTcpClient();
                NetworkStream networkStream = tcpClient.GetStream();

                byte[] buffer = new byte[1024];
                int bytesRead = networkStream.Read(buffer, 0, buffer.Length);
                string data = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                Console.WriteLine($"Received data: {data}");

                tcpClient.Close();
                tcpListener.Stop();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
