using System.Data;

namespace Uppgift2_20dec
{
    internal class Program
    {
        private static Dictionary<string, int> studentScores = new Dictionary<string, int>();
        static void Main(string[] args)
        {
            
            //Lägg till några studerande och deras poäng
            AddStudent("Alice", 85);
            AddStudent("Bob", 90);
            AddStudent("Charlie", 78);

            DisplayStudents();

            //Uppdatera poäng för en student
            UpdatePoints("Bob", 95);

            //Ta bort en student
            RemoveStudent("Alice");
            //Visa alla studenter och deras poäng
            DisplayStudents();

        }
        private static void AddStudent(string name, int points)
        {
            studentScores[name] = points;
        }
            
        private static void UpdatePoints(string name, int newPoints)
        {
            if (studentScores.ContainsKey(name))
                studentScores[name] = newPoints;
            else
                Console.WriteLine($"Student {name} finns inte i listan.");

        }
        private static void RemoveStudent(string name)
        {
            if (studentScores.ContainsKey(name))
                studentScores.Remove(name);
            else
                Console.WriteLine($"Student {name} finns inte i listan.");
        }
        private static void DisplayStudents()
        {
            Console.WriteLine("Studenter och deras poäng: ");
            foreach (var student in studentScores)
            {
                Console.WriteLine($"{student.Key}: {student.Value}");
            }
        }
    }
}