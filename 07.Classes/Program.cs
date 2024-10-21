using System;

namespace _07.Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();

            ProductManager productManager = new ProductManager();
            productManager.Add();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.City = "Ankara";
            customer.FirstName = "Engin";
            customer.LastName = "Demiroğ";

            Customer customer2 = new Customer
            {
                Id = 2,
                City = "İstanbul",
                FirstName = "Derin",
                LastName = "Demiroğ"
            };

            Console.WriteLine(customer2.FirstName);

        }
    }
}
