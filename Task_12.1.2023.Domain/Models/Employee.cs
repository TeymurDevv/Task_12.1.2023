
namespace Task_12._1._2023.Domain.Models
{
    public partial class Employee
    {
        private static int _lastid=0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime Birthday { get; set; }
        public int Salary { get; set; }
    }
    public partial class Employee
    {
        public Employee()
        {
            
        }

        public Employee(string name, string surname, DateTime birthday, int salary)
        {
            _lastid = _lastid++;
            Id = _lastid;
            Name = name;
            SurName = surname;
            Birthday = birthday;
            Salary = salary;
        }
    }

    public partial class Employee
    {
        public Employee[] GetEmployees()
        {
            Employee employee1 = new()
            {
                Id = 1,
                Name = "Fidan",
                SurName = "Suleymanli",
                Birthday = new DateTime(2000, 02, 04),
                Salary = 800,
            };

            Employee employee2 = new()
            {
                Id = 2,
                Name = "Teymur",
                SurName = "Suleymanov",
                Birthday = new DateTime(2008, 02, 04),
                Salary = 2000,
            };

            Employee employee3 = new()
            {
                Id = 3,
                Name = "Nihad",
                SurName = "Ibadzade",
                Birthday = new DateTime(2002, 02, 04),
                Salary = 4000,
            };

            Employee employee4 = new()
            {
                Id = 4,
                Name = "Fuad",
                SurName = "Isgenderli",
                Birthday = new DateTime(1990, 02, 04),
                Salary = 800,
            };

            Employee[] arr = {employee1,employee2, employee3, employee4};
            return arr;
        }

        public void Filter(DateTime minDateTime, DateTime maxDateTime, int minSalary, int maxSalary)
        {
            Employee[] employees = GetEmployees();
            foreach (Employee employee  in employees)
            {
                if (
                    employee.Birthday > minDateTime 
                    &&
                    employee.Birthday < maxDateTime
                    &&
                    employee.Salary > minSalary
                    &&
                    employee.Salary < maxSalary
                    )
                {
                    Console.WriteLine($"Id: {employee.Id} Name: {employee.Name} Surname: {employee.SurName} Birthday: {employee.Birthday} Salary: {employee.Salary}");
                }
            }
        }
    }
}
