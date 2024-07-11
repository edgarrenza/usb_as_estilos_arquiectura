namespace Arquitectura.Tuberias.Filtros
{
    public class Pipeline<T>
    {
        private readonly List<IFilter<T>> _filters = new();

        public void Register(IFilter<T> filter)
        {
            _filters.Add(filter);
        }

        public T Execute(T input)
        {
            T output = input;
            foreach (var filter in _filters)
            {
                output = filter.Process(output);
            }
            return output;
        }
    }
}
