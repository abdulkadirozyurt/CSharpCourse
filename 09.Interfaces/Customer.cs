using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Interfaces
{
    internal class Customer : IPerson
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
}
