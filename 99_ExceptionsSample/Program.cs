using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _99_ExceptionsSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            

            try
            {
                Console.Write("DevideBy3", "DevideBy5");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fehler: Datei nicht gefunden." + "\n" + "Fehler-Typ: " + ex.GetType().ToString());
            }
            
        }

        static void DevideBy3(string fileName)
        {
           throw new Exception("Die von dir eingegebene Datei exsistiert nicht: " + fileName);
        }
        static void DevideBy5(string fileName)
        {
            throw new Exception("Die von dir eingegebene Datei exsistiert nicht: " + fileName);
        }
    }
}
