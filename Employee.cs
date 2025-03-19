using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_task
{
    class Employee
    {
        public string Name;
        public float Salary;
        public Employee(string name,float salary) 
        { 
          Name = name;
          Salary = salary;
        }
        public void ShowInfo()
        {
           Console.WriteLine($"{Name} {Salary}");
        }
    }
}
