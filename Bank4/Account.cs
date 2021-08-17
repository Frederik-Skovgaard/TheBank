using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank4.Interface;

namespace Bank4
{    
    public enum AccountType { CheckingAccount, SavingsAccount, MasterCardAccount }

    public abstract class Account : IAccount, IContact
    {
        #region IAccount
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
        #endregion
        #region IContact
        //Felts Start

        //Customer street
        string street;

        //Customer postal
        int postal;

        //Customer city
        string city;

        //Customer phone nummber
        int phoneNummber;

        //Felt End

        //Prophitis Start

        //Return customer first name
        public string FirstName { get; set; }
        //Return customer last name
        public string LastName { get; set; }

        //Return customer full name
        public string FullName { get { return $"{FirstName} {LastName}"; } }

        //Return customer street
        public string Street { get { return street; }  }

        //Return customer postal
        public int Postal { get { return postal; } }

        //Return customer city
        public string City { get { return city; } }

        //Return customer location
        public string ContactInfo { get { return $"{Street}, {City}, {Postal}"; } }

        //Return customer nummber
        public int PhoneNummber { get { return phoneNummber; }  }

        //Prophitis End
        #endregion

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

        public CheckingAccount(string fName, string lName, int accountNummber)
        {
            this.FirstName = fName;
            this.LastName = lName;

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
            //If acount under 50 000 Kr. 1 procent Interest
            if (Balance < 50000)
            {
                Balance *= 1.01M;
            }

            //If account under 100 000 Kr. 2 procent interest
            else if (Balance <= 100000)
            {
                Balance *= 1.02M;
            }

            //If account over 100 000 Kr. 3 procent interest
            else if (Balance > 100000)
            {
                Balance *= 1.03M;
            }
        }

        public SavingsAccount(string fName, string lName, int accountNummber)
        {
            this.FirstName = fName;
            this.LastName = lName;

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

        public MasterCardAccount(string fName, string lName, int accountNummber)
        {
            this.FirstName = fName;
            this.LastName = lName;

            this._AccountNummber = accountNummber;
        }

    }
}
