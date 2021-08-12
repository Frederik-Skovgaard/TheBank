using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Bank3
{
    class Program
    {
        //Class Varibale
        static Bank bank;

        static bool ShouldLoop = true;

        static string name;


        static void Main(string[] args)
        {
            //Call class bank
            bank = new Bank("*** Velkomen til EUC Bank 3 ***");

            //Write name of user
            Console.Write("Skriv name på bruger: ");
            name = Console.ReadLine();

            //Call class account
            bank.CreateAccount(name);


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
            Console.WriteLine("s = Vis saldo");                                                            //
            Console.WriteLine("b = Vis bank");                                                             //
            Console.WriteLine("x = Afslut");                                                               //
                                                                                                           //
            //Read the next key press                                                                      //
            var readKey = Console.ReadKey().Key;                                                           //
                                                                                                           //
             ////////////////////////////////End Of Menu 2////////////////////////////////////////////////////


            //Switch for the indiviual key pressed
            switch (readKey)
            {
                //Enter Menu
                case ConsoleKey.M:
                    
                    break;

                //Create account
                case ConsoleKey.K:

                    Console.Clear();

                    CreateAccount();
                    break;

                //Deposit money
                case ConsoleKey.I:

                    Console.Clear();

                    Deposit();
                    break;

                //Withdraw money
                case ConsoleKey.H:

                    Console.Clear();

                    Withdraw();
                    break;

                //Show balance
                case ConsoleKey.S:

                    Console.Clear();

                    ShowBalance();
                    
                    break;

                //Show bank
                case ConsoleKey.B:
                    Console.WriteLine(bank.BankSaldo);
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

            //Call class Account
            bank.CreateAccount(name);

            //Show name & balance
            Console.WriteLine();

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
            Console.Write("Indtast beløb, der sakl indsættets: ");
            decimal indtast = Convert.ToDecimal(Console.ReadLine());

            //Deposit the insertet money to account balance
            Console.WriteLine(bank.Deposit(indtast, accountNum));

            
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

            //Show balance of account
            Console.WriteLine(bank.TotalBalance(accountNum));
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
        #endregion
    }
}
