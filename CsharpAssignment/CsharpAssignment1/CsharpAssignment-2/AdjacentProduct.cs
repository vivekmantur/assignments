namespace MaxAdjacentProduct
{
    /// <summary>
    /// This class will calculate greatest product of adjacent four digits
    /// </summary>
    public class AdjacentProduct
    {
        /// <summary>
        /// This method will calculate the maximum product of four adjacent digits in a input string1
        /// </summary>
        /// <param name="string1">User input</param>
        /// <returns>integer which contain greatest product</returns>
        public int MaximumProduct(string string1)
        {
            int max=0;
            //iterating through each character and calculating adjacent four digits product
            for (int i = 0; i < string1.Length - 3; i++)
            {
                int firstIndex = (int)string1[i] - '0';
                int secondIndex = (int)string1[i + 1] - '0';
                int thirdIndex = (int)string1[i + 2] - '0';
                int fourthIndex = (int)string1[i + 3] - '0';
                int product = firstIndex * secondIndex * thirdIndex * fourthIndex;
                if (max < product)
                {
                    max = product;
                }
            }
            return max;
        }
    }
}