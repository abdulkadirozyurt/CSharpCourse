using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {

            // Value Types 

            int number1 =10;
            Console.WriteLine("number1 is {0}",number1); // virgülden sonraki ilk değeri yazacak.


            long number2 = 5464684684684684;
            Console.WriteLine(number2);


            short number3 = -32767;

            Console.WriteLine( number3);



            byte number4 = 255;
            Console.WriteLine(number4);

            
            
            bool condition = false;


            char character= 'a'; // atama için tek tırnak.

            double number5 = 10.4;
            Console.WriteLine(number5);

            decimal number6 = 112121255.54555m;
            Console.WriteLine(number6);



            var number7 = 10;
            number7 = 'A';
            Console.WriteLine(number7);

            








            //Console.WriteLine("Hello World");

            Console.ReadLine();


        }
    }
}
