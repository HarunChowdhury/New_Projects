using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PersonApps
{
    class Person
    {
        private string firstName;
        private string middleName;
        private string lastName;

        public Person(string firstName, string middleName, string lastName):this(firstName , lastName)
        {
           
            this.middleName = middleName;
        
        }


        public Person(string firstName, string lastName)
        {

            this.firstName = firstName;
            this.lastName = lastName;


        }


        public Person(string firstName)
        {
            this.firstName = firstName; 
        }


        public string getFullname()
        {
            return firstName + " " + middleName + " " + lastName;
        }

        public string getReverseName()
        {
            string fullName = getFullname();
            char[] cArray = fullName.ToCharArray();
           
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
             return reverse;
            }


        public string FirstName
        {

            get { return firstName; }
            set { firstName = value; }
        
        }

        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        
           
    }
}

