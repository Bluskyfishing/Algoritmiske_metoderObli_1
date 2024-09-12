using contactsSystem;
using Newtonsoft.Json;
using System;
using System.Net;

// Populate contacts
Phonebook phonebook = new Phonebook();
phonebook.Add("contactsINFO.json");

// Display func
//Contact emma = phonebook.Contacts[0];
//Console.WriteLine(Phonebook.Display(emma));

// Search func
Console.WriteLine("Enter text to search all contacts: ");

String searchTerm = Console.ReadLine();

while (true){
    if (searchTerm != null)
    {
        Console.WriteLine(phonebook.Search(searchTerm));
        break;
    }
}

// Sort func
Console.WriteLine("Before sort:\n");
phonebook.printAll();

while (true)
{
    String[] acceptedFields = ["FirstName", "LastName", "MobileNumber", "Birthday", "Address"];
    String[] acceptedOrder = ["asc", "desc"];
    Console.WriteLine("\nWhat field do you wish to sort on? Available fields: FirstName, LastName, MobileNumber, Birthday, Address\n");
    String field = Console.ReadLine();
    if (acceptedFields.Contains(field)){
        Console.WriteLine("\nWhat order should the list be in?");
       String order = Console.ReadLine().ToLower();
        if (acceptedOrder.Contains(order))
        {
            phonebook.Sort(field, order);
            break;
        }

    }

}

Console.WriteLine("After sort:\n");
phonebook.printAll();