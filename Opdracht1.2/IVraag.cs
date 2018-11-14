using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1._2
{
    public interface IVraag
    {
        string Vraag();
        string Antwoord();
        int Graad();
        string Categorie();
    }
}
