namespace Övning1
{
    internal class Program
    {
        class Person
        {
            private string namn = "_____";
            private int år = 0;

            //Deklaration av egenskapen namn av typen sträng:
            public string GetSetNamn
            {
                get { return namn; }
                set { namn = value; }
            }

            //Deklaration av egenskapen år av typen int:
            public int GetSetÅlder
            {
                get { return år; }
                set { år = value; }
            }

            public override string ToString()
            {
                return "Namn = " + namn + ", Ålder = " + år; 
            }

        }
        static void Main(string[] args)
        {
            //Skapa objekt:
            Person objektPerson = new Person();

            //Skriv ut namn och ålder för en specifik person:
            Console.WriteLine($"Namn och ålder - {objektPerson}");

            //Ställa in värdet för det skapade objektet:
            objektPerson.GetSetNamn = "Anna";
            objektPerson.GetSetÅlder = 99;
            Console.WriteLine($"Namn och ålder - {objektPerson}");

            //Öka egenskapen Ålder:
            objektPerson.GetSetÅlder += 1;
            Console.WriteLine($"Namn och ålder - {objektPerson}");

            Person objektPersonTvå = new Person();
            objektPersonTvå.GetSetNamn = "Nina";
            objektPersonTvå.GetSetÅlder = 29;
            Console.WriteLine($"Namn och ålder - {objektPersonTvå}");
        }
    }
}