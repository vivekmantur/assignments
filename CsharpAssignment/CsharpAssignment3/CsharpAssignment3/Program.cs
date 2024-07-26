using System;
namespace Assignment3
{
    /// <summary>
    /// This is main class which will take user input and perform operation
    /// </summary>
    public class program
    {
        /// <summary>
        /// this method will call the FinalFloat class 
        /// </summary>
        public static void Main()
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            int alphabetCountInInput1=0;
            for(int i=0;i<input1.Length;i++)
            {
                if(input1[i]>=65&&input1[i]<=122)
                {
                    alphabetCountInInput1=1;
                    break;
                }
            }
            int alphabetCountInInput=0;
            for(int i=0;i<input2.Length;i++)
            {
                if(input2[i]>=65&&input2[i]<=122)
                {
                    alphabetCountInInput2=1;
                    break;
                }
            }
            if(alphabetcount==1)
            {
                Console.WriteLine("string contains alphabets give correct input");
        
            }
            float m = float.Parse(input1);
            float n = float.Parse(input2);
            float finalFloat = FinalFloat.ConvertFloat(m, n);
            Console.WriteLine("{0}", finalFloat);
        }
    }
}
