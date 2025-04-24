# Tuple creation overhead

Im benchmarking was the overhead of creating a Tuple using the class vs struct approach.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3775)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.203
  [Host]   : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method     | item1 | item2                | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s            | Ratio | Gen0   | Allocated | Alloc Ratio |
|----------- |------ |--------------------- |----------:|----------:|----------:|----------:|----------:|----------:|----------------:|------:|-------:|----------:|------------:|
| ValueTuple | 4     | Random Text          | 0.8176 ns | 0.3899 ns | 0.0214 ns | 0.0123 ns | 0.7940 ns | 0.8356 ns | 1,223,125,761.0 |  0.96 |      - |         - |          NA |
| TupleSruct | 4     | Random Text          | 0.8526 ns | 0.1523 ns | 0.0084 ns | 0.0048 ns | 0.8446 ns | 0.8613 ns | 1,172,943,095.3 |  1.00 |      - |         - |          NA |
| TupleClass | 4     | Random Text          | 4.0364 ns | 0.4300 ns | 0.0236 ns | 0.0136 ns | 4.0119 ns | 4.0589 ns |   247,745,228.0 |  4.73 | 0.0051 |      32 B |          NA |
|            |       |                      |           |           |           |           |           |           |                 |       |        |           |             |
| TupleSruct | 101   | XXXXXXXXXXXXXXXXXXXX | 0.7880 ns | 0.2354 ns | 0.0129 ns | 0.0075 ns | 0.7732 ns | 0.7967 ns | 1,269,014,771.4 |  1.00 |      - |         - |          NA |
| ValueTuple | 101   | XXXXXXXXXXXXXXXXXXXX | 0.8059 ns | 0.0825 ns | 0.0045 ns | 0.0026 ns | 0.8008 ns | 0.8096 ns | 1,240,899,604.3 |  1.02 |      - |         - |          NA |
| TupleClass | 101   | XXXXXXXXXXXXXXXXXXXX | 3.5211 ns | 1.0955 ns | 0.0600 ns | 0.0347 ns | 3.4675 ns | 3.5860 ns |   283,998,177.5 |  4.47 | 0.0051 |      32 B |          NA |
