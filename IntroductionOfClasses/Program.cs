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
