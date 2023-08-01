using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_pojištění___zjednodušená_verze
{
    internal class Pojistenec
    {
        public string jmeno {get;private set; }
        public string prijimeni { get; private set; }
        public string vek { get; private set; }
        public string telefon { get; private set; }
        public Pojistenec(string jmeno, string prijimeni, string vek, string telefon)
        {
            this.jmeno = jmeno;
            this.prijimeni = prijimeni;
            this.vek = vek;
            this.telefon = telefon;
        }

        public override string ToString()
        {
         return $"{jmeno}      {prijimeni}      {vek}      {telefon}";
        }
    }
}
