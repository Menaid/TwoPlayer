using TwoPlayer;

Console.WriteLine("Hej! Välkommen till ett spel med sten, sax, påse.");
Console.WriteLine("Välj om du/ni vill spela 1 spelare eller 2 spelare.");

string val = Console.ReadLine();
var Random random1 = new Random();

while (val != "1" || val != "2")
{
    Console.WriteLine("Fel inmatning, ange antigen 1 eller 2.");
}

while (val == "1" || val == "2")
{
    Console.WriteLine("Vänligen ange vilket namn spelare 1 har.");
   var spelare1 = Console.ReadLine();
    Console.WriteLine("Vänligen ange nu vilket namn spelare 2 har.");
    var spelare2 = Console.ReadLine();
}

List<string> antalSpelare = new List<string>();

string singelplayer = "1";
string multiplayer = "2";


spelare spelare1 = new spelare();
spelare spelare2 = new spelare();

spelare1.namm = Console.ReadLine();
spelare2.namm = Console.ReadLine();

Random random = new Random();

int firstRound = 0;
bool on = true;

firstRound = random.Next(0, 2);

while (on)
{

    if (firstRound == 0)
    {
        Console.WriteLine("Spelare 1 börjar");
    }
    else
    {
        Console.WriteLine("Spelare 2 börjar");
    }

    on = true;
}
