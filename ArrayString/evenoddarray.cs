using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayString
{
    internal class evenoddarray
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10]{15,10,35,67,88,66,12,9,7,18};
            int[] arr1 = new int[10];
            int[] arr2 = new int[10];
            int j = 0, k = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    arr1[j] = arr[i];
                    j++;
                }
                else
                {
                    arr2[k] = arr[i];
                    k++;
                }
            }
            Console.WriteLine("Even numbers ");
            for (int i = 0; i < j; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            Console.WriteLine("Odd numbers ");
            for(int i =0; i < k; i++)
            {
                Console.WriteLine(arr2[i]);
            }






        }

            
        }
    }

