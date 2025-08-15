# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.4946/24H2/2024Update/HudsonValley)
Unknown processor
.NET SDK 9.0.304
  [Host]   : .NET 9.0.8 (9.0.825.36511), Arm64 RyuJIT AdvSIMD
  ShortRun : .NET 9.0.8 (9.0.825.36511), Arm64 RyuJIT AdvSIMD

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method      | list                 | value | Mean         | Error         | StdDev       | StdErr      | Min          | Max          | Op/s        | Gen0   | Allocated |
|------------ |--------------------- |------ |-------------:|--------------:|-------------:|------------:|-------------:|-------------:|------------:|-------:|----------:|
| FirstUsage  | Syste(...)rator [36] | 100   |     213.3 ns |     129.42 ns |      7.09 ns |     4.10 ns |     208.4 ns |     221.5 ns | 4,687,309.0 | 0.0305 |     128 B |
| AnyUsage    | Syste(...)rator [36] | 100   |     230.1 ns |      43.09 ns |      2.36 ns |     1.36 ns |     228.5 ns |     232.8 ns | 4,345,312.6 | 0.0305 |     128 B |
| FirstUsage  | Syste(...)rator [36] | 1000  |   1,905.0 ns |     704.53 ns |     38.62 ns |    22.30 ns |   1,863.2 ns |   1,939.3 ns |   524,939.2 | 0.0305 |     128 B |
| SingleUsage | Syste(...)rator [36] | 100   |   1,911.9 ns |   1,521.84 ns |     83.42 ns |    48.16 ns |   1,847.2 ns |   2,006.1 ns |   523,026.9 | 0.0305 |     128 B |
| WhereUsage  | Syste(...)rator [36] | 100   |   1,984.0 ns |   1,797.74 ns |     98.54 ns |    56.89 ns |   1,870.2 ns |   2,044.0 ns |   504,043.0 | 0.0591 |     248 B |
| AnyUsage    | Syste(...)rator [36] | 1000  |   2,017.2 ns |   5,278.75 ns |    289.35 ns |   167.05 ns |   1,831.3 ns |   2,350.6 ns |   495,730.1 | 0.0305 |     128 B |
| CountUsage  | Syste(...)rator [36] | 100   |   2,267.5 ns |   4,378.35 ns |    239.99 ns |   138.56 ns |   1,993.7 ns |   2,441.6 ns |   441,020.1 | 0.0305 |     128 B |
| FirstUsage  | Syste(...)rator [36] | 10000 |  19,007.9 ns |   1,869.08 ns |    102.45 ns |    59.15 ns |  18,890.4 ns |  19,078.4 ns |    52,609.7 | 0.0305 |     128 B |
| CountUsage  | Syste(...)rator [36] | 1000  |  19,104.9 ns |  13,095.21 ns |    717.79 ns |   414.42 ns |  18,282.2 ns |  19,604.0 ns |    52,342.7 | 0.0305 |     128 B |
| WhereUsage  | Syste(...)rator [36] | 1000  |  19,567.4 ns |  12,378.63 ns |    678.51 ns |   391.74 ns |  18,832.1 ns |  20,169.4 ns |    51,105.5 | 0.0305 |     248 B |
| AnyUsage    | Syste(...)rator [36] | 10000 |  19,630.2 ns |   8,315.97 ns |    455.83 ns |   263.17 ns |  19,235.2 ns |  20,128.9 ns |    50,942.0 | 0.0305 |     128 B |
| SingleUsage | Syste(...)rator [36] | 1000  |  20,104.9 ns |  14,456.19 ns |    792.39 ns |   457.49 ns |  19,416.6 ns |  20,971.1 ns |    49,739.1 | 0.0305 |     128 B |
| WhereUsage  | Syste(...)rator [36] | 10000 | 181,511.6 ns |  21,329.80 ns |  1,169.16 ns |   675.01 ns | 180,328.1 ns | 182,665.9 ns |     5,509.3 |      - |     248 B |
| CountUsage  | Syste(...)rator [36] | 10000 | 194,836.8 ns | 164,394.51 ns |  9,011.02 ns | 5,202.51 ns | 187,336.5 ns | 204,832.5 ns |     5,132.5 |      - |     128 B |
| SingleUsage | Syste(...)rator [36] | 10000 | 444,525.6 ns | 218,323.04 ns | 11,967.02 ns | 6,909.16 ns | 431,402.1 ns | 454,834.4 ns |     2,249.6 |      - |     128 B |
