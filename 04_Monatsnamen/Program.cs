using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _04_Monatsnamen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Monat;
            Console.Write("Gebe eine Ganzzahl zwischen 1 & 12 ein.");
            string eingabe = Console.ReadLine();

            if (int.TryParse(eingabe, out Monat) == true)
            {
                string[] monat = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
                Console.WriteLine(monat[Monat-1]);

            }
            else
            {
                Console.WriteLine("Ungültige Eingabe");
            }
            Console.ReadKey();
        }
    }
}
