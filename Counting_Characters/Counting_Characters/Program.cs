using System;
using System.Collections.Generic;

namespace Counting_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter string to count: ");
            string input = Console.ReadLine();

          //  string loremIpsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

            Dictionary<char, int> countedCharacters = Counter.charCounter(input);
            foreach (KeyValuePair<char, int> c in countedCharacters)
            {
                Console.WriteLine($"{c.Key} : {c.Value}");
            }

        }
    }
}
