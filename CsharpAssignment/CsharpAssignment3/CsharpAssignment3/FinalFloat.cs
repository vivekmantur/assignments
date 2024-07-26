using System;
namespace Assignment3
{
    /// <summary>
    /// This class will contain number conversion methods and return final float value 
    /// </summary>
    static class FinalFloat
    {
        /// <summary>
        /// This method will convert binary value to integer
        /// </summary>
        /// <param name="stringInput">string input which contains binary value</param>
        /// <returns>integer converted value</returns>
        public static int BinaryToInteger(string stringInput)
        {
            int decimalValue = 0;
            int power = 0;

            for (int i = stringInput.Length - 1; i >= 0; i--)
            {
                if (stringInput[i] == '1')
                {
                    decimalValue += (int)Math.Pow(2, power);
                }
                power++;
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
        /// <param name="stringInput">string input which contain binary value of float part</param>
        /// <returns>float value</returns>
        public static float BinaryToFloat(string stringInput)
        {
            int i = -1;
            float floatResult = 0.0f;
            for (int j = 0; j < stringInput.Length; j++)
            {
                int t = stringInput[j] - '0';
                floatResult += (float)(t * Math.Pow(2, i));
                i--;
            }
            return floatResult;
        }
        /// <summary>
        /// This methods perform binary addition value of two binary values
        /// </summary>
        /// <param name="firstBinaryString">first input binary value</param>
        /// <param name="secondBinaryString">second input binary value</param>
        /// <returns>string binary value after addition</returns>
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
        /// <param name="input">input integer value</param>
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
        /// <param name="input">input string</param>
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
        /// This method will add zeros before string to make a proper binary addition
        /// </summary>
        /// <param name="input">input string</param>
        /// <param name="length">length to add zeros</param>
        /// <returns>updated string with equal leading values</returns>
        public static string PadZeros(string input, int length)
        {

            while (input.Length < length)
            {
                input = "0" + input;
            }
            return input;
        }
        /// <summary>
        /// This method return maximum values after decimal points in two strings
        /// </summary>
        /// <param name="string1">first string</param>
        /// <param name="string2">second string</param>
        /// <returns>maximum values after decimal point</returns>
        public static int GetMaxFractionalPartdigits(string string1, string string2)
        {
            int decimalIndex1 = string1.IndexOf('.') + 1;
            int decimalIndex2 = string2.IndexOf('.') + 1;
            int countInput1 = 0;
            int countInput2 = 0;
            while (decimalIndex1 < string1.Length)
            {
                countInput1++;
                decimalIndex1++;
            }
            while (decimalIndex2 < string2.Length)
            {
                countInput2++;
                decimalIndex2++;
            }
            return Math.Max(countInput1, countInput2);
        }
        /// <summary>
        /// this method will convert given two float values to binary values and add and convert final binary to float
        /// </summary>
        /// <param name="m">user input1</param>
        /// <param name="n">user input2</param>
        /// <returns>final float value</returns>
        public static float ConvertFloat(float m, float n)
        {
            string string1 = m.ToString();
            string string2 = n.ToString();
            //converting m to binary
            string[] splitString1 = string1.Split('.');
            int input1Int= Convert.ToInt32(splitString1[0]);
            float input1Float = float.Parse("0." + splitString1[1]);
            string binaryIntInput1 = IntegerToBinary(input1Int);
            string binaryFloatInput1 = FloatToBinary(input1Float);
            string binaryInput1 = binaryIntInput1 + "." + binaryFloatInput1;
            //cnverting n to binary
            string[] splitString2 = string2.Split('.');
            int input2Int = Convert.ToInt32(splitString2[0]);
            float input2Float = float.Parse("0." + splitString2[1]);
            string binartIntInput2 = IntegerToBinary(input2Int);
            string binaryFloatInput2= FloatToBinary(input2Float);
            string binaryInput2 = binaryIntInput2 + "." + binaryFloatInput2;
            //making the fraction part zero equal 
            int maxLength = Math.Max(s.Length, sk2.Length);
            binaryFloatInput1 = binaryFloatInput1.PadRight(maxLength, '0');
            binaryFloatInput2 = binaryFloatInput2.PadRight(maxLength, '0');
            binaryInput1 = binaryIntInput1 + "." + binaryFloatInput1;
            binaryInput2= binaryIntInput2 + "." + binaryFloatInput2;
            char dotIndex = '.';
            string binaryinputM = sp.Replace(ch.ToString(), "");
            string binaryinputN = sk.Replace(ch.ToString(), "");
            maxLength = Math.Max(binaryIntInput1.Length + binaryFloatInput1.Length, binaryIntInput2.Length + binaryFloatInput2.Length);
            string paddedInput1 = PadZeros(binaryinputM, maxLength);
            string paddedInput2 = PadZeros(binaryinputN, maxLength);
            string binaryAddedValue= BinaryAddition(paddedInput1, paddedInput2);

            int decimalPoint=GetMaxFractionalPartdigits(string1,string2);

            string integerPart = "";
            string floatPart = "";
            for (int i = 0; i < binaryAddedValue.Length; i++)
            {
                if (i < binaryAddedValue.Length - decimalPoint)
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
