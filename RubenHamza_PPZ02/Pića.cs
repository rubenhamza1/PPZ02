using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubenHamza_PPZ02
{
    internal class Pića
    {
        string nazivPica;
        int kolicina;
        float pakiranje;
        int cijena;
        int postotakAlkohola;

        public Pića(string nazivPica, int kolicina, float pakiranje, int cijena, int postotakAlkohola)
        {
            this.nazivPica = nazivPica;
            this.kolicina = kolicina;
            this.pakiranje = pakiranje;
            this.cijena = cijena;
            this.postotakAlkohola = postotakAlkohola;
        }

        public string NazivPica { get => nazivPica; set => nazivPica = value; }
        public int Kolicina { get => kolicina; set => kolicina = value; }
        public float Pakiranje { get => pakiranje; set => pakiranje = value; }
        public int Cijena { get => cijena; set => cijena = value; }
        public int PostotakAlkohola { get => postotakAlkohola; set => postotakAlkohola = value; }

        public override string ToString()
        {
            string ispis = "Vrsta pića: Gazirana " + Environment.NewLine + "Naziv pića: " + this.nazivPica +
            Environment.NewLine + "Količina: " + this.kolicina + Environment.NewLine + "Pakiranje: " + this.pakiranje
            + Environment.NewLine + "Cijena: " + this.cijena;
            return ispis;
        }
    }

    class Negazirana 
    {
        string nazivPica;
        int kolicina;
        float pakiranje;
        int cijena;

        public Negazirana(string nazivPica, int kolicina, float pakiranje, int cijena)
        {
            this.nazivPica = nazivPica;
            this.kolicina = kolicina;
            this.pakiranje = pakiranje;
            this.cijena = cijena;
        }

        public string NazivPica { get => nazivPica; set => nazivPica = value; }
        public int Kolicina { get => kolicina; set => kolicina = value; }
        public float Pakiranje { get => pakiranje; set => pakiranje = value; }
        public int Cijena { get => cijena; set => cijena = value; }
    }
      
    class Gazirana
    {
        string nazivPica;
        int kolicina;
        float pakiranje;
        int cijena;

        public Gazirana(string nazivPica, int kolicina, float pakiranje, int cijena, int postotakAlkohola)
        {
            this.nazivPica = nazivPica;
            this.kolicina = kolicina;
            this.pakiranje = pakiranje;
            this.cijena = cijena;

        }

        public string NazivPica { get => nazivPica; set => nazivPica = value; }
        public int Kolicina { get => kolicina; set => kolicina = value; }
        public float Pakiranje { get => pakiranje; set => pakiranje = value; }
        public int Cijena { get => cijena; set => cijena = value; }

        public override string ToString()
        {
            string ispis = "Vrsta pića: Gazirana " + Environment.NewLine + "Naziv pića: " + this.nazivPica +
            Environment.NewLine + "Količina: " + this.kolicina + Environment.NewLine + "Pakiranje: " + this.pakiranje
            + Environment.NewLine + "Cijena: " + this.cijena;
            return ispis;
        }


    }

    class Alkoholna
    {
        string nazivPica;
        int kolicina;
        float pakiranje;
        int cijena;
        int postotakAlkohola;

        public Alkoholna(string nazivPica, int kolicina, float pakiranje, int cijena, int postotakAlkohola)
        {
            this.nazivPica = nazivPica;
            this.kolicina = kolicina;
            this.pakiranje = pakiranje;
            this.cijena = cijena;
            this.postotakAlkohola = postotakAlkohola;
        }

        public string NazivPica { get => nazivPica; set => nazivPica = value; }
        public int Kolicina { get => kolicina; set => kolicina = value; }
        public float Pakiranje { get => pakiranje; set => pakiranje = value; }
        public int Cijena { get => cijena; set => cijena = value; }
        public int PostotakAlkohola { get => postotakAlkohola; set => postotakAlkohola = value; }

        public override string ToString()
        {
             string ispis = "Vrsta pića: Alkoholna " + Environment.NewLine + "Naziv pića: " + this.nazivPica +
             Environment.NewLine + "Količina: " + this.kolicina + Environment.NewLine + "Pakiranje: " + this.pakiranje
             + Environment.NewLine + "Cijena: " + this.cijena + Environment.NewLine + "Postotak alkohola: " + this.postotakAlkohola;
              return ispis;
        }
    }

    
}
