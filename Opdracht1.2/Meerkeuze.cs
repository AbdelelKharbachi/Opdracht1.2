using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1._2
{
    class Meerkeuze : IVraag
    {
        private List<string> Antwoorden = new List<string>();

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

        public void AddChoice(string antwoord)
        {
            Antwoorden.Add(antwoord);
        }

        public List<string> GetChoices()
        {
            return Antwoorden;
        }

        public void ToonChoices(List<string> choices)
        {
            foreach (string s in choices)
            {
                Console.WriteLine(s);
            }
        }

        public override string ToString()
        {
            return Vraag;
        }
    }
}