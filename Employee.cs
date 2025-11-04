using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_1___Personalregister
{
    internal class Employee
    {
        public Guid Id;
        private string Name { get; set; }
        private int Salary { get; set; }

        public Employee(string name, int salary)
        {
            this.Id = Guid.NewGuid();
            this.Name = name;
            this.Salary = salary;
        }

        public override string ToString()
        {
            return $"\nId: {Id} | Name: {Name} | Salary: {Salary:C0}";
        }

    }
}
