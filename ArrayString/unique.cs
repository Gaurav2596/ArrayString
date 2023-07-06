using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayString
{
    internal class unique
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] {1,2,1,7,8,};
            
           

            for (int i = 0; i < arr.Length; i++)
            {
                int a = 0;
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        a = 1;
                        break;
                    }
                    
                    
                }
                if(a==0)
                Console.WriteLine(arr[i]);






            }
                


        }
    }
}
