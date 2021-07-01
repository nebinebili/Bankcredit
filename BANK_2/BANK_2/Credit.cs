using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK_2
{
    class Credit
    {
        public Guid ID { get; set; }
        public Client Client { get; set; }
        public double Amount { get; set; }
        public double Percent { get; set; }
        public int Months { get; set; }
        private double Payment { get; set; }
       

        public double CalculatePercent()
        {
           return Amount * ((100 + Percent) / 100);
        }
        public double payment()
        {
            int intPayment = (int)(CalculatePercent() / Months); // 458
            double longPayment = ((int)(((CalculatePercent() / Months) - intPayment) * 100)); // 0,33
            double payshort = longPayment / 100;
            return intPayment + payshort;
        }
        
        public void ShowCredit()
        {
            Console.WriteLine("\n-----------------------------------------");
            Console.WriteLine($"ID->{ID}");
            Console.WriteLine($"Amount->{Amount} AZN");
            Console.WriteLine($"Percent->{Percent} %");
            Console.WriteLine($"Months->{Months}");
            Console.WriteLine($"Payment->{Payment=payment()}AZN");
            Console.WriteLine("------- Client Info ------");
            Client.ShowClient();
        }
    }
}
