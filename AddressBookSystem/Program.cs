using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to address book system");
            Console.WriteLine("");
            Person person = new Person("firstName", "lastName", "address", "city", "state", "zipCode", "phoneNum");

            // Adding multiple persons to address book one by one with some contact address
            Console.Write("Enter the number of multiple persons to be added one by one: ");
            int multiplePerson = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < multiplePerson; i++)
            {
                Person.AddList();
            }

            // Calling a method to print present contact in address book
            Person.PrintList();
        }
    }
}
