
Tamagothci tama = new();

while (tama.GetAlive())
{

    tama.tick();

    tama.PrintStats();

    Console.WriteLine("What do you want to do?");
    Console.WriteLine("1. Feed");
    Console.WriteLine("2. Say hi to ");
    Console.WriteLine("3. Teach word  ");

    String thing = Console.ReadLine();

    if (thing == "Feed")
    {
        tama.Feed();
    }

    if (thing == "hi")
    {
        tama.Hi();
    }

    if (thing == "teach")
        {
            tama.Teach();
    
        }

    Console.ReadLine();
}

Console.ReadLine();

