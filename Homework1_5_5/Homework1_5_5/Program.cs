using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> collection = new List<string>();
            string [] array1 = { "1", "3", "5", "7", "9", "10", "12", "14", "16", "18" };
            string [] array2 = { "2", "3", "5", "7", "11", "13", "17", "19" };
            string array1Name = "array1";
            string array2Name = "array2";
            string collectionName = "collection";

            AddArrayToCollection(ref collection, array1);
            AddArrayToCollection(ref collection, array2);
            PrintData(array1, array1Name);
            PrintData(array2, array2Name);
            PrintData(collection, collectionName);

            Console.ReadKey();
        }

        static void AddArrayToCollection(ref List<string> collection, string[] array)
        {
            foreach (var elementArray in array)
            {
                if (collection.Contains(elementArray)==false)
                {
                    collection.Add(elementArray);
                }
            }
        }

        static void PrintData (string[] array, string name)
        {
            Console.WriteLine(name + ":");

            foreach (var elementArray in array)
            {
                Console.Write(elementArray + " ");
            }

            Console.WriteLine();
        }

        static void PrintData(List <string> collection, string name)
        {
            Console.WriteLine(name + ":");

            foreach (var elementCollection in collection)
            {
                Console.Write(elementCollection + " ");
            }

            Console.WriteLine();
        }
    }
}