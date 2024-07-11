namespace Arquitectura.Cliente.Servidor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var userController = new UserController();

            var newUser = new User("1", "John Doe", "john.doe@example.com");
            userController.SaveUser(newUser);

            var retrievedUser = userController.GetUserById("1");
            Console.WriteLine($"Retrieved User: {retrievedUser.Name}, {retrievedUser.Email}");
        }
    }
}
