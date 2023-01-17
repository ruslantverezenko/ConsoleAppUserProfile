using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUserProfile
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Mandarin();
                Console.Write("Enter the data again(y = yes | n = no): ");
                string userSelection = Console.ReadLine();
                if (userSelection == "y" ||  userSelection == "yes")
                {
                    continue;
                    Console.Clear();
                }
                if (userSelection == "n" || userSelection == "no")
                {
                    break;
                }
            }
        }
        static void Mandarin()
        {
            Console.Write("Enter your last name: ");
            string lastNameUser = Console.ReadLine();

            Console.Write("Enter a name: ");
            string nameUser = Console.ReadLine();

            Console.Write("Enter the age: ");
            int ageUser = int.Parse(Console.ReadLine());

            Console.Write("Enter the weight (in kilograms): ");
            double weightUser = double.Parse(Console.ReadLine());

            Console.Write("Enter height in meters(for example 1,78): ");
            double heightUser = double.Parse(Console.ReadLine());

            double bodyMassIndexUser = weightUser / (heightUser * heightUser);
            string userProfile = "Profile\n"
                + $"Full name: {lastNameUser} {nameUser}\n"
                + $"Age: {ageUser}\n"
                + $"Weight: {weightUser}\n"
                + $"Height: {heightUser}\n"
                + $"Body Mass Index: {bodyMassIndexUser}";

            Console.WriteLine(userProfile);
        }
    }
}
