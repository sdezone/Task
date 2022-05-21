using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QoniacBussinesLayer
{
    public class QoniacTask
    {
        public string CurrencyToWords(string currency)
        {
            string result = "";
            string dollars = "";
            string cents = "";
               
            if (currency.Contains(','))
            {
              
                dollars = currency.Split(',')[0].Replace(" ", "").Replace(".", "").PadLeft(9, '0').Substring(0, 9).Trim();
                cents = currency.Split(',')[1].Replace(" ", "").Replace(".", "").PadRight(2, '0').Substring(0, 2).Trim();
            }
            else
            {
                dollars = currency.Split(',')[0].Replace(" ", "").Replace(".", "").PadLeft(9, '0').Substring(0, 9).Trim();
                cents = "00";
            }
            if (dollars == "000000000")
            {
                if (Convert.ToInt32(cents) > 0)
                {
                    return $"zero dollars and {TwoDigitCentsToWords(Convert.ToInt32(cents))} cents";

                }
                else
                {
                    return $"zero dollars";
                }
            }
            int thousandCount = 0;
            for (int i = 0; i < dollars.Length; i += 3)
            {
                int tempThreeDigit = Convert.ToInt32(dollars.Substring(i, 3));
                thousandCount++;
                if (tempThreeDigit > 0)
                {
                    result += $" {ThreeDigitDollarsToWords(tempThreeDigit).Trim()}{GetDigitsArrays().Item4[thousandCount - 1]}";
                }
            }
            if (Convert.ToInt32(cents) == 0)
            {
                return $"{result} dollars".Trim();

            }
            else
            {
                return $"{result} dollars and {TwoDigitCentsToWords(Convert.ToInt32(cents))} cents".Trim();
            }
        }
        string ThreeDigitDollarsToWords(int threeDigit)
        {
            string[] onesDigits = GetDigitsArrays().Item1;
            string[] tensDigits = GetDigitsArrays().Item2;
            string[] hundredsDigits = GetDigitsArrays().Item3;
            int onesPlace = GetDigits(threeDigit).Item1;
            int tensPlace = GetDigits(threeDigit).Item2;
            int hundrendsPlace = GetDigits(threeDigit).Item3;
            if (threeDigit == 0)
            {
                return "zero";
            }

            if (threeDigit < 20)
            {
                return $"{hundredsDigits[hundrendsPlace]} {onesDigits[threeDigit]}";
            }
            else
            {
                return $"{hundredsDigits[hundrendsPlace]}{tensDigits[tensPlace]}{onesDigits[onesPlace]}";
            }
        }

        string TwoDigitCentsToWords(int twoDigit)
        {
            string[] onesDigits = GetDigitsArrays().Item1;
            string[] tensDigits = GetDigitsArrays().Item2;
            int onesPlace = GetDigits(twoDigit).Item1;
            int tensPlace = GetDigits(twoDigit).Item2;
            if (twoDigit == 0)
                return "zero";
            if (twoDigit < 20)
            {
                return $"{onesDigits[twoDigit]}";
            }
            else
            {
                return $"{tensDigits[tensPlace]}{onesDigits[onesPlace]}";
            }
        }

        Tuple<string[], string[], string[], string[]> GetDigitsArrays()
        {
            string[] onesDigits = { "", " one", " two", " three", " four", " five", " six", " seven", " eight", " nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eghteen", "nineteen" };
            string[] tensDigits = { "", "ten", "twenty", "thirty", "fourty", "fivty", "sixty", "seventy", "eighty", "ninety" };
            string[] hundredsDigits = { "", "one-hundred ", "two-hundred ", "three-hundred ", "four-hundred ", "five-hundred ", "six-hundred ", "seven-hundred ", "eight-hundred ", "nine-hundred " };
            string[] thousandDigits = { " million ", " thousand ", "" };
            return Tuple.Create(onesDigits, tensDigits, hundredsDigits, thousandDigits);
        }

        Tuple<int, int, int> GetDigits(int inputNumber)
        {
            int hundrendsPlace = inputNumber / 100;
            int tensPlace = (inputNumber / 10) % 10;
            int onesPlace = (inputNumber % 100) % 10;
            return Tuple.Create(onesPlace, tensPlace, hundrendsPlace);
        }
    }
}
