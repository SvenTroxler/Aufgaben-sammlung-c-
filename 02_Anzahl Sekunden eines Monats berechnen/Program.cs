using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace _02_Anzahl_Sekunden_eines_Monats_berechnen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Wieviele Tage hat der Monat, für den Sie die Sekundenzahl berechnen sollen?");
                int Tage = Convert.ToInt32(Console.ReadLine());
                if (Tage > 27 && Tage < 32)
                {
                    int Sekunden = Tage * 24 * 60 * 60;

                    Console.WriteLine("Ein Monat mit " + Tage + " Tagen hat " + Sekunden + " Sekunden.");
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. ungültige Zahl");
                }
            }
            catch { 
            
                Console.WriteLine("Ungültige Eingabe. verwende Zahl");
            
            Console.ReadKey();
            }
        }
    }
}
