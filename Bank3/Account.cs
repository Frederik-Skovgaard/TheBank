using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank3 
{
    
    //TODO:list with all Accounts & and Account nummbers
    
    class Account : Bank
    {
        //Readonly public string with the name of the account
        public string Name { get; }

        //Get, Set decimal of account balance
        public decimal Balance { get; set; }

        public int _AccountNummber { get; }


        //Method for getting name and balance
        public Account(string name, int account)
        {
            this.Balance = 0;
            //Setting variables to Name
            this.Name = name;
            this._AccountNummber = account;
        }

        

        
    }
}
