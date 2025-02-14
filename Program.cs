using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk5Ex2
{
    //lists for contacts names and their numbers
    static Dictionary<string, int> contact = new Dictionary<string, int>(); 
    internal class Program
    {
        static void addContact()
        {
            Console.WriteLine("Please add a Contact Name");
            string name = Console.ReadLine();

            Console.WriteLine("PLease enter a phone number");
            int phone = Convert.ToInt32(Console.ReadLine());

            

            contacts[name] = phone; 
        }
        static void removeContact() 
        {
        
        }
        static void searchContact()
        {

        }
        static void displayContacts()
        { 
        
        }
        static void Main(string[] args)
        {
            //menu for Contact Management Application
            //Looping through the menu so user can keep using it

            while (true)
            {
                Console.WriteLine("Welcome to Contact Management Application");
                Console.WriteLine("1 - Add a contact");
                Console.WriteLine("2 - Remove a contact");
                Console.WriteLine("3 - Search for a contact");
                Console.WriteLine("4 - Display all contacts");
                Console.WriteLine("5 - EXIT");

                //user choses witch method they want to chose
                //declaration
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        addContact();
                        break;
                    case "2":
                        removeContact();
                        break;
                    case "3":
                        searchContact();
                        break;
                    case "4":
                        displayContacts();
                        break;
                    case "5":
                        Console.WriteLine("Closing the program....");
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again");
                        break;
                }
        }
    }
}
