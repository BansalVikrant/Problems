using System;
using System.Text;

namespace BinaryCode
{
    public class BinaryCode
    {
        public static string[] decode(string encryptedString)
        {
            string[] decodeStrings = new string[2];
            decodeStrings[0] = decode(encryptedString, 0);
            decodeStrings[1] = decode(encryptedString, 1);
            return decodeStrings;
        }

        private static string decode(string encryptedString, int digit)
        {
            StringBuilder decode = new StringBuilder();
            decode.Append(digit);

            int decodePreviousBit = 0;
            int decodeCurrentBit = digit;

            foreach (char ch in encryptedString)
            {
                int encodeCurrentBit = (int)Char.GetNumericValue(ch);

                int decodeNextBit = encodeCurrentBit - decodePreviousBit - decodeCurrentBit;
                if ((decodeNextBit < 0) || (decodeNextBit > 1)) return "NONE";

                decode.Append(decodeNextBit);
                decodePreviousBit = decodeCurrentBit;
                decodeCurrentBit = decodeNextBit;
            }

            decode.Remove(decode.Length - 1, 1);
            return decode.ToString();
        }

        private static void Main(string[] args)
        {
            string[] decodeStrings = new string[2];
            decodeStrings = decode("12221112222221112221111111112221111");

            decodeStrings = decode("123210122");

            decodeStrings = decode("11");

            decodeStrings = decode("22111");

            decodeStrings = decode("123210120");

            decodeStrings = decode("3");
        }
    }
}