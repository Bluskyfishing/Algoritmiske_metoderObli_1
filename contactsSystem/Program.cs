using contactsSystem;
using Newtonsoft.Json;
using System;
using System.Net;

// Populate contacts
Phonebook phonebook = new Phonebook();
phonebook.Add("contactsINFO.json");

// display func
Contact emma = phonebook.Contacts[0];
Console.WriteLine(Phonebook.Display(emma));

// search func 
Console.WriteLine(phonebook.Search("Street"));
