using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK_2
{
    class Program
    {
        static void start()
        {
            DateTime dt = new DateTime();

            CEO ceo = new CEO { Age = 30, Name = "Anar", Surname = "Aliyev", Salary = 4323, Position = "CEO", ID = Guid.NewGuid() };

            Manager manager1 = new Manager { ID = Guid.NewGuid(), Name = "Azer", Surname = "Veliyev", Age = 23, Position = "Manager", Salary = 1200 };
            Manager manager2 = new Manager { ID = Guid.NewGuid(), Name = "Kenan", Surname = "Idayetov", Age = 21, Position = "Manager", Salary = 1500 };


            Operation[] operations1 = new Operation[2]
            {
              new Operation { ID = Guid.NewGuid(), DateTime = new DateTime(2021, 6, 23), Process_name = "Process 1" },
              new Operation { ID = Guid.NewGuid(), DateTime = new DateTime(2021, 8, 21), Process_name = "Process 2" }

            };


            Worker worker1 = new Worker
            {
                ID = Guid.NewGuid(),
                Name = "Nebi",
                Surname = "Nebili",
                Age = 20,
                StartTime = dt.ToString("9:00")
            ,
                EndTime = dt.ToString("18:00"),
                Position = "Worker",
                Salary = 900,
                Operations = operations1
            };

            Operation[] operations2 = new Operation[2]
            {
              new Operation { ID = Guid.NewGuid(), DateTime = new DateTime(2021, 12, 23), Process_name = "Process 3" },
              new Operation { ID = Guid.NewGuid(), DateTime = new DateTime(2021, 2, 12), Process_name = "Process 4" }

            };

            Worker worker2 = new Worker
            {
                ID = Guid.NewGuid(),
                Name = "Emiraslan",
                Surname = "Aliyev",
                Age = 20,
                StartTime = dt.ToString("9:00")
            ,
                EndTime = dt.ToString("20:00"),
                Position = "Worker",
                Salary = 800,
                Operations = operations2
            };

            Client client1 = new Client
            {
                ID = Guid.NewGuid(),
                Name = "Eli",
                SurName = "Aliyev",
                Age = 45,
                Salary = 1200,
                Live_adress = "Baku",
                Work_adress = "28 may street"
            };

            Client client2 = new Client
            {
                ID = Guid.NewGuid(),
                Name = "Namiq",
                SurName = "Elizade",
                Age = 30,
                Salary = 3210,
                Live_adress = "Baku",
                Work_adress = "Baku White City Office"
            };

            Client client3 = new Client
            {
                ID = Guid.NewGuid(),
                Name = "Gulnar",
                SurName = "Aliyeva",
                Age = 35,
                Salary = 900,
                Live_adress = "Samaxi",
                Work_adress = "4 nom school"
            };

            Credit credit1 = new Credit { ID = Guid.NewGuid(), Amount = 5000, Months = 12, Percent = 20, Client = client2 };
            Credit credit2 = new Credit { ID = Guid.NewGuid(), Amount = 3000, Months = 10, Percent = 10, Client = client3 };

            Worker[] workers = new Worker[2]
            {
                 worker1, worker2
            };
            Manager[] managers = new Manager[2]
            {
                manager1,manager2
            };
            Credit[] credits = new Credit[2]
            {
              credit1, credit2
            };

            Bank bank = new Bank
            {
                Budget = 700000,
                CEO = ceo,
                Name = "Kapital",
                Workers = workers,
                Managers = managers,
                Credits = credits,
            };

            //Show all credit method
            bank.ShowAllCredit();

            //Show all Client Credit
            bank.ShowClientCredit("Gulnar");

            //Bank Profit Method
            Console.WriteLine($"Bank Profit->{bank.CalculateProfit()} AZN");

            //Bank Info
            bank.BankInfo();

            //Pay Credit Method
            bank.PayCredit(client2, 2300);

            //Manager Calaculate salary method
            Console.WriteLine($"All Salary Sum->{manager1.CalculateSalary(workers, managers, ceo)} AZN");

            //Ceo Decrease percentage Method
            ceo.DecreasePercentage(credits, 5);

            //Credit Calculate percent Method
            Console.WriteLine(credit1.CalculatePercent());
            

        }
        static void Main(string[] args)
        {
            start();
        }
    }
}
