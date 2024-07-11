using Arquitectura.Espacio.Nombres.Model;
using Arquitectura.Espacio.Nombres.Service;

namespace Arquitectura.Espacio.Nombres.Controller
{
    public class EmployeeController : IController<Employee>
    {
        private readonly IService<Employee> _service;

        public EmployeeController(IService<Employee> service)
        {
            _service = service;
        }

        public Employee GetById(string id)
        {
            return _service.GetById(id);
        }

        public IEnumerable<Employee> GetAll()
        {
            return _service.GetAll();
        }

        public void Save(Employee employee)
        {
            _service.Save(employee);
        }

        public void Delete(string id)
        {
            _service.Delete(id);
        }
    }
}
