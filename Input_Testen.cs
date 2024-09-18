using System.Linq.Expressions;
using System.Numerics;
void Calculatie1()
{
    //variablen gereed maken voor in de loop
    string Antwoord_getal1 = "";
    string Antwoord_getal2 = "";

    while (9 < 10) { 
        // Gebruiken vragen voor cijfers die berekend moet worden.
        Console.WriteLine("Voer een getal 1 in: ");
        Antwoord_getal1 = Console.ReadLine();
        Console.Clear();


        Console.WriteLine("Voer een getal 2 in: ");
        Antwoord_getal2 = Console.ReadLine();
        Console.Clear();


    // controlleren als gebruikt geen string invoert maar een double 

    
   
        if (double.TryParse(Antwoord_getal1, out double controle_resultaat) && double.TryParse(Antwoord_getal2, out double Controle_resultaat2))
        {
            break;
        }

        else
        {
            Console.WriteLine("Voer cijfers in! ");
            continue;
        }

    }
//Cijfers converteren naar double
    double Getal1 = Convert.ToDouble(Antwoord_getal1);
    double Getal2 = Convert.ToDouble(Antwoord_getal2);
    

    

    

    //De gebruiker laten kiezen al er opgeteld,afgetrokken,gedeeld of vermeningvuldigt moet worden

    double Antwoord_berekening = 0;

    bool loop = true;
    while (loop == true)
    {


        Console.WriteLine("Kies uit [Optellen (O),aftrekken(A),vermeningvuldigen (V) of delen (D)]");
        string antwoord_calculatie = Console.ReadLine();

        switch (antwoord_calculatie)
        {
            case "O" or "o":

                Antwoord_berekening = Getal1 + Getal2;
                Console.WriteLine("Het antwoord is: " + Antwoord_berekening);
                Thread.Sleep(5000);
                Console.Clear();
                loop = false;
                break;



            case "A" or "a":

                Antwoord_berekening = Getal1 - Getal2;
                Console.WriteLine("Het antwoord is: " + Antwoord_berekening);
                Thread.Sleep(5000);
                Console.Clear();
                loop = false;

                break;

            case "V" or "v":

                Antwoord_berekening = Getal1 * Getal2;
                Console.WriteLine("Het antwoord is: " + Antwoord_berekening);
                Thread.Sleep(5000);
                Console.Clear();
                loop = false;
                break;

            case "D" or "d":

                Antwoord_berekening = Getal1 / Getal2;
                Console.WriteLine("Het antwoord is: " + Antwoord_berekening);
                Thread.Sleep(5000);
                Console.Clear();
                loop = false;
                break;

            default:
                Console.WriteLine("Voer O A V of D in! ");
                loop = true;

                break;




        }
    }

    bool loop2 = true;
    while (loop2 == true)
    {
        //gebruikere laten kiezen als het programma vervolgd moet worden of gesloten moet worden
        Console.WriteLine("Wilt u een nieuwe berekening uitvoeren of verder gaan met de huidige? (N/H) \n Of wilt u het programma sluiten? (E) ");
        string Antwoord_herhalen = Console.ReadLine();

        if (Antwoord_herhalen == "N")
        {
            Console.Clear();
            Calculatie1();

        }

        else if (Antwoord_herhalen == "H")
        {
            Console.Clear();
            Calculatie2(Antwoord_berekening);

        }

        else if (Antwoord_herhalen == "E")
        {
            System.Environment.Exit(0);

        }

        else
        {
            Console.Clear();
            Console.WriteLine("Voer N,H of E in! ");
            loop2 = true;
        }
    }
}

//functie activeren
Calculatie1();



//Programma opnieuw uitvoeren
void Calculatie2(double Antwoord_berekening)
{
    //variable gereed maken voor loop
    string Antwoord_getal2 = "";


    while (9 < 10)
    {
        Console.WriteLine("Voer een getal 2 in: ");
        Antwoord_getal2 = Console.ReadLine();
        Console.Clear();
        
        //controlleren als gebruiker een cijfers heeft ingevoerd
        if (double.TryParse(Antwoord_getal2, out double controle_resultaat))
        {
            break;
        }

        else
        {
            Console.WriteLine("Voer cijfers in! ");
            continue;
        }
    }

    //antwoorden van gebruiker van string naar double converteren

    double getal1 = Convert.ToDouble(Antwoord_berekening);
    double getal2 = Convert.ToDouble(Antwoord_getal2);
    double Antwoord_calculatie2 = 0;

    bool Loop3 = true;

    // gebruiker laten keizen hoe de cijers berekent moeten worden.
    while (Loop3 == true)
    {

        Console.WriteLine("Kies uit [Optellen (O),aftrekken(A),vermeningvuldigen (V) of delen (D)]");
        string gebruikerinput2 = Console.ReadLine();


        switch (gebruikerinput2)
        {
            case "O" or "o":

                Antwoord_calculatie2 = getal1 + getal2;
                Console.WriteLine("Het antwoord is: " + Antwoord_calculatie2);
                Thread.Sleep(5000);
                Console.Clear();
                Loop3 = false;

                break;

            case "A" or "a":

                Antwoord_calculatie2 = getal1 - getal2;
                Console.WriteLine("Het antwoord is: " + Antwoord_calculatie2);
                Thread.Sleep(5000);
                Console.Clear();
                Loop3 = false;

                break;

            case "V" or "v":

                Antwoord_calculatie2 = getal1 * getal2;
                Console.WriteLine("Het antwoord is: " + Antwoord_calculatie2);
                Thread.Sleep(5000);
                Console.Clear();
                Loop3 = false;
                break;

            case "D" or "d":

                Antwoord_calculatie2 = getal1 / getal2;
                Console.WriteLine("Het antwoord is: " + Antwoord_calculatie2);
                Thread.Sleep(5000);
                Console.Clear();
                Loop3 = false;
                break;

            default:
                Console.WriteLine("Voer O,A,V,D in! ");
                Loop3 = true;
                break;
        }
    }

    //geburiker laten kiezen om met de huidgie calculatie door te gaan/een niewe te starten of het programma te sluiten

    Console.WriteLine("Wilt u een nieuwe berekening uitvoeren of verder gaan met de huidige? (N/H) \n Of wilt u het programma sluiten? (E) ");
    string Antwoord_herhalen = Console.ReadLine();

    if (Antwoord_herhalen == "N")
    {
        Console.Clear();
        Calculatie1();

    }

    else if (Antwoord_herhalen == "H")
    {
        Console.Clear();
        Calculatie2(Antwoord_calculatie2);

    }

    else if (Antwoord_herhalen == "E")
    {
        System.Environment.Exit(0);
    }

    else
    {
        Console.Clear();
        Console.WriteLine("Voer N,H of E in! ");
    }
}



















