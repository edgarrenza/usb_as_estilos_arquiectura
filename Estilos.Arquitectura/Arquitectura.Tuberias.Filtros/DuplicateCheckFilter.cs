namespace Arquitectura.Tuberias.Filtros
{
    public class DuplicateCheckFilter : IFilter<User>
    {
        private readonly HashSet<string> _existingIds = new();

        public User Process(User input)
        {
            if (_existingIds.Contains(input.Id))
            {
                throw new ArgumentException("Duplicate user ID");
            }
            _existingIds.Add(input.Id);
            return input;
        }
    }
}
