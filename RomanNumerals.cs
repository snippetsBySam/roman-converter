using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanConverter
{
    public static class RomanNumerals
    {
        static readonly Dictionary<char, int> romanTable = new Dictionary<char, int>()
        {
            {'I', 1 },
            {'V', 5 },
            {'X', 10 },
            {'L', 50 },
            {'C', 100 },
            {'D', 500 },
            {'M', 1000 },

        };
        public static int Convert(string romanNumeral)
        {
            romanNumeral = romanNumeral.ToUpper();
            char[] keys = romanTable.Keys.ToArray();
            //Console.WriteLine(keys);
            bool validRomanString = romanNumeral.All(x => keys.Contains(x));
            if (validRomanString)
            {
                int sum = 0;
                int numberOfNumerals = romanNumeral.Length;
                for (int i = 0; i < numberOfNumerals; i++)
                {
                    if ((i + 1) < numberOfNumerals)
                    {
                        if (romanTable[romanNumeral[i]] < romanTable[romanNumeral[i + 1]])
                        {
                            sum -= romanTable[romanNumeral[i]];
                        }
                        else
                        {
                            sum += romanTable[romanNumeral[i]];
                        }
                    }
                    else
                    {
                        sum += romanTable[romanNumeral[i]];
                    }
                }
                return sum;
            }
            return 0;
        }
    }
}
