# Tuple creation overhead

Im benchmarking was the overhead of creating a Tuple using the class vs struct approach.

```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 11 (10.0.22621.2428/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.402
  [Host]   : .NET 7.0.12 (7.0.1223.47720), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.12 (7.0.1223.47720), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method     | item1 | item2                | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s          | Ratio | Gen0   | Allocated | Alloc Ratio |
|----------- |------ |--------------------- |----------:|----------:|----------:|----------:|----------:|----------:|--------------:|------:|-------:|----------:|------------:|
| ValueTuple | 4     | Random Text          |  2.237 ns |  3.283 ns | 0.1800 ns | 0.1039 ns |  2.049 ns |  2.408 ns | 447,024,823.3 |  0.97 |      - |         - |          NA |
| TupleSruct | 4     | Random Text          |  2.316 ns |  1.218 ns | 0.0668 ns | 0.0386 ns |  2.255 ns |  2.387 ns | 431,777,806.0 |  1.00 |      - |         - |          NA |
| TupleClass | 4     | Random Text          | 11.903 ns | 14.327 ns | 0.7853 ns | 0.4534 ns | 11.261 ns | 12.779 ns |  84,013,149.9 |  5.14 | 0.0051 |      32 B |          NA |
|            |       |                      |           |           |           |           |           |           |               |       |        |           |             |
| ValueTuple | 101   | XXXXXXXXXXXXXXXXXXXX |  2.160 ns |  3.224 ns | 0.1767 ns | 0.1020 ns |  1.992 ns |  2.344 ns | 462,871,199.6 |  0.95 |      - |         - |          NA |
| TupleSruct | 101   | XXXXXXXXXXXXXXXXXXXX |  2.269 ns |  1.808 ns | 0.0991 ns | 0.0572 ns |  2.179 ns |  2.375 ns | 440,809,089.8 |  1.00 |      - |         - |          NA |
| TupleClass | 101   | XXXXXXXXXXXXXXXXXXXX | 11.489 ns |  4.983 ns | 0.2731 ns | 0.1577 ns | 11.224 ns | 11.769 ns |  87,040,880.3 |  5.07 | 0.0051 |      32 B |          NA |
