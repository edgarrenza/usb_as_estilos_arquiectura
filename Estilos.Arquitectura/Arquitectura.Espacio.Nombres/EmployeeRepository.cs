using Arquitectura.Espacio.Nombres.Model;

namespace Arquitectura.Espacio.Nombres.Repository
{
    public class EmployeeRepository : IRepository<Employee>
    {
        private readonly Dictionary<string, Employee> _employeeDatabase = new();

        public Employee GetById(string id)
        {
            _employeeDatabase.TryGetValue(id, out var employee);
            return employee;
        }

        public IEnumerable<Employee> GetAll()
        {
            return _employeeDatabase.Values;
        }

        public void Save(Employee employee)
        {
            _employeeDatabase[employee.Id] = employee;
        }

        public void Delete(string id)
        {
            _employeeDatabase.Remove(id);
        }
    }
}
