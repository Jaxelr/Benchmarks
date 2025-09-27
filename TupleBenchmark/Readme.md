# Tuple creation overhead

Im benchmarking was the overhead of creating a Tuple using the class vs struct approach.

```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26200.6584)
Unknown processor
.NET SDK 9.0.305
  [Host]   : .NET 9.0.9 (9.0.925.41916), Arm64 RyuJIT AdvSIMD
  ShortRun : .NET 9.0.9 (9.0.925.41916), Arm64 RyuJIT AdvSIMD

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  RatioSD=?  

```
| Method     | item1 | item2                | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s              | Ratio | Gen0   | Allocated | Alloc Ratio |
|----------- |------ |--------------------- |----------:|----------:|----------:|----------:|----------:|----------:|------------------:|------:|-------:|----------:|------------:|
| ValueTuple | 4     | Random Text          | 0.0025 ns | 0.0792 ns | 0.0043 ns | 0.0025 ns | 0.0000 ns | 0.0075 ns | 399,081,405,421.5 |     ? |      - |         - |           ? |
| TupleSruct | 4     | Random Text          | 0.0768 ns | 1.5999 ns | 0.0877 ns | 0.0506 ns | 0.0000 ns | 0.1723 ns |  13,021,839,552.7 |     ? |      - |         - |           ? |
| TupleClass | 4     | Random Text          | 3.6378 ns | 1.1098 ns | 0.0608 ns | 0.0351 ns | 3.5789 ns | 3.7004 ns |     274,894,083.3 |     ? | 0.0077 |      32 B |           ? |
|            |       |                      |           |           |           |           |           |           |                   |       |        |           |             |
| TupleSruct | 101   | XXXXXXXXXXXXXXXXXXXX | 0.0098 ns | 0.3084 ns | 0.0169 ns | 0.0098 ns | 0.0000 ns | 0.0293 ns | 102,468,665,805.7 |     ? |      - |         - |           ? |
| ValueTuple | 101   | XXXXXXXXXXXXXXXXXXXX | 0.0172 ns | 0.5428 ns | 0.0298 ns | 0.0172 ns | 0.0000 ns | 0.0515 ns |  58,217,162,685.8 |     ? |      - |         - |           ? |
| TupleClass | 101   | XXXXXXXXXXXXXXXXXXXX | 4.1695 ns | 3.4840 ns | 0.1910 ns | 0.1103 ns | 3.9824 ns | 4.3641 ns |     239,836,203.9 |     ? | 0.0077 |      32 B |           ? |
