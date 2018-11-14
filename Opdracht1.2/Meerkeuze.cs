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

        public string Vraag()
        {
            throw new NotImplementedException();
        }

        public string Antwoord()
        {
            throw new NotImplementedException();
        }

        public int Graad()
        {
            throw new NotImplementedException();
        }

        public string Categorie()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return vraag;
        }
    }
}
