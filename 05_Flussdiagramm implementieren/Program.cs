using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Flussdiagramm_implementieren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie viele Kilometer möchtest du rennen?");
            int Kilometer = int.Parse(Console.ReadLine());

            if (Kilometer > 42)
            {
                Console.WriteLine("Das schaffs du nicht");
            }
            else
            {
                int Bahnrunden = Kilometer * 1000 / 400;
                Console.WriteLine("Das sind " + Bahnrunden + " runden. Bereit? [j/n]");
                string Bereit = Console.ReadLine();

                if (Bereit == "j")
                {
                    int i = 1;
                    while (i <= Bahnrunden)
                    {
                        Console.WriteLine("Du läufst runde" + i);
                        i++;
                    }
                    Console.WriteLine("Du hast es geschafft");
                }
            }
        }
    }
}
