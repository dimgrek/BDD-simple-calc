using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Customer
    {
        public int Account { get; set; }
        public bool IsAccountInCredit { get; set; }
        public bool IsCardValid { get; set; }
        public bool IsAccountDebited { get; set; }

        public Customer()
        {
            IsAccountInCredit = true;
            IsCardValid = true;
            IsAccountDebited = false;
        }

        public bool RequestCash()
        {
            IsAccountDebited = true;
            return true;
        }

        
    }
}
