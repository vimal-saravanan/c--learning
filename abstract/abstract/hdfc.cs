using System;
using System.Collections.Generic;
using System.Text;

namespace abstraction
{
    internal class hdfc : bank
    {
        public override void kyc_verification()
        {
            Console.WriteLine("KYC verification successfully for HDFC");
        }
    }
}