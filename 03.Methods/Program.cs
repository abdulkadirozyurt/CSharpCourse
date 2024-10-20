using System;

namespace _03.Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var result = Addition(10, 20);
            //Console.WriteLine(result);

            //int number1 = 20;
            //int number2 = 100;
            //var result2 = Addition3(ref number1, number2);
            //Console.WriteLine(result2);
            //Console.WriteLine(number1);

            Console.WriteLine("\n");

            //int number3;
            //int number4 = 100;
            //var result3 = Addition4(out number3, number4);

            Console.WriteLine("\n");


            Console.WriteLine(Multiply(2, 4));



        }

        static int Addition(int number1, int number2)
        {
            return number1 + number2;
        }

        static int Addition2(int number1, int number2 = 50)
        {
            // default parameter
            return number1 + number2;
        }


        #region Ref Keyword
        // değer tipin, referans tip olarak davranmasını sağlar
        static int Addition3(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
        #endregion

        #region Out Keyword
        // değer tipin, referans tip olarak davranmasını sağlar,
        // ref'ten farkı: out keyword'ü ile gönderilen parametrenin metot içerisinde değer atanması zorunlu değildir.

        static int Addition4(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
        #endregion

        #region Method Overloading

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }


        #endregion

        #region Params Keyword
        // params keyword'ü ile metoda istenilen sayıda parametre gönderilebilir.
        static int Addition4(params int[] numbers)
        {
            int result = 0;
            foreach (var item in numbers)
            {
                result += item;
            }
            return result;
        }
        #endregion

    }
}
