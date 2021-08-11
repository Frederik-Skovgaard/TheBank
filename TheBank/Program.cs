using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBank
{
    class Program
    {
       static void Main(string[] args)
        {
            //Call class bank
            Bank bankClass = new Bank();
         
           

            //Write title to console
            Console.WriteLine(bankClass.bankName);
        }
    }
}
