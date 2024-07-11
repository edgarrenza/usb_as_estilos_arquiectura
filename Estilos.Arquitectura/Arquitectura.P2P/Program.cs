namespace Arquitectura.P2P
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var peer1 = new Peer("Peer1", 5000);
            var peer2 = new Peer("Peer2", 5001);

            _ = Task.Run(() => peer1.StartAsync());
            _ = Task.Run(() => peer2.StartAsync());

            await Task.Delay(1000);

            await peer1.SendMessageAsync("127.0.0.1", 5001, "Hello from Peer1");

            await peer2.SendMessageAsync("127.0.0.1", 5000, "Hello from Peer2");

            Console.ReadLine();
        }
    }
}
