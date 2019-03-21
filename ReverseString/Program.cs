
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            while (true)
            {
                Console.Write("Enter a string to be reversed: ");
                string oldString = Console.ReadLine();
                char[] newString = oldString.ToCharArray();
                Array.Reverse(newString);
                oldString = String.Join("", newString);
                Console.WriteLine("\nAnd now, the reversed string...\n");
                Console.WriteLine(oldString);
                Console.Write("\nWould you like to try again? Enter 'yes' or 'no': ");
                choice = Console.ReadLine();
                choice.ToLower();
                while (choice != "yes" && choice != "no")
                {
                    Console.Write("\nInvalid input. Would you like to try again? Enter 'yes or 'no': ");
                    choice = Console.ReadLine();
                }

                Console.Write("\n");
                if (choice == "yes") continue;
                else if (choice == "no") break;
            }
            Console.Write("Thank you for using this program.");
            Console.ReadKey();
        }
    }
}