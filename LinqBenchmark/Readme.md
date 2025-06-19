# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.4349)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.301
  [Host]   : .NET 9.0.6 (9.0.625.26613), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  ShortRun : .NET 9.0.6 (9.0.625.26613), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method      | list                 | value | Mean         | Error         | StdDev      | StdErr      | Min          | Max          | Op/s        | Gen0   | Allocated |
|------------ |--------------------- |------ |-------------:|--------------:|------------:|------------:|-------------:|-------------:|------------:|-------:|----------:|
| FirstUsage  | Syste(...)rator [36] | 100   |     151.7 ns |      51.71 ns |     2.83 ns |     1.64 ns |     149.0 ns |     154.6 ns | 6,592,680.5 | 0.0203 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 100   |     153.8 ns |     136.65 ns |     7.49 ns |     4.32 ns |     147.9 ns |     162.2 ns | 6,502,767.7 | 0.0203 |     128 B |
| SingleUsage | Syste(...)rator [36] | 100   |     900.9 ns |   1,731.62 ns |    94.92 ns |    54.80 ns |     843.3 ns |   1,010.4 ns | 1,110,013.6 | 0.0200 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 1000  |   1,061.0 ns |      58.44 ns |     3.20 ns |     1.85 ns |   1,058.5 ns |   1,064.6 ns |   942,493.9 | 0.0191 |     128 B |
| FirstUsage  | Syste(...)rator [36] | 1000  |   1,062.1 ns |     172.23 ns |     9.44 ns |     5.45 ns |   1,051.3 ns |   1,068.6 ns |   941,505.1 | 0.0191 |     128 B |
| WhereUsage  | Syste(...)rator [36] | 100   |   1,106.3 ns |     421.13 ns |    23.08 ns |    13.33 ns |   1,083.3 ns |   1,129.5 ns |   903,926.2 | 0.0381 |     248 B |
| CountUsage  | Syste(...)rator [36] | 100   |   1,202.9 ns |     153.90 ns |     8.44 ns |     4.87 ns |   1,195.4 ns |   1,212.0 ns |   831,315.6 | 0.0191 |     128 B |
| SingleUsage | Syste(...)rator [36] | 1000  |   8,053.1 ns |   2,737.17 ns |   150.03 ns |    86.62 ns |   7,949.7 ns |   8,225.2 ns |   124,175.8 | 0.0153 |     128 B |
| CountUsage  | Syste(...)rator [36] | 1000  |  10,332.5 ns |     600.19 ns |    32.90 ns |    18.99 ns |  10,294.5 ns |  10,353.1 ns |    96,782.3 | 0.0153 |     128 B |
| WhereUsage  | Syste(...)rator [36] | 1000  |  10,406.7 ns |   1,130.99 ns |    61.99 ns |    35.79 ns |  10,353.2 ns |  10,474.6 ns |    96,092.3 | 0.0305 |     248 B |
| FirstUsage  | Syste(...)rator [36] | 10000 |  10,434.0 ns |   4,177.30 ns |   228.97 ns |   132.20 ns |  10,252.2 ns |  10,691.2 ns |    95,840.2 | 0.0153 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 10000 |  12,734.1 ns |  53,670.22 ns | 2,941.85 ns | 1,698.48 ns |  11,011.0 ns |  16,130.9 ns |    78,529.4 | 0.0153 |     128 B |
| CountUsage  | Syste(...)rator [36] | 10000 | 102,804.7 ns |  13,611.92 ns |   746.12 ns |   430.77 ns | 101,943.5 ns | 103,255.4 ns |     9,727.2 |      - |     128 B |
| WhereUsage  | Syste(...)rator [36] | 10000 | 107,687.1 ns |  35,493.02 ns | 1,945.49 ns | 1,123.23 ns | 105,517.5 ns | 109,276.6 ns |     9,286.2 |      - |     248 B |
| SingleUsage | Syste(...)rator [36] | 10000 | 405,086.2 ns | 176,868.41 ns | 9,694.75 ns | 5,597.27 ns | 395,234.1 ns | 414,615.5 ns |     2,468.6 |      - |     128 B |
