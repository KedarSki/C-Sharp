using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AlgoZad1
{
    class Program
    {
        static void Main(string[] arg)
        {
            int search, i;
            string text;
            int[] arr = new int[] { 12, 14, 17, 9, 7, 4, 13, 57, 89, 0 };
            bool contains = false;

            for (i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{i}. {arr[i]}");
            }

            Console.WriteLine($"Please provide numbwer you are looking for ");

            text = Console.ReadLine();

            if (!int.TryParse(text, out search))
            {
                Console.WriteLine();
                Console.ReadKey();
            }

            for (i = 0; i < arr.Length; i++)
            {

                if (search == arr[i])
                {
                    contains = true;
                    break;
                }

            }

            if (contains == true)
                Console.WriteLine($"Searching number {search} existing in the array on the position {i}");

            else
                Console.WriteLine($"Searching Number do not exist in array");

            Console.ReadKey(true);
        }
    }
}

