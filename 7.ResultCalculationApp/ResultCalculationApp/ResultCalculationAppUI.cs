using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResultCalculationApp
{
    public partial class ResultCalculationAppUI : Form
    {
        public ResultCalculationAppUI()
        {
            InitializeComponent();
        }

       
        private void showButton_Click(object sender, EventArgs e)
        {
            if ((PhysicsTextBox.Text!= "")
                &(ChemistryTextBox.Text!="")
                &(MathTextBox.Text!=""))
                {
                    ResultCalculator aCalculator = new ResultCalculator();
                    aCalculator.PhysicsNumber = Convert.ToInt16(PhysicsTextBox.Text);
                    aCalculator.ChemistryNumber = Convert.ToInt16(ChemistryTextBox.Text);
                    aCalculator.MathNumber = Convert.ToInt16(MathTextBox.Text);


                    avgMarkTexBox.Text = aCalculator.GetAvgMark();
                    greadTextBox.Text = aCalculator.GetGread();
                }
                else
                {
                    MessageBox.Show("Entry is missing");
                }
        }
    }
}
