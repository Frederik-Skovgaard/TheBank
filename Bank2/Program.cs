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
        Account account;

        /// <summary>
        /// Bank choose Menu
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Call class bank
            Bank bank = new Bank();

            //Write name of user
            Console.WriteLine("Skriv name på bruger: ");
            string name = Console.ReadLine();

            //Call class account
            bank.CreateAccount(name);
            


            ////////////////////////////////Start Of Menu//////////////////////////////////////////////////////////////
                                                                                                                     //
            //Write bank name                                                                                        //
            Console.WriteLine(bank.bankName);                                                                        //
                                                                                                                     //
            //Write Name & Saldo                                                                                     //
            Console.WriteLine($"Ny Konto oprettet til {bank.account.Name} med saldoen Kr. {bank.account.Balance}");  //
                                                                                                                     //
                                                                                                                     //
            ////////////////////////////////End Of Menu////////////////////////////////////////////////////////////////

            
            Console.Clear();

            ////////////////////////////////Start Of Menu 2//////////////////////////////////////////////////
                                                                                                           //
            //Write bank name 2                                                                            //
            Console.WriteLine(bank.bankName2);                                                             //
                                                                                                           //
            //Enter a key                                                                                  //
            Console.WriteLine("Vælg venligst...");                                                         //
                                                                                                           //
            Console.WriteLine("m = Menu");                                                                 //
            Console.WriteLine("k = Konto oprettes");                                                       //
            Console.WriteLine("i = Indsæt");                                                               //
            Console.WriteLine("h = Hæv beløb");                                                            //
            Console.WriteLine("s = Vis saldo");                                                            //
            Console.WriteLine("b = Vis bank");                                                             //
            Console.WriteLine("x = Afslut");                                                               //
                                                                                                           //
            //Read the next key press                                                                      //
            string readKey = Console.ReadKey().ToString();                                                 //
                                                                                                           //
            ////////////////////////////////End Of Menu 2////////////////////////////////////////////////////


            //Switch for the indiviual key pressed
            switch (readKey)
            {
                    //Enter Menu
                case "m":

                    break;

                    //Create account
                case "k":

                    //Writ account name
                    Console.WriteLine("Indtast kundens navn: ");
                    string uName = Console.ReadLine();

                    //Call class Account
                    bank.CreateAccount(uName);

                    //Show name & balance
                    Console.WriteLine($"Ny konto oprettet til {uName} med saldoen Kr. {bank.account.Balance}");

                    //Space
                    Console.WriteLine("");

                    //Continue
                    Console.WriteLine("Press any key to continue...");
                    Console.Read();

                    Console.Clear();

                    break;

                    //Deposit money
                case "i":

                    
                    break;

                    //Withdraw money
                case "h":

                    break;

                    //Show balance
                case "s":

                    break;

                    //Show bank
                case "b":

                    break;

                    //Exit
                case "x":

                    //Close Console
                    Environment.Exit(0);

                    break;

                default:
                    break;
            }
        }



        /// <summary>
        /// Bank Menu
        /// </summary>
        public void Menu()
        {          
            //Call class bank
            Bank bank = new Bank(); ;

            

        }
    }
}
