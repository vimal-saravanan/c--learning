using polymorphismex1;
using System;
class Program
{
    public static void Main()
    {
        school obj1 = new school(101, 201, "vimal", "ece", "santhosh");
        school obj2 = new school(102, 202, "indira","cse", "aganda");

        obj1.schoollog("vimal", 101);
       
    }
}