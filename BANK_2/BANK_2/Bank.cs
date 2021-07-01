using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK_2
{
    class Bank
    {
        public string Name { get; set; }
        public double Budget { get; set; }
        private double Profit { get; set; }
        public Worker[] Workers { get; set; }
        public Manager[] Managers { get; set; }
        public Credit[] Credits { get; set; }
        public CEO CEO { get; set; }

        public void ShowClientCredit(string name)
        {
            foreach (var credit in Credits)
            {
                if (credit.Client.Name == name)
                {
                    Console.WriteLine("\t<<<Credit Info>>>");
                    credit.ShowCredit();
                    System.Environment.Exit(1);
                }
            }
            Console.WriteLine("No credit was found for this client");
        }
        public void PayCredit(Client client,double money)
        {
            foreach (var credit in Credits)
            {
                if (credit.Client.ID == client.ID)
                {
                    if (money < credit.Amount)
                    {
                        credit.Amount = credit.Amount - money;
                        Console.WriteLine($"\nClient paid {money} AZN of the credit.");
                        Console.WriteLine($"Amount->{credit.Amount}");
                        System.Environment.Exit(1);
                    }
                    else if(money>= credit.Amount)
                    {
                        credit.Amount = 0;
                        Console.WriteLine($"\nClient paid all of the credit.");
                        Console.WriteLine($"Amount->{credit.Amount}");
                        System.Environment.Exit(1);
                    }
                }
            }
            Console.WriteLine("No credit was found for this client");
        }
        public double CalculateProfit()
        {
            foreach (var credit in Credits)
            {
                double temp=credit.CalculatePercent();
                Profit += temp;
            }
            return Profit;
        }
        public void ShowAllCredit()
        {
            Console.WriteLine("\t<<<Credits Info>>>");
            foreach (var credit in Credits)
            {
                credit.ShowCredit();
            }
        }

        public void BankInfo()
        {
            Console.WriteLine($"Name->{Name}");
            Console.WriteLine($"Budget->{Budget} AZN");
            CalculateProfit();
            Console.WriteLine($"Profit->{Profit}");
        }
    }
}
