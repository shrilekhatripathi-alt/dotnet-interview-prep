using System;
namespace Day6.CosoleApp
{
    class AgeException : Exception
    {
        public AgeException(string message) : base(message)
        {
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int age = -5;
                validateAge(age);
            }
            catch (AgeException ex)
            {
                Console.WriteLine($"Custom exception:{ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General exception : {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finally block executed");
            }
        }

        static void validateAge(int age)
        {
            if (age < 0)
            {
                throw new AgeException("age can not be negative");
            }

        }
    }
}