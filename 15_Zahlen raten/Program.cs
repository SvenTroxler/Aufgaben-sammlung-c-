using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Zahlen_raten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zahl zwischen 1-100:");

            string Antwort = "";

            int Eingabe = int.Parse(Console.ReadLine());

            Random random = new Random();
            int Rnd_Num = random.Next(1, 100);
            do
            {
                if (Antwort.ToLower() == "y")
                {
                    Console.WriteLine("Zahl zwischen 1-100:");
                    Eingabe = int.Parse(Console.ReadLine());

                  
                    Rnd_Num = random.Next(1, 100);
                }

                while (Eingabe != Rnd_Num)
                {
                    if (Eingabe < Rnd_Num)
                    {
                        Console.WriteLine("Zu tief: ");
                        Eingabe = int.Parse(Console.ReadLine());
                    }
                    if (Eingabe > Rnd_Num)
                    {
                        Console.WriteLine("Zu hoch: ");
                        Eingabe = int.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("Du hast es geschafft! Nochmal? [y/n]");
                Antwort = Console.ReadLine();
                if (Antwort.ToLower() == "n")
                {
                    break;
                }
            }
            while (true);





        }
    }
}
