using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Durch_Quersumme_teilbare_Zahlen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wert1;
            int wert2;



            Console.Write("zahl1: ");
            string eingabe1 = Console.ReadLine();
            Console.Write("zahl2: ");
            string eingabe2 = Console.ReadLine();

            if (int.TryParse(eingabe1, out wert1) == true && int.TryParse(eingabe2, out wert2) == true)
            {

                int sum = 0;
                int zahl = wert1;

                Console.WriteLine("------------------------------------------");
                Console.WriteLine("zahl \t| Quersumme \t| zahl / Quersumme");
                Console.WriteLine("------------------------------------------");

                while (zahl <= wert2)
                {

                    
                    
                   sum = BerechneQuersumme(zahl);

                    if (zahl % sum == 0)
                    {

                        Console.WriteLine(zahl + "\t|  " + sum + "\t\t|  " + zahl/sum);
                        
                    }
                    
                    zahl++;
                }
            }

            else
            {
                Console.WriteLine("Ungültig: Ganzzahl benötigt");
            }
        }
        static int BerechneQuersumme(int zahl)
        {

            int sum = 0;
            while (zahl != 0)
            {
                sum = sum + zahl % 10;
                zahl = zahl / 10;
            }
            return sum;
        }
    }
}
