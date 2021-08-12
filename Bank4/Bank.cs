using System;
using System.Collections.Generic;
using System.Linq;

namespace Bank4
{
    class Bank
    {
        //Public string bankName set to readonly
        public string bankName { get; }

        //Readonly name of bank
        public string bankName2 { get; }

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
        public Bank()
        {

            //Give variables a value
            this.bankName = "*** Velkommen til EUC Banken ***";

            this.bankName2 = "*** Velkommen til EUC Banken - Bank 2 ***";

            acList = new List<Account>();

        }



        /// <summary>
        /// Method for Creating account (name)
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string CreateAccount(string name)
        {
            //Add account to list of accounts
            acList.Add(new Account(name, accountNumberCounter));

            //method for getting account
            account = FindAccount(accountNumberCounter);

            accountNumberCounter++;

            return $"Ny konto oprettet til {name} med saldoen {account.Balance:c}";

        }


        /// <summary>
        /// Method for depositing money to the account
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public string Deposit(decimal amount, int accountNum)
        {
            //method for getting account
            account = FindAccount(accountNum);

            //Account balance is equle to account balance + amount of deposit money
            account.Balance += amount;

            //Return how much money has been added to account
            return $"Konteons saldo efter indsæt: {account.Balance:c}";
        }

        /// <summary>
        /// Method for withdrawing money fro account
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public string Withdraw(decimal amount, int accountNum)
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
                    Console.WriteLine("You don't have enough money");
                    Console.WriteLine("");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();

                    Console.Clear();
                    break;
                }
            } while (true);



            //Return amount of money felt in bank
            return $"Kontoens saldo efter hæv: {account.Balance:c}";
        }

        public string TotalBalance(int accountNum)
        {
            //method for getting account
            account = FindAccount(accountNum);

            return $"Kontoens saldo: {account.Balance:c}";
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


    }
}
