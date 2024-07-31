namespace BinaryAddition
{
    /// <summary>
    /// This class will contain number conversion methods and return final float value 
    /// </summary>
    public static class FinalFloat
    {
        /// <summary>
        /// This method will convert binary value to integer
        /// </summary>
        /// <param name="stringInput">string input which contains integer part of original string</param>
        /// <returns>string which contains binary value of integer part</returns>
        public static int BinaryToInteger(string stringInput)
        {
            int decimalValue = 0;
            int powervalue= 0;

            for (int i = stringInput.Length - 1; i >= 0; i--)
            {
                if (stringInput[i] == '1')
                {
                    decimalValue += power(2, powervalue);
                }
                powervalue++;
            }
            return decimalValue;
        }
        /// <summary>
        /// this method will convert float value to binary
        /// </summary>
        /// <param name="number">float input which contains float part of original string</param>
        /// <returns>string which contains binary value of float number</returns>
        public static string FloatToBinary(float number)
        {
            string floatValue = "";
            while (number > 0)
            {
                number = number * 2;
                int k = (int)number;
                floatValue += k;
                number -= k;
                if (floatValue.Length > 32) break;
            }
            return floatValue;
        }
        /// <summary>
        /// This method which converts binary value to float
        /// </summary>
        /// <param name="stringInput">binary value input</param>
        /// <returns>float value</returns>
        public static float BinaryToFloat(string stringInput)
        {
            float floatValue= 0;
            float power = 0.5f;
            foreach (char character in stringInput)
            {
                if (character == '1')
                {
                    floatValue += power;
                }
                power /= 2;
            }

            return floatValue;
        }
        /// <summary>
        /// This methods perform binary addition value of two binary values
        /// </summary>
        /// <param name="firstBinaryString">input1 binary value</param>
        /// <param name="secondBinaryString">input2 binary value</param>
        /// <returns>binary value after addition</returns>
        public static string BinaryAddition(string firstBinaryString, string secondBinaryString)
        {
            int i = firstBinaryString.Length - 1;
            int j = secondBinaryString.Length - 1;
            string binaryAddition = "";
            int carry = 0;
            while (i >= 0 || j >= 0)
            {
                int sum = carry;
                if (i >= 0) sum += firstBinaryString[i--] - '0';
                if (j >= 0) sum += secondBinaryString[j--] - '0';
                binaryAddition = (sum % 2) + binaryAddition;
                carry = sum / 2;
            }
            if (carry != 0)
            {
                binaryAddition = carry + binaryAddition;
            }
            return binaryAddition;
        }
        /// <summary>
        /// this method convert integer to binary value
        /// </summary>
        /// <param name="input">integer part of input</param>
        /// <returns>binary value of int</returns>

        public static string IntegerToBinary(int input)
        {
            string binarystring = "";
            while (input > 0)
            {
                int remainder = input % 2;
                binarystring = remainder + binarystring;
                input = input / 2;
            }
            return binarystring;
        }
        /// <summary>
        /// This method will reverse a string
        /// </summary>
        /// <param name="input">string input which need to be reversed</param>
        /// <returns>reversed string</returns>
        public static string StringReverse(string input)
        {
            string reversedString = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedString = reversedString + input[i];
            }
            return reversedString;
        }
        /// <summary>
        /// This method calculates the power operation for given base and exponent
        /// </summary>
        /// <param name="baseinput">base</param>
        /// <param name="n">exponent</param>
        /// <returns>return value after power operation</returns>
        static int power(int baseinput, int n)
        {
            int power = 1;
            for (int i = 0; i < n; i++)
            {
                power = power * baseinput;
            }
            return power;
        }
        /// <summary>
        /// this method will convert given two float values to binary values and add and convert final binary to float
        /// </summary>
        /// <param name="m">user input1</param>
        /// <param name="n">user input2</param>
        /// <returns>final float value</returns>
        public static float ConvertFloat(float m, float n)
        {
            string stringM = m.ToString();
            string stringN = n.ToString();
            //converting m to binary
            string[] splitStringM = stringM.Split('.');
            int inputMInt = Convert.ToInt32(splitStringM[0]);
            float inputMFloat = float.Parse("0." + splitStringM[1]);
            string binaryIntInputM = IntegerToBinary(inputMInt);
            string binaryFloatInputM = FloatToBinary(inputMFloat);
            string binaryInputM = binaryIntInputM + "." + binaryFloatInputM;
            //cnverting n to binary
            string[] splitStringN = stringN.Split('.');
            int inputNInt = Convert.ToInt32(splitStringN[0]);
            float inputNFloat = float.Parse("0." + splitStringN[1]);
            string binaryIntInputN = IntegerToBinary(inputNInt);
            string binaryFloatInputN = FloatToBinary(inputNFloat);
            string binaryInputN = binaryIntInputN + "." + binaryFloatInputN;

            //padding zeros to right of float values to make proper binary addition
            int floatmaxlength = Math.Max(binaryFloatInputM.Length, binaryFloatInputN.Length);
            binaryFloatInputM = binaryFloatInputM.PadRight(floatmaxlength, '0');
            binaryFloatInputN = binaryFloatInputN.PadRight(floatmaxlength, '0');


            string paddedInputM = binaryIntInputM + binaryFloatInputM;
            string paddedInputN = binaryIntInputN + binaryFloatInputN;
            string binaryAddedValue = BinaryAddition(paddedInputM, paddedInputN);

            //seperating final binary value to integer part and float part
            string integerPart = "";
            string floatPart = "";
            for (int i = 0; i < binaryAddedValue.Length; i++)
            {
                if (i < binaryAddedValue.Length - floatmaxlength)
                {
                    integerPart = integerPart + binaryAddedValue[i];
                }
                else
                {
                    floatPart = floatPart + binaryAddedValue[i];
                }
            }
            int finalint = BinaryToInteger(integerPart);
            float finalfloat = BinaryToFloat(floatPart);
            float finalFloatResult = finalint + finalfloat;
            return finalFloatResult;
        }
    }
}
