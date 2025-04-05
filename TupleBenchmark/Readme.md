# Tuple creation overhead

Im benchmarking was the overhead of creating a Tuple using the class vs struct approach.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3476)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.201
  [Host]   : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method     | item1 | item2                | Mean      | Error     | StdDev    | StdErr    | Min       | Max       | Op/s          | Ratio | Gen0   | Allocated | Alloc Ratio |
|----------- |------ |--------------------- |----------:|----------:|----------:|----------:|----------:|----------:|--------------:|------:|-------:|----------:|------------:|
| ValueTuple | 4     | Random Text          |  1.513 ns | 0.0263 ns | 0.0014 ns | 0.0008 ns |  1.511 ns |  1.514 ns | 661,110,227.9 |  1.00 |      - |         - |          NA |
| TupleSruct | 4     | Random Text          |  1.514 ns | 0.2146 ns | 0.0118 ns | 0.0068 ns |  1.507 ns |  1.528 ns | 660,329,018.9 |  1.00 |      - |         - |          NA |
| TupleClass | 4     | Random Text          | 10.950 ns | 5.2539 ns | 0.2880 ns | 0.1663 ns | 10.617 ns | 11.120 ns |  91,325,687.4 |  7.23 | 0.0051 |      32 B |          NA |
|            |       |                      |           |           |           |           |           |           |               |       |        |           |             |
| TupleSruct | 101   | XXXXXXXXXXXXXXXXXXXX |  1.511 ns | 0.0337 ns | 0.0018 ns | 0.0011 ns |  1.508 ns |  1.512 ns | 661,998,735.4 |  1.00 |      - |         - |          NA |
| ValueTuple | 101   | XXXXXXXXXXXXXXXXXXXX |  2.011 ns | 3.4252 ns | 0.1877 ns | 0.1084 ns |  1.882 ns |  2.227 ns | 497,175,155.0 |  1.33 |      - |         - |          NA |
| TupleClass | 101   | XXXXXXXXXXXXXXXXXXXX |  4.320 ns | 0.2166 ns | 0.0119 ns | 0.0069 ns |  4.310 ns |  4.333 ns | 231,455,608.3 |  2.86 | 0.0051 |      32 B |          NA |
