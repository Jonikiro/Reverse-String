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
            Console.Write("Enter a string to be reversed: ");
            string oldString = Console.ReadLine();
            char[] newString = oldString.ToCharArray();
            Array.Reverse(newString);
            oldString = String.Join("", newString);
            Console.WriteLine("\nAnd now, the reversed string...\n");
            Console.WriteLine(oldString);
            Console.ReadKey();
        }
    }
}
