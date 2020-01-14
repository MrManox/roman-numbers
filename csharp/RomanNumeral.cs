using System;

namespace csharp
{
    public class RomanNumeral
    {
        private static int[] numbers = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        private static String[] letters = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

        public String ConvertArabicToRomanNumeral (int arabic)
        {
            //check input
            if (arabic < 1)
                throw new ArgumentException ("Value of RomanNumeral must be positive.");
            if (arabic > 3999)
                throw new ArgumentException ("Value of RomanNumeral must be 3999 or less.");

            //build numeral
            String roman = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                while (arabic >= numbers[i])
                {
                    roman += letters[i];
                    arabic -= numbers[i];
                }
            }
            return roman;
        }

    }
}