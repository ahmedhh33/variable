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

            // swaping two intiger
            Console.WriteLine("Swapping two intiger ");
            int Z = 15;
            int M = 30;
            Console.WriteLine("Befor swapping Z = " + Z + " M =" + M);
            Z = Z + M;
            M = Z - M;
            Z = Z - M;
            Console.WriteLine("After swapping Z = " + Z + " M =" + M);

            // swaping two string
            Console.WriteLine("Swapping two strings ");
            string stri1 = "Ahmed";
            string stri2 = "Humaid";

            Console.WriteLine("Befor swapping");
            Console.WriteLine(stri1);
            Console.WriteLine(stri2);
            stri1 = stri1 + stri2;

            stri2 = stri1.Substring(0, stri1.Length - stri2.Length);
            stri1 = stri1.Substring( stri2.Length);
            Console.WriteLine("after swapping");
            Console.WriteLine(stri1);
            Console.WriteLine(stri2);
        }
    }
}