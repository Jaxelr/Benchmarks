# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.521)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.401
  [Host]   : .NET 6.0.9 (6.0.922.41905), X64 RyuJIT AVX2
  ShortRun : .NET 6.0.9 (6.0.922.41905), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|      Method |                 list | value |         Mean |        Error |       StdDev |       StdErr |          Min |           Q1 |       Median |           Q3 |          Max |        Op/s |   Gen0 | Allocated |
|------------ |--------------------- |------ |-------------:|-------------:|-------------:|-------------:|-------------:|-------------:|-------------:|-------------:|-------------:|------------:|-------:|----------:|
|    AnyUsage | Syste(...)rator [36] |   100 |     457.4 ns |     316.9 ns |     17.37 ns |     10.03 ns |     439.8 ns |     448.9 ns |     458.0 ns |     466.3 ns |     474.5 ns | 2,186,111.9 | 0.0200 |     128 B |
|  FirstUsage | Syste(...)rator [36] |   100 |     461.6 ns |     228.3 ns |     12.52 ns |      7.23 ns |     451.0 ns |     454.7 ns |     458.5 ns |     467.0 ns |     475.5 ns | 2,166,147.6 | 0.0200 |     128 B |
|    AnyUsage | Syste(...)rator [36] |  1000 |   4,065.2 ns |   1,322.4 ns |     72.49 ns |     41.85 ns |   4,007.2 ns |   4,024.6 ns |   4,042.1 ns |   4,094.3 ns |   4,146.5 ns |   245,987.4 | 0.0153 |     128 B |
|  FirstUsage | Syste(...)rator [36] |  1000 |   4,077.1 ns |     734.6 ns |     40.27 ns |     23.25 ns |   4,030.8 ns |   4,063.8 ns |   4,096.8 ns |   4,100.3 ns |   4,103.8 ns |   245,270.7 | 0.0153 |     128 B |
| SingleUsage | Syste(...)rator [36] |   100 |   4,206.7 ns |   3,684.7 ns |    201.97 ns |    116.61 ns |   4,013.5 ns |   4,101.8 ns |   4,190.1 ns |   4,303.3 ns |   4,416.4 ns |   237,716.4 | 0.0153 |     128 B |
|  CountUsage | Syste(...)rator [36] |   100 |   4,244.5 ns |   1,814.2 ns |     99.44 ns |     57.41 ns |   4,183.9 ns |   4,187.1 ns |   4,190.2 ns |   4,274.7 ns |   4,359.2 ns |   235,601.0 | 0.0153 |     128 B |
|  WhereUsage | Syste(...)rator [36] |   100 |   4,852.8 ns |     331.7 ns |     18.18 ns |     10.50 ns |   4,833.4 ns |   4,844.6 ns |   4,855.8 ns |   4,862.6 ns |   4,869.4 ns |   206,064.5 | 0.0381 |     256 B |
|    AnyUsage | Syste(...)rator [36] | 10000 |  40,360.0 ns |   1,618.6 ns |     88.72 ns |     51.22 ns |  40,266.4 ns |  40,318.5 ns |  40,370.6 ns |  40,406.8 ns |  40,442.9 ns |    24,777.0 |      - |     128 B |
|  CountUsage | Syste(...)rator [36] |  1000 |  40,728.9 ns |  18,728.2 ns |  1,026.56 ns |    592.68 ns |  39,871.2 ns |  40,160.2 ns |  40,449.1 ns |  41,157.7 ns |  41,866.4 ns |    24,552.6 |      - |     128 B |
| SingleUsage | Syste(...)rator [36] |  1000 |  40,937.1 ns |  23,840.2 ns |  1,306.76 ns |    754.46 ns |  39,512.0 ns |  40,366.1 ns |  41,220.3 ns |  41,649.7 ns |  42,079.0 ns |    24,427.7 |      - |     128 B |
|  WhereUsage | Syste(...)rator [36] |  1000 |  45,868.0 ns |   9,904.5 ns |    542.90 ns |    313.44 ns |  45,507.6 ns |  45,555.8 ns |  45,604.1 ns |  46,048.2 ns |  46,492.4 ns |    21,801.7 |      - |     256 B |
|  FirstUsage | Syste(...)rator [36] | 10000 |  60,600.5 ns |  64,730.4 ns |  3,548.09 ns |  2,048.49 ns |  58,192.7 ns |  58,563.2 ns |  58,933.7 ns |  61,804.4 ns |  64,675.1 ns |    16,501.5 |      - |     128 B |
|  CountUsage | Syste(...)rator [36] | 10000 | 448,028.3 ns | 662,215.9 ns | 36,298.29 ns | 20,956.83 ns | 423,684.7 ns | 427,168.2 ns | 430,651.7 ns | 460,200.1 ns | 489,748.5 ns |     2,232.0 |      - |     128 B |
| SingleUsage | Syste(...)rator [36] | 10000 | 541,113.5 ns | 129,869.5 ns |  7,118.59 ns |  4,109.92 ns | 533,433.1 ns | 537,925.2 ns | 542,417.3 ns | 544,953.7 ns | 547,490.0 ns |     1,848.0 |      - |     128 B |
|  WhereUsage | Syste(...)rator [36] | 10000 | 557,900.8 ns | 330,165.8 ns | 18,097.50 ns | 10,448.60 ns | 539,227.3 ns | 549,170.5 ns | 559,113.7 ns | 567,237.5 ns | 575,361.3 ns |     1,792.4 |      - |     256 B |
