using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepartmentApp
{
    public partial class DepartmentUI : Form
    {
        private Department aDepartment;

        public DepartmentUI()
        {
            InitializeComponent();
        }

        private void deptSaveButton_Click(object sender, EventArgs e)
        {
            aDepartment = new Department(deptCodeTextBox.Text,deptNameTextBox.Text);
            MessageBox.Show("Department created");
        }

        private void studentSaveButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student(studentRegNoTextBox.Text,studentNameTextBox.Text,studentEmailTextBox.Text);
           string msg= aDepartment.AddStudent(aStudent);

            MessageBox.Show(msg);

        }

        private void showDetailsInfo_Click(object sender, EventArgs e)
        {
            int NoOfStudents = aDepartment.Students.Count;

            string msg = "Department Id : " + aDepartment.Code + " Name : " + aDepartment.Name +
                         " Number of Students : " + NoOfStudents;
            msg += "\nStudent RegNo\tName\tEmail\n";
            foreach (Student aStudent in aDepartment.Students )
            {
                msg += aStudent.RegNo + "\t" + aStudent.Name + "\t" + aStudent.Email;
            }

            MessageBox.Show(msg);
        }
    }
}
