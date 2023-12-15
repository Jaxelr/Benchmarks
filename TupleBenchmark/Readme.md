# Tuple creation overhead

Im benchmarking was the overhead of creating a Tuple using the class vs struct approach.

```

BenchmarkDotNet v0.13.10, Windows 11 (10.0.22621.2861/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method     | item1 | item2                | Mean     | Error     | StdDev    | StdErr    | Min      | Max      | Op/s          | Ratio | Gen0   | Allocated | Alloc Ratio |
|----------- |------ |--------------------- |---------:|----------:|----------:|----------:|---------:|---------:|--------------:|------:|-------:|----------:|------------:|
| TupleSruct | 4     | Random Text          | 1.287 ns | 0.0713 ns | 0.0039 ns | 0.0023 ns | 1.283 ns | 1.290 ns | 776,815,044.9 |  1.00 |      - |         - |          NA |
| ValueTuple | 4     | Random Text          | 1.309 ns | 0.3005 ns | 0.0165 ns | 0.0095 ns | 1.292 ns | 1.325 ns | 763,659,219.7 |  1.02 |      - |         - |          NA |
| TupleClass | 4     | Random Text          | 5.117 ns | 3.4852 ns | 0.1910 ns | 0.1103 ns | 4.896 ns | 5.232 ns | 195,432,475.6 |  3.98 | 0.0051 |      32 B |          NA |
|            |       |                      |          |           |           |           |          |          |               |       |        |           |             |
| TupleSruct | 101   | XXXXXXXXXXXXXXXXXXXX | 1.321 ns | 0.3117 ns | 0.0171 ns | 0.0099 ns | 1.303 ns | 1.338 ns | 757,094,229.0 |  1.00 |      - |         - |          NA |
| ValueTuple | 101   | XXXXXXXXXXXXXXXXXXXX | 1.335 ns | 0.2697 ns | 0.0148 ns | 0.0085 ns | 1.321 ns | 1.351 ns | 749,085,062.1 |  1.01 |      - |         - |          NA |
| TupleClass | 101   | XXXXXXXXXXXXXXXXXXXX | 4.759 ns | 4.9057 ns | 0.2689 ns | 0.1552 ns | 4.559 ns | 5.065 ns | 210,114,384.5 |  3.60 | 0.0051 |      32 B |          NA |
