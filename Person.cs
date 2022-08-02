using System;

namespace Testing
{
    public class Person
    {
        private string firstname;
        private string lastname;
        private int age;
        private char gender;

        public void SetFirstname(string firstname)
        {
            this.firstname = firstname;
        }

        public string GetFirstName()
        { 
            return firstname; 
        }

        public void SetLastname(string lastname)
        {
            this.lastname = lastname;
        }

        public string GetLastname()
        {
            return lastname;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetGender(char gender)
        {
            this.gender = gender;
        }

        public char GetGender()
        {
            return gender;
        }

        public string PrintPersonDetails()
        {
            var result = $"\n========My Bio-Data =========\nSurname: {lastname}\nFirstname: {firstname}\nAge: {age}\nGender: {gender}\n==================";

            return result;
        }

        public void AcceptUserInput()
        {
            try
            {
                Console.Write("Enter your firstname: ");
                string firstname = Console.ReadLine();

                Console.Write("Enter your lastname: ");
                string lastname = Console.ReadLine();

                Console.Write("Enter your age: ");
                int age = int.Parse(Console.ReadLine());

                Console.Write("Enter your gender (M/F): ");
                char gender = char.Parse(Console.ReadLine());

                SetFirstname(firstname);
                SetLastname(lastname);
                SetAge(age);
                SetGender(gender);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured: {0}", ex.Message);
            }
        }

    }
}
