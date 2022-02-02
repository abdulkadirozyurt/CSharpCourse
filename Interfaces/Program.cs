using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{

    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            // bir interface hiçbir zaman new lenemez çünkü tek başına bir anlamı yoktur.


            //Demo();



            // Bir verimiz var ve bu veriyi şirketin hem oracle hem de sql veritabanına yazmak istiyoruz.
            // ICustomerDal'ı bir array haline getiriyoruz.

            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
                
            }
            








            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
            customerManager.Add(new SqlServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();

            //manager.Add(new Customer { Id = 61, FirstName = "Abdulkadir", LastName = "Özyurt", Address = "Sakarya" });

            Console.WriteLine("-----------");

            //manager.Add(new Student { Id = 39, FirstName = "Emirhan", LastName = "Cıbır", Department = "EEE" });


            manager.Add(new Student
            {

                Id = 61,
                FirstName = "Abdulkadir",
                LastName = "Özyurt",
                Department = "Computer Sciences"

            });

            manager.Add(new Customer
            {
                Id = 21,
                FirstName = "Engin",
                LastName = "Demiroğ",
                Address = "diyarbakır"
            });

            /*
             
            Customer customer = new Customer();           normalde bu şekilde yazardık customer ve student'i 
            customer.FirstName = "Abdulkadir";
            
             */


            /*
             
             ya da


                Customer customer = new Customer
                
                {
                        
                    Id=1,
                    FirstName="Abdulkadir",
                    LastName="Özyurt",
                    Address="Ankara"

                };
                
                manager.Add(Customer);


                Şeklinde de yazabilirdik. Tamamen yazım teknikleri.
                
             
             
             */
        }
    }
}


interface IPerson  // isimlendirme standardı büyük I ile başlatmaktır.
{

    int Id { get; set; } // interface ler yazılırken tamamen metodun imzası yazılır. public yok.
    string FirstName { get; set; }
    string LastName { get; set; }

}

public class Customer : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Address { get; set; }  // müşteriye ait ayrıca bir adress özelliği tanımladık

}


public class Student : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Department { get; set; } // öğrenciye ait ayrıca bir department özelliği tanımladık
}

// Şu anlama gelir, IPerson 'da tanımlanmış her şeyi interface'e bağladığımız class larda  görebiliriz.




class PersonManager
{
    public void Add(IPerson person)
    {
        Console.WriteLine(person.FirstName);

        Console.WriteLine(person.LastName);
        Console.WriteLine(person.Id);


    }

    //public void Add(IPerson person)
    //{
    //    Console.WriteLine(person.FirstName);
    //    Console.WriteLine(person.LastName);
    //    Console.WriteLine(person.Id);
    //    //Console.WriteLine(person.Department);

    //}



}


