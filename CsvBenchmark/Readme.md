# Csv sample benchmarks

This is a benchmark run displaying how much time it would take to generate a csv using sample list data on multiple sizes.

```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 11 (10.0.22621.2428/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.403
  [Host]   : .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method      | examples             | Mean        | Error       | StdDev      | StdErr      | Min         | Max         | Op/s   | Gen0        | Gen1      | Gen2      | Allocated  |
|------------ |--------------------- |------------:|------------:|------------:|------------:|------------:|------------:|-------:|------------:|----------:|----------:|-----------:|
| GenerateCsv | Syste(...)mple] [55] |    126.6 ms |    111.3 ms |     6.10 ms |     3.52 ms |    119.6 ms |    131.1 ms | 7.9017 |   4000.0000 |         - |         - |   25.49 MB |
| GenerateCsv | Syste(...)mple] [55] |  8,872.1 ms |  4,780.1 ms |   262.01 ms |   151.27 ms |  8,573.7 ms |  9,064.4 ms | 0.1127 | 288000.0000 |         - |         - |  2400.3 MB |
| GenerateCsv | Syste(...)mple] [55] | 34,263.1 ms | 68,644.2 ms | 3,762.62 ms | 2,172.35 ms | 30,325.4 ms | 37,822.0 ms | 0.0292 | 294000.0000 | 5000.0000 | 1000.0000 | 9568.94 MB |
