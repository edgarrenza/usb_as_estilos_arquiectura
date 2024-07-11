namespace Arquitectura.Componentes
{
    public interface IService<T>
    {
        T GetById(string id);
        IEnumerable<T> GetAll();
        void Save(T entity);
        void Delete(string id);
    }
}
