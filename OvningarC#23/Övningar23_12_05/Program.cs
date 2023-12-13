namespace Övningar23_12_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Övning1

            //Console.WriteLine("Vilket land vann fotbolls-VM för damer år 2015?");
            //string svar = Console.ReadLine();

            //if (svar == "usa")
            //{
            //    Console.WriteLine("Rätt svar!");
            //}

            //if (svar != "usa")
            //{
            //    Console.WriteLine("Fel svar!");
            //}

            //Övning2

            /*Console.WriteLine("Hur gammal är du? Svara i år.");
            int ålder = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur mycket tjänar du per månad? Svara i kronor.");
            int inkomst = int.Parse(Console.ReadLine());

            if (ålder == 39)
            {
                Console.WriteLine("Du är lika gammal som medelpersonen i Göteborg");
            }
            else if (ålder > 39 )
            {
                Console.WriteLine("Du är äldre än medelpersonen i Göteborg");
            }
            else
            {
                Console.WriteLine("Du är yngre än medelpersonen i Göteborg");
            }

            if (inkomst == 36100)
            {
                Console.WriteLine("Du tjänar lika mycket som medellönen i Sverige");
            }
            else if (inkomst > 36100)
            {
                Console.WriteLine("Du tjänar mer än medellönine i Sverige");
            }
            else
            {
                Console.WriteLine("Du tjänar mindre än medellönen i Sverige");
            }*/

            //Övning3

            //Läs in användarens namn och ålder
            //Console.WriteLine("Vad heter du?");
            //string namn = Console.ReadLine();
            //Console.WriteLine("Hur gammal är du? Svara i hela antal år.");
            //int ålder = int.Parse(Console.ReadLine());

            ////Kontrollera användarens grupp
            //if (namn == "Felicia" || namn == "Felix")
            //{
            //    Console.WriteLine("Du har namnsdag idag, du får gå ombord först.");
            //}
            //else if (ålder > 75)
            //{
            //    Console.WriteLine("På grund av din ålder får du gå ombord i grupp två");
            //}
            //else if (ålder >=18 &&  ålder <=25)
            //{
            //    Console.WriteLine("Unga vuxna får gå ombord i grupp tre.");
            //}
            //else 
            //{
            //    Console.WriteLine("Du är välkommen ombord i grupp fyra.");
            //}

            //Övning 4
            //Console.WriteLine("Hur gammal är du?");
            //int ålder =int.Parse(Console.ReadLine());

            //if (ålder > 65 || (ålder >= 10 &&  ålder <= 18))
            //{
            //    Console.WriteLine("Du får köpa kaffe till ett billigt pris");
            //}
            //else
            //    Console.WriteLine("Du får köpa kaffe till vårt normala pris");

            //int n, sum = 0;
            //int fact = 1;

            //Console.WriteLine("Ange numret som tillägget görs till");
            //n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++) 
            //{
            //    sum += i;
            //    fact *= i;
            //}

            //Console.WriteLine($"Summan av talen från 1 till {n} är {sum}");
            //Console.WriteLine("Fakultet är " + fact);


            //Övning5

            //Console.WriteLine("Detta är ett omvandlingsprogram");
            //string val = "";

            //while (val != "3")
            //{

            //    Console.WriteLine("Välj ett av föjande alternativ");
            //    Console.WriteLine("1. Omvandla meter till kilometer");
            //    Console.WriteLine("2. Omvandla kilometer till meter");
            //    Console.WriteLine("3. Avsluta programmet");

            //    val = Console.ReadLine();

            //    switch (val)
            //    {
            //        case "1":
            //            Console.WriteLine("Skriv in en längd i meter");
            //            double antalMeter = double.Parse(Console.ReadLine());
            //            Console.WriteLine($"Längden du skrev in är detsamma som {antalMeter /1000}km");
            //            break;
            //        case "2":
            //            Console.WriteLine("Skriv in en läng i km");
            //            double antalKm = double.Parse(Console.ReadLine());
            //            Console.WriteLine($"Längden du skrev in är detsamma som {antalKm * 1000}meter");
            //            break; 
            //        case "3":
            //            Console.WriteLine("Programmet avslutas....");
            //            break;
            //        default:
            //            Console.WriteLine("Du valde inte ett giltigt alternativ!");
            //            break;
            //    }



            //}

            //Övning6

            //Console.WriteLine("Hur stor är insats i banken?");
            //double insats = double.Parse(Console.ReadLine());
            //Console.WriteLine("Vad ör räntan (i %) ?");
            //double ränta = 1 + double.Parse(Console.ReadLine()) / 100.0;

            //Console.WriteLine("Vilket insatsvärde vill du nå?");
            //double mål = double.Parse(Console.ReadLine());

            //int år = 0;

            //do
            //{
            //    insats *= ränta;
            //    ++år;
            //}
            //while (insats < mål);

            //Console.WriteLine($"I {år} år insatsvärde kommer att vara {insats}kr.");
            //Console.ReadKey();


            //Övning7

            //Console.WriteLine("Vilket är Europas folkrikaste land?");
            //string svar = Console.ReadLine().ToLower();

            //int antalGissningar = 1;

            //while (svar != "ryssland")
            //{
            //    if ( antalGissningar >=5)
            //    {
            //        Console.WriteLine("Dina gissningar är slut");
            //        break;
            //    }

            //    Console.WriteLine("Fel svar, försök igen");
            //    svar = Console.ReadLine();
            //    antalGissningar++;
            //}

            //if (svar == "ryssland")
            //    Console.WriteLine("Ditt svar är rätt!");


            //Övning8

            //Console.WriteLine("Skriv in rektangels bredd");
            //int bredd = int.Parse(Console.ReadLine());
            //Console.WriteLine("Skriv in rektangels höjd");
            //int höjd = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //for (int i = 0; i < höjd; i++) 
            //{
            //    for (int j = 0; j < bredd; j++)
            //    {
            //        if (i == 0 || i== höjd-1 || j==0 || j==bredd-1)
            //        {
            //            Console.Write("X");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            //    Console.WriteLine();

            //}

        }
    }
}