using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1._2
{
    class Open : IVraag
    {
        public Open(string vraag, string antwoord, string categorie, int graad)
        {
            Vraag = vraag;
            Antwoord = antwoord;
            Categorie = categorie;
            Graad = graad;
        }
        public Open() { }

        public string Vraag { set; get; }

        public string Antwoord { set; get; }

        public string Categorie { set; get; }

        public int Graad { set; get; }

        public override string ToString()
        {
            return Vraag;
        }
    }
}
