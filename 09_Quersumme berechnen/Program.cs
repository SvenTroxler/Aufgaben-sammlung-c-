using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Quersumme_berechnen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = BerechneQuersumme(78);
            Console.WriteLine(sum);
            Console.ReadLine();
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
