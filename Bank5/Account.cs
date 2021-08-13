using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank4
{    
    enum AccountType { CheckingAccount, SavingsAccount, MasterCardAccount }

    abstract class Account
    {
        //Readonly public string with the name of the account
        public string Name { get; set; }

        //Get, Set decimal of account balance
        public decimal Balance { get; set; }

        //Account's identifyer 
        public int _AccountNummber { get; set; }

        //Account Type
        public AccountType AccountType { get; set; }

        /// <summary>
        /// Charg interst method 
        /// </summary>
        public abstract void ChargeInterest();

    }

    class CheckingAccount : Account
    {
        /// <summary>
        /// Checking account 
        /// </summary>
        public override void ChargeInterest()
        {
            //Gain 0.5 procent interest
            this.Balance = Balance * 1.005M;
        }

        public CheckingAccount(string name, int accountNummber)
        {
            this.Name = name;
            this._AccountNummber = accountNummber;
        }
    }

    class SavingsAccount : Account
    {
        /// <summary>
        /// Saving account 
        /// </summary>
        public override void ChargeInterest()
        {
            //If acount under 50 Kr. 1 procent Interest
            if (Balance < 50000)
            {
                this.Balance = this.Balance * 1.01M;
            }

            //If account under 100 Kr. 2 procent interest
            else if (Balance < 100000)
            {
                this.Balance = this.Balance * 1.02M;
            }

            //If account over 100 Kr. 3 procent interest
            else if (Balance > 100000)
            {
                this.Balance = this.Balance * 1.03M;
            }
        }

        public SavingsAccount(string name, int accountNummber)
        {
            this.Name = name;
            this._AccountNummber = accountNummber;
        }

    }

    class MasterCardAccount : Account
    {
        /// <summary>
        /// MasterCard account 
        /// </summary>
        public override void ChargeInterest()
        {
            //If balance abov 0 get 0.1 procent interest
            if (Balance > 0)
            {
                //Gain a 0.1 procent of account balance
                this.Balance = this.Balance * 1.001M;
            }

            //If balance in minus pay 20% of balance to bank
            else if (Balance < 0)
            {
                decimal minus = Balance * 1.2M;

                //Loss 20 procent of account balance
                this.Balance = this.Balance - minus;
            }
        }

        public MasterCardAccount(string name, int accountNummber)
        {
            this.Name = name;
            this._AccountNummber = accountNummber;
        }

    }
}
