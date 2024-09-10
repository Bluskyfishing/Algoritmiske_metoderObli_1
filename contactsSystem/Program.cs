using contactsSystem;
using Newtonsoft.Json;
using System;
using System.Net;



// Populate contacts
Contacts[] contacts = new Contacts[100];

using (StreamReader r = new StreamReader("contactsINFO.json"))
{
    string json = r.ReadToEnd();
    List<Contacts> contactsLIST = JsonConvert.DeserializeObject<List<Contacts>>(json);

    int index = 0;

    foreach (var contact in contactsLIST)
    {
        Contacts c = new Contacts(contact.FirstName, contact.LastName, contact.MobileNumber, contact.Birthday, contact.Address);
        contacts[index] = c;
        index++;
    }
}

//foreach (Contact person in contacts)
//{
//    if (person == null) { break; }
//    Console.WriteLine(person.data());
//}

// display func
Console.WriteLine(Contacts.Display(contacts[0]));

foreach(Contacts contact in contacts)
{
    Console.Write(contacts);
}
