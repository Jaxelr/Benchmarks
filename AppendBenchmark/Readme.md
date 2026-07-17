# Append an element to an array

I needed to benchmark an addition of an element to an array using multiple scenarios [as described on this article](https://www.techiedelight.com/add-new-elements-array-csharp/).

```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8875/25H2/2025Update/HudsonValley2)
Snapdragon X 12-core X1E80100 3.40 GHz (Max: 3.42GHz), 1 CPU, 12 logical and 12 physical cores
.NET SDK 10.0.302
  [Host]   : .NET 10.0.10 (10.0.10, 10.0.1026.32716), Arm64 RyuJIT armv8.0-a
  ShortRun : .NET 10.0.10 (10.0.10, 10.0.1026.32716), Arm64 RyuJIT armv8.0-a

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method       | array        | value | Mean       | Error     | StdDev   | StdErr   | Min        | Max        | Op/s        | Ratio | Gen0    | Gen1   | Allocated | Alloc Ratio |
|------------- |------------- |------ |-----------:|----------:|---------:|---------:|-----------:|-----------:|------------:|------:|--------:|-------:|----------:|------------:|
| AppendCopyTo | Int32[1000]  | 4     |   127.0 ns |  13.10 ns |  0.72 ns |  0.41 ns |   126.6 ns |   127.9 ns | 7,871,514.1 |  0.34 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 4     |   140.5 ns |  20.84 ns |  1.14 ns |  0.66 ns |   139.7 ns |   141.8 ns | 7,115,397.3 |  0.38 |  0.9842 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 4     |   373.6 ns |  77.73 ns |  4.26 ns |  2.46 ns |   370.2 ns |   378.4 ns | 2,676,926.9 |  1.00 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 4     |   477.1 ns | 290.39 ns | 15.92 ns |  9.19 ns |   464.5 ns |   495.0 ns | 2,095,809.2 |  1.28 |  3.8457 |      - |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 4     |   980.3 ns |  63.63 ns |  3.49 ns |  2.01 ns |   976.9 ns |   983.9 ns | 1,020,119.6 |  2.62 |  9.5234 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 4     | 1,025.7 ns | 758.77 ns | 41.59 ns | 24.01 ns |   998.8 ns | 1,073.6 ns |   974,923.9 |  2.75 |  9.5234 |      - |  39.18 KB |        9.95 |
| Append       | Int32[10000] | 4     | 2,944.4 ns | 120.64 ns |  6.61 ns |  3.82 ns | 2,937.5 ns | 2,950.7 ns |   339,629.0 |  7.88 |  9.5215 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 4     | 3,574.1 ns | 355.44 ns | 19.48 ns | 11.25 ns | 3,557.7 ns | 3,595.6 ns |   279,787.8 |  9.57 | 37.9715 | 6.3286 | 156.36 KB |       39.71 |
|              |              |       |            |           |          |          |            |            |             |       |         |        |           |             |
| AppendCopyTo | Int32[1000]  | 101   |   131.6 ns |   5.96 ns |  0.33 ns |  0.19 ns |   131.4 ns |   131.9 ns | 7,600,573.5 |  0.34 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendConcat | Int32[1000]  | 101   |   146.4 ns |  24.08 ns |  1.32 ns |  0.76 ns |   144.8 ns |   147.3 ns | 6,832,587.4 |  0.38 |  0.9842 |      - |   4.02 KB |        1.02 |
| Append       | Int32[1000]  | 101   |   383.0 ns |  22.52 ns |  1.23 ns |  0.71 ns |   381.6 ns |   383.7 ns | 2,611,126.6 |  1.00 |  0.9632 |      - |   3.94 KB |        1.00 |
| AppendToList | Int32[1000]  | 101   |   475.9 ns |  65.14 ns |  3.57 ns |  2.06 ns |   472.8 ns |   479.8 ns | 2,101,239.2 |  1.24 |  3.8452 |      - |  15.73 KB |        4.00 |
| AppendCopyTo | Int32[10000] | 101   | 1,041.6 ns | 273.17 ns | 14.97 ns |  8.64 ns | 1,031.5 ns | 1,058.8 ns |   960,061.4 |  2.72 |  9.5234 |      - |  39.09 KB |        9.93 |
| AppendConcat | Int32[10000] | 101   | 1,071.1 ns |  97.33 ns |  5.33 ns |  3.08 ns | 1,066.5 ns | 1,076.9 ns |   933,617.2 |  2.80 |  9.5234 |      - |  39.18 KB |        9.95 |
| Append       | Int32[10000] | 101   | 3,045.0 ns |  30.78 ns |  1.69 ns |  0.97 ns | 3,043.5 ns | 3,046.8 ns |   328,412.2 |  7.95 |  9.5215 |      - |  39.09 KB |        9.93 |
| AppendToList | Int32[10000] | 101   | 3,640.0 ns | 207.40 ns | 11.37 ns |  6.56 ns | 3,629.0 ns | 3,651.7 ns |   274,721.6 |  9.50 | 37.9715 | 6.3286 | 156.36 KB |       39.71 |
