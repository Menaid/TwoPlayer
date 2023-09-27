using TwoPlayer;

Console.WriteLine("Hej! Välkommen till ett spel med sten, sax, påse.");
Console.WriteLine("Välj om du/ni vill spela 1 spelare eller 2 spelare.");

spelare spelare1 = null;
spelare spelare2 = null;

string val = string.Empty;

bool alternativ = true;
while (alternativ)
{
    val = Console.ReadLine();
    if (val == "1" || val == "2")
    {
        alternativ = false;
    }
    else
    {
        Console.WriteLine("Ange antigen en 1:a eller 2:a.");
    }

}

bool OneOrTwo = true; ;
bool pve = true;

while (true)
{

    while (OneOrTwo)
    {
        if (val == "1")
        {
            Console.WriteLine("Vänligen ange vilket namn spelare 1 har.");
            spelare1 = new spelare(Console.ReadLine());
            spelare2 = new spelare("Botten", true);
        }
        else if (val == "2")
        {
            Console.WriteLine("Vänligen ange vilket namn spelare 1 har.");
            spelare1 = new spelare(Console.ReadLine());
            Console.WriteLine("Vänligen ange nu vilket namn spelare 2 har.");
            spelare2 = new spelare(Console.ReadLine());
            pve = false;
        }
        OneOrTwo = false;
    }

    Random random = new Random();

    var firstRound = random.Next(0, 2);

    spelare firstPlayer = null;
    spelare secondPlayer = null;

    if (firstRound == 1)
    {
        firstPlayer = spelare1;
        secondPlayer = spelare2;
    }
    else
    {
        firstPlayer = spelare2;
        secondPlayer = spelare1;
    }

    Console.WriteLine("Spelare " + firstPlayer.name + " börjar.");


    for (int i = 0; i < 3; i++)
    {
        var drag1 = Drag.påse;
        var drag2 = Drag.påse;

        if (firstPlayer.isBot)
        {
            drag1 = (Drag)random.Next(0, 3);
        }
        else
        {
            while (true)
            {
                Console.WriteLine("Spelare " + firstPlayer.name + " välj ett av alternativen sten, sax, påse.");
                string valDrag = Console.ReadLine().ToLower();
                if (Enum.TryParse<Drag>(valDrag, true, out var parsed))
                {
                    drag1 = parsed;
                    break;
                }
            }

            if (!pve)
            {
                Console.Clear();
            }

        }


        if (secondPlayer.isBot)
        {
            drag2 = (Drag)random.Next(0, 3);
        }
        else
        {

            while (true)
            {
                Console.WriteLine("Spelare " + secondPlayer.name + " välj ett av alternativen sten, sax, påse.");
                string valDrag = Console.ReadLine().ToLower();
                if (Enum.TryParse<Drag>(valDrag, true, out var parsed))
                {
                    drag2 = parsed;
                    break;
                }
            }
            if (!pve)
            {
                Console.Clear();
            }

        }


        if (drag1 == drag2)
        {
            Console.WriteLine("Det blir oavgjort");
        }
        else if (drag1 == Drag.sten && drag2 == Drag.sax)
        {
            firstPlayer.points++;
            Console.WriteLine("Grattis, " + firstPlayer.name + " fick ett poäng");
        }
        else if (drag1 == Drag.sax && drag2 == Drag.påse)
        {
            firstPlayer.points++;
            Console.WriteLine("Grattis, " + firstPlayer.name + " fick ett poäng");
        }
        else if (drag1 == Drag.påse && drag2 == Drag.sten)
        {
            firstPlayer.points++;
            Console.WriteLine("Grattis, " + firstPlayer.name + " fick ett poäng");
        }
        else
        {
            secondPlayer.points++;
            Console.WriteLine("Grattis, " + secondPlayer.name + " fick ett poäng");
        }

    }

    Console.WriteLine("Spelare " + firstPlayer.name + " fick: " + firstPlayer.points);
    Console.WriteLine("Spelare " + secondPlayer.name + " fick: " + secondPlayer.points);

    if (firstPlayer.points > secondPlayer.points)
    {
        Console.WriteLine("Grattis " + firstPlayer.name + " vann.");
    }
    else if (secondPlayer.points > firstPlayer.points)
    {
        Console.WriteLine("Grattis " + secondPlayer.name + " vann.");
    }
    else
    {
        Console.WriteLine("Hepp det blev oavgjort!");
    }

    Console.WriteLine("Vill ni spela igen");
    var spelaIgen = Console.ReadLine().ToLower();
    if (spelaIgen == "ja")
    {
        OneOrTwo = true;
        Console.Clear();
    }
    else
    {
        break;
    }
}