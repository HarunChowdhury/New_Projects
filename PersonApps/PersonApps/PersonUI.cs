using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonApps
{
    public partial class PersonForm : Form
    {
        public PersonForm()
        {
            InitializeComponent();
        }

        private Person newperson;
        private void fullButton_Click(object sender, EventArgs e)
        {
           
            if(middleTextBox.Text == "")
                newperson = new Person(firstTextBox.Text , lastTextBox.Text);

            else if (middleTextBox.Text == "" && lastTextBox.Text=="")
                newperson = new Person(firstTextBox.Text);
            else
                                      
                newperson = new Person(firstTextBox.Text ,middleTextBox.Text ,lastTextBox.Text);
           

            fullTextBox.Text = newperson.getFullname();
        }

        private void reverseButton_Click(object sender, EventArgs e)
        {
            reverseTextBox.Text = newperson.getReverseName();
        }
    }
}
