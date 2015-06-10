using System;
using System.Linq;

namespace MinimumCharactersToInsertMakePalindrome
{
    internal class Program
    {
        private const int NumberOfAlphabets = 26;

        private static int[] _lookupTable;

        private static string _arrayString;

        static Program()
        {
            _lookupTable = new int[NumberOfAlphabets];
        }

        private static void InitializeArrayString()
        {
            Console.WriteLine("Enter String : ");
            _arrayString = Convert.ToString(Console.ReadLine());
            Console.WriteLine("");
        }

        private static int FindLookupTableIndex(char ch)
        {
            if (ch >= 'a' && ch <= 'z')
                return ch - 'a';

            if (ch >= 'A' && ch <= 'Z')
                return ch - 'A';

            return -1;
        }

        private static bool FillupLookupTable()
        {
            bool result = true;
            foreach (char ch in _arrayString)
            {
                int pos = FindLookupTableIndex(ch);
                if (pos == -1)
                {
                    result = false;
                    break;
                }
                else
                {
                    _lookupTable[pos]++;
                }
            }

            return result;
        }

        private static bool IsOdd(int item)
        {
            if (item % 2 == 0)
                return false;

            return true;
        }

        private static int FindOddGrouping()
        {
            return _lookupTable.Count(IsOdd);
        }

        private static void Main(string[] args)
        {
            InitializeArrayString();
            if (!FillupLookupTable()) return;
            int oddGrouping = FindOddGrouping();
            Console.WriteLine("Number of elements to be added to make a palindrome : {0}", oddGrouping - 1);
        }
    }
}