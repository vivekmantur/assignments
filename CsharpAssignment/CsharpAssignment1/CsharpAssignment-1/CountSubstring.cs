namespace SubstringCount
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
        /// <returns>return total count of number of occurences of substring in a first string</returns>
        public int GetCountOfSubstring(string originalstring, string substring)
        {
            int countOfSubstring = 0;
            int length1 = originalstring.Length;
            int length2 = substring.Length;
            //iterating through each character for string
            for (int i = 0; i <= length1 - length2; i++)
            {
                int j = i;
                string finalstring = "";
                //add input2 length of characters of first input string
                for (int k = j; k < i + length2; k++)
                {
                    finalstring = finalstring + originalstring[k];
                }
                if (finalstring == substring)
                {
                    Console.Write("{0} ", i);
                    countOfSubstring++;
                }

            }
            return countOfSubstring;
        }
    }
}