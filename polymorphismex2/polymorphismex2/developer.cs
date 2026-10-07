using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphismex2
{
    internal class developer:employeelogin
    {
        string employeename = "mathesh";
        public override void emp_login(string emp_name)
        {
            if (emp_name == employeename)
            {
                Console.WriteLine("login unsuccesful");
            }

        }
    }
}
