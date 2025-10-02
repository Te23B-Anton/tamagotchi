
public class Tamagothci
{
    private int _hunger = Random.Shared.Next(3);

    private int _boredom;

    public string Name;


    public bool _IsAlive;

    private int Hp = 10;

   private List<string> words = [];


    // public Tamagothci()
    // {
    // List<string> names = ["Elis"];
    // int i = Random.Shared.Next(names.Count);
    // Name = names[i];


    // }

    public void Feed()
    {
        _hunger -= 2;
    }

    public void Hi()
    {
        
        int i = Random.Shared.Next(words.Count);

        Console.WriteLine(words[i]);

        ReduceBoredom();

    }
    public void Teach()
    {
         Console.WriteLine($"Vad vill du lära {Name}");
        string word = Console.ReadLine() ?? string.Empty;
        words.Add(word);

        Console.WriteLine($"{Name} Lärde sig {word}");



        ReduceBoredom();
    }

    public void tick()
    {
        _boredom++;
        _hunger++;
        
        if (_hunger > 10 || _boredom > 10)
        {
            Hp -= 10;
        }


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
        _boredom -=2;
    }
}
