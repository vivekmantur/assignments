namespace MaxAdjacentProduct
{
    /// <summary>
    /// Validates input is correct or not
    /// </summary>
    public class InputValidation
    {
        /// <summary>
        /// This method validates that it is a numeric string or not.
        /// </summary>
        /// <param name="display">The input message to user</param>
        /// <returns>return string if it is valid else error message.</returns>
        public string ValidateInput(string display)
        {
            string input;
            do
            {
                Console.Write(display);
                input = Console.ReadLine();
                int valid = CheckUserInput(input);
                if (string.IsNullOrEmpty(input) || valid==1 || input.Length<4)
                {
                    Console.WriteLine("Input is either empty or having other than numbers or length is less than 4 Please try again.");
                }
            } while (CheckUserInput(input)==1||string.IsNullOrEmpty(input)||input.Length<4);

            return input;
        }

        /// <summary>
        /// Checks if a string consists only of digits.
        /// </summary>
        /// <param name="input">The string to check.</param>
        /// <returns>0 if the string is numeric otherwise 1</returns>
        public static int CheckUserInput(string input)
        {
            int alphabetCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 65 && input[i] <= 122)
                {
                    alphabetCount = 1;
                    break;
                }
            }
            return alphabetCount;
        }
    }
}