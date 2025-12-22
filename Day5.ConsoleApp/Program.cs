using System;
using System.IO;
using System.Net.NetworkInformation;

namespace Day5.ConsoleApp
{
    class Resource : IDisposable
    {
        public void Use()
        {
            Console.WriteLine("using resource");
        }
        public void Dispose()
        {
            Console.WriteLine("resource disposed");
        }
        ~Resource()
        {
            Console.WriteLine("finalize called");
        }
    }
    class Person
    {
        public int Age;
    }
    class Program
    {
        public static void Main(string[] args)
        {
            //GC example
            Resource r = new Resource();
            r.Use();
            r = null;
            GC.Collect();

            // Using example
            using (Resource res = new Resource())
            {
                res.Use();
            }

            //Shallow copy example
            Person p1 = new Person { Age = 30 };
            Person p2 = p1;
            p2.Age = 40;
            Console.WriteLine($"shallow copy {p1.Age}");

        }


    }
}