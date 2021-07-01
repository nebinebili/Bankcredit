using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK_2
{
    class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }

        public void ShowHuman()
        {
            Console.WriteLine($"Name->{Name}");
            Console.WriteLine($"Surname->{Surname}");
            Console.WriteLine($"Age->{Age}");
            Console.WriteLine($"Position->{Position}");
            Console.WriteLine($"Salary->{Salary}");
        }
    }
}
