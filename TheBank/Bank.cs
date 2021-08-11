using System;

namespace TheBank
{


    //TODO: Create menue
    class Bank
    {

        //Method for getting/initializing bankName
        public Bank()
        {
            //Give bankName a value
            this.bankName = "*** Welcome To EUC Bank ***";
        }


        //Public string bankName set to readonly
        public string bankName { get; }

    }
}
