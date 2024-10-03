using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Kleines_1x1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Wert1 = 0;
            int Wert2 = 0;

            for (int i = 0; i < 10; i++)
            {
                Wert1++;
                for (int n = 0; n < 10; n++)
                {
                    Wert2++;
                    Console.Write(Wert1 * Wert2 + "\t");
                }
                Console.Write("\n");
                Wert2 = 0;

            }
        }
    }
}
