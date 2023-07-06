using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayString
{
    internal class secondsmallest
    {
        static void Main(string[] args)
        {

            int[] arr = new int[10] { 29, 4, 27, 45, 1, 66, 5, 90, 18, 45 };
            int min, ssm;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            if (arr[0] < arr[1])
            {
                min = arr[0];
                ssm = arr[1];
            }
            else
            {
                min = arr[1];
                ssm = arr[0];
            }
            for(int i =2; i < arr.Length;i++)
            {
                if (arr[i] < min)
                {
                    ssm = min;
                    min= arr[i];
                }
                else if (arr[i] < ssm)
                {
                    ssm = arr[i];
                }
            }
            Console.WriteLine($"Second Smallest number is {ssm}");






        }
        

        }
    }

