using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bränsleförbrukning, Liter/ mil: ");
            string str1 = Console.ReadLine();
            double bränsleförbrukning = Convert.ToDouble(str1);
            Console.WriteLine("Hur många liter är tanken på?");
            string str2 = Console.ReadLine();
            double tanken = Convert.ToDouble(str2);
            Console.WriteLine("Hur långt har ni/du kört i kilometer?");
            string str3 = Console.ReadLine();
            double kört = Convert.ToDouble(str3);

            Double summa1 = (kört / 10) * bränsleförbrukning;
            Double summa2 = tanken - summa1;
            Double summa3 = (summa2 / bränsleförbrukning) * 10;
            Console.WriteLine("Bränsle kvar i taken: " + summa3 + " km ");      
                }
    }
}
