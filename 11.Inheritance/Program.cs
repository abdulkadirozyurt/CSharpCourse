using System;

namespace _11.Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[]
            {
                new Customer{FirstName = "Abdulkadir"},
                new Student{Department = "Computer Science"}

            };

            foreach (var item in people)
            {
                Console.WriteLine(item.FirstName);
            }

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
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Department { get; set; }
    }
}
