using System;

namespace TheBank
{


    //TODO: Create menue
    class Bank
    {

        //Method for getting/initializing bankName
        public Bank()
        {

        }
        public Bank(string bName)
        {
            //Give bName a value
            bName = "*** Welcome To EUC Bank ***";

            //Set bankName value to variable bName
            this.bankName = bName;
        }


        //Public string bankName set to readonly
        public string bankName { get; }

    }
}
