namespace Arquitectura.Tuberias.Filtros
{
    public class UpperCaseNameFilter : IFilter<User>
    {
        public User Process(User input)
        {
            input.Name = input.Name.ToUpper();
            return input;
        }
    }
}
