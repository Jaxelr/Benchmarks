# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.6584/24H2/2024Update/HudsonValley)
Unknown processor
.NET SDK 9.0.305
  [Host]   : .NET 9.0.9 (9.0.925.41916), Arm64 RyuJIT AdvSIMD
  ShortRun : .NET 9.0.9 (9.0.925.41916), Arm64 RyuJIT AdvSIMD

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method      | list                 | value | Mean         | Error         | StdDev      | StdErr      | Min          | Max          | Op/s        | Gen0   | Allocated |
|------------ |--------------------- |------ |-------------:|--------------:|------------:|------------:|-------------:|-------------:|------------:|-------:|----------:|
| FirstUsage  | Syste(...)rator [36] | 100   |     241.1 ns |       3.22 ns |     0.18 ns |     0.10 ns |     240.9 ns |     241.3 ns | 4,147,552.2 | 0.0305 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 100   |     243.0 ns |       6.90 ns |     0.38 ns |     0.22 ns |     242.5 ns |     243.3 ns | 4,115,972.7 | 0.0305 |     128 B |
| CountUsage  | Syste(...)rator [36] | 100   |   2,155.8 ns |     110.52 ns |     6.06 ns |     3.50 ns |   2,148.9 ns |   2,159.9 ns |   463,855.0 | 0.0305 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 1000  |   2,163.0 ns |     342.57 ns |    18.78 ns |    10.84 ns |   2,145.3 ns |   2,182.7 ns |   462,314.2 | 0.0305 |     128 B |
| SingleUsage | Syste(...)rator [36] | 100   |   2,164.3 ns |     358.55 ns |    19.65 ns |    11.35 ns |   2,151.5 ns |   2,186.9 ns |   462,045.7 | 0.0305 |     128 B |
| WhereUsage  | Syste(...)rator [36] | 100   |   2,179.3 ns |     189.78 ns |    10.40 ns |     6.01 ns |   2,170.5 ns |   2,190.8 ns |   458,855.7 | 0.0572 |     248 B |
| FirstUsage  | Syste(...)rator [36] | 1000  |   2,388.8 ns |   1,764.08 ns |    96.70 ns |    55.83 ns |   2,279.1 ns |   2,461.6 ns |   418,620.2 | 0.0305 |     128 B |
| CountUsage  | Syste(...)rator [36] | 1000  |  22,078.5 ns |   6,538.22 ns |   358.38 ns |   206.91 ns |  21,806.5 ns |  22,484.6 ns |    45,293.0 | 0.0305 |     128 B |
| WhereUsage  | Syste(...)rator [36] | 1000  |  22,335.9 ns |   4,034.77 ns |   221.16 ns |   127.69 ns |  22,196.2 ns |  22,590.9 ns |    44,771.0 | 0.0305 |     248 B |
| AnyUsage    | Syste(...)rator [36] | 10000 |  22,445.4 ns |   3,377.68 ns |   185.14 ns |   106.89 ns |  22,237.8 ns |  22,593.3 ns |    44,552.5 | 0.0305 |     128 B |
| FirstUsage  | Syste(...)rator [36] | 10000 |  23,000.8 ns |   5,083.84 ns |   278.66 ns |   160.89 ns |  22,685.1 ns |  23,212.8 ns |    43,476.8 | 0.0305 |     128 B |
| SingleUsage | Syste(...)rator [36] | 1000  |  23,058.5 ns |     261.91 ns |    14.36 ns |     8.29 ns |  23,042.0 ns |  23,067.2 ns |    43,367.9 | 0.0305 |     128 B |
| CountUsage  | Syste(...)rator [36] | 10000 | 223,842.7 ns |  16,184.73 ns |   887.14 ns |   512.19 ns | 222,821.9 ns | 224,427.5 ns |     4,467.4 |      - |     128 B |
| WhereUsage  | Syste(...)rator [36] | 10000 | 224,511.8 ns |  43,635.74 ns | 2,391.82 ns | 1,380.92 ns | 222,469.4 ns | 227,143.0 ns |     4,454.1 |      - |     248 B |
| SingleUsage | Syste(...)rator [36] | 10000 | 538,270.4 ns | 113,854.38 ns | 6,240.74 ns | 3,603.09 ns | 531,311.3 ns | 543,370.2 ns |     1,857.8 |      - |     128 B |
