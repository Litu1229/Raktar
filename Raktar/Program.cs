using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Raktar
{
    class Program
    {

        static void beolvasraktar()
        {
            StreamReader raktar = new StreamReader("raktar.csv");
            while (!raktar.EndOfStream)
            {
                string[] sor = raktar.ReadLine().Split(';');
            }
            raktar.Close();
        }
        static void Main(string[] args)
        {
            //termek t = new termek("P01", "Póló XXL", 1500, 10);
            //Console.WriteLine($"{t.Kod}- {t.Nev}- {t.Ar}- {t.DB}";
            Console.ReadKey();
        }
    }
}
