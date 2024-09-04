# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4112/23H2/2023Update/SunValley3)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.400
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method      | list                 | value | Mean         | Error        | StdDev      | StdErr      | Min          | Max          | Op/s        | Gen0   | Allocated |
|------------ |--------------------- |------ |-------------:|-------------:|------------:|------------:|-------------:|-------------:|------------:|-------:|----------:|
| FirstUsage  | Syste(...)rator [36] | 100   |     116.2 ns |     42.25 ns |     2.32 ns |     1.34 ns |     114.5 ns |     118.8 ns | 8,608,346.5 | 0.0204 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 100   |     129.4 ns |    189.66 ns |    10.40 ns |     6.00 ns |     117.5 ns |     136.4 ns | 7,726,378.5 | 0.0203 |     128 B |
| FirstUsage  | Syste(...)rator [36] | 1000  |     936.5 ns |    463.68 ns |    25.42 ns |    14.67 ns |     907.2 ns |     951.8 ns | 1,067,778.9 | 0.0191 |     128 B |
| CountUsage  | Syste(...)rator [36] | 100   |     966.4 ns |    684.03 ns |    37.49 ns |    21.65 ns |     925.7 ns |     999.6 ns | 1,034,768.1 | 0.0191 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 1000  |   1,025.8 ns |  2,461.57 ns |   134.93 ns |    77.90 ns |     938.7 ns |   1,181.2 ns |   974,841.9 | 0.0191 |     128 B |
| SingleUsage | Syste(...)rator [36] | 100   |   1,095.9 ns |  1,725.59 ns |    94.59 ns |    54.61 ns |   1,026.9 ns |   1,203.7 ns |   912,495.5 | 0.0200 |     128 B |
| WhereUsage  | Syste(...)rator [36] | 100   |   1,213.0 ns |    651.63 ns |    35.72 ns |    20.62 ns |   1,184.9 ns |   1,253.2 ns |   824,430.0 | 0.0401 |     256 B |
| FirstUsage  | Syste(...)rator [36] | 10000 |   9,165.1 ns |  5,317.31 ns |   291.46 ns |   168.27 ns |   8,967.0 ns |   9,499.8 ns |   109,109.4 | 0.0153 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 10000 |   9,458.8 ns |  3,189.18 ns |   174.81 ns |   100.93 ns |   9,274.6 ns |   9,622.5 ns |   105,721.8 | 0.0153 |     128 B |
| SingleUsage | Syste(...)rator [36] | 1000  |  12,822.7 ns | 73,373.87 ns | 4,021.87 ns | 2,322.03 ns |  10,353.5 ns |  17,463.5 ns |    77,987.0 |      - |     128 B |
| CountUsage  | Syste(...)rator [36] | 1000  |  13,437.7 ns | 78,241.50 ns | 4,288.68 ns | 2,476.07 ns |   9,367.8 ns |  17,916.0 ns |    74,417.5 | 0.0153 |     128 B |
| WhereUsage  | Syste(...)rator [36] | 1000  |  17,527.3 ns | 75,748.38 ns | 4,152.02 ns | 2,397.17 ns |  12,789.3 ns |  20,530.7 ns |    57,053.7 | 0.0305 |     256 B |
| CountUsage  | Syste(...)rator [36] | 10000 |  91,993.0 ns | 55,796.29 ns | 3,058.38 ns | 1,765.76 ns |  89,460.7 ns |  95,390.9 ns |    10,870.4 |      - |     128 B |
| WhereUsage  | Syste(...)rator [36] | 10000 |  99,822.8 ns |  1,342.97 ns |    73.61 ns |    42.50 ns |  99,747.4 ns |  99,894.5 ns |    10,017.7 |      - |     256 B |
| SingleUsage | Syste(...)rator [36] | 10000 | 392,985.3 ns | 65,326.29 ns | 3,580.75 ns | 2,067.35 ns | 390,013.6 ns | 396,960.8 ns |     2,544.6 |      - |     128 B |
