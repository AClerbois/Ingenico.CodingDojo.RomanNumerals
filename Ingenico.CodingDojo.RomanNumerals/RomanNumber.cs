using System.Collections.Generic;

namespace Ingenico.CodingDojo.RomanNumerals
{
    public class RomanNumber
    {
        public string Convert(int number)
        {
            return $"{ConvertAboseThousand(number / 1000)}{ConvertBelowThousand(number % 1000)}";
        }

        private string ConvertBelowThousand(int number)
        {
            string result = "";
            var converters = new List<RomanNumberSectionLetter>() {
                new RomanNumberSectionLetter('C','D','M'),
                new RomanNumberSectionLetter('X','L','C'),
                new RomanNumberSectionLetter('I','V','X')
            };

            var numbers = number.ToString().PadLeft(3, '0').ToCharArray();

            for (int i = 0; i < 3; i++)
            {
                result = $"{result}{converters[i].Convert(numbers[i])}";
            }
            return result;
        }

        private string ConvertAboseThousand(int number)
        {
            return new string('M', number);
        }
    }
}
