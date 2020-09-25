using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Schema;

namespace Raktar
{
    class megrendeles
    {
        private string datum;

        public string Datum
        {
            get { return datum; }
            set { datum = value; }
        }

        private string kod;

        public string Kod
        {
            get { return kod; }
            set { kod = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public megrendeles(string datum, string kod, string email)
        {
            this.datum = datum;
            this.kod = kod;
            this.email = email;
        }

    }
}
