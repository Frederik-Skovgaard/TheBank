using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank4
{    
    abstract class Account : Bank
    {
        //Readonly public string with the name of the account
        public string Name { get; }

        //Get, Set decimal of account balance
        public decimal Balance { get; set; }

        //Account's identifyer 
        public int _AccountNummber { get; }


        /// <summary>
        /// Charg interst method 
        /// </summary>
        public abstract void ChargeInterest();

    }

    abstract class CheckingAccount : Account
    {
        /// <summary>
        /// Checking account 
        /// </summary>
        public override void ChargeInterest()
        {
            //Gain 0.5 procent interest
            this.Balance = Balance / 100 * 0.5M;
        }

        public CheckingAccount(string name, int accountNummber)
        {
            
        }
    }

    abstract class SavingsAccount : Account
    {
        /// <summary>
        /// Saving account 
        /// </summary>
        public override void ChargeInterest()
        {
            //If acount under 50 Kr. 1 procent Interest
            if (Balance < 50)
            {
                this.Balance = this.Balance / 100 * 1;
            }

            //If account under 100 Kr. 2 procent interest
            else if (Balance < 100)
            {
                this.Balance = this.Balance / 100 * 2;
            }

            //If account over 100 Kr. 3 procent interest
            else if (Balance > 100)
            {
                this.Balance = this.Balance / 100 * 3;
            }
        }

        public SavingsAccount(string name, int accountNummber)
        {
            
        }

    }

    abstract class MasterCardAccount : Account
    {
        /// <summary>
        /// MasterCard account 
        /// </summary>
        public override void ChargeInterest()
        {
            //If balance abov 0 get 0.1 procent interest
            if (Balance >= 0)
            {
                //Gain a 0.1 procent of account balance
                this.Balance = this.Balance / 100 * 0.1M;
            }

            //If balance in minus pay 20% of balance to bank
            else if (Balance < 0)
            {
                decimal minus = Balance / 100 * 20;

                //Loss 20 procent of account balance
                this.Balance = this.Balance - minus;
            }
        }

        public MasterCardAccount(string name, int accountNummber)
        {
            
        }

    }
}
