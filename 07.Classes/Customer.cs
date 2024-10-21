using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _07.Classes
{
    public class Customer
    {
        private string _firstName;
        private string _lastName;
        private string _city;

        // auto property, fields are not required
        public int Id { get; set; }
        public string FirstName { get => "Mr. " + _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string City { get; set; }

    }
}
