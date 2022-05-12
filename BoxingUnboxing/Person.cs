using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    abstract class Person
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"ID : {ID}\nName : {Name}\nSurname : {Surname}\nAge : {Age}\n";
        }

        public Person()
        {
            ID = Guid.NewGuid();
        }
    }
}
