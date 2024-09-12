using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contactsSystem
{
    public class Phonebook
    {
        private Contact[] contacts;

        public Phonebook()
        {
            contacts = new Contact[100];
        }

        public Contact[] Contacts
        {
            get { return contacts; }
        }

        public void Add(String fileName)
        {
            using (StreamReader r = new StreamReader(fileName))
            {
                string json = r.ReadToEnd();
                List<Contact> contactsLIST = JsonConvert.DeserializeObject<List<Contact>>(json);

                int index = 0;

                foreach (var contact in contactsLIST)
                {
                    Contact c = new Contact(contact.FirstName, contact.LastName, contact.MobileNumber, contact.Birthday, contact.Address);
                    contacts[index] = c;
                    index++;
                }
            }
        }

        public void printAll() // debug method 
        {
            Console.WriteLine("Contacts count: " + contacts.Length);

            foreach(Contact contact in contacts)
            {
                Console.WriteLine(contact.FirstName + " " + contact.LastName);
            }
        }

        public static string Display(Contact c)
        {
            return ($"_______Display________\n" +
                $"Name: {c.FirstName} {c.LastName}\n" +
                $"Tlf: {c.MobileNumber}\n" +
                $"Birthday: {c.Birthday}\n" +
                $"Addres: {c.Address}\n" +
                $"--------------------------------------");
        }

        public Contact[] Search(String searchTerm)
        {
            List<Contact> contactsLIST = new();

            foreach (Contact contact in contacts)
            {
                if (contact.data().Contains(searchTerm))
                {
                    contactsLIST.Add(contact);
                }
            }

            int index = 0;

            foreach (Contact contact in contactsLIST)
            {
                Console.WriteLine($"{index}. " + contact.FirstName + " " + contact.LastName);
                index++;
            }

            while (true)
            {
                Console.WriteLine("Enter 'q' to quit\nSelect an contact to display!:\n");
                string strInput = Console.ReadLine();

                if (strInput == "q")
                {
                    break;
                }
                else
                {
                    int input;
                    int.TryParse(strInput, out input);

                    if (input + 1 <= contactsLIST.Count)
                    {
                        Contact chosenContact = contactsLIST[input];
                        Console.WriteLine(Phonebook.Display(chosenContact));
                    }
                    else
                    {
                        Console.WriteLine("Number too big or not a number! Try again!");
                    }
                }

            }

           Contact[] contactArray = contactsLIST.ToArray();

           return contactArray;
        }

    }
}
