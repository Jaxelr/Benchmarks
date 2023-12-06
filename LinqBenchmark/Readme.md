# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

```

BenchmarkDotNet v0.13.10, Windows 11 (10.0.22621.2715/22H2/2022Update/SunValley2)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method      | list                 | value | Mean         | Error        | StdDev       | StdErr       | Min          | Max          | Op/s        | Gen0   | Allocated |
|------------ |--------------------- |------ |-------------:|-------------:|-------------:|-------------:|-------------:|-------------:|------------:|-------:|----------:|
| FirstUsage  | Syste(...)rator [36] | 100   |     205.0 ns |     182.6 ns |     10.01 ns |      5.78 ns |     195.3 ns |     215.3 ns | 4,878,488.4 | 0.0200 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 100   |     245.7 ns |     413.3 ns |     22.66 ns |     13.08 ns |     223.8 ns |     269.1 ns | 4,069,641.9 | 0.0200 |     128 B |
| FirstUsage  | Syste(...)rator [36] | 1000  |   1,470.5 ns |   1,144.9 ns |     62.75 ns |     36.23 ns |   1,408.7 ns |   1,534.2 ns |   680,049.1 | 0.0191 |     128 B |
| SingleUsage | Syste(...)rator [36] | 100   |   1,526.7 ns |     753.1 ns |     41.28 ns |     23.83 ns |   1,489.3 ns |   1,571.0 ns |   655,021.7 | 0.0191 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 1000  |   1,633.0 ns |   3,068.7 ns |    168.21 ns |     97.11 ns |   1,442.2 ns |   1,759.7 ns |   612,353.6 | 0.0191 |     128 B |
| WhereUsage  | Syste(...)rator [36] | 100   |   1,790.8 ns |     670.5 ns |     36.75 ns |     21.22 ns |   1,758.7 ns |   1,830.9 ns |   558,405.9 | 0.0401 |     256 B |
| CountUsage  | Syste(...)rator [36] | 100   |   2,922.0 ns |     685.9 ns |     37.60 ns |     21.71 ns |   2,878.6 ns |   2,944.7 ns |   342,231.5 | 0.0191 |     128 B |
| CountUsage  | Syste(...)rator [36] | 1000  |  14,367.7 ns |   9,568.0 ns |    524.46 ns |    302.79 ns |  13,861.8 ns |  14,908.9 ns |    69,600.7 | 0.0153 |     128 B |
| SingleUsage | Syste(...)rator [36] | 1000  |  14,630.2 ns |  15,480.0 ns |    848.51 ns |    489.89 ns |  14,073.5 ns |  15,606.8 ns |    68,351.7 |      - |     128 B |
| AnyUsage    | Syste(...)rator [36] | 10000 |  16,224.4 ns |  33,337.7 ns |  1,827.35 ns |  1,055.02 ns |  14,883.3 ns |  18,305.7 ns |    61,635.5 |      - |     128 B |
| WhereUsage  | Syste(...)rator [36] | 1000  |  17,645.8 ns |   7,595.6 ns |    416.34 ns |    240.37 ns |  17,255.4 ns |  18,083.9 ns |    56,670.6 | 0.0305 |     256 B |
| FirstUsage  | Syste(...)rator [36] | 10000 |  19,394.9 ns |  27,344.5 ns |  1,498.84 ns |    865.36 ns |  18,184.6 ns |  21,071.5 ns |    51,559.9 |      - |     128 B |
| CountUsage  | Syste(...)rator [36] | 10000 | 192,301.9 ns | 295,235.6 ns | 16,182.86 ns |  9,343.18 ns | 175,188.4 ns | 207,357.2 ns |     5,200.2 |      - |     128 B |
| WhereUsage  | Syste(...)rator [36] | 10000 | 200,244.9 ns | 316,707.4 ns | 17,359.80 ns | 10,022.69 ns | 188,351.4 ns | 220,165.6 ns |     4,993.9 |      - |     256 B |
| SingleUsage | Syste(...)rator [36] | 10000 | 703,177.0 ns | 751,719.5 ns | 41,204.28 ns | 23,789.30 ns | 676,417.2 ns | 750,626.4 ns |     1,422.1 |      - |     128 B |
