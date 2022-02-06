using System;

namespace Inheritance  // Kalıtım, miras
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[]
            {
                new Customer
                {
                    FirstName ="Abdulkadir",
                    LastName = "Özyurt",
                    Id =61,
                    City="İstanbul"
                },
                new Student
                {
                    FirstName="Emirhan",
                    LastName=  "Cıbır",
                    Id=39,
                    Department="EEE"
                },
                new Person
                {
                    FirstName="Selman",
                    LastName=  "Özyurt",
                    Id=61,

                }

                
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
                Console.WriteLine(person.LastName);
                Console.WriteLine(person.Id);
                
                
            }

            
            
        }
            
    }


    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    class Person2
    {

    }


    // hem Person hem de Person2 yazamayız ----> bir kişinin bir tane babası olur çünkü.
    
    class Customer : Person       // customer'ın ebeveyni Person'dır. Bundan dolayı içerisini doldurma gerek kalmaz.
    {
        
        // ama illa ebeveynin özelliklerini taşımak zorunda değil, kendine has özelliği varsa onları içerisinde tanımlayabiliriz.
        
        
        public string City { get; set; }

    }

    class Student : Person
    {
        public string Department { get; set; }
    }
}















