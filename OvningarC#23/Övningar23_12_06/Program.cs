namespace Övningar23_12_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Övning 10   */
            //string meddelande = "Hej. Detta är ett meddelande. Tack för att du läste meddelandet.";
            //for (int i = 0; i < meddelande.Length; i++)
            //{
            //    Console.Write(meddelande[i]);
            //    if (meddelande[i] == '.')
            //    {
            //        Thread.Sleep(1000);
            //    }
            //    else
            //    {
            //        Thread.Sleep(100);
            //    }


            //}

            /*  Övning 11   */

            //Console.WriteLine("Hur många sporter vill du skriva in?");
            //int antal = int.Parse(Console.ReadLine());
            //string[] sporter = new string[antal];

            //for (int i = 0; i < antal; i++) 
            //{
            //    Console.WriteLine("Skriv in en sport.");
            //    sporter[i] = Console.ReadLine();
            //}


            //for (int i = 0;i < antal; i++) 
            //{
            //    Console.WriteLine(sporter[i]);
            //}

            /*  Övning 12   */

            //int[] talLista = { 432, 231, 32, -123, 20 };
            //int summa = 0;

            //foreach (int tal in talLista)
            //{
            //    summa += tal;
            //    Console.WriteLine(summa);
            //}

            //Console.WriteLine($"Summan av talen är {summa}");

            /*  Övning 13   */

            //string[,] karta = new string[4, 2];
            //karta[0, 0] = "Ö";
            //karta[1, 0] = "Hav";
            //karta[2, 0] = "Hav";
            //karta[3, 0] = "Skog";
            //karta[0, 1] = "Hav";
            //karta[1, 1] = "Hav";
            //karta[2, 1] = "Skog";
            //karta[3, 1] = "Skog";

            //Console.WriteLine("Skriv in en X-koordinat (0 - 3)");
            //int x = int.Parse(Console.ReadLine());

            //Console.WriteLine("Skriv in en Y-koordinat (0 - 1");
            //int y = int.Parse(Console.ReadLine());

            //Console.WriteLine($"På denna ruta finns {karta[x,y]}");

            /* Random */

            //Random random = new Random();

            //int current = 0;

            //do
            //{
            //    current = random.Next(1,11);
            //    Console.WriteLine(current);
            //} while (current != 7);

            /* The replicator of d'to */
            int[] original = new int[5];

            for (int item = 0; item < 5; item++)
            {
                Console.WriteLine("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                original[item] = number;
            }

            int[] copy = new int[5];

            for (int index = 0; index  < 5; index++)
            {
                copy[index] = original[index];
                Console.WriteLine($"{original[index]} and {copy[index]}");
            }

            Console.ReadKey();


        }
    }
}