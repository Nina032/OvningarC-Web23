namespace Pesonnummer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriva in ditt personnummer i format \"YYMMDD-XXXX\" ");
            string personnummer = Console.ReadLine();

            bool isValid = IsValidSwedishPersonalNumber(personnummer);


            if (isValid)
                Console.WriteLine("Personnummret är giltigt.");
            else
                Console.WriteLine("Personnummret är ogiltigt.");
        }

        static bool IsValidSwedishPersonalNumber(string personnummer)
        {
            //Ta bort eventuella mellanslag eller bindestreck
            personnummer = personnummer.Replace(" ", "").Replace("-", "");

            //Kontrollera att personnummer har rätt läng
            if (personnummer.Length !=10)
                return false;

            //Kontrollera att alla tecken är siffror
            if (!IsAllDigits(personnummer))
                return false;

            //Extrahera datumsiffra (9siffror) och kontrollsiffra
            string datePart = personnummer.Substring(0, 9);
            string controlDigit = personnummer.Substring(personnummer.Length - 1);


            //Beräkna och jämför kontrollsiffran
            int calculatedControlDigit = CalculateControlDigit(datePart); 

            return calculatedControlDigit == int.Parse(controlDigit);
        }

        static bool IsAllDigits(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }

        static int CalculateControlDigit(string datePart)
        {
            int sum = 0;
            for (int i = 0; i < datePart.Length; i++) 
            {
                int digit = int.Parse(datePart[i].ToString());
                if (i % 2 == 0)
                {
                    digit *= 2;
                    if (digit > 9)
                        digit -= 9;
                }
                sum += digit;
            }

            int realControlDigit = (10 - (sum % 10)) % 10;
            return realControlDigit;
        }

    }
}