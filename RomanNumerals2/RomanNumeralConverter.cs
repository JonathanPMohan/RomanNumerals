using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RomanNumerals2
{
    public class RomanNumeralConvertor
    {
        public string ConvertToRoman(int convertThis)
        {
            int leftovers;              //store mod results
            string RomanNumeral = "";   //store roman numeral string
            Dictionary<string, int> dict = new Dictionary<string, int>()
        {
            {"M", 1000},// 1000 = M
            {"CM", 900},// 900 = CM
            {"D", 500}, // 500 = D
            {"CD", 400},// 400 = CD
            {"C", 100}, // 100 = C
            {"XC", 90}, // 90 = XC
            {"L", 50},  // 50 = L
            {"XL", 40}, // 40 = XL
            {"X", 10},  // 10 = X
            {"IX", 9},  // 9 = IX
            {"V", 5},   // 5 = V
            {"IV", 4},  // 4 = IV
            {"I", 1},   // 1 = I
        };
            foreach (KeyValuePair<string, int> pair in dict)
            {
                if (convertThis >= pair.Value)
                {
                    leftovers = convertThis % pair.Value;
                    int remainder = (convertThis - leftovers) / pair.Value;
                    convertThis = leftovers;
                    while (remainder > 0)
                    {
                        RomanNumeral += pair.Key; remainder--;
                    }
                }
            }
            return RomanNumeral;
        }
    }
}