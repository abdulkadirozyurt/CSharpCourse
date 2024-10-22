using System;

namespace _12.ReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ValueTypesDemo();
            // RefenrenceTypesDemo();
            


        }

        private static void RefenrenceTypesDemo()
        {
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine("Sayilar1[0]: " + sayilar1[0]); // 999
        }

        private static void ValueTypesDemo()
        {
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 100;
            Console.WriteLine("Sayi1: " + sayi1); // 20
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }








}
