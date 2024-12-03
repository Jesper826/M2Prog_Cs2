using Constructers;

namespace Constructors;

internal class Program
{
    Quiz quiz = new Quiz(10);

    static void Main()
    {
        Program p = new Program();
        p.Run();
    }

    internal void Run()
    {
        VoegVraagToeOpIndex(0, "What 1997 N64 video game, features James Bond and is named after the 1995 film?", "GoldenEye");
        VoegVraagToeOpIndex(1, "What arcade game was called Puckman in Japan?", "Pac-Man");
        VoegVraagToeOpIndex(2, "In July 2023, video game company EA announced that players will be able to explore Wakanda in an upcoming open-world video game based on the adventures of what Marvel superhero?", "Black Panther");
        VoegVraagToeOpIndex(3, "Which spooky 2001 GameCube game starring Mario’s brother got a reboot for Nintendo Switch in 2019?", "Luigi's Mansion");
        VoegVraagToeOpIndex(4, "In May 2022, the government of what European nation banned its employees from using American gaming terms such as \"e-sports,\" instead using their domestic language counterparts like \"jeu video de competition?\"", "France");

        VoegVraagToeOpIndex(5, "Regarded as one of the greatest video games of all time, what 1981 arcade game features the titular amphibian trying to cross a road without getting squashed by cars, and a river without getting eaten by predators?", "Frogger");
        VoegVraagToeOpIndex(6, "What is thought to be the first video game, created in 1958 and becoming popular in the 1970s?", "Pong");
        VoegVraagToeOpIndex(7, "What Will Wright created video game series released in 2000 (with sequels in 2004, 2009, and 2014) saw players watching and directing characters to mundane things like eating, sleeping, and cleaning their houses?", "The Sims");
        VoegVraagToeOpIndex(8, "Making his debut in 1990's \"Super Mario World,\" what is the name of the enemy-eating, egg-throwing green dinosaur who serves as a sidekick to Mario and Luigi in the Mario franchise?", "Yoshi");
        VoegVraagToeOpIndex(9, "Which video game console released in 2006 pioneered the use of motion controls in its gameplay?", "Nintendo Wii");

        quiz.StelVraag(0);
        quiz.StelVraag(1);
        quiz.StelVraag(2);
        quiz.StelVraag(3);
        quiz.StelVraag(4);
        quiz.StelVraag(5);
        quiz.StelVraag(6);
        quiz.StelVraag(7);
        quiz.StelVraag(8);
        quiz.StelVraag(9);

        Console.WriteLine("Je score is: " + quiz.score);
    }

    internal void VoegVraagToeOpIndex(int index, string vraag, string antwoord)
    {
        QuizVraag quizVraag = new QuizVraag(vraag, antwoord);
        quiz.VoegVraagToeOpIndex(index, quizVraag);
    }
}