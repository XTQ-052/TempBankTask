using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    class CEO : Employee, IOrganize
    {
        public void Control()
        {
            Console.WriteLine("I control workers as CEO");
        }
        public void MakeMeeting(Worker[] workers)
        {
            Console.WriteLine("I make meeting with this workers : ");
            for (int i = 0; i < workers.Length; i++)
            {
                Console.WriteLine($"{i}) {workers[i].Name} {workers[i].Surname}");
            }
        }
        public void DecreasePercentage(Client client, decimal percent)
        {
            client.Credit.Percent = percent;
        }

        public void Organize()
        {
            Console.WriteLine("I organize as CEO");
        }
    }
}
