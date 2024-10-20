using System;

namespace _01.VariablesAndDataTypes
{
    enum Days { Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Integer
            // 32 bit
            // int is value type
            // -2,147,483,648 to 2,147,483,647

            int number1 = 10;
            Console.WriteLine($"Number1 is {number1}");
            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine();
            Console.WriteLine("** Integer bounds **");

            // integer bounds
            int number2 = 1000000000;



            #endregion

            #region Long
            //64 bit
            // int'in iki katı kadar yer kaplar
            long number3 = 129742697423804731;
            Console.WriteLine(number3 + number1);

            #endregion

            #region Short
            // 16 bit
            short number4 = 32767;
            #endregion

            #region Byte
            // 8 bit
            // 0-255
            byte number5 = 255;
            #endregion

            #region Boolean
            // 1 byte
            bool number6 = false;
            #endregion

            #region Char
            char charachter = 'a';
            #endregion

            #region Double
            // 64 bit
            double number7 = 10.4;
            #endregion

            #region Decimal
            // int için long ne ise double için decimal odur.
            // virgülden sonrası için hasssasiyet farkı var

            decimal number8 = 55.7m;


            #endregion

            #region Enum

            Console.WriteLine(Days.Friday); // = 4 index değeri


            #endregion

            #region Var
            // değişkenin türünü otomatik almasını sağlayan keyword'dür
            var number9 = 10;

            #endregion


        }
    }
}
