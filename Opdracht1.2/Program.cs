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
            Open vr1 = new Open()
            {
                Vraag = "Wat is een purnie?",
                Antwoord = "Purnie",
                Categorie = "mens en natuur"
            };

            Open vr2 = new Open()
            {
                Vraag = "Wat is de naam van Jan?",
                Antwoord = "Jan",
                Categorie = "mens en natuur"
            };

            Open vr3 = new Open()
            {
                Vraag = "Wie is de president van amerika",
                Antwoord = "Donald Trump",
                Categorie = "Politiek"
            };

            Quiz quiz = new Quiz();
            quiz.AddVraag(vr1);
            quiz.AddVraag(vr2);
            quiz.AddVraag(vr3);

            string input;
            for (int i = 0; i < quiz.GetVragen().Count; i++)
            {
                quiz.ToonVraag(quiz.GetVragen().ElementAt(i));
                input = Console.ReadLine();
                if (input.Equals(quiz.GetVragen().ElementAt(i).Antwoord))
                {
                    Console.WriteLine("Goed.");
                }
                else
                {
                    Console.WriteLine("Fout.");
                }
            }
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