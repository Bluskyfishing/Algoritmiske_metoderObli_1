using contactsSystem;
using Newtonsoft.Json;
using System;
using System.Net;

// Populate contacts
Phonebook phonebook = new Phonebook();
phonebook.Add("contactsINFO.json");

// Display func
Contact emma = phonebook.Contacts[0];
Console.WriteLine(Phonebook.Display(emma));

// Search func 
Console.WriteLine(phonebook.Search("Street"));

// Sort func
phonebook.printAll();
phonebook.Sort("FirstName", "asc");
Console.WriteLine();
phonebook.printAll();