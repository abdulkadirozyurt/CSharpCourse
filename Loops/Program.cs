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


            int number = 100;
            while (number>=0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("now number is "+number);






            Console.ReadLine();
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
