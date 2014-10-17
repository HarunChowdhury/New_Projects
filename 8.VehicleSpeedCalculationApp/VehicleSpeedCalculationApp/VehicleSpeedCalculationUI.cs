using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleSpeedCalculationApp
{
    public partial class VehicleSpeedCalculationUI : Form
    {
        public VehicleSpeedCalculationUI()
        {
            InitializeComponent();
        }
        VehicleSpeedCalculator aVehicleSpeedCalculator = new VehicleSpeedCalculator();
        private void createButton_Click(object sender, EventArgs e)
        {
            aVehicleSpeedCalculator.VehicleName = vehicleNameTextBox.Text;
            aVehicleSpeedCalculator.VehicleRegNo = VehicleRegNoTextBox.Text;
            MessageBox.Show("Vehicle Registration is complited");
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            aVehicleSpeedCalculator.VehicleSpeed = Convert.ToDouble(speedTextBox.Text);
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            minSpeedTextBox.Text = aVehicleSpeedCalculator.GetMinSpeed();
            maxSpeedTextBox.Text = aVehicleSpeedCalculator.GetMaxSpeed();
            avgSpeedTextBox.Text = aVehicleSpeedCalculator.GetAvgSpeed();
        }
    }
}
