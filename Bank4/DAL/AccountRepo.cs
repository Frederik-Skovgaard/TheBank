using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank4
{
    public class AccountRepo
    {
        //Get acList
        public List<Account> AccountList { get { return acList; } }

        //Get Account nummber counter
        public int AccountNummberCounter { get { return accountNumberCounter; } }

        //Account references
        private Account account;

        //Account List
        private List<Account> acList;

        //Keep track of account nummber
        private int accountNumberCounter = 1;

        //AccountRepo Constructer
        public AccountRepo()
        {
            acList = new List<Account>();
        }


        /// <summary>
        /// Method for Creating account (name)
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string CreateAccount(string fName, string lName, AccountType accountType)
        {
            
            //Switch for creating specific account type
            switch (accountType)
            {
                //Checkings account
                case AccountType.CheckingAccount:
                    acList.Add(new CheckingAccount(fName, lName, accountNumberCounter));
                    break;

                //Savings account
                case AccountType.SavingsAccount:
                    acList.Add(new SavingsAccount(fName, lName, accountNumberCounter));
                    break;

                //MasterCard account
                case AccountType.MasterCardAccount:
                    acList.Add(new MasterCardAccount(fName, lName, accountNumberCounter));
                    break;
                default:
                    break;
            }


            //method for getting account
            account = FindAccount(accountNumberCounter);

            accountNumberCounter++;

            return $"Ny {account.AccountType} oprettet til {fName} {lName} med saldoen {account.Balance:c2}";

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

                if (amount < 0)
                {
                    return $"Du kan ikke insæt minnus penge...";
                }
                else
                {
                    //Account balance is equle to account balance + amount of deposit money
                    account.Balance += amount;

                    //Return how much money has been added to account
                    return $"Konteons saldo efter indsæt: {account.Balance:c}";
                }
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

                if (amount < 0)
                {
                    return $"Du kan ikke hæv minnus penge...";
                }
                else
                {
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
                }

                //Return amount of money felt in bank
                return $"Kontoens saldo efter hæv: {account.Balance:c}";
            }
            catch (Exception)
            {
                return "Dette konto numer eksisterer ikke...";
            }

        }

        /// <summary>
        /// Show account total balance
        /// </summary>
        /// <param name="accountNum"></param>
        /// <returns></returns>
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
            account = acList.Find(l => l._AccountNummber == accountNum);
            return account;
        }

        


    }
}
