using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koncert
{
    class Account
    {
        //Account name
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }


        //Othe account info
        public string Email { get; set; }
        public int AccountID { get; set; }

        public Account(string firstName, string lastName, string mail)
        {
            FirstName = firstName;
            LastName = lastName;

            Email = Email;
        }
        

    }
}
