Console.WriteLine("Hej! Välkommen till ett spel med sten, sax, påse.");
Console.WriteLine("Välj om du/ni vill spela 1 spelare eller 2 spelare.");

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
//var Random random1 = new Random();
bool OneOrTwo = true; ;

while (OneOrTwo)
{
    if (val == "1")
    {
        Console.WriteLine("Vänligen ange vilket namn spelare 1 har.");
        string spelare1 = Console.ReadLine();
    }
    else if (val == "2")
    {
        Console.WriteLine("Vänligen ange vilket namn spelare 1 har.");
        string spelare1 = Console.ReadLine();
        Console.WriteLine("Vänligen ange nu vilket namn spelare 2 har.");
        string spelare2 = Console.ReadLine();
    }
    OneOrTwo = false;
}

//List<string> antalSpelare = new List<string>();

//string singelplayer = "1";
//string multiplayer = "2";

//Random random = new Random();

//int firstRound = 0;
//bool on = true;

//firstRound = random.Next(0, 2);

//while (on)
//{

//    if (firstRound == 0)
//    {
//        Console.WriteLine("Spelare 1 börjar");
//    }
//    else
//    {
//        Console.WriteLine("Spelare 2 börjar");
//    }

//    on = true;
//}
