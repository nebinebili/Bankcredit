using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK_2
{
    class CEO:Human,IControl,IMakeMeet,IOrganize
    {
        public Guid ID { get; set; }

        public void Control()
        {
            Console.WriteLine("Ceo Controller");
        }

        public void MakeMeeting()
        {
            Console.WriteLine("Ceo Make Meeting");
        }

        public void Organize()
        {
            Console.WriteLine("Ceo can organizeing");
        }
        
        public void DecreasePercentage(Credit[] credits,double percent)
        {
            foreach (var credit in credits)
            {
                if (percent < credit.Percent)
                {
                    credit.Percent = credit.Percent - percent;
                }
                else if (percent > credit.Percent)
                {
                    Console.WriteLine($"Percent bigger than credit percent({credit.Percent})");
                }
            }
        }

        public void ShowCeo()
        {
            Console.WriteLine($"ID->{ID}");
            ShowHuman();  
        }
    }
}
