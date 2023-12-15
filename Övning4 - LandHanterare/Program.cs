namespace Övning4___LandHanterare
{
    public class Land
    {
        private string namn;
        private string hStad;
        private double yta;
        private long antalInv;

        public void Inmätning()
        {
            Console.WriteLine("Ange landsinformation: ");
            Console.WriteLine();
            
            Console.Write("Landets namn: ");
            namn = Console.ReadLine();  //Inmätninga av string namn

            Console.Write("Huvudstad: ");
            hStad = Console.ReadLine(); //Inmätning av string hstad

            Console.Write("Yta: ");
            yta = double.Parse(Console.ReadLine()); // double.Parse för att konvertera string till double

            Console.Write("Befolkning: ");
            antalInv = long.Parse(Console.ReadLine()); //long.Parse - string till long
        }

        public void Utskrift()
        {
            Console.WriteLine("Landets namn: " + namn);
            Console.WriteLine("Huvudstad: " + hStad);
            Console.WriteLine("Yta: " + yta);
            Console.WriteLine("Befolkning: " + antalInv);
            Console.WriteLine($"Befolkningstäthet är: {this.Befolkningstäthet()}");
            Console.WriteLine();
        }
        public double Befolkningstäthet() { return antalInv/yta; }

    }
     class Program
    {
        static public void Utbyta(Land[] array, int a, int b)
        {
            Land t = array[a];
            array[a] = array[b];
            array[b] = t;
        }
        
        static public void Sort(Land[] array, int n)
        {
            for (int i = 0; i < n-1; i++)
                for (int j = i + 1 ; j < n; j++)
                {
                    if (array[i].Befolkningstäthet() > array[j].Befolkningstäthet())
                    {
                        Utbyta(array, i, j);
                    }
                }
        }
        static public void lägstBeft(Land[] array, int n)
        {
            double min = array[0].Befolkningstäthet();
            int mini = 0;
            for (int i = 0;i < n;i++)
            {
                if (min > array[i].Befolkningstäthet())
                {
                    min = array[i].Befolkningstäthet();
                    mini = i;
                }
            }
            Console.WriteLine("Data om staten med den lägsta befolkningstätheten är: ");
            array[mini].Utskrift();
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Antal länder n (n<10): ");
            int n = int.Parse(Console.ReadLine());

            Land[] array = new Land[n];
            for (int i = 0;i < n; i++)
            {
                array[i] = new Land();
                array[i].Inmätning();
            }
            Console.WriteLine();
            Sort(array, n);
            Console.WriteLine("Lista över angivna länder:");
            Console.WriteLine();
            for (int i = 0;i < n ; i++)
            {
                array[i].Utskrift();
            }
            Console.WriteLine();
            lägstBeft(array, n);
            Console.ReadKey();
        }
    }
}