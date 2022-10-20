using System.Collections.Generic;
using Module3HW4.Models;

namespace Module3HW4
{
    public class ContactList
    {
        public ContactList()
        {
            AllContacts = new List<Contacts>();
        }

        public List<Contacts> AllContacts { get; set; }

        public void ListInit()
        {
            AllContacts.Add(new Contacts("mr", "er", "1030405846"));
            AllContacts.Add(new Contacts("ap", "st", "8295639014"));
            AllContacts.Add(new Contacts("re", "op", "3285397502"));
            AllContacts.Add(new Contacts("aa", "pe", "9736103658"));
            AllContacts.Add(new Contacts("ee", "st", "8320567839"));
        }
    }
}
