using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary_Calculator_App
{
    public partial class SalaryCalculatorForm : Form
    {
        public SalaryCalculatorForm()
        {
            InitializeComponent();
        }


        Salary aSalaryCalculator;

        private void showMeSalaryButton_Click(object sender, EventArgs e)
        {
             aSalaryCalculator = new Salary (employeeNameTextBox.Text, Convert.ToDouble(basicAccountTextBox.Text) , Convert.ToDouble(houseRentTextBox.Text), Convert.ToDouble(medicalAllowanceTextBox.Text));



            double salary = aSalaryCalculator.CalculateSalary();
            ShowSalary();


        }

        public void ShowSalary()
        {

            string message = aSalaryCalculator.name + ", your Salary is : " + aSalaryCalculator.CalculateSalary(); 
            MessageBox.Show(message);
        }
    }
}
