using System;
using System.Collections.Generic;

namespace Day.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array
            int[] numbers = { 1, 2, 3 };
            Console.WriteLine("Array:");
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }

            //List
            List<int> li = new List<int> { 10, 20, 30 };
            li.Add(40);
            Console.WriteLine("List:");
            for (int i=0;i< li.Count;i++)
            {
                Console.WriteLine(li[i]);
            }

            //Dictionary
            Dictionary<int, string> di = new Dictionary<int, string>();
            di.Add(1,"One");
            di.Add(2,"Two");

            Console.WriteLine("Dictionary");
            foreach(var i in di)
            {
                Console.WriteLine($"{i.Key}- {i.Value}");
            }

            //IEnumerable
            IEnumerable <int> enumerable =li;
            Console.WriteLine("IEnumerable:");
            foreach (var v in enumerable)
            {
                Console.WriteLine(v);
            }

        }

    }
}