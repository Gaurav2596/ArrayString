﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayString
{
    internal class Minmax
    {
        static void Main(string[] args)
        {

            int max, min;

            int[] arr = new int[] { 56, 34, 89, 12, 45, 99, 78, 11, 55, 10 };

            max = arr[0];
            min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine($"max = {max} and min ={min}");

        }

    }
}
