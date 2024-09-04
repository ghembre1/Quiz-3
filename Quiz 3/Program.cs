using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // prompts user to input a string
            Console.WriteLine("Enter a string");
            
            // Makes user input a variable
            string stringA = Console.ReadLine();

           

            bool is Palindrome = true;
            for (int i = 0; i<stringA.Lenght; i++)
            {
                if (stringA[i] == stringA[stringA.lenght - 1])
                {
                    ispalindrome = false;
                    break;
                }
            }

            Console.WriteLine

        }
    }
}
