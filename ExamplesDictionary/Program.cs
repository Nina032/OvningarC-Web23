namespace ExamplesDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cities = new Dictionary<string, string>()
            {
                {"UK","London, Manchester, Birmingham" },
                {"USA", "Chicago, New York, Washington" },
                {"India","Mumbai, New Delhi, Pune" }
            };

            foreach (var e in cities)
                Console.WriteLine($"Key: {e.Key}, Value: {e.Value}");

            Console.WriteLine();
            Console.WriteLine(cities["UK"]); // värde för nyckel UK
            //Console.WriteLine(cities["usa"]);

            //kontrollera om nyckeln finns

            if (cities.ContainsKey("France"))
                Console.WriteLine(cities["France"]);
            else
                Console.WriteLine("Ingen element med nyckel \"France\" ");

            Console.WriteLine("_____________________________________");
            string result;

            if (cities.TryGetValue("USA",out result))
                Console.WriteLine(result);

            Console.WriteLine("_____________________________________");
            //använda ElementAt() att hämta key-value par med hjälp av index
            for (int i = 0; i < cities.Count; i++)
            {
                Console.WriteLine($"Key: {cities.ElementAt(i).Key}, " +
                    $"Value: {cities.ElementAt(i).Value}");
            }

            //Uppdatera element
            cities["UK"] = "Liverpool, Bristol";
            cities["USA"] = "Los Angeles, Boston";


            if (cities.ContainsKey("France"))
            {
                cities["France"] = "Paris";
            }

            //Ta bort elements
            cities.Remove("UK");

            cities.Remove("France");

            cities.Clear(); //tar bort dictionary

        }
    }
}