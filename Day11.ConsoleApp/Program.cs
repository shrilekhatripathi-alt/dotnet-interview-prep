using System;
using System.Collections.Generic;
using System.Linq;

namespace Day11.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int> { 1, 5, 10, 15, 20 };

            //where
            var filter = num.Where(x => x > 10);

            //Deferred execution
            Console.WriteLine("Deferred Execution");
             foreach(var v in filter)
            {
                Console.WriteLine(v);
            }

            //Select
            var doubled = num.Select(x=>x*2);
            Console.WriteLine("Select");
            foreach(var v in doubled)
            {
                Console.WriteLine(v);
            }

            //Order by
            var ord = num.OrderByDescending(x => x);
            Console.WriteLine("Order By");
            foreach(var n in ord)
            {
                Console.WriteLine(n);
            }

            //Immediate Execution
            var imm = num.Where(x => x > 5).ToList();
            Console.WriteLine("Immediate Execution count:" +imm.Count);


        }
    }
}