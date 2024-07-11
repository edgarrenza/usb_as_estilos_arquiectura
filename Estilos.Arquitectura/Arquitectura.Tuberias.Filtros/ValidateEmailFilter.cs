namespace Arquitectura.Tuberias.Filtros
{
    public class ValidateEmailFilter : IFilter<User>
    {
        public User Process(User input)
        {
            if (string.IsNullOrEmpty(input.Email) || !input.Email.Contains("@"))
            {
                throw new ArgumentException("Invalid email address");
            }
            return input;
        }
    }
}
