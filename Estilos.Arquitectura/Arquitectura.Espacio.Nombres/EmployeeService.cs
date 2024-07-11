using Arquitectura.Espacio.Nombres.Model;
using Arquitectura.Espacio.Nombres.Repository;

namespace Arquitectura.Espacio.Nombres.Service
{
    public class EmployeeService : IService<Employee>
    {
        private readonly IRepository<Employee> _repository;

        public EmployeeService(IRepository<Employee> repository)
        {
            _repository = repository;
        }

        public Employee GetById(string id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<Employee> GetAll()
        {
            return _repository.GetAll();
        }

        public void Save(Employee employee)
        {
            _repository.Save(employee);
        }

        public void Delete(string id)
        {
            _repository.Delete(id);
        }
    }
}
