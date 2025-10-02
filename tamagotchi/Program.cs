
Tamagothci tama = new();

Console.WriteLine("What is your tamas name?");
tama.Name = Console.ReadLine();

while (tama.GetAlive())
{

    tama.tick();

    tama.PrintStats();

    Console.WriteLine("What do you want to do?");
    Console.WriteLine($"1. Feed {tama.Name}");
    Console.WriteLine($"2. Say hi to {tama.Name}");
    Console.WriteLine($"3. Teach {tama.Name} a word  ");

    String thing = Console.ReadLine();

    if (thing == "1")
    {
        tama.Feed();
    }

    if (thing == "2")
    {
        tama.Hi();
    }

    if (thing == "3")
    {
        tama.Teach();

    }

}

Console.WriteLine($"{tama.Name} is Dead!");
Console.ReadLine();




