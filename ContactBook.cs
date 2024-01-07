using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook
{
    public class ContactBook
    {
        public List<Contact> ContactList { get; set; }
        public ContactBook()
        {
            ContactList = new List<Contact>();
        }
        private void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"Contact: {contact.Name}, {contact.Number}");
        }

        private void DisplayContactsDetails(List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                DisplayContactDetails(contact);
            }
        }
        
        public void AddContact(Contact contact)
        {
            ContactList.Add(contact);
        }
        public void DisplayContactByNumber(string number)
        {           
            var contact = ContactList.FirstOrDefault(c => c.Number == number);
            if (contact != null)
            {
                DisplayContactDetails(contact);
            }
            else
            {
                Console.WriteLine("Contact not found");
            }
        }
        public void DisplayAllContact()
        {
            DisplayContactsDetails(ContactList);
        }

        public void DisplayMatchingContacts(string searchPhrase)
        {
            var matchingContacts = ContactList.Where(c => c.Name.Contains(searchPhrase)).ToList();
            DisplayContactsDetails(matchingContacts);
        }
        
    }
}
