# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3775)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.203
  [Host]   : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method      | list                 | value | Mean         | Error         | StdDev       | StdErr      | Min          | Max          | Op/s        | Gen0   | Allocated |
|------------ |--------------------- |------ |-------------:|--------------:|-------------:|------------:|-------------:|-------------:|------------:|-------:|----------:|
| AnyUsage    | Syste(...)rator [36] | 100   |     140.8 ns |      49.37 ns |      2.71 ns |     1.56 ns |     137.8 ns |     143.1 ns | 7,104,558.9 | 0.0203 |     128 B |
| FirstUsage  | Syste(...)rator [36] | 100   |     141.9 ns |     126.73 ns |      6.95 ns |     4.01 ns |     135.4 ns |     149.2 ns | 7,045,354.4 | 0.0203 |     128 B |
| SingleUsage | Syste(...)rator [36] | 100   |     898.9 ns |     613.18 ns |     33.61 ns |    19.41 ns |     868.2 ns |     934.8 ns | 1,112,502.0 | 0.0200 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 1000  |   1,030.6 ns |      79.81 ns |      4.37 ns |     2.53 ns |   1,025.9 ns |   1,034.5 ns |   970,268.5 | 0.0191 |     128 B |
| CountUsage  | Syste(...)rator [36] | 100   |   1,053.7 ns |     121.45 ns |      6.66 ns |     3.84 ns |   1,046.6 ns |   1,059.8 ns |   949,056.6 | 0.0191 |     128 B |
| FirstUsage  | Syste(...)rator [36] | 1000  |   1,071.0 ns |     843.98 ns |     46.26 ns |    26.71 ns |   1,037.6 ns |   1,123.8 ns |   933,697.1 | 0.0191 |     128 B |
| WhereUsage  | Syste(...)rator [36] | 100   |   1,092.6 ns |     918.21 ns |     50.33 ns |    29.06 ns |   1,063.1 ns |   1,150.7 ns |   915,222.0 | 0.0381 |     248 B |
| SingleUsage | Syste(...)rator [36] | 1000  |   8,268.9 ns |   6,691.96 ns |    366.81 ns |   211.78 ns |   7,953.7 ns |   8,671.5 ns |   120,935.5 | 0.0153 |     128 B |
| CountUsage  | Syste(...)rator [36] | 1000  |  10,049.3 ns |   1,058.72 ns |     58.03 ns |    33.50 ns |   9,984.4 ns |  10,096.1 ns |    99,509.1 | 0.0153 |     128 B |
| FirstUsage  | Syste(...)rator [36] | 10000 |  10,433.2 ns |   5,266.39 ns |    288.67 ns |   166.66 ns |  10,185.2 ns |  10,750.1 ns |    95,847.9 | 0.0153 |     128 B |
| WhereUsage  | Syste(...)rator [36] | 1000  |  10,442.5 ns |   6,732.36 ns |    369.02 ns |   213.06 ns |  10,092.3 ns |  10,827.8 ns |    95,762.6 | 0.0305 |     248 B |
| AnyUsage    | Syste(...)rator [36] | 10000 |  10,818.7 ns |  12,379.14 ns |    678.54 ns |   391.76 ns |  10,185.2 ns |  11,534.8 ns |    92,432.3 | 0.0153 |     128 B |
| WhereUsage  | Syste(...)rator [36] | 10000 |  99,399.6 ns |  11,881.79 ns |    651.28 ns |   376.02 ns |  98,888.8 ns | 100,133.0 ns |    10,060.4 |      - |     248 B |
| CountUsage  | Syste(...)rator [36] | 10000 | 102,307.9 ns |  56,097.38 ns |  3,074.89 ns | 1,775.29 ns |  99,506.8 ns | 105,598.0 ns |     9,774.4 |      - |     128 B |
| SingleUsage | Syste(...)rator [36] | 10000 | 394,417.2 ns | 196,695.59 ns | 10,781.55 ns | 6,224.73 ns | 386,338.3 ns | 406,659.7 ns |     2,535.4 |      - |     128 B |
