using System;

namespace ReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int,decimal,float,enum,boolean ==== value types (değer tiplerdir.)

            int sayi1 = 10; // sayi1 in değeri eşittir 10
            int sayi2 = 20; // sayi2 in değeri eşittir 20

            sayi1 = sayi2;  // sayi1 in değeri eşittir sayi2 nin değeri (sayi2 ile bir bağlantımız yok sadece atama yaptık.)
            sayi2 = 100;
            Console.WriteLine("sayi 1 : " + sayi1);

            Console.WriteLine("----------------------------------");



            // arrays,classes,interfaces ... --> reference type

            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2;  // sayilar1 in adresi === sayilar2 nin adresi demek.   Sayilar1'in ilk adresi kayboldu gitti. 101 ----> 102 oldu
            sayilar2[0] = 1000;   // sayilar2 nin adresinin (102) sıfırıncı elemanı = 1000.

            Console.WriteLine("sayilar1 in [0]= " + sayilar1[0]);

            Console.WriteLine("------------------------------------");



            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";

            person2 = person1;
            person1.FirstName = "Derin";

            Console.WriteLine(person2.FirstName);

            Console.WriteLine("----------------------------------");


            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "6546546546546";


            Employee employee = new Employee();
            employee.FirstName = "Veli";
            // customer = employee;   //biri customer biri employee türünde. atanamaz.


            Person person3 = customer;  // miras aldığımız sınıf türüne mirası alan türünde bir şeyi atayabiliriz.
            customer.FirstName = "Ahmet";
            customer.CreditCardNumber = "654646";

            Console.WriteLine(customer.FirstName);
            Console.WriteLine(((Customer)person3).CreditCardNumber);
                              // boxing


          
            PersonManager personManager = new PersonManager();
            personManager.Add(employee);






        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }


    // base class : Person   (ebeveyn)    base clası inherit eden class lara onun referansını (adresini) atayabiliriz.

    class Customer : Person  // inheritance yaptık.
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee : Person
    {
        public int Employeenumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}




