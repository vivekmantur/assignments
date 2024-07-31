namespace SubstringCount
{
    /// <summary>
    /// Main class to call the main method 
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main method to take input from user and call CountStringClass
        /// </summary>
        public static void Main()
        {
            string originalMessage = "Enter the original string : ";
            string substringMessage = "Enter the substring: ";
            InputValidation Validate = new InputValidation();
            string orginalString=Validate.ValidateInput(originalMessage);
            string substring = Validate.ValidateInput(substringMessage);
            CountSubstring countsubstring = new CountSubstring();
            int countofsubstring = countsubstring.GetCountOfSubstring(orginalString, substring);
            Console.WriteLine("\n{0}", countofsubstring);
        }
    }
}