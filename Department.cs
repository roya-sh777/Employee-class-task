using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Class_task
{
    class Department
    {
        public string Name;
        public int EmployeeLimit;
        public Employee[] Employees;
        public Department(string name, int employeeLimit)
        {
            Name = name;
            EmployeeLimit = employeeLimit;
            Employees = new Employee[employeeLimit];
        }
        public void AddEmployee(Employee employee ,int i) 
            {
            if (i >= 0 && i < EmployeeLimit) 
            {
                Employees[i] = employee;   
            }
            else 
            {
                Console.WriteLine("limiti kecib");            
            }
        }
        public Employee[] GetAllEmployees() 
        {
           return Employees;
        }
    }
}
