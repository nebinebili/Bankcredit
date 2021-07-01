using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK_2
{
    class Worker:Human
    {
        public Guid ID { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public Operation[] Operations { get; set; }

        public void AddOperation(Operation newoperation)
        {
            Operation[] newoperations = new Operation[Operations.Length + 1];
            for (int i = 0; i < Operations.Length; i++)
            {
                newoperations[i] = Operations[i];
            }
            newoperations[Operations.Length] = newoperation;
            Operations = newoperations;
        }

    }
}
