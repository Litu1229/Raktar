using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Remoting.Messaging;

namespace Raktar
{
    class termek
    {
            private string kod;


            public string Kod
            {
                get { return kod; }
                set { kod = value; }
            }
            private string nev;
            public string Nev
            {
                get { return nev; }
                set { nev = value; }
            }
            private int ar;

            public int Ar
            {
                get { return ar; }
                set { ar = value; }
            }
            private int db;
            public int DB
            {
                get { return db; }
                set { db = value; }
            }

        

        public string Alakit(string szoveg)
        {
        string ekezetes = "áéíúüűöőó";
        string mire = "aeiuuuooo";
        string tmp = "";
        //string szo = "árvíztűrőtükörfúrógép";
            for (int i = 0; i < szoveg.Length; i++)
            {
                int hol = ekezetes.IndexOf(szoveg[i]);
                if (hol > -1)
                {
                    tmp += mire[hol];
                }
                else
                {
                    tmp += szoveg[i];
                }
            }
            //Console.WriteLine(tmp);
            return tmp;
         }

            public termek(string kod, string nev, int ar, int db)
            {
                this.kod = kod;
                this.nev = Alakit(nev);
                this.ar = ar;
                this.db = db;
            }
        }
    }


