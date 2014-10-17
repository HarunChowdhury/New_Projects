using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryUI
{
    class Salary
    {
      
    
        public double BasicSalary { set; get; }
        public double MedicalPercent { set; get; }
        public double ConveyancePercent { set; get; }
        public int NumberOfIncrements { private set; get; }

        public double GetMedicalAmount()
        {
            return BasicSalary * (MedicalPercent / 100);
        }
        public double GetConveyanceAmount()
        {
            return BasicSalary * (ConveyancePercent / 100);
        }
        public double GetTotal()
        {
           
            return BasicSalary + GetMedicalAmount() + GetConveyanceAmount();
        }
        public void Increase(double increaseAmount)
        {
            double amountToBeIncresed=(BasicSalary*increaseAmount)/100;
            BasicSalary=BasicSalary+amountToBeIncresed;
            NumberOfIncrements++;

        }

      
    }
}
