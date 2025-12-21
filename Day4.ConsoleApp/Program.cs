using System;

namespace Day3.ConsoleApp
{
    interface IAnimal
    {
        void Speak();
    }
    abstract class Animal
    {
        public abstract void Eat();
        public virtual void Sound()
        {
            Console.WriteLine("Animal Sound");
        }
    }
    class Dog : Animal, IAnimal
    {
        public override void Eat()
        {
            Console.WriteLine("Dog Eats");
        }
        public override void Sound()
        {
            Console.WriteLine("Dog Barks");
        }

        public void Speak()
        {
            Console.WriteLine("Dog Speaks");
        }
    }
    sealed class FinalClass
    {
        public void Show()
        {
            Console.WriteLine("Sealed class method");
        }
    }
    class Parent
    {
        public void Display()
        {
            Console.WriteLine("Parent Display");
        }
    }
    class Child : Parent 
    {
        public new void Display()
        {
            Console.WriteLine("Child Display");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Animal a = new Dog();
            a.Sound();
            a.Eat();

            Child c = new Child();
            c.Display();
        }
    }
}