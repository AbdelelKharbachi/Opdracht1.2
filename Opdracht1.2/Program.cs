using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Open vr1 = new Open("Wat is een purnie?", "Een purnie", "mens en natuur", 1);
            
            Quiz quiz = new Quiz();
            quiz.AddVraag(vr1);


            quiz.ToonVraag();

            Console.ReadLine();
        }
    }
}


/*
Meerkeuze mk1 = new Meerkeuze()
{
    Vraag = "Hoeveel autisten zitten er in onze klas?",
    Categorie = "School",
    Graad = 1
};
mk1.AddChoice("1", false);
mk1.AddChoice("2", false);
mk1.AddChoice("3", false);
mk1.AddChoice("25", true);
*/