using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace ParallelBenchmark;

[BenchmarkCategory("Parallel Foreach")]
[AllStatisticsColumn]
[HideColumns("Q1", "Q3", "Median", "RatioSD")]
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
