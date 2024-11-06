# Tuple creation overhead

Im benchmarking was the overhead of creating a Tuple using the class vs struct approach.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2033)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method     | item1 | item2                | Mean      | Error      | StdDev    | StdErr    | Min       | Max       | Op/s            | Ratio | Gen0   | Allocated | Alloc Ratio |
|----------- |------ |--------------------- |----------:|-----------:|----------:|----------:|----------:|----------:|----------------:|------:|-------:|----------:|------------:|
| TupleSruct | 4     | Random Text          | 0.8009 ns |  0.0273 ns | 0.0015 ns | 0.0009 ns | 0.7992 ns | 0.8019 ns | 1,248,576,881.7 |  1.00 |      - |         - |          NA |
| ValueTuple | 4     | Random Text          | 0.8115 ns |  0.4271 ns | 0.0234 ns | 0.0135 ns | 0.7932 ns | 0.8378 ns | 1,232,334,763.9 |  1.01 |      - |         - |          NA |
| TupleClass | 4     | Random Text          | 5.0349 ns | 19.2437 ns | 1.0548 ns | 0.6090 ns | 3.8332 ns | 5.8077 ns |   198,613,443.0 |  6.29 | 0.0051 |      32 B |          NA |
|            |       |                      |           |            |           |           |           |           |                 |       |        |           |             |
| ValueTuple | 101   | XXXXXXXXXXXXXXXXXXXX | 0.8009 ns |  0.1906 ns | 0.0104 ns | 0.0060 ns | 0.7928 ns | 0.8127 ns | 1,248,546,296.2 |  0.97 |      - |         - |          NA |
| TupleSruct | 101   | XXXXXXXXXXXXXXXXXXXX | 0.8256 ns |  0.4645 ns | 0.0255 ns | 0.0147 ns | 0.7967 ns | 0.8446 ns | 1,211,220,521.0 |  1.00 |      - |         - |          NA |
| TupleClass | 101   | XXXXXXXXXXXXXXXXXXXX | 4.1338 ns |  1.9574 ns | 0.1073 ns | 0.0619 ns | 4.0156 ns | 4.2250 ns |   241,907,987.4 |  5.01 | 0.0051 |      32 B |          NA |
