# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.4652/24H2/2024Update/HudsonValley)
Unknown processor
.NET SDK 9.0.302
  [Host]   : .NET 9.0.7 (9.0.725.31616), Arm64 RyuJIT AdvSIMD
  ShortRun : .NET 9.0.7 (9.0.725.31616), Arm64 RyuJIT AdvSIMD

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method      | list                 | value | Mean         | Error         | StdDev       | StdErr      | Min          | Max          | Op/s        | Gen0   | Allocated |
|------------ |--------------------- |------ |-------------:|--------------:|-------------:|------------:|-------------:|-------------:|------------:|-------:|----------:|
| FirstUsage  | Syste(...)rator [36] | 100   |     214.4 ns |      39.58 ns |      2.17 ns |     1.25 ns |     212.3 ns |     216.6 ns | 4,663,457.3 | 0.0305 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 100   |     219.9 ns |     152.53 ns |      8.36 ns |     4.83 ns |     211.7 ns |     228.4 ns | 4,547,322.3 | 0.0305 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 1000  |   1,833.8 ns |     211.74 ns |     11.61 ns |     6.70 ns |   1,822.2 ns |   1,845.4 ns |   545,313.1 | 0.0305 |     128 B |
| SingleUsage | Syste(...)rator [36] | 100   |   1,850.8 ns |     577.66 ns |     31.66 ns |    18.28 ns |   1,829.4 ns |   1,887.2 ns |   540,311.9 | 0.0305 |     128 B |
| FirstUsage  | Syste(...)rator [36] | 1000  |   1,857.2 ns |     332.34 ns |     18.22 ns |    10.52 ns |   1,836.3 ns |   1,870.2 ns |   538,455.2 | 0.0305 |     128 B |
| WhereUsage  | Syste(...)rator [36] | 100   |   1,864.9 ns |     374.02 ns |     20.50 ns |    11.84 ns |   1,847.0 ns |   1,887.3 ns |   536,227.5 | 0.0591 |     248 B |
| CountUsage  | Syste(...)rator [36] | 100   |   1,894.6 ns |     509.26 ns |     27.91 ns |    16.12 ns |   1,877.0 ns |   1,926.8 ns |   527,814.3 | 0.0305 |     128 B |
| CountUsage  | Syste(...)rator [36] | 1000  |  18,055.6 ns |     352.89 ns |     19.34 ns |    11.17 ns |  18,034.5 ns |  18,072.4 ns |    55,384.4 | 0.0305 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 10000 |  18,110.2 ns |   2,323.49 ns |    127.36 ns |    73.53 ns |  18,028.6 ns |  18,257.0 ns |    55,217.5 | 0.0305 |     128 B |
| WhereUsage  | Syste(...)rator [36] | 1000  |  18,350.8 ns |   9,173.66 ns |    502.84 ns |   290.31 ns |  18,037.4 ns |  18,930.8 ns |    54,493.5 | 0.0305 |     248 B |
| FirstUsage  | Syste(...)rator [36] | 10000 |  18,495.3 ns |   9,562.36 ns |    524.15 ns |   302.62 ns |  18,043.7 ns |  19,070.1 ns |    54,067.8 | 0.0305 |     128 B |
| SingleUsage | Syste(...)rator [36] | 1000  |  18,820.1 ns |   6,869.30 ns |    376.53 ns |   217.39 ns |  18,584.8 ns |  19,254.4 ns |    53,134.7 | 0.0305 |     128 B |
| CountUsage  | Syste(...)rator [36] | 10000 | 189,466.4 ns | 124,758.55 ns |  6,838.44 ns | 3,948.17 ns | 182,849.2 ns | 196,506.5 ns |     5,278.0 |      - |     128 B |
| WhereUsage  | Syste(...)rator [36] | 10000 | 191,029.6 ns | 282,230.81 ns | 15,470.02 ns | 8,931.62 ns | 180,867.0 ns | 208,833.4 ns |     5,234.8 |      - |     248 B |
| SingleUsage | Syste(...)rator [36] | 10000 | 437,137.7 ns |  39,018.20 ns |  2,138.72 ns | 1,234.79 ns | 434,670.9 ns | 438,473.2 ns |     2,287.6 |      - |     128 B |
