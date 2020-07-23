using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] arg)
        {
            
            string text;
            Random gen;
            int numbers, i;
            int[] vector;
            gen = new Random();

            Console.WriteLine("Random Values Array Generator");
            Console.WriteLine("Enter number of Generating Values");
            text = Console.ReadLine(); 

            if (!int.TryParse(text, out numbers)) 
            {
                Console.WriteLine();
                Console.ReadKey(true);
            }

            vector = new int[numbers]; 

            for (i = 0; i < vector.Length; i++)
            {

                int newRandomValue = gen.Next(0, 100);

                if (!vector.Contains(newRandomValue))
                    vector[i] = newRandomValue; 
                else
                    i--;
            }

            Console.WriteLine();

            int j; 

            for (i = 0; i < vector.Length; i++)
            {
                for (j = 0; j < vector.Length; j++)
                {
                    if (vector[i] < vector[j])
                    {
                        int temp = vector[i];
                        vector[i] = vector[j];
                        vector[j] = temp;
                    }
                }
            }

            for (i = 0; i < vector.Length; i++)
            {
                Console.WriteLine($"{i}. {vector[i]} ");
            }

            Console.ReadKey();
            Console.WriteLine("Please enter looking value: ");
            text = Console.ReadLine();             

            int top = 0;
            int mid;
            int bottom = vector.Length - 1;
            int search;
            
            if(!int.TryParse(text, out search)) 
            {
                Console.WriteLine();
                Console.ReadKey();
            }

                while (true) 
                {
                    if(top>bottom)
                {
                    Console.WriteLine("Entered value do not exist in the Array");

                    break;
                }
                    
                    mid = (bottom + top) / 2;
                if (vector[mid] == search)

                {
                    Console.WriteLine($"Searching value it's in the following index: { mid}");
                    break;
                }

                if (vector[mid] > search)
                    {
                        bottom = mid - 1;
                    }
                  else
                    {
                        top = mid + 1;
                    }
            }   
        }
    }
}

            
