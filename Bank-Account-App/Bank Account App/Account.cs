using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Account_App
{
    class Account
    {
      
        private string number;
        private string name;
        private double balance;       

        public Account()
        {
            balance = 0;
        }

        public Account(string number , string name)
        {
            this.number = number;
            this.name = name;
            balance = 0;
        }
      
        public void Depsit(double amount)
        {
            balance += amount;

        }

        public void Widthdraw(double amount)
        {
            balance -= amount;
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public string Number
        {
            get{return number;}
            set{ number = value;}
        }


        public double Balance
        {
            get { return balance; }
        }

    }
}
