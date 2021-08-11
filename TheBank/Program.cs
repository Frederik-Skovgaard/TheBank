using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBank
{
    class Program
    {

        /// <summary>
        /// Bank Menu
        /// </summary>
        /// <param name="args"></param>
       static void Main(string[] args)
       {
            //String variable
            string name = "Katja";

            //Call class bank
            Bank bankObj = new Bank();

            //Call class account
            Account acObj = bankObj.CreateAccount(name);


            ////////////////////////////////Start Of Menu////////////////////////////////////////////////////
                                                                                                           //
            //Write title                                                                                  //
            Console.WriteLine(bankObj.bankName);                                                           //
                                                                                                           //
            //Write Name & Saldo                                                                           //
            Console.WriteLine($"Ny Konto oprettet til {acObj.Name} med saldoen Kr. {acObj.Balance}");      //
                                                                                                           //
            //Write Saldo after deposit                                                                    //
            Console.WriteLine($"kontoens saldo efter indsæt: Kr. {bankObj.Deposit(500)}");                 //
                                                                                                           //
            //Write Saldo after withdraw                                                                   //
            Console.WriteLine($"Kontoens saldo efter hæv: Kr. {bankObj.Withdraw(300)}");                   //
                                                                                                           //
            //Write the saldo                                                                              //
            Console.WriteLine($"Kontoens saldo: Kr. {acObj.Balance}");                                     //
                                                                                                           //
            ////////////////////////////////End Of Menu//////////////////////////////////////////////////////
       }
    }
}
