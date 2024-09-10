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
            contacts = new Contact[];
        }

        public static string Display(Contact c)
        {
            return ($"_______Display________\n" +
                $"Name: {c.FirstName} {c.LastName}\n" +
                $"Tlf: {c.MobileNumber}\n" +
                $"Birthday: {c._birthday}\n" +
                $"Addres: {c.Address}\n" +
                $"--------------------------------------");
        }

        public Contact[] Search(String s)
        {
            return null;
        }
        public Contact[] Sort(String s)
        {
            return null;
        }
    }
}
