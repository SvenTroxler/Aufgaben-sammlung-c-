using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Schaltjahr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            while (true)
            {
                
                Console.WriteLine("Prüfen, ob es sich bei einem jahr um ein Schaltjahr handelt");
                Console.Write("Eingabe Jahr (q to quit): ");
                string Eingabe = Console.ReadLine();


                    int Jahr = int.Parse(Eingabe);

                    if (Jahr % 4 == 0 && Jahr > 1582 && Jahr % 100 != 0)
                    {
                        Console.WriteLine("Das Jahr " + Jahr + " ist ein Schaltjahr");
                    }
                    else
                    {
                        Console.WriteLine("Das Jahr " + Jahr + " ist kein Schaltjahr");
                    }
                
            }
        }
        

    }
}
