namespace Arquitectura.Capas
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var server = new Server();
            _ = Task.Run(() => server.StartAsync(6666));

            var client = new Client();
            try
            {
                await client.StartConnectionAsync("127.0.0.1", 6666);

                var response = await client.SendMessageAsync("hello server");
                Console.WriteLine("Server response: " + response);

                response = await client.SendMessageAsync("bye");
                Console.WriteLine("Server response: " + response);

                client.StopConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Client error: {e.Message}");
            }
        }
    }
}
