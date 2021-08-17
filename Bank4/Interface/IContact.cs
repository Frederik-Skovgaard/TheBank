using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank4.Interface
{
    interface IContact
    {
        string FirstName { get; }
        string LastName { get; }

        string FullName { get; }


        string Street { get; }
        int Postal { get; }
        string City { get; }

        string ContactInfo { get; }


        int PhoneNummber { get; }
    }
}
