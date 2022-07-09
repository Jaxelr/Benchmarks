# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.301
  [Host]   : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT
  ShortRun : .NET 6.0.6 (6.0.622.26707), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|      Method |                 list | value |         Mean |          Error |       StdDev |       StdErr |          Min |           Q1 |       Median |           Q3 |          Max |        Op/s |  Gen 0 | Allocated |
|------------ |--------------------- |------ |-------------:|---------------:|-------------:|-------------:|-------------:|-------------:|-------------:|-------------:|-------------:|------------:|-------:|----------:|
|  FirstUsage | Syste(...)rator [36] |   100 |     742.4 ns |     1,528.1 ns |     83.76 ns |     48.36 ns |     654.1 ns |     703.2 ns |     752.4 ns |     786.5 ns |     820.7 ns | 1,347,021.6 | 0.0191 |     128 B |
|    AnyUsage | Syste(...)rator [36] |   100 |     750.5 ns |       678.5 ns |     37.19 ns |     21.47 ns |     707.6 ns |     738.5 ns |     769.3 ns |     771.9 ns |     774.5 ns | 1,332,490.9 | 0.0200 |     128 B |
|    AnyUsage | Syste(...)rator [36] |  1000 |   6,459.2 ns |     1,914.0 ns |    104.92 ns |     60.57 ns |   6,382.0 ns |   6,399.4 ns |   6,416.9 ns |   6,497.7 ns |   6,578.6 ns |   154,819.1 | 0.0153 |     128 B |
|  FirstUsage | Syste(...)rator [36] |  1000 |   6,469.0 ns |     5,805.3 ns |    318.21 ns |    183.72 ns |   6,110.5 ns |   6,344.4 ns |   6,578.4 ns |   6,648.2 ns |   6,718.0 ns |   154,584.2 | 0.0153 |     128 B |
|  WhereUsage | Syste(...)rator [36] |   100 |   6,661.6 ns |     8,980.9 ns |    492.27 ns |    284.21 ns |   6,218.1 ns |   6,396.8 ns |   6,575.4 ns |   6,883.3 ns |   7,191.3 ns |   150,114.2 | 0.0305 |     256 B |
|  CountUsage | Syste(...)rator [36] |   100 |   6,920.3 ns |     4,827.3 ns |    264.60 ns |    152.77 ns |   6,735.3 ns |   6,768.7 ns |   6,802.1 ns |   7,012.7 ns |   7,223.3 ns |   144,503.3 | 0.0153 |     128 B |
| SingleUsage | Syste(...)rator [36] |   100 |   7,229.9 ns |     2,351.3 ns |    128.88 ns |     74.41 ns |   7,099.8 ns |   7,166.0 ns |   7,232.3 ns |   7,294.9 ns |   7,357.5 ns |   138,315.2 | 0.0153 |     128 B |
| SingleUsage | Syste(...)rator [36] |  1000 |  63,615.8 ns |    64,406.6 ns |  3,530.34 ns |  2,038.24 ns |  61,347.7 ns |  61,582.0 ns |  61,816.3 ns |  64,749.8 ns |  67,683.3 ns |    15,719.4 |      - |     128 B |
|  CountUsage | Syste(...)rator [36] |  1000 |  65,602.4 ns |    88,086.5 ns |  4,828.32 ns |  2,787.63 ns |  61,173.8 ns |  63,028.7 ns |  64,883.6 ns |  67,816.7 ns |  70,749.8 ns |    15,243.4 |      - |     128 B |
|    AnyUsage | Syste(...)rator [36] | 10000 |  66,188.7 ns |    61,408.4 ns |  3,366.00 ns |  1,943.36 ns |  62,661.6 ns |  64,599.9 ns |  66,538.1 ns |  67,952.2 ns |  69,366.4 ns |    15,108.3 |      - |     128 B |
|  FirstUsage | Syste(...)rator [36] | 10000 |  66,611.6 ns |    56,019.0 ns |  3,070.59 ns |  1,772.81 ns |  63,750.7 ns |  64,989.5 ns |  66,228.3 ns |  68,042.1 ns |  69,855.9 ns |    15,012.4 |      - |     128 B |
|  WhereUsage | Syste(...)rator [36] |  1000 |  69,623.0 ns |    48,665.4 ns |  2,667.52 ns |  1,540.09 ns |  67,788.2 ns |  68,093.0 ns |  68,397.9 ns |  70,540.4 ns |  72,683.0 ns |    14,363.1 |      - |     256 B |
|  CountUsage | Syste(...)rator [36] | 10000 | 643,080.5 ns | 1,082,232.6 ns | 59,320.82 ns | 34,248.89 ns | 608,632.8 ns | 608,831.8 ns | 609,030.9 ns | 660,304.4 ns | 711,577.9 ns |     1,555.0 |      - |     128 B |
| SingleUsage | Syste(...)rator [36] | 10000 | 686,161.5 ns |   470,031.1 ns | 25,763.99 ns | 14,874.85 ns | 656,665.6 ns | 677,108.7 ns | 697,551.8 ns | 700,909.5 ns | 704,267.2 ns |     1,457.4 |      - |     128 B |
|  WhereUsage | Syste(...)rator [36] | 10000 | 695,225.5 ns | 1,246,493.1 ns | 68,324.49 ns | 39,447.16 ns | 627,180.0 ns | 660,925.5 ns | 694,671.0 ns | 729,248.3 ns | 763,825.6 ns |     1,438.4 |      - |     257 B |
