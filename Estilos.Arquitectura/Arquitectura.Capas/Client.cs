using System.Net.Sockets;

namespace Arquitectura.Capas
{
    public class Client
    {
        private TcpClient _client;
        private StreamReader _reader;
        private StreamWriter _writer;

        public async Task StartConnectionAsync(string ip, int port)
        {
            _client = new TcpClient();
            while (!_client.Connected)
            {
                try
                {
                    await _client.ConnectAsync(ip, port);
                }
                catch (SocketException)
                {
                    Console.WriteLine("Server not ready, retrying...");
                    await Task.Delay(500);
                }
            }

            var stream = _client.GetStream();
            _reader = new StreamReader(stream);
            _writer = new StreamWriter(stream) { AutoFlush = true };
            Console.WriteLine("Client connected to server");
        }

        public async Task<string> SendMessageAsync(string message)
        {
            await _writer.WriteLineAsync(message);
            return await _reader.ReadLineAsync();
        }

        public void StopConnection()
        {
            _reader.Close();
            _writer.Close();
            _client.Close();
            Console.WriteLine("Client disconnected from server");
        }
    }
}
