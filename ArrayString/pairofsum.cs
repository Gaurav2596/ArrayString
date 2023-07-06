using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayString
{
    internal class pairofsum
    {
        static void Main(string[] args)
        {

            int[] arr = new int[] {4,5,7,1,2,3,0 };
            Console.WriteLine("Enter The number");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i =0;i<arr.Length-1;i++)
            {
                for(int j =1;j<arr.Length;j++)
                    if(num == arr[i] + arr[j])
                    {
                        Console.WriteLine($"{ arr[i]}, { arr[j]}");
                    }
            }
                
        }
    }
}
