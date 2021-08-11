using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Bank2
{
    class Program
    {
        //Class Varibale
        static Bank bank;

        static bool ShouldLoop = true;

        static void Main(string[] args)
        {
            //Call class bank
            bank = new Bank();

            //Write name of user
            Console.Write("Skriv name på bruger: ");
            string name = Console.ReadLine();

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

                    Console.Clear();

                    if (ShouldLoop)
                    {
                        //Press any key to continue
                        ToContinue();
                    }
                } 
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
            Console.WriteLine(bank.bankName2);                                                             //
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
                    Deposit();
                    break;

                //Withdraw money
                case ConsoleKey.H:
                    Withdraw();
                    break;

                //Show balance
                case ConsoleKey.S:
                    Console.WriteLine($"Kontoens saldo: {bank.account.Balance:c}");
                    break;

                //Show bank
                case ConsoleKey.B:

                    break;

                //Exit
                case ConsoleKey.X:

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
            Console.WriteLine($"Ny konto oprettet til {name} med saldoen {bank.account.Balance:c}");
        }
        /// <summary>
        /// Method for depositing money
        /// </summary>
        static void Deposit()
        {
            //read info from user
            Console.Write("Indtast beløb, der sakl indsættets: ");
            decimal indtast = Convert.ToDecimal(Console.ReadLine());

            //Deposit the insertet money to account balance
            bank.Deposit(indtast);

            //Show account balance after deposit
            Console.WriteLine($"Konteons saldo efter indsæt: {bank.account.Balance:c}");
        }
        /// <summary>
        /// Withdraw money from account
        /// </summary>
        static void Withdraw()
        {
            //Read info from user
            Console.WriteLine($"Indtast beløb, der skal hæves: ");
            decimal indtast = Convert.ToDecimal(Console.ReadLine());

            //Withdraw the insertet money to account balance
            bank.Withdraw(indtast);

            //Show account balance after Withdraw
            Console.WriteLine($"Kontoens saldo efter hæv: {bank.account.Balance:c}");
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
            Console.Read();

            //Clear console
            Console.Clear();
        }
        #endregion
    }
}
