using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeSalaryUI;

namespace EmployeeSalaryApp
{
    public partial class EmployeeSalaryUI : Form
    {
        private Employee aEmployee;

        public EmployeeSalaryUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            aEmployee = new Employee();
            aEmployee.Id = employeeIdtextBox.Text;
            aEmployee.Name = employeeNametextBox.Text;
            aEmployee.Email = employeeEmailtextBox.Text;

            Salary aSalary = new Salary();
            aSalary.BasicSalary = Convert.ToDouble(employeeBasicSalarytextBox.Text);
            aSalary.MedicalPercent = Convert.ToDouble(employeeMedicalOfBasictextBox.Text);
            aSalary.ConveyancePercent = Convert.ToDouble(employeeconveyanceOfBasictextBox.Text);

            aEmployee.ASalary = aSalary;

            MessageBox.Show("Employee Information Entry Completed");
        }

        private void incrementButton_Click(object sender, EventArgs e)
        {
          
            aEmployee.ASalary.Increase(Convert.ToDouble(employeeIncrementOfBasicTextBox.Text));
            MessageBox.Show("Salary hass been increased");

        }

 
        private void showButton_Click_1(object sender, EventArgs e)
        {
        
            employeeBasicDisplayTextBox.Text=aEmployee.ASalary.BasicSalary.ToString();
            employeeMedicalDisplayTextBox.Text = aEmployee.ASalary.GetMedicalAmount().ToString();
            employeeConveyanceDisplayTextBox.Text = aEmployee.ASalary.GetConveyanceAmount().ToString();
            totalSalaryDisplayTextBox.Text = aEmployee.ASalary.GetTotal().ToString();
            incrementNumberTextBox.Text = aEmployee.ASalary.NumberOfIncrements.ToString();
        }
    }
}
