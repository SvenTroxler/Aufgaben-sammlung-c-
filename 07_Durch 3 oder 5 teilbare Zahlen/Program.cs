using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Durch_3_oder_5_teilbare_Zahlen
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int Wert1 = 0;



            for (int n = 0; n < 30; n++)
            {
                Wert1++;

                if (Wert1 % 3 == 0 || Wert1 % 5 == 0)
                {
                    Console.Write(Wert1);

                    if (Wert1 != 30)
                    {
                        Console.Write(", ");
                    }
                }
            }
            
            Console.ReadKey();

        }
    }
}
