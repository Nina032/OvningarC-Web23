namespace Övningar23_12_14
{
    internal class Program
    {
        class Height
        {
            //Höjd i meter och centimeter är fält
            private int meter;
            private int centimeter;

            //Skapa höjd utifrån centimeter
            public Height(int cm)
            {
                meter = cm / 100;
                centimeter = cm % 100; 
            }

            //Skapa höjd utifrån meter och centimeter
            public Height(int m, int cm)
            {
                this.meter = m;
                this.centimeter = cm;
            }

            //Skapa en strängrepresentation av objekt
            public override string ToString()
            {
                return meter + " meter och " + centimeter + " centimeter";
            }
        }
        static void Main(string[] args)
        {
            int meter = int.Parse(Console.ReadLine());
            int centimeter = int.Parse(Console.ReadLine());

            Height myHeight = new Height(meter,centimeter);
            Height yourHeight = new Height(169);

            Height hisHeight = yourHeight;


            Console.WriteLine($"Min längd är: {myHeight}");
            Console.WriteLine("Din längd är: {0} ", yourHeight);
            Console.WriteLine("Hans längd är: " + hisHeight);
            Console.ReadKey();
        }
    }
}