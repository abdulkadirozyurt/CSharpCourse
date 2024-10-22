using System;

namespace _13.Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                City = "New York"
            };

            Customer customer2 = new Customer(2, "Jane", "Doe", "Los Angeles");

        }
    }

    class Customer
    {
        public Customer()
        {

        }

        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
