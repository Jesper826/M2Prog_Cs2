using System.Net.Http.Headers;

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
    }
    Auto auto1 = new Auto()
    {
        automaat = true,
        kenteken = "AA824H",
        KilometerStand = 20567,
        merk = "volvo",
    };

    RijLeraar rijLeraar = new RijLeraar()
    {
        leeftijd = 30,
        naam = "HENK",
        zzp = false
    };

    LesUur lesUur = new LesUur() {
        auto = auto1,
        rijleraar = rijLeraar,

        tijd = 1130
    };

    Student student = new Student()
    {
        naam = "Jan",
        leeftijd = 18,
        lesPakket = 1,
        rijTest = RijTest,
    };

    Student student2 = new Student()
    {
        naam = "Sara",
        leeftijd = 20,
        lesPakket = 3,
        rijTest = 3,
    };

    Dag dag = new Dag()
    {
        Datum = DateTime.Now,
    };
    