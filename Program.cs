using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIOrnek259
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s, ys = "";
            int a;
            byte c;

            Console.Write("Bir cümle giriniz:");
            s = Console.ReadLine();

            for (a = 0; a < s.Length; a++)
            {
                c = (byte)s[a];

                if (c >= 65 && c <= 97)
                {
                    
                    ys = ys + (char)(c + 32);
                }
                else
                {
                    ys = ys + s[a];
                }
            }

            Console.WriteLine(ys);
            Console.WriteLine("\n\nDevam etmek için herhangi bir tuşa basın...");
            Console.ReadKey(true);
        }
    }
}