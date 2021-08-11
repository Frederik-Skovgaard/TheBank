using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank2
{
    
    class Account
    {

        //Method for getting name and balance
        public Account(string name)
        {
            //Setting variables to Name & Balance
            this.Balance = 0;
            this.Name = name;
        }

        

        //Readonly public string with the name of the account
        public string Name {get;}

        //Get, Set decimal of account balance
        public decimal Balance { get; set; }
    }
}
