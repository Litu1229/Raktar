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
        static List<termek> termekek = new List<termek>();
        static List<megrendeles> megrendel = new List<megrendeles>();
        static void beolvasraktar()
        {
            StreamReader raktar = new StreamReader("raktar.csv");
            while (!raktar.EndOfStream)
            {
                string[] sor = raktar.ReadLine().Split(';');
                termekek.Add(new termek(sor[0],sor[1],int.Parse(sor[2]),int.Parse(sor[3])));
            }
            raktar.Close();
        }

        static void beolvasrendeles()
        {
            StreamReader rendeles = new StreamReader("rendeles.csv");
            while (!rendeles.EndOfStream)
            {
                string[] sor2 = rendeles.ReadLine().Split(';');
                //megrendel.Add(new megrendeles(sor2[1], sor2[2], sor2[3]));
                if (sor2[0] == "M")
                {
                    megrendel.Add(new megrendeles(sor2[1], sor2[2], sor2[3]));
                }
            }
            rendeles.Close();
        }
        static void Main(string[] args)
        {
            //termek t = new termek("P01", "Póló XXL", 1500, 10);
            //Console.WriteLine($"{t.Kod}- {t.Nev}- {t.Ar}- {t.DB}");
             beolvasraktar();
            beolvasrendeles();
            /*foreach (var t in termekek)
            {
                Console.WriteLine(t.Nev);
            }*/
            foreach (var m in megrendel)
            {
                Console.WriteLine($"{m.Datum} - {m.Email}- {m.Kod}");
            }
            Console.ReadKey();
        }
    }
}
