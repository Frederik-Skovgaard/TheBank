using System;

namespace Bank3
{

    //TODO: Method for showing all money in the bank
    
    class Bank
    {

        /// <summary>
        /// Method for getting/initializing bankName
        /// </summary>
        public Bank()
        {
            //Give variables a value
            this.bankName = "*** Velkommen til EUC Banken ***";

            this.bankName2 = "*** Velkommen til EUC Banken - Bank 2 ***";
        }

        //Public string bankName set to readonly
        public string bankName { get; }

        //Readonly name of bank
        public string bankName2 { get; }


        //Account varible
        public Account account { get; private set; }

        /// <summary>
        /// Method for Creating account (name)
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public void CreateAccount(string name)
        {
            //Fill Account Object
            Account acObj = new Account(name);

            //Account varible is equle to account object
            this.account = acObj;
        }


        /// <summary>
        /// Method for depositing money to the account
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public decimal Deposit(decimal amount)
        {
            //Account balance is equle to account balance + amount of deposit money
            account.Balance = account.Balance + amount;

            //Return how much money has been added to account
            return account.Balance;
        }

        /// <summary>
        /// Method for withdrawing money fro account
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public decimal Withdraw(decimal amount)
        {
            //Account balance is equle to account balance - amount of witdrawed money
            account.Balance = account.Balance - amount;

            //Return amount of money felt in bank
            return account.Balance;
        }

        /// <summary>
        /// Method for returning account balance
        /// </summary>
        /// <returns></returns>
        public decimal Balance()
        {
            //Return account balance
            return account.Balance;
        }


    }
}
