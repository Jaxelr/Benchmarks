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
|      Method |                 list | value |         Mean |        Error |      StdDev |      StdErr |          Min |           Q1 |       Median |           Q3 |          Max |        Op/s |  Gen 0 | Allocated |
|------------ |--------------------- |------ |-------------:|-------------:|------------:|------------:|-------------:|-------------:|-------------:|-------------:|-------------:|------------:|-------:|----------:|
|  FirstUsage | Syste(...)rator [36] |   100 |     473.8 ns |     133.4 ns |     7.31 ns |     4.22 ns |     466.4 ns |     470.2 ns |     474.0 ns |     477.5 ns |     481.0 ns | 2,110,660.6 | 0.0200 |     128 B |
|    AnyUsage | Syste(...)rator [36] |   100 |     497.9 ns |     212.2 ns |    11.63 ns |     6.72 ns |     485.5 ns |     492.6 ns |     499.7 ns |     504.1 ns |     508.6 ns | 2,008,321.8 | 0.0200 |     128 B |
|  CountUsage | Syste(...)rator [36] |   100 |   4,407.6 ns |   3,020.7 ns |   165.57 ns |    95.59 ns |   4,284.9 ns |   4,313.5 ns |   4,342.0 ns |   4,469.0 ns |   4,596.0 ns |   226,879.8 | 0.0153 |     128 B |
| SingleUsage | Syste(...)rator [36] |   100 |   4,505.5 ns |   2,678.8 ns |   146.84 ns |    84.78 ns |   4,406.9 ns |   4,421.2 ns |   4,435.4 ns |   4,554.8 ns |   4,674.3 ns |   221,949.4 | 0.0153 |     128 B |
|    AnyUsage | Syste(...)rator [36] |  1000 |   4,663.7 ns |   6,354.8 ns |   348.33 ns |   201.11 ns |   4,265.8 ns |   4,538.6 ns |   4,811.4 ns |   4,862.6 ns |   4,913.8 ns |   214,422.7 | 0.0153 |     128 B |
|  FirstUsage | Syste(...)rator [36] |  1000 |   4,969.6 ns |   6,161.8 ns |   337.75 ns |   195.00 ns |   4,595.6 ns |   4,828.2 ns |   5,060.9 ns |   5,156.6 ns |   5,252.3 ns |   201,223.2 | 0.0153 |     128 B |
|  WhereUsage | Syste(...)rator [36] |   100 |   5,107.2 ns |   1,549.6 ns |    84.94 ns |    49.04 ns |   5,057.7 ns |   5,058.1 ns |   5,058.6 ns |   5,131.9 ns |   5,205.2 ns |   195,803.2 | 0.0381 |     256 B |
|    AnyUsage | Syste(...)rator [36] | 10000 |  40,125.2 ns |  10,489.8 ns |   574.98 ns |   331.97 ns |  39,658.6 ns |  39,804.0 ns |  39,949.5 ns |  40,358.5 ns |  40,767.5 ns |    24,922.0 |      - |     128 B |
|  FirstUsage | Syste(...)rator [36] | 10000 |  40,437.6 ns |  14,223.7 ns |   779.65 ns |   450.13 ns |  39,962.6 ns |  39,987.7 ns |  40,012.8 ns |  40,675.1 ns |  41,337.4 ns |    24,729.5 |      - |     128 B |
| SingleUsage | Syste(...)rator [36] |  1000 |  43,886.7 ns |  37,650.8 ns | 2,063.77 ns | 1,191.52 ns |  42,507.7 ns |  42,700.4 ns |  42,893.1 ns |  44,576.2 ns |  46,259.3 ns |    22,785.9 |      - |     129 B |
|  WhereUsage | Syste(...)rator [36] |  1000 |  45,582.0 ns |   7,580.5 ns |   415.51 ns |   239.90 ns |  45,117.1 ns |  45,414.3 ns |  45,711.5 ns |  45,814.4 ns |  45,917.3 ns |    21,938.5 |      - |     256 B |
|  CountUsage | Syste(...)rator [36] |  1000 |  46,220.4 ns |  33,573.6 ns | 1,840.28 ns | 1,062.49 ns |  44,711.0 ns |  45,195.3 ns |  45,679.7 ns |  46,975.0 ns |  48,270.4 ns |    21,635.5 |      - |     128 B |
|  CountUsage | Syste(...)rator [36] | 10000 | 403,101.3 ns |  86,084.0 ns | 4,718.56 ns | 2,724.26 ns | 398,941.0 ns | 400,537.7 ns | 402,134.5 ns | 405,181.4 ns | 408,228.4 ns |     2,480.8 |      - |     128 B |
|  WhereUsage | Syste(...)rator [36] | 10000 | 409,032.1 ns | 103,832.5 ns | 5,691.41 ns | 3,285.94 ns | 402,464.0 ns | 407,292.6 ns | 412,121.1 ns | 412,316.1 ns | 412,511.1 ns |     2,444.8 |      - |     256 B |
| SingleUsage | Syste(...)rator [36] | 10000 | 411,499.7 ns | 160,025.6 ns | 8,771.54 ns | 5,064.25 ns | 405,577.7 ns | 406,461.2 ns | 407,344.6 ns | 414,460.6 ns | 421,576.7 ns |     2,430.1 |      - |     128 B |
