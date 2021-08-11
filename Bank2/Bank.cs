using System;

namespace Bank2
{


    
    class Bank
    {

        /// <summary>
        /// Method for getting/initializing bankName
        /// </summary>
        public Bank()
        {
            //Give bankName a value
            this.bankName = "*** Welcome To EUC Bank ***";
        }

        //Public string bankName set to readonly
        public string bankName { get; }


        //Account varible
        Account account;

        /// <summary>
        /// Method for Creating account (name)
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Account CreateAccount(string name)
        {
            //Fill Account Object
            Account acObj = new Account(name);

            //Account varible is equle to account object
            account = acObj;

            //Return Account varibal
            return account;
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
