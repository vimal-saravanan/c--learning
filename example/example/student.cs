using System;
using System.Collections.Generic;
using System.Text;

namespace example
{
    internal class student
    {
        private int student_id;
        private string student_name;
        private char student_section;
        private string student_group;

        public student(int id, string name, char section, string group)
        {
            student_id = id;
            student_name = name;
            student_section= section;
            student_group = group;
        }
        public void student_details()
        {
            Console.WriteLine(student_id);
            Console.WriteLine(student_name);
            Console.WriteLine(student_section);
            Console.WriteLine(student_group);
        }
        

      
    }
}
