# Tuple creation overhead

Im benchmarking was the overhead of creating a Tuple using the class vs struct approach.

```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.4946/24H2/2024Update/HudsonValley)
Unknown processor
.NET SDK 9.0.304
  [Host]   : .NET 9.0.8 (9.0.825.36511), Arm64 RyuJIT AdvSIMD
  ShortRun : .NET 9.0.8 (9.0.825.36511), Arm64 RyuJIT AdvSIMD

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  RatioSD=?  

```
| Method     | item1 | item2                | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s              | Ratio | Gen0   | Allocated | Alloc Ratio |
|----------- |------ |--------------------- |----------:|----------:|----------:|----------:|----------:|----------:|------------------:|------:|-------:|----------:|------------:|
| TupleSruct | 4     | Random Text          | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |          Infinity |     ? |      - |         - |           ? |
| ValueTuple | 4     | Random Text          | 0.0026 ns | 0.0835 ns | 0.0046 ns | 0.0026 ns | 0.0000 ns | 0.0079 ns | 378,575,765,325.3 |     ? |      - |         - |           ? |
| TupleClass | 4     | Random Text          | 3.3153 ns | 5.5213 ns | 0.3026 ns | 0.1747 ns | 3.0952 ns | 3.6604 ns |     301,632,980.8 |     ? | 0.0077 |      32 B |           ? |
|            |       |                      |           |           |           |           |           |           |                   |       |        |           |             |
| TupleSruct | 101   | XXXXXXXXXXXXXXXXXXXX | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |          Infinity |     ? |      - |         - |           ? |
| ValueTuple | 101   | XXXXXXXXXXXXXXXXXXXX | 0.0115 ns | 0.3644 ns | 0.0200 ns | 0.0115 ns | 0.0000 ns | 0.0346 ns |  86,713,294,713.0 |     ? |      - |         - |           ? |
| TupleClass | 101   | XXXXXXXXXXXXXXXXXXXX | 2.8795 ns | 0.5970 ns | 0.0327 ns | 0.0189 ns | 2.8542 ns | 2.9164 ns |     347,287,978.8 |     ? | 0.0077 |      32 B |           ? |
