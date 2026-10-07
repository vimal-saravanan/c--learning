using example;
using System;
class Program
{
    public static void Main(string[] args)
    {
        student s1=new student(1,"vimal",'a',"computer");
        s1.student_details();

        student s2 = new student(2, "nara", 'b', "bio");
        s2.student_details();

    }
}