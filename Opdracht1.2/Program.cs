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
                Categorie = "Open"
            };

            Open vr2 = new Open()
            {
                Vraag = "Wat is de naam van Jan?",
                Antwoord = "Jan",
                Categorie = "Open"
            };

            Open vr3 = new Open()
            {
                Vraag = "Hoe schrijf je patat",
                Antwoord = "patat",
                Categorie = "Open"
            };

            Meerkeuze mk1 = new Meerkeuze()
            {
                Vraag = "Wie is de president van amerika",
                Categorie = "Meerkeuze"
            };
            mk1.AddChoice("Trump");
            mk1.AddChoice("Kaas");
            mk1.AddChoice("Pepernoot");
            mk1.AddChoice("Suikerspin");

            Quiz quiz = new Quiz();
            quiz.AddVraag(vr1);
            quiz.AddVraag(vr2);
            quiz.AddVraag(vr3);

            quiz.AddVraag(mk1);

            string input;
            
            for (int i = 0; i < quiz.GetVragen().Count; i++)
            {
                quiz.ToonVraag(quiz.GetVragen().ElementAt(i));
                if (quiz.GetVragen().ElementAt(i).Categorie.Equals("Meerkeuze"))
                {
                    quiz.GetVragen().ElementAt(i).ToonChoices(quiz.GetVragen().ElementAt(i).GetChoices());
                }
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
        }
    }
}