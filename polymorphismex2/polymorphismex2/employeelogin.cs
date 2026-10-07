using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphismex2
{
    internal class employeelogin
    {
        public int employeeid;
        public string employeename;

        string employee_name = "vimal";

        public virtual void  emp_login(string emp_name)
        {
            if (employeename==emp_name)
            {
                Console.WriteLine("login succesful");
            }

        }
    }
}
