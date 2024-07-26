using System;
namespace Assignment2
{
    /// <summary>
    /// Main class to call the main method
    /// </summary>
    public class Assignment2
    {
        /// <summary>
        /// Main method to take input from user and call AdjacentProduct class and return output to user
        /// </summary>
        public static void Main()
        {
            string string1 = Console.ReadLine();

            AdjacentProduct object1 = new AdjacentProduct();
            int greatestproduct = object1.Product(string1);
            Console.WriteLine("{0}", greatestproduct);
        }
    }
}
