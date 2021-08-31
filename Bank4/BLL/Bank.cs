using System;
using System.Collections.Generic;
using System.Linq;
using Bank4.Interface;

namespace Bank4
{
    class Bank : IBank
    {
        public AccountRepo accountRepo = new AccountRepo();

        //Get Bank Name
        public string BankName => bankName;

        //Get Bank saldo
        public decimal BankSaldo => bankSaldo;


        //Bank name
        string bankName;

        //Total sum of money in bank
        decimal bankSaldo => accountRepo.AccountList.Sum(x => x.Balance);


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
            foreach (Account account in accountRepo.AccountList)
            {
                account.ChargeInterest();
            }
        }

    }
}
