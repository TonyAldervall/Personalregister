using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalregister
{
    internal class EmployeeRegistry
    {
        private List<Employee> Employees { get; set; }
        public EmployeeRegistry()
        {
            Employees = new List<Employee>();
        }

        public void AddEmployee()
        {
            Console.Write("\nEnter name: ");
            string name = Console.ReadLine() ?? string.Empty;

            int salary;
            while (true)
            {
                Console.Write("\nEnter salary: ");
                string input = Console.ReadLine() ?? string.Empty;

                if(int.TryParse(input, out salary) && salary >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid input. Please enter a valid number.");
                }
            }

            Employee employee = new Employee(name, salary);
            Employees.Add(employee);
        }
        public void RemoveEmployeeById()
        {
            Console.Write("\nEnter id (0 to cancel): ");
            string id = Console.ReadLine() ?? string.Empty;

            if (id == "0")
            {
                Console.WriteLine("\nCancelling...");
                return;
            }

            Employee employee = getEmployeeById(id);
            if (employee == null)
            {
                Console.WriteLine("\nNo employee found with that id.");
                return;
            }

            Employees.Remove(employee);
            Console.WriteLine("\nSuccessfully removed employee with id: " + employee.Id);
           
            
        }

        public Employee getEmployeeById(string id)
        {
            return Guid.TryParse(id, out Guid guid) ? Employees.FirstOrDefault(e => e.Id == guid) : null;
        }

        public override string ToString()
        {
            if (Employees.Count == 0)
            {
                return "\nNo employees currently in registry.";
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                foreach (Employee employee in Employees)
                {
                    sb.Append(employee.ToString());
                }

                return sb.ToString();
            }
        }
    }
}