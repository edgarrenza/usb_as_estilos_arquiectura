namespace Arquitectura.Espacio.Nombres.Controller
{
    public interface IController<T>
    {
        T GetById(string id);
        IEnumerable<T> GetAll();
        void Save(T entity);
        void Delete(string id);
    }
}
