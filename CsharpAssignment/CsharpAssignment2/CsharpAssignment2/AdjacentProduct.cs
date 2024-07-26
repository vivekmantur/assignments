using System;
namespace Assignment2
{
    /// <summary>
    /// This class will calculate greatest product of adjacent four digits
    /// </summary>
    public class AdjacentProduct
    {
        /// <summary>
        /// This method will calculate the maximum product of four adjacent digits in a input string1
        /// </summary>
        /// <param name="string1">User input string</param>
        /// <returns>greatest product integer value</returns>
        public int Product(string string1)
        {
            int maximum = 0;
            for (int i = 0; i < string1.Length - 4; i++)
            {
                int firstIndex = (int)string1[i] - '0';
                int secondIndex = (int)string1[i + 1] - '0';
                int thirdIndex = (int)string1[i + 2] - '0';
                int fourthIndex = (int)string1[i + 3] - '0';
                int product = firstIndex * secondIndex * thirdIndex * fourthIndex;
                if (maximum< product)
                {
                    maximum = product;
                }
            }
            return maximum;
        }
    }
}
