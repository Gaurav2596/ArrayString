using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayString
{
    internal class givennumber
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 10, 23, 45, 6, 7, 89, 90, 12, 45, 100 };
            int num, flag = 0;
            Console.WriteLine("Enter number to be search");
            num = Convert.ToInt32(Console.ReadLine());

            for(int i  = 0; i < arr.Length; i++)
            {
                if (arr[i] == num) 
                {
                    flag = 1;
                    Console.WriteLine($"Number is {num} and found at {i+1}");

                }
            }
            if(flag == 0)
            {
                Console.WriteLine("Number not found");
            }
        }
    }
}
