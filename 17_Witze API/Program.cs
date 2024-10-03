using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace _17_Witze_API
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            do
            {
                string witz = ReturnJoke();

                Console.WriteLine(witz);
                Console.WriteLine("Noch einen?[y/n]");
                string Antwort = Console.ReadLine();
                if (Antwort.ToLower() == "n")
                {
                    break;
                }
            }
            while (true);
        }
        static string ReturnJoke()
        {
            WebRequest request = WebRequest.Create("https://witzapi.de/api/joke/");

            WebResponse response = request.GetResponse();

            StreamReader sr = new StreamReader(response.GetResponseStream());
            string json = sr.ReadToEnd().ToString();

            JArray array = JArray.Parse(json);
            return array[0]["text"].ToString();

        }
    }
}
