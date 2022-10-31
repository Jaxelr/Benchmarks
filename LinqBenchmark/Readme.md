# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.674)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.402
  [Host]   : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT AVX2
  ShortRun : .NET 6.0.10 (6.0.1022.47605), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|      Method |                 list | value |         Mean |       Error |     StdDev |     StdErr |          Min |          Max |      Op/s |   Gen0 | Allocated |
|------------ |--------------------- |------ |-------------:|------------:|-----------:|-----------:|-------------:|-------------:|----------:|-------:|----------:|
|    AnyUsage | Syste(...)rator [36] |   100 |     1.895 μs |   2.2632 μs |  0.1241 μs |  0.0716 μs |     1.757 μs |     1.998 μs | 527,639.8 | 0.0191 |     128 B |
|  FirstUsage | Syste(...)rator [36] |   100 |     1.969 μs |   0.6947 μs |  0.0381 μs |  0.0220 μs |     1.928 μs |     2.004 μs | 507,973.6 | 0.0191 |     128 B |
|    AnyUsage | Syste(...)rator [36] |  1000 |    16.370 μs |   5.9087 μs |  0.3239 μs |  0.1870 μs |    15.997 μs |    16.583 μs |  61,087.8 |      - |     128 B |
|  CountUsage | Syste(...)rator [36] |   100 |    16.535 μs |   3.2069 μs |  0.1758 μs |  0.1015 μs |    16.333 μs |    16.642 μs |  60,476.2 |      - |     128 B |
| SingleUsage | Syste(...)rator [36] |   100 |    16.553 μs |   5.6820 μs |  0.3115 μs |  0.1798 μs |    16.222 μs |    16.840 μs |  60,410.3 |      - |     128 B |
|  WhereUsage | Syste(...)rator [36] |   100 |    17.459 μs |   4.3289 μs |  0.2373 μs |  0.1370 μs |    17.299 μs |    17.732 μs |  57,277.3 | 0.0305 |     256 B |
|  FirstUsage | Syste(...)rator [36] |  1000 |    18.537 μs |   5.3377 μs |  0.2926 μs |  0.1689 μs |    18.316 μs |    18.869 μs |  53,945.6 |      - |     128 B |
| SingleUsage | Syste(...)rator [36] |  1000 |   156.243 μs |  67.1195 μs |  3.6790 μs |  2.1241 μs |   152.098 μs |   159.123 μs |   6,400.3 |      - |     128 B |
|    AnyUsage | Syste(...)rator [36] | 10000 |   161.685 μs |  63.0275 μs |  3.4548 μs |  1.9946 μs |   157.697 μs |   163.764 μs |   6,184.9 |      - |     128 B |
|  CountUsage | Syste(...)rator [36] |  1000 |   164.232 μs | 122.3009 μs |  6.7037 μs |  3.8704 μs |   159.975 μs |   171.960 μs |   6,088.9 |      - |     128 B |
|  FirstUsage | Syste(...)rator [36] | 10000 |   164.452 μs | 102.1132 μs |  5.5972 μs |  3.2315 μs |   157.990 μs |   167.788 μs |   6,080.8 |      - |     128 B |
|  WhereUsage | Syste(...)rator [36] |  1000 |   183.216 μs | 238.9054 μs | 13.0952 μs |  7.5605 μs |   171.459 μs |   197.329 μs |   5,458.0 |      - |     256 B |
|  CountUsage | Syste(...)rator [36] | 10000 | 1,490.526 μs | 399.3784 μs | 21.8913 μs | 12.6389 μs | 1,477.113 μs | 1,515.788 μs |     670.9 |      - |     129 B |
|  WhereUsage | Syste(...)rator [36] | 10000 | 1,514.967 μs | 999.2798 μs | 54.7739 μs | 31.6237 μs | 1,463.753 μs | 1,572.715 μs |     660.1 |      - |     257 B |
| SingleUsage | Syste(...)rator [36] | 10000 | 1,558.001 μs | 617.4231 μs | 33.8430 μs | 19.5393 μs | 1,526.351 μs | 1,593.677 μs |     641.8 |      - |     129 B |
