using System;
using System.Linq;
using Module3HW4.Models;

namespace Module3HW4
{
    public class Program
    {
        public static void Main()
        {
            var myDelegate = new Delegate();
            myDelegate.Subscribe();
            myDelegate.CountSum();
            Console.WriteLine(myDelegate.FinallSum);
            var contacts = new ContactList();
            contacts.ListInit();
            Console.WriteLine("all contacts:");
            foreach (var item in contacts.AllContacts)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("FirstOrDefault:");
            var firstContact = contacts.AllContacts.FirstOrDefault(contact => contact.FirstName == "aa");
            Console.WriteLine(firstContact);
            Console.WriteLine();
            Console.WriteLine("Where & Select:");
            var returnedList = contacts.AllContacts.Where(cont => cont.FirstName.StartsWith('a')).Select(c => $"{c.FirstName} {c.PhoneNumber}").ToList();
            foreach (var item in returnedList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("ElementAt:");
            Console.WriteLine(contacts.AllContacts.ElementAt(3));
            Console.WriteLine();
            Console.WriteLine("OrderBy:");
            var orderedContactListByName = contacts.AllContacts.OrderBy(c => c.FirstName).ToList();
            foreach (var item in orderedContactListByName)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Any:");
            Console.WriteLine(contacts.AllContacts.Any(c => c.FirstName == "ee"));
        }
    }
}
