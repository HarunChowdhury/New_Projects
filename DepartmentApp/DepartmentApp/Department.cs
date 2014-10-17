using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepartmentApp
{
    class Department
    {
        public string Code { set; get; }
        public string Name { set; get; }
        private const int  MAX_NO_STUDENT=2;
        public List<Student> Students { set; get; } 

        public Department(string code,string name):this()
        {
            Code = code;
            Name = name;
        }

        public Department()
        {
            Students = new List<Student>();
        }

        public string AddStudent(Student aStudent)
        {
            if (Students.Count<MAX_NO_STUDENT)
            {
              Students.Add(aStudent);
              return " added";   
            }
            else
            {
                return "Overflow";
            }
         
        }
    }
}
