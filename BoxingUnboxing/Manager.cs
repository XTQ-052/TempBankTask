using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    class Manager : Employee, IOrganize
    {
        public void CalculateSalaries(Worker[] workers)
        {
            decimal salary = default;
            foreach (var worker in workers)
            {
                salary += worker.Salary;
            }
            Console.WriteLine("Sum of Salaries : {0}", salary);
        }

        public void Organize()
        {
            Console.WriteLine("I organize as Manager");
        }
    }
}
