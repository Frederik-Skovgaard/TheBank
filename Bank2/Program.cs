using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank2
{
    class Program
    {
        
        /// <summary>
        /// Bank choose Menu
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Call class bank
            Bank bank = new Bank();

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
            //String variable
            string name = "Katja";

            //Call class bank
            Bank bank = new Bank(); ;

            //Call class account
            Account acObj = bank.CreateAccount(name);


            ////////////////////////////////Start Of Menu////////////////////////////////////////////////////
                                                                                                           //
            //Write bank name                                                                              //
            Console.WriteLine(bank.bankName);                                                              //
                                                                                                           //
            //Write Name & Saldo                                                                           //
            Console.WriteLine($"Ny Konto oprettet til {acObj.Name} med saldoen Kr. {acObj.Balance}");      //
                                                                                                           //
            //Write Saldo after deposit                                                                    //
            Console.WriteLine($"kontoens saldo efter indsæt: Kr. {bank.Deposit(500)}");                    //
                                                                                                           //
            //Write Saldo after withdraw                                                                   //
            Console.WriteLine($"Kontoens saldo efter hæv: Kr. {bank.Withdraw(300)}");                      //
                                                                                                           //
            //Write the saldo                                                                              //
            Console.WriteLine($"Kontoens saldo: Kr. {acObj.Balance}");                                     //
                                                                                                           //
            ////////////////////////////////End Of Menu//////////////////////////////////////////////////////

        }
    }
}
