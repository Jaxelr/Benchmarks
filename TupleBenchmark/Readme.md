# Tuple creation overhead

Im benchmarking was the overhead of creating a Tuple using the class vs struct approach.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2454)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method     | item1 | item2                | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s            | Ratio | Gen0   | Allocated | Alloc Ratio |
|----------- |------ |--------------------- |----------:|----------:|----------:|----------:|----------:|----------:|----------------:|------:|-------:|----------:|------------:|
| TupleSruct | 4     | Random Text          | 0.7989 ns | 0.0558 ns | 0.0031 ns | 0.0018 ns | 0.7967 ns | 0.8024 ns | 1,251,778,626.1 |  1.00 |      - |         - |          NA |
| ValueTuple | 4     | Random Text          | 0.8651 ns | 1.2891 ns | 0.0707 ns | 0.0408 ns | 0.7944 ns | 0.9357 ns | 1,155,967,652.7 |  1.08 |      - |         - |          NA |
| TupleClass | 4     | Random Text          | 4.2576 ns | 0.7840 ns | 0.0430 ns | 0.0248 ns | 4.2082 ns | 4.2862 ns |   234,873,476.7 |  5.33 | 0.0051 |      32 B |          NA |
|            |       |                      |           |           |           |           |           |           |                 |       |        |           |             |
| ValueTuple | 101   | XXXXXXXXXXXXXXXXXXXX | 0.7873 ns | 0.0666 ns | 0.0036 ns | 0.0021 ns | 0.7834 ns | 0.7906 ns | 1,270,094,746.1 |  0.88 |      - |         - |          NA |
| TupleSruct | 101   | XXXXXXXXXXXXXXXXXXXX | 0.8988 ns | 0.6715 ns | 0.0368 ns | 0.0212 ns | 0.8679 ns | 0.9395 ns | 1,112,590,518.0 |  1.00 |      - |         - |          NA |
| TupleClass | 101   | XXXXXXXXXXXXXXXXXXXX | 3.8854 ns | 2.4550 ns | 0.1346 ns | 0.0777 ns | 3.7722 ns | 4.0341 ns |   257,375,712.8 |  4.33 | 0.0051 |      32 B |          NA |
