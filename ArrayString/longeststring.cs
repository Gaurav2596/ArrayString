using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayString
{
    internal class longeststring
    {
        static void Main(string[] args)
        {

            string str = "Hello Good Morning";
            string[]str1 = str.Split(new[] { " "}, StringSplitOptions.None);

            int count = 0; string word = "";
            foreach (string s in str1) 
            {
                if(s.Length>count)
                {
                    count=s.Length;
                    word = s;
                }
            }
            Console.WriteLine($"Longest string is {word} and count is {count}");
        }
    }
}
