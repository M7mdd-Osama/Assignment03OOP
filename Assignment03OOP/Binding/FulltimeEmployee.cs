using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03OOP.Binding
{
    public class FulltimeEmployee : Employee
    {
        public decimal Salary { get; set; }
        public FulltimeEmployee(int id, string name, int age, decimal salary) : base(id, name, age)
        {
            Salary = salary;
        }



        public new void GetEmployeeType()
        {
            Console.WriteLine("I am FulltimeEmployee");
        }
        public override void GetEmployeeData()
        {
            Console.WriteLine($"FulltimeEmployee : Id = {Id} , Name = {Name} , Age = {Age} , Salary = {Salary}");
        }
    }
}
