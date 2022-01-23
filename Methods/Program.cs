using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
   class Program
    {
        static void Main(string[] args)
        {

            Add();
            Add();
            Add();


            //int result= Add2(3,5);
            //Console.WriteLine(result);


            int number1 = 20;
            int number2 = 100;
            var result2= Add3(ref number1,number2);

            Console.WriteLine(result2);
            Console.WriteLine( number1);


            Console.ReadLine();
        }




        static void Add()
        {
            Console.WriteLine("Added!!!");
        }

        static int Add2(int number1=10,int number2=55) // default değer number 2 için 30. mesaj vermek yerine gerçekten toplama yapıyoruz şimdi. Parametre vermeliyiz.
        {
            int sonuc=number1 + number2;
            
            return sonuc;

        }


        static int Add3(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }














    }
}
