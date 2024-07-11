using System.Net.Sockets;
using System.Net;
using System.Text;

namespace Arquitectura.P2P
{
    public class Peer
    {
        private readonly string _id;
        private readonly TcpListener _listener;
        private readonly int _port;

        public Peer(string id, int port)
        {
            _id = id;
            _port = port;
            _listener = new TcpListener(IPAddress.Any, port);
        }

        public async Task StartAsync()
        {
            _listener.Start();
            Console.WriteLine($"{_id} listening on port {_port}.");

            while (true)
            {
                var client = await _listener.AcceptTcpClientAsync();
                _ = Task.Run(() => HandleClientAsync(client));
            }
        }

        private async Task HandleClientAsync(TcpClient client)
        {
            using var stream = client.GetStream();
            using var reader = new StreamReader(stream, Encoding.UTF8);
            using var writer = new StreamWriter(stream, Encoding.UTF8) { AutoFlush = true };

            string message;
            while ((message = await reader.ReadLineAsync()) != null)
            {
                Console.WriteLine($"Received: {message}");
                await writer.WriteLineAsync($"Echo from {_id}: {message}");
            }
        }

        public async Task SendMessageAsync(string ip, int port, string message)
        {
            using var client = new TcpClient();
            await client.ConnectAsync(ip, port);

            using var stream = client.GetStream();
            using var writer = new StreamWriter(stream, Encoding.UTF8) { AutoFlush = true };

            await writer.WriteLineAsync(message);
        }
    }
}
