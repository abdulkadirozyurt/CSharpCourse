using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // aynı değişkenleri tek bir yerde yönetebilmek için  kullanılır.



            string[] students = new string[] { "Engin", "Derin", "Salih", "Abdulkadir", "İzzet" };
            //students[0] = "Engin";
            //students[1] = "Derin";
            //students[2] = "Salih";
            //students[3] = "Abdulkadir";

                             
                    

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("------------");

            
            string[] students2 = new[] { "Engin", "Derin", "Salih", "Abdulkadir","İzzet" };

            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }

            Console.ReadLine();
        }
    }
}
