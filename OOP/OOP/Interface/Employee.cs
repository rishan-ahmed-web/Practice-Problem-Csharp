using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;
using System.Text;

namespace Interface
{
    public class Employee
    {
        public string Name { get; set; }
        public decimal BasicSalary {  get; private set; }

        public Employee(string name,decimal basicsalary) 
        { 
            Name = name;

            if (basicsalary <= 0)
                throw new ArgumentException("Salary must be psoitive");
            else
            BasicSalary = basicsalary;
        
        }

        public virtual decimal CalculateSalary()
        {
            return BasicSalary;
        }
        public virtual void  DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Total Salary: {CalculateSalary()}");
        }
    }
}
