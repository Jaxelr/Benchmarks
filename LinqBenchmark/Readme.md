# Linq sample benchmarks

This is a benchmark test using different types of methods for a list of integers.

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8650U CPU 1.90GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.201
  [Host]   : .NET 6.0.3 (6.0.322.12309), X64 RyuJIT  [AttachedDebugger]
  ShortRun : .NET 6.0.3 (6.0.322.12309), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|      Method |                 list | value |         Mean |        Error |       StdDev |       StdErr |          Min |           Q1 |       Median |           Q3 |          Max |        Op/s |  Gen 0 | Allocated |
|------------ |--------------------- |------ |-------------:|-------------:|-------------:|-------------:|-------------:|-------------:|-------------:|-------------:|-------------:|------------:|-------:|----------:|
|    AnyUsage | Syste(...)rator [36] |   100 |     680.9 ns |     254.7 ns |     13.96 ns |      8.06 ns |     665.5 ns |     674.9 ns |     684.3 ns |     688.5 ns |     692.7 ns | 1,468,749.4 | 0.0305 |     128 B |
|  FirstUsage | Syste(...)rator [36] |   100 |     727.7 ns |     331.7 ns |     18.18 ns |     10.50 ns |     711.1 ns |     718.0 ns |     725.0 ns |     736.0 ns |     747.1 ns | 1,374,153.3 | 0.0305 |     128 B |
|    AnyUsage | Syste(...)rator [36] |  1000 |   5,558.4 ns |     773.8 ns |     42.41 ns |     24.49 ns |   5,529.9 ns |   5,534.0 ns |   5,538.1 ns |   5,572.6 ns |   5,607.1 ns |   179,908.6 | 0.0305 |     128 B |
|  FirstUsage | Syste(...)rator [36] |  1000 |   5,827.9 ns |     743.3 ns |     40.74 ns |     23.52 ns |   5,781.4 ns |   5,813.0 ns |   5,844.7 ns |   5,851.1 ns |   5,857.6 ns |   171,588.9 | 0.0305 |     128 B |
|  CountUsage | Syste(...)rator [36] |   100 |   5,924.8 ns |     720.0 ns |     39.47 ns |     22.79 ns |   5,881.4 ns |   5,908.0 ns |   5,934.6 ns |   5,946.5 ns |   5,958.5 ns |   168,782.1 | 0.0305 |     128 B |
| SingleUsage | Syste(...)rator [36] |   100 |   6,355.4 ns |     738.4 ns |     40.48 ns |     23.37 ns |   6,326.8 ns |   6,332.2 ns |   6,337.6 ns |   6,369.7 ns |   6,401.7 ns |   157,346.8 | 0.0305 |     128 B |
|  WhereUsage | Syste(...)rator [36] |   100 |   6,877.3 ns |   5,961.6 ns |    326.77 ns |    188.66 ns |   6,668.2 ns |   6,689.0 ns |   6,709.8 ns |   6,981.8 ns |   7,253.8 ns |   145,406.7 | 0.0610 |     256 B |
| SingleUsage | Syste(...)rator [36] |  1000 |  54,693.3 ns |   8,867.1 ns |    486.04 ns |    280.61 ns |  54,200.7 ns |  54,453.8 ns |  54,706.9 ns |  54,939.7 ns |  55,172.4 ns |    18,283.8 |      - |     128 B |
|  CountUsage | Syste(...)rator [36] |  1000 |  59,079.5 ns |  12,454.4 ns |    682.67 ns |    394.14 ns |  58,344.3 ns |  58,772.6 ns |  59,200.9 ns |  59,447.1 ns |  59,693.3 ns |    16,926.3 |      - |     128 B |
|  WhereUsage | Syste(...)rator [36] |  1000 |  59,959.9 ns |  14,188.9 ns |    777.74 ns |    449.03 ns |  59,415.1 ns |  59,514.6 ns |  59,614.1 ns |  60,232.4 ns |  60,850.6 ns |    16,677.8 | 0.0610 |     256 B |
|    AnyUsage | Syste(...)rator [36] | 10000 |  60,491.5 ns |   6,270.4 ns |    343.70 ns |    198.44 ns |  60,094.9 ns |  60,385.9 ns |  60,676.9 ns |  60,689.8 ns |  60,702.6 ns |    16,531.3 |      - |     128 B |
|  FirstUsage | Syste(...)rator [36] | 10000 |  61,344.7 ns |  39,349.9 ns |  2,156.90 ns |  1,245.29 ns |  59,965.0 ns |  60,102.0 ns |  60,238.9 ns |  62,034.6 ns |  63,830.3 ns |    16,301.3 |      - |     128 B |
| SingleUsage | Syste(...)rator [36] | 10000 | 573,837.0 ns | 351,861.0 ns | 19,286.69 ns | 11,135.18 ns | 552,175.8 ns | 566,181.7 ns | 580,187.7 ns | 584,667.6 ns | 589,147.6 ns |     1,742.7 |      - |     128 B |
|  CountUsage | Syste(...)rator [36] | 10000 | 589,524.4 ns |  38,152.1 ns |  2,091.24 ns |  1,207.38 ns | 588,129.0 ns | 588,322.2 ns | 588,515.5 ns | 590,222.2 ns | 591,928.9 ns |     1,696.3 |      - |     128 B |
|  WhereUsage | Syste(...)rator [36] | 10000 | 626,033.8 ns | 687,441.3 ns | 37,680.98 ns | 21,755.12 ns | 598,308.7 ns | 604,582.3 ns | 610,855.9 ns | 639,896.3 ns | 668,936.8 ns |     1,597.4 |      - |     256 B |
