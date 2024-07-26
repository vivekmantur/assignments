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
            int alphabetCount=0;
            for(int i=0;i<string1.Length;i++)
            {
                if(string1[i]>=65&&string1[i]<=122)
                {
                    alphabetCount=1;
                    break;
                }
            }
            if(alphabetCount==1)
            {
                Console.WriteLine("string contains alphabets give correct input");
            }
            else
            {
                AdjacentProduct object1 = new AdjacentProduct();
                int greatestProduct = object1.Product(string1);
                Console.WriteLine("{0}", greatestProduct);
            }
        }
    }
}
