namespace BinaryAddition
{
    /// <summary>
    /// This is main class which will take user input and perform operation
    /// </summary>
    public class Program
    {
        /// <summary>
        /// this method will call the FinalFloat class which involves number conversions methods
        /// </summary>
        public static void Main()
        {
            string displayFirst="Provide first input string : ";
            string displaySecond="Provide second input string : ";
            InputValidation Validate = new InputValidation();
            string firstInput = Validate.ValidateInput(displayFirst);
            string secondInput = Validate.ValidateInput(displaySecond);
            float m = float.Parse(firstInput);
            float n = float.Parse(secondInput);
            float finalFloat = FinalFloat.ConvertFloat(m, n);
            Console.WriteLine("{0}", finalFloat);
        }
    }
}
