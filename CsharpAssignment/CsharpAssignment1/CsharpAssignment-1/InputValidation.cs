namespace SubstringCount
{
    /// <summary>
    /// Validates input is correct or not
    /// </summary>
    public class InputValidation
    {
        /// <summary>
        /// This method validates the user input is only alphabets or not
        /// </summary>
        /// <param name="display">The input message displayed to the user.</param>
        /// <returns>A valid string that contains only alphabets</returns>
        public string ValidateInput(string display)
        {
            string input;
            do
            {
                Console.Write(display);
                input = Console.ReadLine();
                int valid = CheckUserInput(input);
                if (string.IsNullOrEmpty(input) || valid == 1)
                {
                    Console.WriteLine("Input is either empty or having numbers please give correct input which contains only alphabets");
                }
            } while (CheckUserInput(input) == 1 || string.IsNullOrEmpty(input));

            return input;
        }

        /// <summary>
        /// Checks if a string consists only of alphabets.
        /// </summary>
        /// <param name="input">The string to check.</param>
        /// <returns>1 if the string is numeric otherwise 0</returns>
        public static int CheckUserInput(string input)
        {
            int  numCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >48 && input[i] <= 57)
                {
                    numCount = 1;
                    break;
                }
            }
            return numCount;
        }
    }
}