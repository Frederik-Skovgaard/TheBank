using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Bank4
{

    
    class Program
    {
        //Class Varibale
        static Bank bank;

        static bool ShouldLoop = true;

        static string name;

        static AccountType accountType;

        static ConsoleKey acType;


        static void Main(string[] args)
        {
            //Call class bank
            bank = new Bank("*** Velkommen til EUC Bank 4 ***");

            //Write name of user
            Console.Write("Skriv name på bruger: ");
            name = Console.ReadLine();

            Console.WriteLine("");

            //Choose account type
            Console.WriteLine("Konto type: \n(1) Checking Konto\n(2) Savings Konto\n(3) MasterCard Konto");
            acType = Console.ReadKey().Key;

            accountType = AccountChoose(acType);

            //Call class account
            bank.CreateAccount(name, accountType);

            Console.Clear();

            //Show Account info
            Console.WriteLine($"Konto Navn: {name}\nKonto Type: {accountType}");

            ToContinue();


            //Loop bank menu
            while (ShouldLoop)
            {
                try
                {
                    Console.Clear();

                    //Bank Menu
                    BankTwoMenu();

                    if (ShouldLoop)
                    {
                        //Press any key to continue
                        ToContinue();
                    }
                }
                //Writ custome error message on error
                catch (Exception e)
                {
                    Console.Clear();

                    Console.WriteLine(e.Message);

                    ToContinue();
                }
            }
        }


        /// <summary>
        /// Bank Menu
        /// </summary>
        static void BankTwoMenu()
        {
            ////////////////////////////////Start Of Menu 2//////////////////////////////////////////////////
                                                                                                           //
            //Write bank name 2                                                                            //
            Console.WriteLine(bank.bankName);                                                             //
                                                                                                           //
            //Enter a key                                                                                  //
            Console.WriteLine("Vælg venligst...");                                                         //
            Console.WriteLine();                                                                           //
            Console.WriteLine("m = Menu");                                                                 //
            Console.WriteLine("k = Konto oprettes");                                                       //
            Console.WriteLine("i = Indsæt");                                                               //
            Console.WriteLine("h = Hæv beløb");                                                            //
            Console.WriteLine("r = Rentetilskrivning");                                                    //
            Console.WriteLine("s = Vis saldo");                                                            //
            Console.WriteLine("b = Vis bank");                                                             //
            Console.WriteLine("x = Afslut");                                                               //
                                                                                                           //
            //Read the next key press                                                                      //
            var readKey = Console.ReadKey().Key;                                                           //
                                                                                                           //
             ////////////////////////////////End Of Menu 2///////////////////////////////////////////////////


            //Switch for the indiviual key pressed
            switch (readKey)
            {
                //Enter Menu
                case ConsoleKey.M:
                    
                    break;

                //Create account
                case ConsoleKey.K:

                    Console.Clear();
                    Console.WriteLine("--- Konto Oprettelse ---");
                    CreateAccount();
                    break;

                //Deposit money
                case ConsoleKey.I:

                    Console.Clear();

                    Console.WriteLine("--- Indsæt penge ---");
                    Deposit();
                    break;

                //Withdraw money
                case ConsoleKey.H:

                    Console.Clear();

                    Console.WriteLine("--- Hæv penge ---");
                    Withdraw();
                    break;

                case ConsoleKey.R:

                    Console.Clear();

                    Console.WriteLine("--- Rentetilskrivning ---");
                    Rentetilskrivning();

                    break;

                //Show balance
                case ConsoleKey.S:

                    Console.Clear();

                    Console.WriteLine("--- Vis konto saldo ---");
                    ShowBalance();
                    
                    break;

                //Show bank
                case ConsoleKey.B:
                    Console.Clear();

                    Console.WriteLine("--- Banken Saldo ---");
                    Console.WriteLine($"Banken saldo: {bank.BankSaldo}");

                    break;

                //Exit
                case ConsoleKey.X:

                    Console.Clear();

                    //Close Console
                    Environment.Exit(0);

                    ShouldLoop = false;

                    break;

                default:
                    throw new ArgumentException("Dette menupunkt eksisterer ikke...");
            }
        }


        #region Functions
        /// <summary>
        /// Method for creating accounts 
        /// </summary>
        static void CreateAccount()
        {
            //Writ account name
            Console.Write("Indtast kundens navn: ");
            string name = Console.ReadLine();

            Console.WriteLine("");

            //Choose account type
            Console.WriteLine("Konto type: \n(1) Checking Konto\n(2) Savings Konto\n(3) MasterCard Konto");
            acType = Console.ReadKey().Key;

            accountType = AccountChoose(acType);

            Console.Clear();

            //Show Account info
            Console.WriteLine($"Konto Navn: {name}\nKonto Type: {accountType}");

            //Call class Account
            bank.CreateAccount(name, accountType);
        }



        /// <summary>
        /// Method for depositing money
        /// </summary>
        static void Deposit()
        {
            //Show specific acconunt
            Console.Write("Indtast kontonummer: ");
            int accountNum = Convert.ToInt32(Console.ReadLine());

            //read info from user
            Console.Write("Indtast beløb, der skal indsættets: ");
            decimal indtast = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("");

            //Deposit the insertet money to account balance
            Console.WriteLine(bank.Deposit(indtast, accountNum));

            Console.WriteLine("");
            
        }
        
        /// <summary>
        /// Withdraw money from account
        /// </summary>
        static void Withdraw()
        {
            //Show specific acconunt
            Console.Write("Indtast kontonummer: ");
            int accountNum = Convert.ToInt32(Console.ReadLine());

            //Read info from user
            Console.Write($"Indtast beløb, der skal hæves: ");
            decimal indtast = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("");

            //Withdraw the insertet money to account balance
            Console.WriteLine(bank.Withdraw(indtast, accountNum));
        }

        /// <summary>
        /// Shows account balance
        /// </summary>
        static void ShowBalance()
        {
            //Show specific acconunt
            Console.Write("Indtast kontonummer: ");
            int accountNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            //Show balance of account
            Console.WriteLine(bank.TotalBalance(accountNum));
        }

        /// <summary>
        /// Method for executing charged interest
        /// </summary>
        static void Rentetilskrivning()
        {
           
            Console.WriteLine("Renter er tilskrevet");

            //Method for charing interest
            bank.ChargeInterest();
        }

        #endregion


        #region Pratical
        /// <summary>
        /// Method for ending transaction's
        /// </summary>
        static void ToContinue()
        {
            //Space
            Console.WriteLine("");

            //Continue
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            //Clear console
            Console.Clear();
        }

        /// <summary>
        /// Method for chossing account type
        /// </summary>
        /// <param name="acType"></param>
        /// <returns></returns>
        static AccountType AccountChoose(ConsoleKey acType)
        {
            //Switch for choosing account type
            switch (acType)
            {
                case ConsoleKey.D1:
                    accountType = AccountType.CheckingAccount;
                    break;

                case ConsoleKey.D2:
                    accountType = AccountType.SavingsAccount;
                    break;

                case ConsoleKey.D3:
                    accountType = AccountType.MasterCardAccount;
                    break;

                default:
                    break;
            }

            //Return Account Type
            return accountType;
        }
        #endregion
    }
}
