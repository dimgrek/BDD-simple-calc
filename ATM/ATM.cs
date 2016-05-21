using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class ATM
    {
        public bool DoesDispenserContainCash { get; set; }

        public ATM()
        {
            DoesDispenserContainCash = true;
        }

        public bool EnsureCashIsDispenced()
        {
            return true;
        }

        public bool EnsureCardIsReturned()
        {
            return true;
        }
    }
}
