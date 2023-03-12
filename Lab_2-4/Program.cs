using System;
using System.Collections.Generic;

namespace Lab_2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string> { "cat", "cucumber", "apple", "flower" };

            // Create a delegate that accepts a string and returns its length
            Func<string, int> stringLength = s => s.Length;

            // Use a delegate to process a list of lines and display the result
            foreach (string word in words)
            {
                Console.WriteLine("Довжина рядка \"{0}\": {1}", word, stringLength(word));
            }
        }
    }
}
