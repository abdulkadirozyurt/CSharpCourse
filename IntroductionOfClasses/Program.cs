using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionOfClasses
{
    class Program
    {
        static void Main(string[] args)
        {


            // bir class'ı kullanmak için onun bir örneğini oluşturmak gerekir. (instance)

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            Console.WriteLine("-----------");

            Customer customer = new Customer();
            customer.Id = 564124525;
            customer.FirstName = "Abdulkadir";
            customer.LastName = "Özyurt";

            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer.LastName);
            Console.WriteLine(customer.Id);

            Console.WriteLine("----------");
           
            
            
            // farklı bir yazım şekliyle aşağıda yazalım.



            Customer customer2 = new Customer // burada parantez açmak yerine küme paranteziyle devam ettik.

            {
                Id = 2,
                City = "İstanbul",
                FirstName = "Abdulkadir",
                LastName = "Özyurt"

            };

            Console.WriteLine(customer2.Id+" "+customer2.City+" "+customer2.FirstName+" "+customer2.LastName);
            










            Console.ReadLine();
        }

        class CustomerManager
        {
           


            
            public void Add()
            {

                Console.WriteLine("Customer Added");

            }


            public void Update()
            {
                Console.WriteLine("Customer Updated");
            }








        }







    }
}
