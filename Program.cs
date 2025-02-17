using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk5Ex2
{
    internal class Program
    {
        //lists for contacts names and their numbers
        static Dictionary<string, string> contacts = new Dictionary<string, string>();

        //method to add a contact
        static void addContact()
        {
            //asking the user to add a name to the contact list
            Console.WriteLine("Please add a Contact Name: ");
            //user inputs a name to the list
            string name = Console.ReadLine();

            //asking user to add a number to the contact name
            Console.WriteLine("PLease enter a phone number");
            //user adds a number
            string phone = Console.ReadLine();

            //letting user know if they already used that name
            if (contacts.ContainsKey(name))
            {
                Console.WriteLine($"Contact {name} already exists.");
                return;
            }
            else
            {
                contacts.Add(name, phone);
                Console.WriteLine($"Contact {name} added.");

            }
        }
        //method to remove a contact
        static void removeContact()
        {
            //message to let the user know that they can remove a contact
            Console.WriteLine("Enter a contact to Remove");
            //user inputs a contact name to remove from the list
            string name = Console.ReadLine();
            //removing data from the list that had that name
            if (!contacts.ContainsKey(name))
            {
                Console.WriteLine($"Contact {name} does not exists.");
                return;
            }
            else (contacts.Remove(name))
            { 
                Console.WriteLine($"Contact {name}was removed");
            }
        }
        //method to search for a contact
        static void searchContact()
        {
            //message to let the user know that they can search for a name
            Console.WriteLine("Enter contact name to search for");
            //user inputs a name
            string name = Console.ReadLine();
            //searching for the name and number that user inputted
            foreach (KeyValuePair<string, string> pair in contacts)
            {
                if (contacts.Keys.Contains(name))
                {
                    //outputs the name and number that the user inputted
                    Console.WriteLine(name + " " + phone);
                }
            }
        }
        //method to show all of their contacts
        static void displayContacts()
        {
            //shows a message if there are no contacts to show
            if (contacts.Count == 0)
            { 
                Console.WriteLine("There are no contacts to show");
            }
            //if true
            else
            {
                //searches for all of the contacts that the user inputted into the list
                foreach (KeyValuePair<string, string> pair in contacts)
                {
                    //shows the contacts that are in the list
                    Console.WriteLine($"{contacts.Keys}: {contacts.Values}");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Red;
            //menu for Contact Management Application
            //Looping through the menu so user can keep using it

            while (true)
            {
                Console.WriteLine("Welcome to Contact Management Application");
                Console.WriteLine("Please input a number to select an option below.\n" +
                    "1 - Add a contact\n" +
                    "2 - Remove a contact\n" +
                    "3 - Search for a contact\n" +
                    "4 - Display all contacts\n" +
                    "5 - EXIT");

                //user choses witch method they want to chose
                //declaration
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        //process to add a contact
                        addContact();
                        break;
                    case 2:
                        //proces to remove contact
                        removeContact();
                        break;
                    case 3:
                        //process to search contact
                        searchContact();
                        break;
                    case 4:
                        //process to display all contacts
                        displayContacts();
                        break;
                    case 5:
                        Console.WriteLine("Closing the program....");
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again");
                        break;
                }
            }
        }
    }
}
