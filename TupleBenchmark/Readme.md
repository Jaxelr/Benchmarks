# Tuple creation overhead

Im benchmarking was the overhead of creating a Tuple using the class vs struct approach.

```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.4652/24H2/2024Update/HudsonValley)
Unknown processor
.NET SDK 9.0.302
  [Host]   : .NET 9.0.7 (9.0.725.31616), Arm64 RyuJIT AdvSIMD
  ShortRun : .NET 9.0.7 (9.0.725.31616), Arm64 RyuJIT AdvSIMD

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method     | item1 | item2                | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s              | Ratio     | Gen0   | Allocated | Alloc Ratio |
|----------- |------ |--------------------- |----------:|----------:|----------:|----------:|----------:|----------:|------------------:|----------:|-------:|----------:|------------:|
| ValueTuple | 4     | Random Text          | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |          Infinity |     0.000 |      - |         - |          NA |
| TupleSruct | 4     | Random Text          | 0.0245 ns | 0.2220 ns | 0.0122 ns | 0.0070 ns | 0.0157 ns | 0.0384 ns |  40,833,206,215.4 |     1.154 |      - |         - |          NA |
| TupleClass | 4     | Random Text          | 3.8316 ns | 3.5262 ns | 0.1933 ns | 0.1116 ns | 3.6770 ns | 4.0483 ns |     260,984,741.8 |   180.513 | 0.0077 |      32 B |          NA |
|            |       |                      |           |           |           |           |           |           |                   |           |        |           |             |
| ValueTuple | 101   | XXXXXXXXXXXXXXXXXXXX | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |          Infinity |     0.000 |      - |         - |          NA |
| TupleSruct | 101   | XXXXXXXXXXXXXXXXXXXX | 0.0061 ns | 0.1122 ns | 0.0062 ns | 0.0036 ns | 0.0015 ns | 0.0131 ns | 163,275,286,484.7 |     2.064 |      - |         - |          NA |
| TupleClass | 101   | XXXXXXXXXXXXXXXXXXXX | 3.5176 ns | 1.4791 ns | 0.0811 ns | 0.0468 ns | 3.4381 ns | 3.6001 ns |     284,285,199.2 | 1,185.201 | 0.0077 |      32 B |          NA |
