using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayString
{
    internal class duplicate
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 20, 10, 45, 67, 24, 45, 89, 90, 67 };
            int count = 0;
            
            for(int i =0; i < arr.Length; i++)
            {
                for(int j=i+1; j<arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine($"Duplicate number is {arr[i]}");
                        count++;
                    }
                   
                }
            }
                   
                  Console.WriteLine($"total duplicate count is {count}");
           
           

        }
             

        
             
            
        
    }
}
