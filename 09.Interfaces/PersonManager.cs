using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Interfaces
{
    public class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.firstName+" Added");
        }
    }
}
