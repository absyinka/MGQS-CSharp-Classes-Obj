using System;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Person user = new Person();
            Address address = new Address("a@gmail.com", "09938388", "22, Oladele", "24, Jacob Zuma");
            Console.WriteLine(address.Email);
            user.AcceptUserInput();
            string details = user.PrintPersonDetails();
            Utility.Printer(details);
        }
    }

}
