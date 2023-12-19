using System;

namespace Examples23_12_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Skapa - instansiera ett objekt av klass List<T>
            List<int> my_list = new List<int>();

            //Lägg till element - Add() metod
            my_list.Add(1);
            my_list.Add(10);
            my_list.Add(100);
            my_list.Add(1000);
            my_list.Add(10000);
            my_list.Add(100000);
            my_list.Add(1000000);

            foreach (int e in my_list) 
            {
                Console.WriteLine(e);
            }

            //Ta bort element av lista

            //Count
            Console.WriteLine($"Antal element: {my_list.Count}");
            foreach (int e in my_list)
            {
                Console.WriteLine(e);
            }

            my_list.Remove(10);

            Console.WriteLine($"Antal element efter remove: {my_list.Count}");
            foreach (int e in my_list)
            {
                Console.WriteLine(e);
            }
            my_list.RemoveAt(4);
            Console.WriteLine($"Antal element efter remove at: {my_list.Count}");
            foreach (int e in my_list)
            {
                Console.WriteLine(e);
            }

            my_list.RemoveRange(0, 2);
            Console.WriteLine($"Antal element efter remove range: {my_list.Count}");
            foreach (int e in my_list)
            {
                Console.WriteLine(e);
            }

            my_list.Clear();
            Console.WriteLine($"Antal element efter clear: {my_list.Count}");
            foreach (int e in my_list)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine();

            List<int> my_list2 = new List<int>();

            my_list2.Add(496);
            my_list2.Add(1000);
            my_list2.Add(100);
            my_list2.Add(10);
            my_list2.Add(10000);
            my_list2.Add(100000000);
            my_list2.Add(10000000);
            my_list2.Add(1000000);
            my_list2.Add(00000);

            //Utan sorterting
            Console.WriteLine("Unsorted list: ");
            foreach (int e in my_list2)
            {
                Console.WriteLine(e);
            }

            my_list2.Sort();

            Console.WriteLine("Sorted list: ");
            foreach (int e in my_list2)
            {
                Console.WriteLine(e);
            }

           
        }
    }
}