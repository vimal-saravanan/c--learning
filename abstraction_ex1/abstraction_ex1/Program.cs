using abstraction_ex1;
using System;
class Program
{
    public static void Main()
    {
        transport train = new train();
        transport flight = new flight();
        flight.travel();
    }
}