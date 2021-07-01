using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK_2
{
    class Client
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Live_adress { get; set; }
        public string Work_adress { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public void ShowClient()
        {
            Console.WriteLine($"ID->{ID}");
            Console.WriteLine($"Name->{Name}");
            Console.WriteLine($"Surname->{SurName}");
            Console.WriteLine($"Age->{Age}");
            Console.WriteLine($"Live Adress->{Live_adress}");
            Console.WriteLine($"Work Adress->{Work_adress}");
            Console.WriteLine($"Salary->{Salary}");
        }
    }
}
