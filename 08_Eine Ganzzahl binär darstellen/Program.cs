using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Eine_Ganzzahl_binär_darstellen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bin = "";

            Console.Write("Zahl: ");
            int n = int.Parse(Console.ReadLine());

            while (n != 0) {
                int rest = n % 2;
                bin = bin + rest;
                int wert = n / 2;
                n = wert;
                    }

            Console.Write(bin);
            Console.ReadKey();
        }
    }
}
