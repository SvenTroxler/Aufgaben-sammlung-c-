using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Tannenbaum_zeichnen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Breite des Stammes: ");
            int Breite_Stamm = int.Parse(Console.ReadLine());

            Console.Write("Höhe des Stammes: ");
            int Höhe_Stamm = int.Parse(Console.ReadLine());

            Console.Write("Höhe der Krone: ");
            int Höhe_Krone = int.Parse(Console.ReadLine());

            int Wert1_Krone = 1;
            int Wert2_Krone = Höhe_Krone - 1;

            for (int l = 0; l < Höhe_Krone; l++)
            {

                Zeichne_Abstand_Krone(Wert2_Krone);

                for (int j = 0; j < Wert1_Krone; j++)
                {
                    Console.Write("*");
                }

                Zeichne_Abstand_Krone(Wert2_Krone);

                Wert2_Krone--;
                Wert1_Krone += 2;
                Console.Write("\n");
            }

            int Wert1_Stamm = Höhe_Krone - (Breite_Stamm/2);

            for (int l = 0; l < Höhe_Stamm; l++)
            {
                Zeichne_Abstand_Stamm(Wert1_Stamm);

                for (int j = 0; j < Breite_Stamm; j++)
                {
                    Console.Write("*");
                }

                Zeichne_Abstand_Stamm(Wert1_Stamm);

                Console.Write("\n");
            }

        }
        static void Zeichne_Abstand_Stamm(int Wert1_Stamm)
        {
            for (int j = 0; j < Wert1_Stamm; j++)
            {
                Console.Write(" ");
            }
        }
            static void Zeichne_Abstand_Krone(int Wert2_Krone)
            {
                for (int i = 0; i < Wert2_Krone; i++)
                {
                    Console.Write(" ");
                }
            }
        }
    }
