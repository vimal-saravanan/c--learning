using System;
using System.Collections.Generic;
using System.Text;

namespace abstraction_ex1
{
    internal class train : transport
    {
        public override void travel()
        {
            Console.WriteLine("the transport type is Rail transport");
        }

    }
}