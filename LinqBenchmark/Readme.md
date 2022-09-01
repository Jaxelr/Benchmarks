# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.400
  [Host]   : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT
  ShortRun : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|      Method |                 list | value |         Mean |          Error |       StdDev |       StdErr |       Median |          Min |           Q1 |           Q3 |          Max |        Op/s |  Gen 0 | Allocated |
|------------ |--------------------- |------ |-------------:|---------------:|-------------:|-------------:|-------------:|-------------:|-------------:|-------------:|-------------:|------------:|-------:|----------:|
|    AnyUsage | Syste(...)rator [36] |   100 |     789.9 ns |     1,103.2 ns |     60.47 ns |     34.91 ns |     819.1 ns |     720.4 ns |     769.8 ns |     824.7 ns |     830.2 ns | 1,265,941.3 | 0.0200 |     128 B |
|  FirstUsage | Syste(...)rator [36] |   100 |     924.7 ns |     1,569.5 ns |     86.03 ns |     49.67 ns |     945.4 ns |     830.2 ns |     887.8 ns |     971.9 ns |     998.5 ns | 1,081,450.7 | 0.0200 |     128 B |
|  FirstUsage | Syste(...)rator [36] |  1000 |   7,888.7 ns |    13,852.3 ns |    759.29 ns |    438.38 ns |   8,175.4 ns |   7,027.8 ns |   7,601.6 ns |   8,319.1 ns |   8,462.9 ns |   126,764.2 | 0.0153 |     128 B |
|    AnyUsage | Syste(...)rator [36] |  1000 |   8,221.3 ns |    11,745.8 ns |    643.83 ns |    371.71 ns |   8,460.5 ns |   7,492.1 ns |   7,976.3 ns |   8,585.9 ns |   8,711.3 ns |   121,634.9 | 0.0153 |     128 B |
|  WhereUsage | Syste(...)rator [36] |   100 |   9,061.8 ns |    36,097.4 ns |  1,978.62 ns |  1,142.36 ns |   9,704.3 ns |   6,841.8 ns |   8,273.0 ns |  10,171.8 ns |  10,639.4 ns |   110,353.0 | 0.0305 |     256 B |
| SingleUsage | Syste(...)rator [36] |   100 |   9,066.2 ns |    23,709.2 ns |  1,299.58 ns |    750.31 ns |   8,891.4 ns |   7,862.9 ns |   8,377.1 ns |   9,667.9 ns |  10,444.4 ns |   110,299.6 | 0.0153 |     128 B |
|  CountUsage | Syste(...)rator [36] |   100 |  11,891.4 ns |   104,911.7 ns |  5,750.57 ns |  3,320.09 ns |   8,968.2 ns |   8,189.7 ns |   8,579.0 ns |  13,742.3 ns |  18,516.4 ns |    84,094.0 | 0.0153 |     128 B |
|  CountUsage | Syste(...)rator [36] |  1000 |  74,350.4 ns |    82,675.0 ns |  4,531.70 ns |  2,616.38 ns |  74,574.7 ns |  69,710.7 ns |  72,142.7 ns |  76,670.3 ns |  78,765.8 ns |    13,449.8 |      - |     128 B |
| SingleUsage | Syste(...)rator [36] |  1000 |  75,082.5 ns |    99,735.2 ns |  5,466.82 ns |  3,156.27 ns |  72,472.8 ns |  71,409.6 ns |  71,941.2 ns |  76,919.0 ns |  81,365.1 ns |    13,318.7 |      - |     128 B |
|    AnyUsage | Syste(...)rator [36] | 10000 |  82,787.5 ns |    29,930.0 ns |  1,640.57 ns |    947.18 ns |  82,733.5 ns |  81,174.7 ns |  81,954.1 ns |  83,594.0 ns |  84,454.5 ns |    12,079.1 |      - |     128 B |
|  WhereUsage | Syste(...)rator [36] |  1000 |  88,515.8 ns |   118,705.5 ns |  6,506.65 ns |  3,756.61 ns |  87,939.0 ns |  82,316.8 ns |  85,127.9 ns |  91,615.3 ns |  95,291.7 ns |    11,297.4 |      - |     256 B |
|  FirstUsage | Syste(...)rator [36] | 10000 |  91,099.0 ns |   145,220.8 ns |  7,960.04 ns |  4,595.73 ns |  87,821.9 ns |  85,300.6 ns |  86,561.3 ns |  93,998.2 ns | 100,174.5 ns |    10,977.1 |      - |     128 B |
|  CountUsage | Syste(...)rator [36] | 10000 | 746,832.6 ns | 1,533,993.9 ns | 84,083.38 ns | 48,545.56 ns | 698,368.1 ns | 698,206.0 ns | 698,287.1 ns | 771,145.9 ns | 843,923.7 ns |     1,339.0 |      - |     128 B |
| SingleUsage | Syste(...)rator [36] | 10000 | 753,123.5 ns |   514,902.1 ns | 28,223.52 ns | 16,294.86 ns | 749,990.8 ns | 726,597.0 ns | 738,293.9 ns | 766,386.7 ns | 782,782.7 ns |     1,327.8 |      - |     128 B |
|  WhereUsage | Syste(...)rator [36] | 10000 | 833,422.3 ns |   549,520.2 ns | 30,121.06 ns | 17,390.40 ns | 829,270.8 ns | 805,592.3 ns | 817,431.5 ns | 847,337.3 ns | 865,403.8 ns |     1,199.9 |      - |     256 B |
