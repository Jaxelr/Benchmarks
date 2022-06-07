# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.300
  [Host]   : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  ShortRun : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|      Method |                 list | value |         Mean |         Error |       StdDev |      StdErr |          Min |           Q1 |       Median |           Q3 |          Max |        Op/s |  Gen 0 | Allocated |
|------------ |--------------------- |------ |-------------:|--------------:|-------------:|------------:|-------------:|-------------:|-------------:|-------------:|-------------:|------------:|-------:|----------:|
|  FirstUsage | Syste(...)rator [36] |   100 |     452.1 ns |      18.07 ns |      0.99 ns |     0.57 ns |     451.3 ns |     451.6 ns |     451.8 ns |     452.5 ns |     453.2 ns | 2,211,831.5 | 0.0200 |     128 B |
|    AnyUsage | Syste(...)rator [36] |   100 |     462.3 ns |     300.55 ns |     16.47 ns |     9.51 ns |     450.5 ns |     452.9 ns |     455.4 ns |     468.3 ns |     481.2 ns | 2,162,895.0 | 0.0200 |     128 B |
|  CountUsage | Syste(...)rator [36] |   100 |   4,083.9 ns |     865.27 ns |     47.43 ns |    27.38 ns |   4,030.8 ns |   4,064.8 ns |   4,098.9 ns |   4,110.4 ns |   4,122.0 ns |   244,864.9 | 0.0153 |     128 B |
| SingleUsage | Syste(...)rator [36] |   100 |   4,166.3 ns |   1,987.22 ns |    108.93 ns |    62.89 ns |   4,072.0 ns |   4,106.7 ns |   4,141.5 ns |   4,213.5 ns |   4,285.5 ns |   240,019.3 | 0.0153 |     128 B |
|    AnyUsage | Syste(...)rator [36] |  1000 |   4,174.6 ns |   2,857.29 ns |    156.62 ns |    90.42 ns |   4,048.0 ns |   4,087.0 ns |   4,126.0 ns |   4,237.9 ns |   4,349.7 ns |   239,544.8 | 0.0153 |     128 B |
|  FirstUsage | Syste(...)rator [36] |  1000 |   4,263.7 ns |   3,788.57 ns |    207.66 ns |   119.90 ns |   4,125.3 ns |   4,144.3 ns |   4,163.3 ns |   4,332.9 ns |   4,502.5 ns |   234,539.3 | 0.0153 |     128 B |
|  WhereUsage | Syste(...)rator [36] |   100 |   5,104.3 ns |   1,814.07 ns |     99.44 ns |    57.41 ns |   5,000.2 ns |   5,057.3 ns |   5,114.3 ns |   5,156.3 ns |   5,198.3 ns |   195,914.9 | 0.0381 |     256 B |
|  FirstUsage | Syste(...)rator [36] | 10000 |  40,489.0 ns |  11,878.93 ns |    651.12 ns |   375.93 ns |  39,769.4 ns |  40,214.8 ns |  40,660.2 ns |  40,848.8 ns |  41,037.4 ns |    24,698.1 |      - |     128 B |
|  CountUsage | Syste(...)rator [36] |  1000 |  41,267.1 ns |  13,923.77 ns |    763.21 ns |   440.64 ns |  40,694.7 ns |  40,833.8 ns |  40,973.0 ns |  41,553.3 ns |  42,133.6 ns |    24,232.4 |      - |     128 B |
| SingleUsage | Syste(...)rator [36] |  1000 |  41,662.6 ns |  35,254.47 ns |  1,932.42 ns | 1,115.68 ns |  40,331.1 ns |  40,554.4 ns |  40,777.6 ns |  42,328.3 ns |  43,879.0 ns |    24,002.4 |      - |     128 B |
|    AnyUsage | Syste(...)rator [36] | 10000 |  41,951.8 ns |  14,354.41 ns |    786.81 ns |   454.27 ns |  41,050.6 ns |  41,676.9 ns |  42,303.1 ns |  42,402.5 ns |  42,501.8 ns |    23,836.9 |      - |     128 B |
|  WhereUsage | Syste(...)rator [36] |  1000 |  45,520.8 ns |   5,143.43 ns |    281.93 ns |   162.77 ns |  45,226.1 ns |  45,387.3 ns |  45,548.4 ns |  45,668.2 ns |  45,787.9 ns |    21,968.0 |      - |     256 B |
| SingleUsage | Syste(...)rator [36] | 10000 | 399,920.2 ns |  53,966.43 ns |  2,958.08 ns | 1,707.85 ns | 397,693.9 ns | 398,241.9 ns | 398,789.9 ns | 401,033.4 ns | 403,276.8 ns |     2,500.5 |      - |     128 B |
|  CountUsage | Syste(...)rator [36] | 10000 | 415,098.5 ns |  86,896.33 ns |  4,763.08 ns | 2,749.97 ns | 409,602.5 ns | 413,634.4 ns | 417,666.4 ns | 417,846.5 ns | 418,026.7 ns |     2,409.1 |      - |     128 B |
|  WhereUsage | Syste(...)rator [36] | 10000 | 447,913.7 ns | 302,231.06 ns | 16,566.30 ns | 9,564.56 ns | 429,021.3 ns | 441,891.8 ns | 454,762.3 ns | 457,360.0 ns | 459,957.7 ns |     2,232.6 |      - |     256 B |
