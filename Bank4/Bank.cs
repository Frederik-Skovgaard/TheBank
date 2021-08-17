using System;
using System.Collections.Generic;
using System.Linq;

namespace Bank4
{
    public class Bank
    {
        //Reference to AccountRepo
        AccountRepo account;

        //Get Bank Name
        public string BankName { get; }

        //Get Bank saldo
        public decimal BankSaldo {get { return bankSaldo; } }


        //Bank name
        string bankName;

        //Total sum of money in bank
        decimal bankSaldo => account.AccountList.Sum(x => x.Balance);


        /// <summary>
        /// Method for getting/initializing bankName
        /// </summary>
        public Bank(string name)
        {
            bankName = name;

        }


        /// <summary>
        /// Method for calculating interest
        /// </summary>
        public void ChargeInterest()
        {
            foreach (Account account in account.AccountList)
            {
                account.ChargeInterest();
            }
        }

    }
}
