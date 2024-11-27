namespace RijSchool;

internal class Program
{
    static void Main()
    {
        Program p = new Program();
        p.Run();
    }

    internal void Run()
    {
        Auto auto1 = new Auto()
        {
            automaat = true,
            kenteken = "AA824H",
            KilometerStand = 20567,
            merk = "volkswagen",
        };

        Auto auto2 = new Auto()
        {
            automaat = false,
            kenteken = "KU786G",
            KilometerStand = 65739,
            merk = "volvo"
        };

        RijLeraar rijLeraar = new RijLeraar()
        {
            leeftijd = 30,
            naam = "John Doe",
            zzp = false
        };


        LesPakket lesPakket = new LesPakket()
        {
            automaat = false,
            examenPogingen = 2,
            urenGekocht = 13,
            urenVerbruikt = 9
        };

        TheorieTest theorieTest = new TheorieTest()
        {
            aantalFouten = 1,
            gehaald = true,
            afnameDatum = DateTime.Now
        };

        RijTest rijTest = new RijTest()
        {
            gehaald = true,
            afnameDatum = DateTime.Now,
        };

        Student student1 = new Student()
        {
            naam = "bob",
            leeftijd = 30,
            lesPakket = lesPakket,
            rijleraar = rijLeraar,
            theorieTest = theorieTest,
            rijTest = rijTest
        };

        LesUur lesUur = new LesUur()
        {
            auto = auto1,
            rijleraar = rijLeraar,
            tijd = 1130,
            student = student1
        };
    }
}