# Parallel Foreach

Benchmark Parallel foreach scenarios [as described on this article](https://aaronbos.dev/posts/parallel-foreach-csharp).

```

BenchmarkDotNet v0.13.7, Windows 11 (10.0.22621.2134/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.400
  [Host]   : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|          Method |     Mean |    Error |   StdDev |   StdErr |      Min |      Max |     Op/s |   Gen0 |   Gen1 | Allocated |
|---------------- |---------:|---------:|---------:|---------:|---------:|---------:|---------:|-------:|-------:|----------:|
| ParallelForEach | 12.69 μs | 11.17 μs | 0.612 μs | 0.354 μs | 12.28 μs | 13.40 μs | 78,796.7 | 1.7548 | 0.0305 |  10.16 KB |
|      AsParallel | 16.57 μs | 14.02 μs | 0.769 μs | 0.444 μs | 15.96 μs | 17.43 μs | 60,348.6 | 1.5259 | 0.0305 |   9.17 KB |
