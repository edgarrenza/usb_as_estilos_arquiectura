using System.Net;
using System.Net.Sockets;

namespace Arquitectura.Capas
{
    public class Server
    {
        private TcpListener _listener;

        public async Task StartAsync(int port)
        {
            _listener = new TcpListener(IPAddress.Any, port);
            _listener.Start();
            Console.WriteLine($"Server started on port {port}");

            while (true)
            {
                var client = await _listener.AcceptTcpClientAsync();
                _ = Task.Run(() => HandleClientAsync(client));
            }
        }

        public void Stop()
        {
            _listener.Stop();
        }

        private async Task HandleClientAsync(TcpClient client)
        {
            Console.WriteLine("Client connected");
            try
            {
                using var stream = client.GetStream();
                using var reader = new StreamReader(stream);
                using var writer = new StreamWriter(stream) { AutoFlush = true };

                string message;
                while ((message = await reader.ReadLineAsync()) != null)
                {
                    Console.WriteLine($"Received: {message}");
                    var response = ProcessMessage(message);
                    await writer.WriteLineAsync(response);

                    if (message.Equals("bye", StringComparison.OrdinalIgnoreCase))
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Client error: {ex.Message}");
            }
            finally
            {
                client.Close();
                Console.WriteLine("Client disconnected");
            }
        }

        private string ProcessMessage(string message)
        {
            return message.ToLower() switch
            {
                "hello server" => "hello client",
                "bye" => "bye",
                _ => "unrecognized message"
            };
        }
    }

}
