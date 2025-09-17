# For loops

Benchmark for custom loops [as described on this article](https://habr.com/en/post/575916/).

```

BenchmarkDotNet v0.15.2, Windows 11 (10.0.26100.6584/24H2/2024Update/HudsonValley)
Unknown processor
.NET SDK 9.0.305
  [Host]   : .NET 9.0.9 (9.0.925.41916), Arm64 RyuJIT AdvSIMD
  ShortRun : .NET 9.0.9 (9.0.925.41916), Arm64 RyuJIT AdvSIMD

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                        | Increment | Iterations | Mean       | Error       | StdDev     | StdErr    | Min        | Max        | Op/s      | Ratio | Allocated | Alloc Ratio |
|------------------------------ |---------- |----------- |-----------:|------------:|-----------:|----------:|-----------:|-----------:|----------:|------:|----------:|------------:|
| ForWithCustomIncrement        | 1         | 10000      |   2.590 μs |   0.7633 μs |  0.0418 μs | 0.0242 μs |   2.546 μs |   2.628 μs | 386,056.2 |  1.00 |         - |          NA |
| ForWithIncrementBy1           | 1         | 10000      |   2.592 μs |   1.0135 μs |  0.0556 μs | 0.0321 μs |   2.553 μs |   2.655 μs | 385,870.8 |  1.00 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 10000      |  18.010 μs |   3.0925 μs |  0.1695 μs | 0.0979 μs |  17.883 μs |  18.203 μs |  55,523.3 |  6.95 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 10000      |  18.891 μs |  11.8004 μs |  0.6468 μs | 0.3734 μs |  18.476 μs |  19.636 μs |  52,935.7 |  7.29 |      56 B |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 10000      |  21.248 μs |   0.9343 μs |  0.0512 μs | 0.0296 μs |  21.189 μs |  21.282 μs |  47,064.0 |  8.20 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 10000      |  21.381 μs |   3.1604 μs |  0.1732 μs | 0.1000 μs |  21.195 μs |  21.537 μs |  46,770.1 |  8.25 |         - |          NA |
|                               |           |            |            |             |            |           |            |            |           |       |           |             |
| ForWithCustomIncrement        | 1         | 100000     |  25.512 μs |   3.1440 μs |  0.1723 μs | 0.0995 μs |  25.369 μs |  25.703 μs |  39,196.8 |  1.00 |         - |          NA |
| ForWithIncrementBy1           | 1         | 100000     |  25.553 μs |   3.3603 μs |  0.1842 μs | 0.1063 μs |  25.423 μs |  25.764 μs |  39,134.2 |  1.00 |         - |          NA |
| ForeachWithEnumerableRange    | 1         | 100000     | 183.800 μs | 187.2280 μs | 10.2626 μs | 5.9251 μs | 177.864 μs | 195.651 μs |   5,440.7 |  7.19 |      40 B |          NA |
| ForeachWithYieldReturn        | 1         | 100000     | 202.117 μs |  88.0170 μs |  4.8245 μs | 2.7854 μs | 198.123 μs | 207.477 μs |   4,947.6 |  7.91 |      56 B |          NA |
| ForeachWithRangeEnumeratorRaw | 1         | 100000     | 225.168 μs |  93.5216 μs |  5.1262 μs | 2.9596 μs | 219.254 μs | 228.343 μs |   4,441.1 |  8.81 |         - |          NA |
| ForeachWithRangeEnumerator    | 1         | 100000     | 240.935 μs | 125.6626 μs |  6.8880 μs | 3.9768 μs | 232.982 μs | 245.006 μs |   4,150.5 |  9.43 |         - |          NA |
