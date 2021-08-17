using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank4.Interface
{
    //Account Interface
    interface IAccount
    {
        //Account balance
        decimal Balance { get; set; }

        //Account nummber
        int _AccountNummber { get; set; }

        //Account type
        AccountType AccountType { get; set; }
    }
}
