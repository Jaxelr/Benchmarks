using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace ParallelBenchmark
{
    [BenchmarkCategory("Parallel Foreach")]
    [MemoryDiagnoser]
    [ShortRunJob]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [MarkdownExporterAttribute.GitHub]
    public class ParallelBenchmark
    {
        [Benchmark]
        public void ParallelForEach() => Parallel.ForEach(Pokemons.OrderBy(p => p.Name), (p) => p.Owner = "Aaron");

        [Benchmark]
        public void AsParallel() => Pokemons.OrderBy(p => p.Name).AsParallel().ForAll(p => p.Owner = "Aaron");

        public List<Pokemon> Pokemons = new()
        {
            new Pokemon("Pikachu", "Electric", "Ash"),
            new Pokemon("Bulbasaur", "Grass", "Ash"),
            new Pokemon("Squirtle", "Water", "Ash"),
            new Pokemon("Charmander", "Fire", "Ash"),
            new Pokemon("Gengar", "Ghost", "Ash"),
            new Pokemon("Snorlax", "Normal", "Ash"),
            new Pokemon("Mew", "Psychic", "Ash"),
        };
    }

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
}
