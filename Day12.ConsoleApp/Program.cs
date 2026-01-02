using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace Day12.ConsoleApp
{
    class Order
    {
        public int Id { get; set; }
        public List<string> Items { get; set; }
    }

    class Program
    {
        static void Main(String[] args)
        {
            List<int> num = new List<int> { 5, 10, 15 };

            //First and FirstDefault
            Console.WriteLine(num.First());
            Console.WriteLine(num.FirstOrDefault());

            //Single and SingleDefault
            List<int> singleList = new List<int> { 100 };
            Console.WriteLine(singleList.Single());

            //Any vs All
            Console.WriteLine(num.Any(x => x > 10)); ;
            Console.WriteLine(num.All(x => x > 0));

            //SelectMany
            List<Order> orders = new List<Order>
            {
                new Order{Id=1,Items=new List<string>{ "Pen","Book" } },
                new Order {Id=2,Items=new List<string>{ "Pencil"} }
            };

            var allItem = orders.SelectMany(o=>o.Items);
            Console.WriteLine("All Items:");
            foreach(var item in allItem)
            {
                Console.WriteLine(item);
            }

        }
    }
}



