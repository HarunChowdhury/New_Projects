using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankNewApp
{
    class Account
    {
        public string Number { set; get; }
        public string OpeningDate { set; get; }
        public double Balance { private set; get; }

        public void Deposite(double amount)
        {
            Balance += amount;
            
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }
    }
}
