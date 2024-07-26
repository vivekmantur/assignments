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
            int minimum = 0, minimumindex = -1;
            for (int i = 0; i < string1.Length - 4; i++)
            {
                int k = (int)string1[i] - '0';
                int k2 = (int)string1[i + 1] - '0';
                int k3 = (int)string1[i + 2] - '0';
                int k4 = (int)string1[i + 3] - '0';
                int product = k * k2 * k3 * k4;
                if (minimum < product)
                {
                    minimum = product;
                    minimumindex = i;
                }
            }
            return minimum;
        }
    }
}
