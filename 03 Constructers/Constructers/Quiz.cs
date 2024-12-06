using Constructers;

namespace Constructors;

public class Quiz
{
    internal QuizVraag[] vragen;
    internal QuizVraagAntwoord[] ingevuldeAntwoorden;
    internal int score;

    internal Quiz(int aantalVragen)
    {
        vragen = new QuizVraag[aantalVragen];
        ingevuldeAntwoorden = new QuizVraagAntwoord[aantalVragen];
    }

    internal void VoegVraagToeOpIndex(int index, QuizVraag vraag)
    {
        vragen[index] = vraag;
    }

    internal void StelVraag(int index)
    {
        QuizVraag vraag = vragen[index];
        QuizVraagAntwoord quizVraagAntwoord = new QuizVraagAntwoord(vraag);

        Console.WriteLine(vraag.vraag);

        if (Console.ReadLine().ToLower() == vraag.antwoord.ToLower())
        {
            quizVraagAntwoord.goed = true;
            Console.WriteLine("goed");
            Score(1);
        }
        else
        {
            quizVraagAntwoord.goed = false;
            Console.WriteLine("fout");
        }
    }

    internal void Score(int add)
    {
        score += add;
    }
}