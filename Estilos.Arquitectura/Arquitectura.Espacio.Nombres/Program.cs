using Arquitectura.Espacio.Nombres.Controller;
using Arquitectura.Espacio.Nombres.Model;
using Arquitectura.Espacio.Nombres.Repository;
using Arquitectura.Espacio.Nombres.Service;

namespace Arquitectura.Espacio.Nombres.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var employeeRepository = new EmployeeRepository();
            var employeeService = new EmployeeService(employeeRepository);
            var employeeController = new EmployeeController(employeeService);

            var newEmployee = new Employee("1", "Jane Smith", "Software Engineer", 80000m);
            employeeController.Save(newEmployee);

            var retrievedEmployee = employeeController.GetById("1");
            Console.WriteLine($"Retrieved Employee: {retrievedEmployee.Name}, {retrievedEmployee.Position}, {retrievedEmployee.Salary:C}");

            var allEmployees = employeeController.GetAll();
            Console.WriteLine("All Employees:");
            foreach (var employee in allEmployees)
            {
                Console.WriteLine($"- {employee.Name}, {employee.Position}, {employee.Salary:C}");
            }

            employeeController.Delete("1");
            Console.WriteLine("Employee deleted.");

            var deletedEmployee = employeeController.GetById("1");
            Console.WriteLine(deletedEmployee == null ? "Employee not found." : "Employee still exists.");
        }
    }
}
