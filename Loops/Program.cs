using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();


            //WhileLoop();


            //DoWhileLoop();


            if (IsPrimeNumber(7))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("not prime number");
            }



            bool IsPrimeNumber(int number)
            {

                bool result = true;

                for (int i = 2; i <number-1; i++)
                {
                    if (number%i==0)
                    {
                        result= false;
                        i = number;
                    }
                }
                return result;


            }














            Console.ReadLine();
        }

        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;

            } while (number >= 11);
        }

        private static void WhileLoop()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("now number is " + number);
        }

        private static void ForLoop()
        {
            for (int i = 1; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Finished");
        }
    }
}
