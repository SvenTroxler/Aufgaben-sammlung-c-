using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie lang soll die Linie sein?");
            int eingabe = int.Parse(Console.ReadLine());

            int Wert1 = 0;
            int Wert2 = eingabe - 1;

            for (int i = 0; i < eingabe; i++)
            {
                for (int j = 0; j < Wert1; j++)
                {
                    Console.Write("*");
                }
                Console.Write(" ");
                for (int j = 0;j < Wert2; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
                Wert1++;
                Wert2--;            
            }
        }
    }
}
