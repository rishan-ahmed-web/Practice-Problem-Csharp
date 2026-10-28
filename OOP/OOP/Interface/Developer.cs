using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public class Developer : Employee
    {
        public decimal Allowance { get; set; }
        public decimal Bonus { get; set; }

        public Developer(string name,decimal basicsalary,
            string department,decimal allowance,decimal bonus)
            :base(name , basicsalary,department)
        {
           
            Allowance = allowance;
            Bonus = bonus;
        }

        public override decimal CalculateSalary()
        {
            return BasicSalary + Allowance + Bonus;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("============//Developer//=============");
            base.DisplayInfo();
            Console.WriteLine($" Allowance: {Allowance} |  Bonus: {Bonus}");
            Console.WriteLine($"Total Salary: {CalculateSalary()}");
        }
    }
}
