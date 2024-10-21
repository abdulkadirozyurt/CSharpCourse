using System;

namespace _05.Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ForLoop();
            // WhileLoop();
            // DoWhileLoop();
            // ForeachLoop();

            // prime number check
            PrimeNumberCheck(2137);

        }

        private static void PrimeNumberCheck(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine("number is not a prime number");
                    break;
                }
                Console.WriteLine("number is a prime number");
                break;
            }
        }

        private static void ForeachLoop()
        {
            string[] students = new string[3] { "John", "Doe", "Jane" };
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            }
            while (number >= 0);

        }

        private static void WhileLoop()
        {
            long number = 100;

            while (number >= 0)
            {

                Console.WriteLine(number);
                number--;
            }
        }

        static void ForLoop()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
