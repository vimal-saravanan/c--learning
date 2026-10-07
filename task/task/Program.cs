using System;
using System.ComponentModel.Design;
class program
{
    public static void Main(string[] args)
    {
        //ex-1
        //int a=Convert.ToInt32(Console.ReadLine());
        //int b = Convert.ToInt32(Console.ReadLine());
        //int c = Convert.ToInt32(Console.ReadLine());

        //if(a>=b && a>=c)
        //{
        //    Console.WriteLine(a);

        //}
        //else if(b>=a && b>=c)
        //{
        //    Console.WriteLine(b);
        //}
        //else
        //{
        //    Console.WriteLine(c);
        //}

        //ex-2
        //int mark = Convert.ToInt32(Console.ReadLine());
        //if(mark >=90 && mark <=100)
        //{
        //    Console.WriteLine("a");

        //}
        //else if(mark >=80)
        //{
        //    Console.WriteLine("b");
        //}
        //else if(mark >=70)
        //{
        //    Console.WriteLine("c");
        //}
        //else if(mark>=50)
        //{
        //    Console.WriteLine("d");
        //}
        //else
        //{
        //    Console.WriteLine("fail");
        //}

        //ex-3
        //int year = Convert.ToInt32(Console.ReadLine());

        //if(year %400==0 || (year %4==0 && year%100!=0))
        //{
        //    Console.WriteLine("leap yaer");
        //}
        //else
        //{
        //    Console.WriteLine("not a leap year");
        //}

        //ex-4

        //char ch = Convert.ToChar(Console.ReadLine());
        //if (ch =='a' || ch== 'e' || ch == 'i'|| ch == 'o'|| ch == 'u')

        //{
        //    Console.WriteLine("vowels");
        //}
        //else
        //{
        //    Console.WriteLine("consonents");
        //}

        //ex-5
        //string username = Console.ReadLine();
        //string password = Console.ReadLine();

        //if (username == "admin" && password == "1234") 
        //{
        //    Console.WriteLine("login success");

        //}
        //else
        //{
        //    Console.WriteLine("invalid login");
        //}


        //ex-6

        //int units = Convert.ToInt32(Console.ReadLine());
        //int bills;
        //if(units<=100)
        //{
        //    bills = units * 5;
        //}
        //else if(units <=200)
        //{
        //    bills = (100 * 5 + (units - 100) * 7);
        //}
        //else
        //{
        //    bills = (100 * 5) + (100 * 7) + ((units - 200) * 10);

        //}
        //Console.WriteLine(bills);


        //ex-7

        //int a = Convert.ToInt32(Console.ReadLine());
        //int b = Convert.ToInt32(Console.ReadLine());
        //int c = Convert.ToInt32(Console.ReadLine());
        //if (a + b > c && b + c > a && c + a > b) 
        //{
        //    Console.WriteLine("valid triangls");

        //}
        //else
        //{
        //    Console.WriteLine("not a valid triangle");
        //}


        //ex-8

        //int balance = Convert.ToInt32(Console.ReadLine());
        //int amount = Convert.ToInt32(Console.ReadLine());

        //if (amount > 0 && amount <= balance && amount % 100 == 0)
        //{
        //    balance -= amount;
        //    Console.WriteLine("withdrawal successful");
        //    Console.WriteLine($"your balance is :{balance}");
        //}
        //else
        //{
        //    Console.WriteLine("invalid transaction");
        //}

        //ex-9

        //int a = Convert.ToInt32(Console.ReadLine());
        //int b = Convert.ToInt32(Console.ReadLine());
        //int c = Convert.ToInt32(Console.ReadLine());
        //if (a > b && a > c) 
        //{
        //    Console.WriteLine("a is largest");
        //}
        //else if (b > a && b > c) 
        //{
        //    Console.WriteLine("b id largest");

        //}
        //else if (c > a && c > b)
        //{
        //    Console.WriteLine("c is greater");
        //}
        //else
        //{
        //    Console.WriteLine("invalid value");
        //}

        //ex-10

        //int a = Convert.ToInt32(Console.ReadLine());
        //int b = Convert.ToInt32(Console.ReadLine());
        //int c = Convert.ToInt32(Console.ReadLine());
        //if (a <= b && a <= c)
        //{
        //    Console.WriteLine("a is smallest");
        //}
        //else if (b <= a && b <= c)
        //{
        //    Console.WriteLine("b is smallest");

        //}
        //else if (c <= a && c <= b)
        //{
        //    Console.WriteLine("c is smallest");
        //}
        //else
        //{
        //    Console.WriteLine("invalid value");
        //}

        //ex-11

        //char ch = Convert.ToChar(Console.ReadLine());
        //if(ch >='A' && ch<='Z')
        //{
        //    Console.WriteLine("Uppercase");
        //}
        //else if(ch >='a' && ch<='z')
        //{
        //    Console.WriteLine("lowercase");
        //}
        //else if (ch >= '0' && ch <= '9')
        //{
        //    Console.WriteLine("digit");
        //}
        //else
        //{
        //    Console.WriteLine("special charecter");
        //}

        //ex-12

        //int age = Convert.ToInt32(Console.ReadLine());
        //if(age<0)
        //{
        //    Console.WriteLine("invalid age");

        //}
        //else if(age<=12)
        //{
        //    Console.WriteLine("child");
        //}
        //else if( age<=19)
        //{
        //    Console.WriteLine("teenager");
        //}
        //else if (age <= 59)
        //{
        //    Console.WriteLine("adult");
        //}
        //else 
        //{
        //    Console.WriteLine("senior citizen");
        //}

        //ex-13

        //int cp = Convert.ToInt32(Console.ReadLine());
        //int sp = Convert.ToInt32(Console.ReadLine());

        //if(sp>cp)
        //{
        //    Console.WriteLine("profit");
        //    Console.WriteLine(sp-cp);
        //}
        //else if(cp>sp)
        //{
        //    Console.WriteLine("loss");
        //    Console.WriteLine(cp-sp);
        //}
        //else
        //{
        //    Console.WriteLine("no profit no loss");
        //}


        //ex-14
        //double weight = Convert.ToDouble(Console.ReadLine());
        //double height = Convert.ToDouble(Console.ReadLine());
        //double bmi =weight/(height*height);
        //if (bmi<18.5)
        //{
        //    Console.WriteLine("underweight");
        //}
        //else if(bmi<25)
        //{
        //    Console.WriteLine("normal");
        //}
        //else if(bmi<30)
        //{
        //    Console.WriteLine("overweight");

        //}
        //else
        //{
        //    Console.WriteLine("obese");
        //}

        //ex-15
        //int attendence = Convert.ToInt32(Console.ReadLine());
        //int internalmak = Convert.ToInt32(Console.ReadLine());
        //bool assignment = Convert.ToBoolean(Console.ReadLine());
        //if(attendence>=75 && internalmak>=40 && assignment)
        //{
        //    Console.WriteLine("eligible for exam");
        //}
        //else if(attendence<75)
        //{
        //    Console.WriteLine("attendence shortage");
           
        //}
        //else if(internalmak<40)
        //{
        //    Console.WriteLine("internal mark shortage");

        //}
        //else
        //{
        //    Console.WriteLine("assignment not submitted");
        //}







    }
}