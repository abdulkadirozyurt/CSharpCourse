using System;

namespace _09.Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                firstName = "John",
                LastName = "Doe",
                Address = "New York"
            };

            Student student = new Student
            {
                Id = 2,
                firstName = "Jane",
                LastName = "Doe",
                Department = "Computer Science"
            };
            personManager.Add(student);
        }
    }
}
