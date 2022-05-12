using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    class Client : Person
    {
        public string LiveAddress { get; set; }
        public string WorkAddress { get; set; }
        public decimal Salary { get; set; }
        public Credit Credit { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"Live Address : {LiveAddress}\nWork Address : {WorkAddress}\nSalary : {Salary}\nCredit : {Credit}\n";
        }
    }
}
