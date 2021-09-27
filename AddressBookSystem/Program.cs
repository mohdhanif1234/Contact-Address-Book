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
            Person person = new Person("firstName", "lastName", "address", "city", "state", "zipCode", "phoneNum");
            Console.Write("Enter the number of persons whose address book you want to maintain: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Creating initial address book with some contact address
            Person.AddList(n);

            // Call function to edit contact name
            string str = "Hanif";
            Person.EditContactName(str);

            // Calling a method to print present contact in address book
            Person.PrintList();
        }
    }
}
