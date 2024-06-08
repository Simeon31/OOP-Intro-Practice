using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace StreamsEx05
{
    /*
     * This program creates a TCP client that connects to IP address "127.0.0.1" and port 8080 (the server from example 4). 
     * The client then sends a text message to the server via NetworkStream. 
     * In case of successful connection and sending of data, a message is displayed on the console.
     */
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TcpClient tcpClient = new();

                tcpClient.Connect(IPAddress.Parse("127.0.0.1"), 8080);

                NetworkStream networkStream = tcpClient.GetStream();
                string message = "Sample data from the client";
                byte[] data = Encoding.ASCII.GetBytes(message);

                networkStream.Write(data, 0, data.Length);

                Console.WriteLine("The information is sent to the server");

                tcpClient.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
