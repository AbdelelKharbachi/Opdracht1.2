using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1._2
{
    class Meerkeuze : IVraag
    {
        private Dictionary<string,bool> Antwoorden = new Dictionary<string, bool>();

        public Meerkeuze(string vraag, string categorie, int graad)
        {
            Vraag = vraag;
            Categorie = categorie;
            Graad = graad;
        }

        public Meerkeuze() { }

        public string Vraag { set; get; }


        public string Antwoord { set; get; }


        public int Graad { set; get; }


        public string Categorie { set; get; }

        public void AddChoice(string antwoord, bool goed)
        {
            Antwoorden.Add(antwoord, goed);
        }

        public override string ToString()
        {
            return Vraag;
        }
    }
}