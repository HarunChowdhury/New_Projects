using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Calculator_App
{
    class Salary
    {
        public string name;
        public double basicAccount;
        public double houseRent;
        public double medicalAllowance;


        public Salary(string name, double basicAccount, double houseRent, double medicalAllowance)
        {
            this.name = name;
            this.basicAccount = basicAccount;
            this.houseRent = houseRent;
            this.medicalAllowance = medicalAllowance;
        }



        public double CalculateSalary()
        {
            return basicAccount+(basicAccount*((houseRent / 100) + (medicalAllowance / 100)));
        }
    }
}
