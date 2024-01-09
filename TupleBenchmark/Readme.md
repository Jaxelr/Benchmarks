# Tuple creation overhead

Im benchmarking was the overhead of creating a Tuple using the class vs struct approach.

```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22621.2861/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method     | item1 | item2                | Mean     | Error     | StdDev    | StdErr    | Min      | Max      | Op/s          | Ratio | Gen0   | Allocated | Alloc Ratio |
|----------- |------ |--------------------- |---------:|----------:|----------:|----------:|---------:|---------:|--------------:|------:|-------:|----------:|------------:|
| ValueTuple | 4     | Random Text          | 1.294 ns | 0.4992 ns | 0.0274 ns | 0.0158 ns | 1.268 ns | 1.323 ns | 772,568,618.3 |  1.00 |      - |         - |          NA |
| TupleSruct | 4     | Random Text          | 1.300 ns | 0.0695 ns | 0.0038 ns | 0.0022 ns | 1.297 ns | 1.305 ns | 769,035,353.9 |  1.00 |      - |         - |          NA |
| TupleClass | 4     | Random Text          | 4.183 ns | 3.3587 ns | 0.1841 ns | 0.1063 ns | 4.044 ns | 4.392 ns | 239,047,739.6 |  3.22 | 0.0051 |      32 B |          NA |
|            |       |                      |          |           |           |           |          |          |               |       |        |           |             |
| ValueTuple | 101   | XXXXXXXXXXXXXXXXXXXX | 1.335 ns | 0.4487 ns | 0.0246 ns | 0.0142 ns | 1.310 ns | 1.359 ns | 749,149,032.8 |  0.87 |      - |         - |          NA |
| TupleSruct | 101   | XXXXXXXXXXXXXXXXXXXX | 1.546 ns | 3.7323 ns | 0.2046 ns | 0.1181 ns | 1.351 ns | 1.759 ns | 646,929,489.5 |  1.00 |      - |         - |          NA |
| TupleClass | 101   | XXXXXXXXXXXXXXXXXXXX | 4.023 ns | 1.3569 ns | 0.0744 ns | 0.0429 ns | 3.963 ns | 4.106 ns | 248,579,106.1 |  2.64 | 0.0051 |      32 B |          NA |
