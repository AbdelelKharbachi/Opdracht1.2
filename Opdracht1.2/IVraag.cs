using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1._2
{
    interface IVraag
    {
        string Vraag { set; get; }
        string Antwoord { set; get; }
        int Graad { set; get; }
        string Categorie { set; get; }
    }
}
