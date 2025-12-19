using System;
using System.Data;


namespace Day2.ConsoleApp 
{
    class Program
    {
        static readonly int ReadOnlyValue = 10;
        const int ConstValue = 20;

        static void Main(string[] args)
        {
            //ref example
            int a = 5;
            Update(ref a);
            Console.WriteLine($"ref value : {a}");

            //Out example
            int result;
            GetValue(out result);
            Console.WriteLine($"out value : {result}");

            //In example
            int num = 100;
            Print(in num);

            //var vs dynamic
            var x = 10;
            dynamic y = "Hello";
            Console.WriteLine(x);
            Console.WriteLine(y);

            static void Update(ref int x)
            {
                x = 50;
            }
            static void GetValue(out int x)
            {
                x = 30;
            }
            static void Print(in int x)
            {
                Console.WriteLine($"In value : {x}");
            }



        }
    }
}