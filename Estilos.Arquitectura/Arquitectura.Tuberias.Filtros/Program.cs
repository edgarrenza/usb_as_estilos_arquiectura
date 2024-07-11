namespace Arquitectura.Tuberias.Filtros
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var pipeline = new Pipeline<User>();

            pipeline.Register(new UpperCaseNameFilter());
            pipeline.Register(new ValidateEmailFilter());
            pipeline.Register(new DuplicateCheckFilter());

            var user = new User("1", "John Doe", "john.doe@example.com");

            try
            {
                var processedUser = pipeline.Execute(user);
                Console.WriteLine($"Processed User: {processedUser.Name}, {processedUser.Email}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            var duplicateUser = new User("1", "Jane Doe", "jane.doe@example.com");
            try
            {
                var processedDuplicateUser = pipeline.Execute(duplicateUser);
                Console.WriteLine($"Processed User: {processedDuplicateUser.Name}, {processedDuplicateUser.Email}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
