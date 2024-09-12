using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace contactsSystem
{
    public class Contact
    {
       private String _firstName;
       private String _lastName;
       private int _mobileNumber;
       private int _birthday;
       private String _address;

        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
            }
        }
        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
            }
        }

        public int MobileNumber
        {
            get => _mobileNumber;
            set
            {
                _mobileNumber = value;
            }
        }

        public int Birthday
        {
            get => _birthday;
            set
            {
                _birthday = value;
            }
        }

        public string Address
        {
            get => _address;
            set
            {
                _address = value;
            }
        }

        public Contact(String firstName, String lastName, int mobileNumber, int birthday, String address)
        {
            FirstName = firstName;
            LastName = lastName;
            MobileNumber = mobileNumber;
            Birthday = birthday;
            Address = address;
        }

        public string data()
        {
            return FirstName  + LastName + MobileNumber +  Birthday + Address;
        }


    }
}
