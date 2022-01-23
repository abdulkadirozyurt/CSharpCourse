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


            int result= Add2(3,5);
            Console.WriteLine(result);
            
            Console.ReadLine();
        }




        static void Add()
        {
            Console.WriteLine("Added!!!");
        }

        static int Add2(int number1,int number2) // mesaj vermek yerine gerçekten toplama yapıyoruz şimdi. Parametre vermeliyiz.
        {
            int sonuc=number1 + number2;
            
            return sonuc;

        }












    }
}
