using System;
namespace Assignment1
{
    /// <summary>
    /// Main class to call the main method 
    /// </summary>
    public class Assignment1
    {
        /// <summary>
        /// Main method to take input from user and call CountStringClass
        /// </summary>
        public static void Main()
        {
            string orginalString = Console.ReadLine();
            string substring = Console.ReadLine();
            CountSubstring object1 = new CountSubstring();
            int countofsubstring = object1.GetCountOfSubstring(orginalString, substring);
            Console.WriteLine("\n{0}", countofsubstring);
        }
    }
}