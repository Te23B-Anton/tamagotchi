
public class Tamagothci
{
    private int _hunger = Random.Shared.Next(3);

    private int _boredom;

    public string Name;

    private int Hp = 10;

   private List<string> names = ["Elis"];

    // public Tamagothci()
    // {
    // List<string> names = ["Elis"];
    // int i = Random.Shared.Next(names.Count);
    // Name = names[i];


    // }

    public void Feed()
    {
        _hunger--;
    }

    public void Hi()
    {
        
        int i = Random.Shared.Next(names.Count);
        Name = names[i];

        Console.WriteLine(names[i]);

        ReduceBoredom();

    }
    public void Teach()
    {
         Console.WriteLine($"Vad vill du lära Tama");
        string word = Console.ReadLine() ?? string.Empty;
        names.Add(word);

        Console.WriteLine($"Tama Lärde sig {word}");



        ReduceBoredom();
    }

    public void tick()
    {
        _boredom++;
        _hunger++;


    }
    public void PrintStats()
    {
        Console.WriteLine($"Name: {Name}, Boredom: {_boredom}, Hunger: {_hunger}, ");
    }

    private bool IsAlive()
    {
        if (Hp <= 0)
        {
            return false;
        }
        return true;
    }

    public bool GetAlive()
    {
        return IsAlive();
    }

    private void ReduceBoredom()
    {
        _boredom--;
    }
}
