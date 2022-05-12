using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    class Operation
    {
        public Guid ID { get; set; }
        public string OperationName { get; set; }
        public DateTime DateTime { get; set; }

        public override string ToString()
        {
            return $"ID : {ID}\nOperation Name : {OperationName}\nDate Time : {DateTime.ToLongTimeString()}\n";
        }

        public Operation()
        {
            ID = Guid.NewGuid();
        }
    }
}
