using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RomanNumerals2
{
    public class RomanNumeralConvertor
    {
        // Building Roman Numeral String To Be Converted From Number Input //
        public string ConvertToRoman(int convertNumber)
        {
            int leftovers;              //store mod results //
            string RomanNumeral = "";   //store roman numeral as a string //
            
            // Build A Dictionary To House The Roman Numeral as a STRING and the Number as a Interger //
            Dictionary<string, int> NumeralConverter = new Dictionary<string, int>()
        {
            {"M", 1000},    // 1000 = M
            {"CM", 900},    // 900 = CM
            {"D", 500},     // 500 = D
            {"CD", 400},    // 400 = CD
            {"C", 100},     // 100 = C
            {"XC", 90},     // 90 = XC
            {"L", 50},      // 50 = L
            {"XL", 40},     // 40 = XL
            {"X", 10},      // 10 = X
            {"IX", 9},      // 9 = IX
            {"V", 5},       // 5 = V
            {"IV", 4},      // 4 = IV
            {"I", 1},       // 1 = I
        };
            // For Each Loop to Loop Over Each Key Value Pair In Dictionary //
            foreach (KeyValuePair<string, int> NumeralNumberPair in NumeralConverter)
            {
                // if number is greater than or equal to Numeral/Numbers Pair in Dictionary // 
                if (convertNumber >= NumeralNumberPair.Value)
                {
                    leftovers = convertNumber % NumeralNumberPair.Value;
                    int remainder = (convertNumber - leftovers) / NumeralNumberPair.Value;
                    convertNumber = leftovers;
                    while (remainder > 0)
                    {
                        RomanNumeral += NumeralNumberPair.Key; remainder--;
                    }
                }
            }

            // Return the Converted Roman Numeral String //
            return RomanNumeral;
        }
    }
}