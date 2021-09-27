using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class Person
    {
        // UC-3: Editing a contact in the present address book

        // Declaring member data
        string firstName, lastName, address, city, state, zipCode, phoneNum;

        // Parameterized constructor to define member data
        public Person(string firstName, string lastName, string address, string city, string state, string zipCode, string phoneNum)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
            this.phoneNum = phoneNum;
        }

        // Creating a list to store the object of the type Person
        public static List<Person> personList = new List<Person>();

        // Adding contacts in empty address book of type List
        public static void AddList(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("");
                Console.Write("Enter the first name: ");
                string firstName = Console.ReadLine();
                Console.Write("Enter the last name: ");
                string lastName = Console.ReadLine();
                Console.Write("Enter the address: ");
                string address = Console.ReadLine();
                Console.Write("Enter the city name: ");
                string city = Console.ReadLine();
                Console.Write("Enter the name of the state: ");
                string state = Console.ReadLine();
                Console.Write("Enter the zipcode: ");
                string zipCode = Console.ReadLine();
                Console.Write("Enter the phone number: ");
                string phoneNum = Console.ReadLine();
                Person addressList = new Person(firstName, lastName, address, city, state, zipCode, phoneNum);
                personList.Add(addressList);
            }
        }

        // Editing the first name of the person
        public static void EditContactName(string changeName)
        {
            int ind = -1;
            for (int i = 0; i < personList.Count; i++)
            {
                if (personList[i].firstName == changeName)
                {
                    ind = i;
                }
            }
            Person newUp = personList[ind];
            newUp.firstName = "Muhammad Hanif";
            personList[ind] = newUp;
        }

        // Printing the present contacts in address book
        public static void PrintList()
        {
            for (int i = 0; i < personList.Count; i++)
            {
                Console.WriteLine("");
                Console.Write("First Name: " + personList[i].firstName + "\n");
                Console.Write("Last Name: " + personList[i].lastName + "\n");
                Console.Write("Address: " + personList[i].address + "\n");
                Console.Write("City: " + personList[i].city + "\n");
                Console.Write("State: " + personList[i].state + "\n");
                Console.Write("Zip code: " + personList[i].zipCode + "\n");
                Console.Write("Phone Number: " + personList[i].phoneNum);
                Console.ReadLine();
            }
        }
        
    }
}

