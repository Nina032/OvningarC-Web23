using System.Collections;
namespace Övning_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            int total = 3;

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine("Namn: ");
                string name = Console.ReadLine();
                Console.WriteLine("Ålder: ");
                int age = int.Parse(Console.ReadLine());

                list.Add(new Person() 
                { 
                    Name = name,  
                    Age = age,
                });

            }
            foreach (Person p in list)
            {
                Console.WriteLine(p);
            }

        }
    }
}