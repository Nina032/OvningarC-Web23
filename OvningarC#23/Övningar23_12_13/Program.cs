namespace Övningar23_12_13
{
    internal class Program
    {
        class Project
        {
            public Project()
            {
                Console.WriteLine("Project created!");
            }
        }
        class Wellcome
        {
            public void WelcomeMessage()
            {
                Console.WriteLine("Wellcome to OOP");
            }
        }
        static void Main(string[] args)
        {
            Project project = new Project();

            Project project1 = new Project();

            //Wellcome wellcome = new Wellcome();
            //Wellcome wellcome1 = new Wellcome();
            //wellcome1.WelcomeMessage();

            //Repetition
            //int[] numbers = { 5, 10, 15, 23, 25 };
            //double average = CalculateAverage(numbers);
            //Console.WriteLine($"Genomsnittet är: {average}");

        }
        //Repetition
        //static double CalculateAverage(int[] array)
        //{
        //    if (array == null || array.Length ==0) 
        //        return 0;

        //    int sum = 0;

        //    foreach (int number in array)
        //    {
        //        sum += number;
        //    }

        //    double average = (double)sum / array.Length;

        //    return average;
        //}
    }
}