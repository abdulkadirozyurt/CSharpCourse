using System;

namespace Constructors   // constructor ---> bir class'ı newlediğimiz zaman bir kez çalışır ve bir daha çalışmaz.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { Id = 1, FirsName = "engin", LastName = "Demiroğ", City = "Ankara" };

            Customer customer2 = new Customer(2, "Derin", "Demiroğ", "Ankara");

            Console.WriteLine(customer2.FirsName);
        }
    }

    class Customer
    {

        public Customer()
        {

        }

        public Customer(int id, string firstName, string lastName, string city)         // -----> constructor yapısı      customer2 kısmını bu şekilde yazarız.
        {
            FirsName = firstName;
            LastName = lastName;
            City = city;
            Id = id;
        }

        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
