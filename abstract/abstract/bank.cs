using System;
using System.Collections.Generic;
using System.Text;

namespace abstraction
{
    abstract class bank
    {
        public abstract void kyc_verification();
        public void bank_details()
        {
            Console.WriteLine("This is my bank");
        }
    }
}