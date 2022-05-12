using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    class Credit
    {
        public Guid ID { get; set; }
        public decimal Amount { get; set; }
        public decimal Percent { get; set; }
        public int Months { get; set; }
        public decimal Payment { get; set; }
        public decimal PaymentPerMonth { get; set; }

        public override string ToString()
        {
            return $"ID : {ID}\nAmount : {Amount}\nPercent : {Percent}\nMonths : " +
                $"{Months}\nPayment : {Payment}\nPayment Per Month : {PaymentPerMonth}";
        }

        public decimal CalculatePercent(decimal percent)
        {
            return Amount / 100 * percent;
        }

        public Credit()
        {
            ID = Guid.NewGuid();
            Payment = Amount + (Amount / 100 * Percent);
            PaymentPerMonth = Payment / Months;
        }
    }
}
