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

            Console.WriteLine(quiz);

            Console.ReadLine();
            

        }
    }
}