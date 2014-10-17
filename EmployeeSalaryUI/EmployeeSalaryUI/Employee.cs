using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryUI
{
    class Employee
    {
        public string Id { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }

        public Salary ASalary { set; get; }
    }
}
