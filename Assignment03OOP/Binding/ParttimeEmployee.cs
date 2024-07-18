using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03OOP.Binding
{
    public class ParttimeEmployee : Employee
    {
        public int CountOfHours { get; set; }
        public decimal HourRate { get; set; }

        public new void GetEmployeeType()
        {
            Console.WriteLine("I am Parttime Employee");
        }
        public override void GetEmployeeData()
        {
            Console.WriteLine($"FulltimeEmployee : Id = {Id} , Name = {Name} , Age = {Age} , Count of Hours = {CountOfHours} , Hour Rate = {HourRate}");
        }
    }
}
