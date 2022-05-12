using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    class Employee : Person
    {
        public string Position { get; set; }
        public decimal Salary { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"Position : {Position}\nSalary : {Salary}\n";
        }
    }
}
