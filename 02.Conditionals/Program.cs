using System;

namespace _02.Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 11;

            #region Classic If Else

            if (number == 10)
            {
                Console.WriteLine("number is 10");
            }
            else
            {
                Console.WriteLine("number is not 10");
            }
            #endregion

            #region single line if, ternary if
            Console.WriteLine(number == 10 ? "number is 10" : "number is not 10");

            #endregion

            #region Else If

            if (number == 10)
            {
                Console.WriteLine("number is 10");
            }
            else if (number == 20)
            {
                Console.WriteLine("number is 20");
            }
            else
            {
                Console.WriteLine("number is not 10 or 20");
            }

            #endregion

            #region Switch

            switch (number)
            {
                case 10:
                    Console.WriteLine("number is 10");
                    break;

                case 20:
                    Console.WriteLine("number is 20");
                    break;

                default:
                    Console.WriteLine("number is not 10 or 20");
                    break;
            }



            #endregion

            #region Multiple conditions

            if (number >= 0 && number <= 100)
            {
                Console.WriteLine("number is between 0-100");
            }
            else if (number > 100 && number <= 200)
            {
                Console.WriteLine("number is between 101-200");
            }
            else if (number > 200 || number < 0)
            {
                Console.WriteLine("number is less than 0 or greater than 200");
            }

            #endregion

            #region Nested İf
            if (number < 100)
            {
                if (number >= 90)
                {

                }
            }
            #endregion


        }
    }
}
