﻿using TwoPlayer;

Console.WriteLine("Hej! Välkommen till ett spel med sten, sax, påse.");
Console.WriteLine("Välj om du/ni vill spela 1 spelare eller 2 spelare.");

spelare spelare1 = null;
spelare spelare2 = null;

string val = string.Empty;
string drag1 = string.Empty;
string drag2 = string.Empty;
int points1 = 0;
int points2 = 0;

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

while (OneOrTwo)
{
    if (val == "1")
    {
        Console.WriteLine("Vänligen ange vilket namn spelare 1 har.");
        spelare1 = new spelare(Console.ReadLine());
        spelare2 = new spelare("Bot", true);
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



for (int i = 0; i < 3; i++)
{


    if (firstPlayer.isBot)
    {
        var drag = (Drag)random.Next(0, 3);
    }
    else
    {
        Console.WriteLine("Välj ett av alternativen sten, sax, påse.");
        string valDrag = Console.ReadLine();
    }
}
Console.WriteLine("Spelare " + firstPlayer.name + " börjar.");