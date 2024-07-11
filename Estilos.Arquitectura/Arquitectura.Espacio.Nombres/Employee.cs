namespace Arquitectura.Espacio.Nombres.Model
{
    public class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }

        public Employee(string id, string name, string position, decimal salary)
        {
            Id = id;
            Name = name;
            Position = position;
            Salary = salary;
        }
    }
}
