using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayString
{
    internal class practice
    {
        static void Main(string[] args)
        {

            int[] arr = new int[] { 12,3,-19,29,5,-61,44,7,-9};
            
            for(int i =0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    int j = i - 1;
                    arr[i] = arr[j] * arr[j];
                }
                Console.WriteLine(arr[i]);
            }
           
        }
    }
}
