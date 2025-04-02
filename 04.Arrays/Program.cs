using System;

namespace _04.Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SingleDimensionArrays();

            MultiDimensionArrays();
        }
        static void SingleDimensionArrays()
        {
            string[] students = new string[3];

            students[0] = "John";
            students[1] = "Mary";
            students[2] = "Steve";

            foreach (var item in students)
            {
                Console.WriteLine(item);
            }

            string[] students2 = new string[] { "Engin", "Derin", "Salih" };
            string[] students3 = new[] { "Engin", "Derin", "Salih" };
            string[] students4 = { "Engin", "Derin", "Salih" }; // array initialization type
        }

        static void MultiDimensionArrays()
        {
            // 2D array
            string[,] regions = new string[5, 3]
            {
                {"izmir","muğla","aydın"},
                {"trabzon","rize","samsun"},
                {"antalya","adana","mersin"},
                {"ankara","konya","kırıkkale"},
                {"istanbul","kocaeli","balıkesir"},
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.Write(regions[i, j] + " ");
                }
                Console.WriteLine("\n--------------------------------------");
            }
        }


    }
}
