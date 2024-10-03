using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Alter_berechnen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            Berechne_Alter();

        }

        static void Berechne_Alter()
        {
            Erfassen_Datum();
            Erfassen_Datum_jetzt();
        }

        static void Erfassen_Datum()
        {
            
            Console.Write("Bitte gib dein Geburtsdatum ein: ");
            Geburtsdatum = new DateTime(2000.20.20).Parse(Console.ReadLine());
            
            return ;
        }
        static void Erfassen_Datum_jetzt()
        {
            DateTime myValue = DateTime.Now;
        }


    }
}
