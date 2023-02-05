using System;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Person user = new();

            user.AcceptUserInput();

            string details = user.PersonDetails();

            Utility.Print(details);
        }
    }

}
