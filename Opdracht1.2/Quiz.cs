using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1._2
{
    class Quiz
    {
        public List<IVraag> quiz = new List<IVraag>();

        public void ToonVraag(IVraag v)
        {
            Console.WriteLine(v);
        }

        public void AddVraag(IVraag v)
        {
            quiz.Add(v);
        }
        
    }
}
