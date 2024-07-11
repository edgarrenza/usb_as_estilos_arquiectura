namespace Arquitectura.Tuberias.Filtros
{
    public interface IFilter<T>
    {
        T Process(T input);
    }
}
