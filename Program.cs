using System;

namespace variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 1;
            //char x = 'a';
            //double p = 5.5;
            //bool b = true;
            //string o = "hello";
            //Console.WriteLine(a);
            //Console.WriteLine(x);
            //Console.Write(x);
            //Console.WriteLine(a+""+x);//string concatenation 
            //Console.WriteLine(p+""+a);//double first when using string concatenation 
            /*int a = 11;
            int b = 2;
            int v = a% b;
            int f = 5;
            int g=6 ;
            int h = a + b - f;
            Console.WriteLine(h);*/
            Console.WriteLine("Enter the vale of a = ");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the vale of a = ");
            int b = Convert.ToInt16(Console.ReadLine());
            Console.Write(" a + b = ");
            Console.WriteLine(a + b);
            Console.Write(" a - b = ");
            Console.WriteLine(a - b);
            Console.Write(" b - a = ");
            Console.WriteLine(b - a);
            Console.Write(" a / b = ");
            Console.WriteLine(a /b);
            Console.Write(" a * b = ");
            Console.WriteLine(b * a);
            Console.Write(" a % b = ");
            Console.WriteLine(a % b);
            Console.Write(" b % a = ");
            Console.WriteLine(b % a);
        }
    }
}