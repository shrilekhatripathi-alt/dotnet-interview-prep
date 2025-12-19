using System;

namespace Day1.ConsoleApp
{
    class Person
    {
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Value Type Example
            int a = 10;
            int b = a;
            b = 20;
            Console.WriteLine("Value Type");
            Console.WriteLine(a);//10
            Console.WriteLine(b);//20

            //Reference Type Example
            Person p1 = new Person();
            p1.Age = 30;

            Person p2 = p1;
            p2.Age = 40;
            Console.WriteLine("Reference Type");
            Console.WriteLine(p1.Age);//40
            Console.WriteLine(p2.Age);

            //Boxing and UnBoxing
            int x = 50;
            Object obj = x;//Boxing
            int y = (int)obj;//UnBoxing

            Console.WriteLine("Boxing and UnBoxing");
            Console.WriteLine(y);
        }
    }
}
