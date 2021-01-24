using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fuzzyBuzzy
{
    class Program
    {
        static void Main(string[] args)
        {
            fuzzy(100,3,5);
        }

        public static void fuzzy(int upperLmt,int key1,int key2)
        {
            var c3 = 0;
            var c5 = 0;
            for (int i=1; i<= upperLmt; i++)
            {
                c3++;
                c5++;
                var d = "";
                if(c3 == key1) { d += "fizz"; c3 = 0; }
                if (c5 == key2) { d += "buzz"; c5 = 0; }
                if(d == "")
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(d);
                }
            }
        }
    }
}
