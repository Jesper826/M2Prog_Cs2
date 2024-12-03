using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructers
{
    class Quiz
    {
        internal QuizVraag[] vragen;
        internal QuizVraagAntwoord[] IngevuldeAntwoorden;
        internal Quiz(int aantalVragen)
        {
            vragen = new QuizVraag[aantalVragen];
            IngevuldeAntwoorden = new QuizVraagAntwoord[aantalVragen];
        }
    }
}
