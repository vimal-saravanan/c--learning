using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphismex1
{
    internal class school
    {
        private int student_registernumber;
        private int teacher_registernumber;
        private string student_name;
        private string teacher_name;

        private string department;



        public school(int stu_id, int teacher_id, string stu_name, string dep, string teach_name)
        {
            student_registernumber = stu_id;
            student_name = stu_name;
            teacher_name = teach_name;
            teacher_registernumber = teacher_id;
            department = dep;


        }



        public void schoollog(string stud_name, int student_register)
        {
            if(stud_name == student_name && student_register==student_registernumber)
            {
                Console.WriteLine("login successful");
            }
            else
            {
                Console.WriteLine("login unsuccessfu");
            }
        }

        public void schoollog(int teacherid, string teach)
        {
            if(teacherid== teacher_registernumber && teach == teacher_name)
            {
                Console.WriteLine("login successful");

            }
            else
            {
                Console.WriteLine("login unsuccesful");
            }
        }

        
        
    }

 }
