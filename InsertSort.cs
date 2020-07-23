using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
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

                int current; 
                int otherIndex;

           for(i = 0; i < vector.Length; i ++)
            {
                current = vector[i]; 
                otherIndex = i;

                while(otherIndex > 0 && current < vector[otherIndex -1]) 
                {
                    vector[otherIndex] = vector[otherIndex - 1];

                    otherIndex--;
                } 

                vector[otherIndex] = current; 
            }

            for (i = 0; i < vector.Length; i++)
            {
                Console.WriteLine($"{i}. {vector[i]} ");
            }

            Console.ReadKey(true);

        }
    }
}
