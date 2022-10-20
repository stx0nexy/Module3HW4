using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW4.Models
{
    public class Contacts
    {
        public Contacts(string firstName, string lastName, string phNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phNumber;
        }

        public string FirstName { get; init; }

        public string LastName { get; init; }

        public string PhoneNumber { get; init; }

        public override string ToString()
        {
            return $"First name: {FirstName} Last name: {LastName} PhoneNumber: {PhoneNumber}";
        }
    }
}
