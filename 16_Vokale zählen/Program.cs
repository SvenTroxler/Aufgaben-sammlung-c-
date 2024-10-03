using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Vokale_zählen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deine Eingabe: ");
            string Eingabe = Console.ReadLine();

            int a = Eingabe.ToLower().Count(x => x == 'a');
            int e = Eingabe.ToLower().Count(x => x == 'e');
            int i = Eingabe.ToLower().Count(x => x == 'i');
            int o = Eingabe.ToLower().Count(x => x == 'o');
            int u = Eingabe.ToLower().Count(x => x == 'u');
            int ä = Eingabe.ToLower().Count(x => x == 'ä');
            int ö = Eingabe.ToLower().Count(x => x == 'ö');
            int ü = Eingabe.ToLower().Count(x => x == 'ü');

            Console.WriteLine("Anzahl der Vokale: {0}", a + e + i + o + u);
            Console.WriteLine("A: {0}", a);
            Console.WriteLine("E: {0}", e);
            Console.WriteLine("I: {0}", i);
            Console.WriteLine("O: {0}", o);
            Console.WriteLine("U: {0}", u);
            Console.WriteLine("Ä: {0}", i);
            Console.WriteLine("Ö: {0}", o);
            Console.WriteLine("Ü: {0}", u);
        }
    }
}
