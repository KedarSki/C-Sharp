﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoZad2Dopis
{
    class Program
    {
        static void Main(string[] args)
        {
            int last = 0;
            int index = 0;
            int insert = 0;
            int[] arr = { 7, 9, 12, 13, 14, 17, 45, 57, 89, 95, 0, 0, 0, 0, 0 };
            int i;

            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            for (i = 0; i < arr.Length; i++)
            {
                if (i + 1 < arr.Length && arr[i + 1] == 0)
                {
                    index = i;
                    last = arr[i];
                    break;
                }
            }

            int insertValue = 20;

            if (insertValue < last)
            {
                for (i = 0; i < arr.Length; i++)
                {
                    if (insertValue < arr[i])
                    {
                        insert = i;
                        break;
                    }
                }
                for (i = arr.Length - 1; i > insert; i--)
                {
                    arr[i] = arr[i - 1];

                }
                arr[insert] = insertValue;
            }
           
            else
            {
                arr[index + 1] = insertValue;
            }

            Console.WriteLine();
            Console.WriteLine();
            
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.ReadKey(true);
        }
    }
}
