using ClassLib;
using static System.Console;

namespace BigProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyExternalClass myObj = new MyExternalClass();
            WriteLine(myObj.ToString());
            ReadKey();
        }
    }
}