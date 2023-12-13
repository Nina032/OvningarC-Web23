//using directive for Collection<T>
using System.Collections.ObjectModel;

namespace Övningar_CollectionT12_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Creating a collection of ints
            //Collection<int> myColl = new Collection<int> { 2, 3, 4, 5, 6 };


            ////Displaying the elements in myColl
            //foreach (int i in myColl)
            //{
            //    Console.WriteLine(i);
            //}
            Collection<string> myColl1 = new Collection<string> { "A", "B", "C", "D", "E" };

            string[] myArr = new string[myColl1.Count];
            
            myColl1.CopyTo(myArr, 0);

            foreach (string str in myArr)
            {
                Console.WriteLine(str);
            }

        }
    }
}