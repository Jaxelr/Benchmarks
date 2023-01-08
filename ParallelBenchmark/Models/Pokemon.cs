namespace ParallelBenchmark;

public class Pokemon
{
    public Pokemon(string name, string type, string owner)
    {
        Name = name;
        Type = type;
        Owner = owner;
    }

    public string Name { get; set; }
    public string Type { get; set; }
    public string Owner { get; set; }
}
