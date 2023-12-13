namespace Övningar23_12_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1.Metoden Sort*/
            //string[] land = new string[]
            //{
            //    "Serbien", "Grekland", "USA", "Nederländerna"
            //};

            //Console.WriteLine("Inan sort: ");
            //foreach (var l in land)
            //{
            //    Console.WriteLine(l);
            //}
            //Console.WriteLine();

            //Array.Sort(land);

            //Console.WriteLine("Efter sort: ");
            //foreach(var l in land)
            //{
            //    Console.WriteLine(l);
            //}

            /*2.Sort och Reverse */
            //int[] tal = { 6, 82, 35, 12 };
            //Console.WriteLine("Inan sort: ");
            //foreach (int i in tal)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine();
            ////Array.Sort(tal);
            ////Console.WriteLine("Efter sort: ");
            ////foreach (int i in tal)
            ////{
            ////    Console.WriteLine(i);
            ////}
            ////Console.WriteLine();

            //Array.Reverse(tal);
            //Console.WriteLine("Efter reverse: ");
            //foreach (int i in tal)
            //{
            //    Console.WriteLine(i);
            //}

            /*3.Recursion */

            //Countdown(50);

            //void Countdown(int number)
            //{
            //    if (number == 0) return;

            //    Console.WriteLine(number);
            //    Countdown(number - 1);
            //}

            /*Uppgift 1*/

            //Person("John");
            //Person("Ema", "Anna", "Henrik");

            //void Person(params string[] namn)
            //{
            //    foreach (string i in namn)
            //        Console.WriteLine($"Hello, {i}!");
            //}

            /* Hantering av betyg - Rep2 */

            string userInput;

            do 
            {
                Console.WriteLine("Vill du beräkna betyg för elev? (ja/nej): ");
                userInput = Console.ReadLine();

                if (userInput == "ja")
                {
                    Console.WriteLine("Ange elevens poäng: ");
                    int points = int.Parse(Console.ReadLine());
                    char grade;

                    if (points >= 90 && points <= 100)
                        grade = 'A';
                    else if (points >= 80 && points < 90)
                        grade = 'B';
                    else if (points >= 70 && points < 80)
                        grade = 'C';
                    else if (points >= 60 && points < 70)
                        grade = 'D';
                    else if (points >= 50 && points < 60)
                        grade = 'E';
                    else
                        grade = 'F';

                    Console.WriteLine($"Elevens poäng: {points} och betyg: {grade}.");     
                }
                else if (userInput != "nej")
                    Console.WriteLine("Ogiltigt svar. Försök igen.");
            } 
            while (userInput != "nej");


        }
    }
}