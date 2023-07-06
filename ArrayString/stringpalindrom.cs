using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayString
{
    internal class stringpalindrom
    {
        static void Main(string[] args)
        {
            string s, rev="";
            Console.WriteLine("Enter a string");
            s= Console.ReadLine();
            for(int i=s.Length-1; i>=0; i--)
            {
                rev += s[i];
            }
            if (rev == s)
            {
                Console.WriteLine("String is Palindrom");
            }
            else
            {
                Console.WriteLine("String is not palindrom");
            }

        }
    }
}
