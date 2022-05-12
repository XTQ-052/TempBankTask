using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    class Bank
    {
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public decimal Profit { get; set; }
        public CEO CEO { get; set; }
        public Worker[] Workers { get; set; }
        public Manager[] Managers { get; set; }
        public Client[] Clients { get; set; }

        public Bank()
        {
            Profit = default;
            Budget = default;
        }

        public decimal CalculateProfit() 
        {
            foreach (var client in Clients)
            {
                Profit += client.Credit.CalculatePercent(client.Credit.Percent);
            }
            return Profit;
        }
        public void ShowClientCredit(string fullname)
        {
            foreach (var client in Clients)
            {
                if ((client.Name + " " + client.Surname).Equals(fullname))
                {
                    Console.WriteLine(client.Credit);
                }
            }
        }
        public void ShowAllCredits()
        {
            foreach (var client in Clients)
            {
                Console.WriteLine(client.Credit);
            }
        }
        public void PayCredit(decimal money)
        {

        }
    }
}
