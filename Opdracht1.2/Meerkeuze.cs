using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1._2
{
    class Meerkeuze : IVraag
    {
        private string vraag;
        private string categorie;


        public string Vraag { set; get; }


        public string Antwoord { set; get; }


        public int Graad { set; get; }


        public string Categorie { set; get; }

        public override string ToString()
        {
            return Vraag;
        }
    }
}
