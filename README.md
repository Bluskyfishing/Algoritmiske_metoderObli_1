# Algoritmiske_metoderObli_1
This program is a console application for creating contact objects from json files. 
Included methods Sort(), Search(), Display().

The purpose for this program is to make it easy to search through data from a json file and to sort it in a desirable way.

HOW TO USE:
First put the filename into the phonebook.add() method to populate the Contact[] array.
After this is done, you can use search() to search through all contacts on all fields with your searchterm. 
Further more you can display the different contacts that match your searchterm buy inputting the number shown on screen.
If you wish to sort the list write the field, on which you wish to sort the data and then in what order you want to sort the data in. The order supports ascending and descending.

Search(): Takes in a String as a searchterm and calls data() to get all data from the contact, and checks if the string is in the data. if it is it adds it to a dynamic list, and goes to next iteration.
After it has found all the matching resualts, it enters a while loop where the user can choose what contact to show (display()). It returns an Contact array.

Sort(): Takes in 2 strings firstly for choosing what field to sort on, secondly in what order the array should be sorted in (asc/desc). It then collects all the data about the contact class,
then it gets the values from the spesified field. After this it implements Icompareable for the the element, and the next elemet to compare them to see if a swap is neccesery. If the swap is neccesery it 
changes places of the current element and the next one. This is called bubble sort.

Developer Details: Isak, https://github.com/Bluskyfishing

License: MIT license 
