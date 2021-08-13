using System;
using System.Collections.Generic;
using System.Linq;

namespace Bank4
{
    class Bank
    {
        //Public string bankName set to readonly
        public string bankName { get; }

        //Account varible
        public Account account { get; private set; }

        //Total sum of money in bank
        public decimal BankSaldo => acList.Sum(x => x.Balance);

        //Account List
        public List<Account> acList;

        int accountNumberCounter = 1;

        /// <summary>
        /// Method for getting/initializing bankName
        /// </summary>
        public Bank(string name)
        {
            
            this.bankName = name;

            acList = new List<Account>();

        }



        /// <summary>
        /// Method for Creating account (name)
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string CreateAccount(string name, AccountType accountType)
        {
            //Switch for creating specific account type
            switch (accountType)
            {
                //Checkings account
                case AccountType.CheckingAccount:
                    acList.Add(new CheckingAccount(name, accountNumberCounter));
                    break;

                    //Savings account
                case AccountType.SavingsAccount:
                    acList.Add(new SavingsAccount(name, accountNumberCounter));
                    break;

                    //MasterCard account
                case AccountType.MasterCardAccount:
                    acList.Add(new MasterCardAccount(name, accountNumberCounter));
                    break;
                default:
                    break;
            }


            //method for getting account
            account = FindAccount(accountNumberCounter);

            accountNumberCounter++;

            return $"Ny {account.AccountType} oprettet til {name} med saldoen {account.Balance:c}";
            
        }


        /// <summary>
        /// Method for depositing money to the account
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public string Deposit(decimal amount, int accountNum)
        {
            //Validates account nummber
            try
            {
                //method for getting account
                account = FindAccount(accountNum);

                //Account balance is equle to account balance + amount of deposit money
                account.Balance += amount;

                //Return how much money has been added to account
                return $"Konteons saldo efter indsæt: {account.Balance:c}";
            }
            catch (Exception)
            {
                return "Dette konto numer eksisterer ikke...";
            }
            
        }

        /// <summary>
        /// Method for withdrawing money fro account
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public string Withdraw(decimal amount, int accountNum)
        {
            //Validates account nummber
            try
            {
                //method for getting account
                account = FindAccount(accountNum);

                //Account balance is equle to account balance - amount of witdrawed money
                do
                {
                    //If amount is less then balance no problem
                    if (amount <= account.Balance)
                    {
                        account.Balance -= amount;
                        break;
                    }
                    //If amount is bigger then balance try agin
                    else if (amount > account.Balance)
                    {
                        return $"Du har ikke nok penge på kontoen";
                    }
                } while (true);


                //Return amount of money felt in bank
                return $"Kontoens saldo efter hæv: {account.Balance:c}";
            }
            catch (Exception)
            {
                return "Dette konto numer eksisterer ikke...";
            }
            
        }

        public string TotalBalance(int accountNum)
        {
            //Validates account nummber
            try
            {
                //method for getting account
                account = FindAccount(accountNum);

                return $"Kontoens saldo: {account.Balance:c}";
            }
            catch (Exception)
            {
                return "Dette konto numer eksisterer ikke...";
            }

            
        }

        /// <summary>
        /// Method for getting account
        /// </summary>
        /// <param name="accountNum"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public Account FindAccount(int accountNum)
        {
            //Account finder from nummber
            Account account = acList[acList.FindIndex(l => l._AccountNummber == accountNum)];
            return account;
        }
       

        /// <summary>
        /// Method for calculating interest
        /// </summary>
        public void ChargeInterest()
        {
            foreach (Account account in acList)
            {
                account.ChargeInterest();
            }            
        }


    }
}
