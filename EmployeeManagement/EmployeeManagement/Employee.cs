using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class Employee
    {
        
         // Propiedades de la clase
            public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }

        // Campo estático para contar el número de empleados
        private static int employeeCount = 0;

        // Constructor
        public Employee(int id, string name, string position, double salary)
        {
            Id = id;
            Name = name;
            Position = position;
            Salary = salary;
            employeeCount++;
        }

        // Destructor
        ~Employee()
        {
            employeeCount--;
        }

        // Método de instancia
        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Position: {Position}, Salary: {Salary}");
        }

        // Método estático
        public static int GetEmployeeCount()
        {
            return employeeCount;
        }
    }
}
