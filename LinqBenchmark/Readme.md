# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2894)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method      | list                 | value | Mean         | Error        | StdDev      | StdErr      | Min          | Max          | Op/s        | Gen0   | Allocated |
|------------ |--------------------- |------ |-------------:|-------------:|------------:|------------:|-------------:|-------------:|------------:|-------:|----------:|
| FirstUsage  | Syste(...)rator [36] | 100   |     129.2 ns |     33.33 ns |     1.83 ns |     1.05 ns |     128.0 ns |     131.3 ns | 7,738,044.8 | 0.0203 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 100   |     138.3 ns |     33.58 ns |     1.84 ns |     1.06 ns |     136.5 ns |     140.2 ns | 7,228,340.3 | 0.0203 |     128 B |
| SingleUsage | Syste(...)rator [36] | 100   |     812.0 ns |    186.13 ns |    10.20 ns |     5.89 ns |     805.4 ns |     823.7 ns | 1,231,589.9 | 0.0200 |     128 B |
| FirstUsage  | Syste(...)rator [36] | 1000  |   1,022.7 ns |     69.28 ns |     3.80 ns |     2.19 ns |   1,019.5 ns |   1,026.9 ns |   977,840.5 | 0.0191 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 1000  |   1,026.5 ns |     57.76 ns |     3.17 ns |     1.83 ns |   1,023.1 ns |   1,029.4 ns |   974,153.5 | 0.0191 |     128 B |
| CountUsage  | Syste(...)rator [36] | 100   |   1,034.3 ns |    109.20 ns |     5.99 ns |     3.46 ns |   1,027.8 ns |   1,039.6 ns |   966,822.6 | 0.0191 |     128 B |
| WhereUsage  | Syste(...)rator [36] | 100   |   1,055.1 ns |    114.90 ns |     6.30 ns |     3.64 ns |   1,048.7 ns |   1,061.3 ns |   947,781.2 | 0.0381 |     248 B |
| SingleUsage | Syste(...)rator [36] | 1000  |   7,779.3 ns |    850.23 ns |    46.60 ns |    26.91 ns |   7,726.1 ns |   7,812.9 ns |   128,545.5 | 0.0153 |     128 B |
| WhereUsage  | Syste(...)rator [36] | 1000  |   9,956.5 ns |    223.55 ns |    12.25 ns |     7.07 ns |   9,942.4 ns |   9,964.1 ns |   100,436.9 | 0.0305 |     248 B |
| AnyUsage    | Syste(...)rator [36] | 10000 |  10,006.2 ns |  1,351.14 ns |    74.06 ns |    42.76 ns |   9,960.3 ns |  10,091.6 ns |    99,938.1 | 0.0153 |     128 B |
| FirstUsage  | Syste(...)rator [36] | 10000 |  10,277.9 ns |  1,029.65 ns |    56.44 ns |    32.58 ns |  10,244.6 ns |  10,343.1 ns |    97,296.2 | 0.0153 |     128 B |
| CountUsage  | Syste(...)rator [36] | 1000  |  10,307.9 ns |  9,759.78 ns |   534.97 ns |   308.86 ns |   9,934.9 ns |  10,920.8 ns |    97,012.8 | 0.0153 |     128 B |
| CountUsage  | Syste(...)rator [36] | 10000 |  99,037.2 ns |  5,124.93 ns |   280.91 ns |   162.19 ns |  98,724.0 ns |  99,267.0 ns |    10,097.2 |      - |     128 B |
| WhereUsage  | Syste(...)rator [36] | 10000 |  99,174.5 ns |  7,451.68 ns |   408.45 ns |   235.82 ns |  98,773.1 ns |  99,589.7 ns |    10,083.2 |      - |     248 B |
| SingleUsage | Syste(...)rator [36] | 10000 | 411,083.9 ns | 42,104.40 ns | 2,307.88 ns | 1,332.46 ns | 409,465.9 ns | 413,726.7 ns |     2,432.6 |      - |     128 B |
