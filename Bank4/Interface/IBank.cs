using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank4.Interface
{
    interface IBank
    {
        string BankName { get; }
        decimal BankSaldo { get; }
    }
}
