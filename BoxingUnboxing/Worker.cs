using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    class Worker : Employee
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Operation[] Operations { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"Start Time : {StartTime.ToLongTimeString()}\nEnd Time : {EndTime.ToLongTimeString()}\n";
        }

        public void AddOperation(Operation operation)
        {
            var newOperations = new Operation[Operations.Length + 1];
            Operations.CopyTo(newOperations, 0);
            newOperations[Operations.Length] = operation;
            Operations = newOperations;
        }
    }
}
