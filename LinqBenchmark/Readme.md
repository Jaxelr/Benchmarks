# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 11 (10.0.22621.2428/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.402
  [Host]   : .NET 7.0.12 (7.0.1223.47720), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.12 (7.0.1223.47720), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method      | list                 | value | Mean         | Error        | StdDev       | StdErr      | Min          | Max          | Op/s        | Gen0   | Allocated |
|------------ |--------------------- |------ |-------------:|-------------:|-------------:|------------:|-------------:|-------------:|------------:|-------:|----------:|
| AnyUsage    | Syste(...)rator [36] | 100   |     457.2 ns |     230.7 ns |     12.65 ns |     7.30 ns |     442.6 ns |     464.9 ns | 2,187,440.8 | 0.0200 |     128 B |
| FirstUsage  | Syste(...)rator [36] | 100   |     487.0 ns |     402.2 ns |     22.04 ns |    12.73 ns |     464.8 ns |     508.9 ns | 2,053,556.0 | 0.0200 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 1000  |   4,180.7 ns |   2,695.6 ns |    147.76 ns |    85.31 ns |   4,050.0 ns |   4,341.0 ns |   239,197.0 | 0.0153 |     128 B |
| FirstUsage  | Syste(...)rator [36] | 1000  |   4,823.6 ns |   5,726.3 ns |    313.88 ns |   181.22 ns |   4,527.7 ns |   5,152.8 ns |   207,313.8 | 0.0153 |     128 B |
| CountUsage  | Syste(...)rator [36] | 100   |   5,022.7 ns |   5,025.3 ns |    275.45 ns |   159.03 ns |   4,801.1 ns |   5,331.1 ns |   199,094.7 | 0.0153 |     128 B |
| WhereUsage  | Syste(...)rator [36] | 100   |   6,896.8 ns |  20,838.8 ns |  1,142.25 ns |   659.48 ns |   5,681.1 ns |   7,947.7 ns |   144,994.3 | 0.0305 |     256 B |
| SingleUsage | Syste(...)rator [36] | 100   |   7,519.2 ns |   2,333.3 ns |    127.90 ns |    73.84 ns |   7,371.7 ns |   7,599.8 ns |   132,992.7 | 0.0153 |     128 B |
| CountUsage  | Syste(...)rator [36] | 1000  |  45,259.3 ns |   1,442.9 ns |     79.09 ns |    45.66 ns |  45,169.0 ns |  45,316.4 ns |    22,094.9 |      - |     128 B |
| AnyUsage    | Syste(...)rator [36] | 10000 |  49,088.4 ns |  55,078.8 ns |  3,019.06 ns | 1,743.05 ns |  46,739.9 ns |  52,493.8 ns |    20,371.4 |      - |     128 B |
| WhereUsage  | Syste(...)rator [36] | 1000  |  55,851.4 ns |  34,430.9 ns |  1,887.27 ns | 1,089.62 ns |  53,950.5 ns |  57,724.8 ns |    17,904.7 |      - |     256 B |
| SingleUsage | Syste(...)rator [36] | 1000  |  58,207.6 ns |  47,551.6 ns |  2,606.46 ns | 1,504.84 ns |  55,317.3 ns |  60,379.5 ns |    17,179.9 |      - |     128 B |
| FirstUsage  | Syste(...)rator [36] | 10000 |  58,985.8 ns |  97,500.7 ns |  5,344.34 ns | 3,085.56 ns |  54,831.7 ns |  65,015.0 ns |    16,953.2 |      - |     128 B |
| SingleUsage | Syste(...)rator [36] | 10000 | 461,699.7 ns |  78,793.3 ns |  4,318.93 ns | 2,493.53 ns | 458,582.9 ns | 466,629.6 ns |     2,165.9 |      - |     128 B |
| WhereUsage  | Syste(...)rator [36] | 10000 | 509,883.8 ns |  93,828.5 ns |  5,143.06 ns | 2,969.35 ns | 506,560.2 ns | 515,807.8 ns |     1,961.2 |      - |     256 B |
| CountUsage  | Syste(...)rator [36] | 10000 | 531,216.0 ns | 216,420.2 ns | 11,862.72 ns | 6,848.95 ns | 517,540.3 ns | 538,730.0 ns |     1,882.5 |      - |     128 B |
