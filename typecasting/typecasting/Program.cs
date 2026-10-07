using System;

class Program
{
    public static void Main(string[] args)
    {
        //typecasting
        //1.impliciteconversion--automatic conversion
        //int->long->float->double->decimal 
        //2.expliciteconversion--manual conversion
        //decimal->double->float->long->int

        int z = 34;
        long x = z;
        Console.WriteLine(x);

        decimal a = 56.568m;
        long b = Convert.ToInt64 (a); 
        Console.WriteLine(b);

        decimal c = 86.5665m;
        double d = Convert.ToDouble(c);
        Console.WriteLine(d);

        decimal e = 86.5665m;
        float f = Convert.ToSingle(e);
        Console.WriteLine(f);

        decimal g = 86.5665m;
        int h = Convert.ToInt32(g);
        Console.WriteLine(h);






    }
}
