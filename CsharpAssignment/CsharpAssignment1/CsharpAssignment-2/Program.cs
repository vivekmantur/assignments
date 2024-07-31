namespace MaxAdjacentProduct
{
    /// <summary>
    /// Main class to call the main method
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main method to take input from user and call AdjacentProduct class and return output to user
        /// </summary>
        public static void Main()
        {
            string userMessage = "give input : ";
            InputValidation Validation = new InputValidation();
            string input = Validation.ValidateInput(userMessage);
            AdjacentProduct object1 = new AdjacentProduct();
            int greatestproduct = object1.MaximumProduct(input);
            Console.WriteLine("{0}", greatestproduct);
       
        }
    }
}
