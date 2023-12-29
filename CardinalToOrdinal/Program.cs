namespace CardinalToOrdinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunCardinalToOrdinal();

            static string CardinalToOrdinal(int number)
            {
                int lastTwoDigits = number % 100;
                switch (lastTwoDigits)
                {
                    case 11:
                    case 12:
                    case 13:
                        return $"{number}th";
                    default:
                        int lastDigit = number % 10;
                        string suffix = lastDigit switch
                        {
                            1 => "st",
                            2 => "nd",
                            3 => "rd",
                            _ => "th"

                        };
                        return $"{number}{suffix}";
                }
            }

            static void RunCardinalToOrdinal()
            {
                for (int number = 1; number <= 1100; number++)
                {
                    Console.WriteLine($"{CardinalToOrdinal(number)}");
                }
                Console.WriteLine();
            }
        }
    }
}
