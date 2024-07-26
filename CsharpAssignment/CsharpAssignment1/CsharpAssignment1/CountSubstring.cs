using System;
namespace Assignment1
{
    /// <summary>
    /// This class is to calculate the occurence of substring in given string and prints the index of that occurence
    /// </summary>
    public class CountSubstring
    {
        /// <summary>
        /// calculate the occurence of substring in given string and prints the index of that occurence
        /// </summary>
        /// <param name="originalstring">first string input</param>
        /// <param name="substring">input2 substring</param>
        /// <returns>count of number of occurences of substring in a first string</returns>
        public int GetCountOfSubstring(string originalString, string substring)
        {
            int countOfSubstring = 0;
            int length1 = originalString.Length;
            int length2 = substring.Length;
            for (int i = 0; i < length1 - length2; i++)
            {
                int j = i;
                string finalString = "";
                for (int k = j; k < i + length2; k++)
                {
                    finalString = finalString + originalString[k];
                }
                if (finalString == substring)
                {
                    Console.Write("{0} ", i);
                    countOfSubstring++;
                }

            }
            return countOfSubstring;
        }
    }
}
