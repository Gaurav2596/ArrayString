using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayString
{
    internal class stringfirstoccurance
    {
        static void Main(string[] args)
        {

            string str = "Gaurav Mahajan";
            
            Console.WriteLine("enter character to search");
            char occ = Console.ReadKey().KeyChar;
            
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == occ)
                {
                    Console.WriteLine($" first occurance of character at {i}");
                    return;
                }
            }
            Console.WriteLine(" Character not found");







        }
    }
}
