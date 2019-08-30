namespace Ingenico.CodingDojo.RomanNumerals
{
    public class RomanNumberSectionLetter
    {
        private readonly char littleLetter;
        private readonly char midLetter;
        private readonly char superiorLetter;

        public RomanNumberSectionLetter(
            char littleLetter,
            char midLetter,
            char superiorLetter)
        {
            this.littleLetter = littleLetter;
            this.midLetter = midLetter;
            this.superiorLetter = superiorLetter;
        }

        public string Convert(char number)
        {
            return int.TryParse(number.ToString(), out int value)
                ? Convert(value)
                : string.Empty;
        }

        public string Convert(int number)
        {
            switch (number)
            {
                case int _ when number > 0 && number < 4:
                    return new string(littleLetter, number);
                case int _ when number == 4:
                    return $"{littleLetter}{midLetter}";
                case int _ when number > 4 && number < 9:
                    return $"{midLetter}{new string(littleLetter, number - 5)}";
                case int _ when number == 9:
                    return $"{littleLetter}{superiorLetter}";
                default:
                    return "";
            }
        }

    }
}
