using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK_2
{
    class Manager : Human, IOrganize
    {
        public Guid ID { get; set; }
        double salary;

        public void Organize()
        {
            Console.WriteLine("Manager can organizing");
        }
        public double CalculateSalary(Worker[] workers,Manager[] managers,CEO ceo)
        {
            foreach (var worker in workers)
            {
                salary += worker.Salary;
            }
            foreach (var manager in managers)
            {
                salary += manager.Salary;
            }
            salary += ceo.Salary;
            return salary;
        }

        public void ShowManager()
        {
            Console.WriteLine($"ID->{ID}");
            ShowHuman();
        }
    }
}
