using System;

namespace Day3.ConsoleApp
{
    class Program
    {
        static void Main()
        {
            ////Encapsulation Example
            //Encapsulation en = new Encapsulation();
            //en.deposit(10000);
            //en.withdraw(500);
            //Console.WriteLine($"Current Balance: {en.GetBalance()}");

            //Inheritance Example
            Manager mg = new Manager();
            mg.Name = "Shrilekha";
            mg.Work();
            mg.ManageTeam();
        }
    }
}