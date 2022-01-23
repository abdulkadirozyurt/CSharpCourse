using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Intro();



            string sentence = "My name is Abdulkadir";
            var result = sentence.Length;// cümlenin karakter sayısını verir.

            var result2 = sentence.Clone();
            sentence = "My name is Emirhan Cıbır";


            bool result3 = sentence.EndsWith("ğ"); // bu cümle ğ ile bitiyor mu bunu kontrol eder.
            bool result4 = sentence.StartsWith("My name");





            var result5 = sentence.IndexOf("name"); // name, kaçıncı karakterden başladığını onu bulur.
            Console.WriteLine(result5);


            Console.WriteLine(result);

            Console.WriteLine(result3+" "+result4);






            Console.WriteLine(result2);























            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";  // stringler aslında bir char array ' idir.

            Console.WriteLine(city[5]);

            foreach (var sehir in city)
            {
                Console.WriteLine(sehir);
            }
        }
    }
}
