using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayString
{
    internal class zeroatendorbegining
    {
        static void Main(string[] args)
        {

            int[] arr = new int[] { 2, 10, 0, 5, 3, 0, 4 };
            
            for(int i=0; i<arr.Length; i++)
            {
                
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] != 0)
                    {
                        continue;
                    }
                    else if (arr[j] ==0) 
                    {
                        continue;
                        arr[i] = arr[j];
                        arr[j] = 0;

                    }

                }
                
            }
            

        }
    }
}
