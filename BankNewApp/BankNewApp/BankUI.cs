using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankNewApp
{
    public partial class BankUI : Form
    {
        private Customer aCustomer;

        public BankUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.Number = accountNumberEntryTextBox.Text;
            account.OpeningDate = openingDateEntryTextBox.Text;

            aCustomer = new Customer();
            aCustomer.Name = customerNameEntryTextBox.Text;
            aCustomer.Email = emailEntryTextBox.Text;

            aCustomer.AnAccount = account;

            MessageBox.Show("Customer & Account Entry Completed..");
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(amountTextBox.Text);
            aCustomer.AnAccount.Deposite(amount);
            MessageBox.Show("Money Deposited");
            amountTextBox.Text = "";
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(amountTextBox.Text);
            aCustomer.AnAccount.Withdraw(amount);
            MessageBox.Show("Money Withdraw");
            amountTextBox.Text = "";
        }

        private void showDetailsButton_Click(object sender, EventArgs e)
        {
            customerNameDisplayTextBox.Text = aCustomer.Name;
            emailDisplayTextBox.Text = aCustomer.Email;
            accountNumberDisplayTextBox.Text = aCustomer.AnAccount.Number;
            openingDateDisplayTextBox.Text = aCustomer.AnAccount.OpeningDate;
            balanceTextBox.Text = aCustomer.AnAccount.Balance.ToString();
        }
    }
}
