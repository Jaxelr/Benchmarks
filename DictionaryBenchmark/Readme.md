# Dictionary benchmark

This is a benchmark performing operations to the different types of dictionaries in dotnet.

```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.4349)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.301
  [Host]  : .NET 9.0.6 (9.0.625.26613), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  LongRun : .NET 9.0.6 (9.0.625.26613), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI

Job=LongRun  InvocationCount=1  IterationCount=100  
LaunchCount=3  UnrollFactor=1  WarmupCount=15  

```
| Method                    | Items | Mean         | Error       | StdDev        | StdErr     | Min          | Max           | Op/s      | Ratio | Gen0      | Gen1      | Allocated  | Alloc Ratio |
|-------------------------- |------ |-------------:|------------:|--------------:|-----------:|-------------:|--------------:|----------:|------:|----------:|----------:|-----------:|------------:|
| AddReadOnlyDictionary     | 100   |    16.350 μs |   0.4883 μs |     2.3469 μs |  0.1467 μs |    13.000 μs |     25.800 μs |  61,160.6 |  0.60 |         - |         - |    17024 B |        1.00 |
| AddFrozenDictionary       | 100   |    24.338 μs |   1.3311 μs |     6.6729 μs |  0.4002 μs |    17.800 μs |     47.800 μs |  41,087.5 |  0.90 |         - |         - |    26160 B |        1.54 |
| AddPlainDictionary        | 100   |    28.267 μs |   1.0124 μs |     5.1491 μs |  0.3045 μs |    16.800 μs |     37.600 μs |  35,377.2 |  1.04 |         - |         - |    16984 B |        1.00 |
| AddImmutableDictionary    | 100   |    87.004 μs |   3.9194 μs |    19.1732 μs |  1.1778 μs |    74.300 μs |    178.900 μs |  11,493.8 |  3.21 |         - |         - |    69144 B |        4.07 |
|                           |       |              |             |               |            |              |               |           |       |           |           |            |             |
| AddPlainDictionary        | 1000  |   121.838 μs |   3.3276 μs |    16.5272 μs |  1.0003 μs |    98.550 μs |    199.300 μs |   8,207.6 |  1.01 |         - |         - |   162016 B |        1.00 |
| AddReadOnlyDictionary     | 1000  |   123.532 μs |   2.8332 μs |    14.2810 μs |  0.8519 μs |   106.000 μs |    177.100 μs |   8,095.1 |  1.03 |         - |         - |   162056 B |        1.00 |
| AddFrozenDictionary       | 1000  |   169.362 μs |   4.3219 μs |    21.7057 μs |  1.2995 μs |   144.100 μs |    259.600 μs |   5,904.5 |  1.41 |         - |         - |   250536 B |        1.55 |
| AddImmutableDictionary    | 1000  |   771.715 μs |  62.9102 μs |   325.0730 μs | 18.9265 μs |   369.700 μs |  1,842.100 μs |   1,295.8 |  6.43 |         - |         - |   902296 B |        5.57 |
|                           |       |              |             |               |            |              |               |           |       |           |           |            |             |
| AddPlainDictionary        | 10000 | 1,020.235 μs |  49.5829 μs |   251.7374 μs | 14.9116 μs |   713.500 μs |  1,839.350 μs |     980.2 |  1.05 |         - |         - |  1549336 B |        1.00 |
| AddReadOnlyDictionary     | 10000 | 1,259.003 μs |  83.7695 μs |   428.3431 μs | 25.1967 μs |   729.050 μs |  2,398.350 μs |     794.3 |  1.30 |         - |         - |  1549040 B |        1.00 |
| AddFrozenDictionary       | 10000 | 1,694.633 μs |  80.9715 μs |   408.1443 μs | 24.3478 μs | 1,022.600 μs |  3,091.800 μs |     590.1 |  1.75 |         - |         - |  2458480 B |        1.59 |
| AddImmutableDictionary    | 10000 | 7,194.672 μs | 112.5721 μs |   557.0223 μs | 33.8367 μs | 6,424.900 μs |  8,989.800 μs |     139.0 |  7.42 | 1000.0000 | 1000.0000 | 11191000 B |        7.22 |
|                           |       |              |             |               |            |              |               |           |       |           |           |            |             |
| ReadPlainDictionary       | 100   |     1.608 μs |   0.0760 μs |     0.3928 μs |  0.0229 μs |     1.100 μs |      2.900 μs | 621,838.1 |  1.05 |         - |         - |      736 B |        1.00 |
| ReadFrozenDictionary      | 100   |     2.301 μs |   0.1297 μs |     0.6679 μs |  0.0390 μs |     1.300 μs |      4.000 μs | 434,524.7 |  1.51 |         - |         - |      736 B |        1.00 |
| ReadReadOnlyDictionary    | 100   |     2.826 μs |   0.1726 μs |     0.8979 μs |  0.0519 μs |     1.500 μs |      4.900 μs | 353,846.2 |  1.85 |         - |         - |      736 B |        1.00 |
| ReadImmutableDictionary   | 100   |     9.368 μs |   0.2305 μs |     1.1931 μs |  0.0693 μs |     7.200 μs |     12.250 μs | 106,749.4 |  6.14 |         - |         - |      736 B |        1.00 |
|                           |       |              |             |               |            |              |               |           |       |           |           |            |             |
| ReadPlainDictionary       | 1000  |    18.197 μs |   1.0596 μs |     5.1733 μs |  0.3184 μs |    12.900 μs |     42.600 μs |  54,953.1 |  1.06 |         - |         - |      736 B |        1.00 |
| ReadFrozenDictionary      | 1000  |    22.974 μs |   1.2306 μs |     6.1691 μs |  0.3700 μs |    12.450 μs |     39.200 μs |  43,527.3 |  1.34 |         - |         - |      736 B |        1.00 |
| ReadReadOnlyDictionary    | 1000  |    38.264 μs |   4.2930 μs |    22.2597 μs |  1.2916 μs |    16.100 μs |    104.300 μs |  26,134.5 |  2.23 |         - |         - |      736 B |        1.00 |
| ReadImmutableDictionary   | 1000  |    75.343 μs |   1.9034 μs |     9.3468 μs |  0.5720 μs |    48.400 μs |    104.300 μs |  13,272.7 |  4.39 |         - |         - |      448 B |        0.61 |
|                           |       |              |             |               |            |              |               |           |       |           |           |            |             |
| ReadFrozenDictionary      | 10000 |    53.185 μs |   2.0863 μs |    10.6303 μs |  0.6275 μs |    30.100 μs |     79.800 μs |  18,802.4 |  0.86 |         - |         - |      736 B |        1.00 |
| ReadPlainDictionary       | 10000 |    65.788 μs |   3.7147 μs |    17.6380 μs |  1.1155 μs |    43.300 μs |    134.500 μs |  15,200.3 |  1.06 |         - |         - |      736 B |        1.00 |
| ReadReadOnlyDictionary    | 10000 |    99.055 μs |   5.4413 μs |    26.2037 μs |  1.6345 μs |    61.700 μs |    152.900 μs |  10,095.4 |  1.60 |         - |         - |      400 B |        0.54 |
| ReadImmutableDictionary   | 10000 |   598.648 μs |  24.5370 μs |   123.0049 μs |  7.3773 μs |   442.800 μs |    914.800 μs |   1,670.4 |  9.67 |         - |         - |      736 B |        1.00 |
|                           |       |              |             |               |            |              |               |           |       |           |           |            |             |
| RemovePlainDictionary     | 100   |     1.796 μs |   0.0916 μs |     0.4749 μs |  0.0276 μs |     1.000 μs |      3.000 μs | 556,701.0 |  1.08 |         - |         - |      736 B |        1.00 |
| RemoveFrozenDictionary    | 100   |     2.769 μs |   0.0934 μs |     0.4833 μs |  0.0281 μs |     1.700 μs |      4.200 μs | 361,195.9 |  1.66 |         - |         - |      448 B |        0.61 |
| RemoveReadOnlyDictionary  | 100   |     2.976 μs |   0.1072 μs |     0.5493 μs |  0.0323 μs |     1.700 μs |      4.400 μs | 336,076.0 |  1.78 |         - |         - |      776 B |        1.05 |
| RemoveImmutableDictionary | 100   |    88.183 μs |   3.8496 μs |    19.9262 μs |  1.1582 μs |    44.500 μs |    146.100 μs |  11,340.1 | 52.89 |         - |         - |    29560 B |       40.16 |
|                           |       |              |             |               |            |              |               |           |       |           |           |            |             |
| RemoveReadOnlyDictionary  | 1000  |    16.782 μs |   0.9126 μs |     4.3422 μs |  0.2741 μs |    11.500 μs |     36.100 μs |  59,587.4 |  0.86 |         - |         - |      488 B |        0.66 |
| RemoveFrozenDictionary    | 1000  |    18.984 μs |   2.4483 μs |    12.2056 μs |  0.7360 μs |    11.100 μs |     81.600 μs |  52,675.9 |  0.97 |         - |         - |      736 B |        1.00 |
| RemovePlainDictionary     | 1000  |    24.715 μs |   2.9132 μs |    14.8697 μs |  0.8762 μs |    11.000 μs |     79.500 μs |  40,461.4 |  1.27 |         - |         - |      736 B |        1.00 |
| RemoveImmutableDictionary | 1000  |   683.199 μs |  73.4312 μs |   372.8179 μs | 22.0838 μs |   184.600 μs |  1,933.200 μs |   1,463.7 | 35.08 |         - |         - |   443704 B |      602.86 |
|                           |       |              |             |               |            |              |               |           |       |           |           |            |             |
| RemoveReadOnlyDictionary  | 10000 |    53.320 μs |   2.5887 μs |    12.9292 μs |  0.7782 μs |    39.700 μs |    100.200 μs |  18,754.8 |  1.06 |         - |         - |      776 B |        1.05 |
| RemovePlainDictionary     | 10000 |    53.562 μs |   2.9065 μs |    14.7830 μs |  0.8741 μs |    37.950 μs |    104.800 μs |  18,670.1 |  1.07 |         - |         - |      736 B |        1.00 |
| RemoveFrozenDictionary    | 10000 |    80.473 μs |   4.6363 μs |    23.8737 μs |  1.3947 μs |    45.550 μs |    156.150 μs |  12,426.5 |  1.60 |         - |         - |      400 B |        0.54 |
| RemoveImmutableDictionary | 10000 | 4,110.618 μs | 322.5772 μs | 1,596.1563 μs | 96.9596 μs | 2,336.000 μs |  7,332.700 μs |     243.3 | 81.75 |         - |         - |  6003864 B |    8,157.42 |
|                           |       |              |             |               |            |              |               |           |       |           |           |            |             |
| WritePlainDictionary      | 100   |    23.228 μs |   1.2757 μs |     6.1433 μs |  0.3832 μs |    16.400 μs |     39.100 μs |  43,050.7 |  1.06 |         - |         - |    10336 B |        1.00 |
| WriteReadOnlyDictionary   | 100   |    25.926 μs |   1.5225 μs |     7.7435 μs |  0.4579 μs |    16.400 μs |     42.300 μs |  38,571.0 |  1.19 |         - |         - |    10376 B |        1.00 |
| WriteFrozenDictionary     | 100   |    28.259 μs |   1.4934 μs |     7.4590 μs |  0.4490 μs |    21.300 μs |     64.300 μs |  35,386.4 |  1.29 |         - |         - |    15200 B |        1.47 |
| WriteImmutableDictionary  | 100   |   125.485 μs |   6.2182 μs |    31.5137 μs |  1.8700 μs |    97.100 μs |    213.900 μs |   7,969.1 |  5.74 |         - |         - |    51456 B |        4.98 |
|                           |       |              |             |               |            |              |               |           |       |           |           |            |             |
| WriteFrozenDictionary     | 1000  |   165.884 μs |   2.2077 μs |    10.6950 μs |  0.6633 μs |   142.400 μs |    193.600 μs |   6,028.3 |  0.88 |         - |         - |   143552 B |        1.49 |
| WriteReadOnlyDictionary   | 1000  |   187.488 μs |   9.1249 μs |    46.0784 μs |  2.7439 μs |   109.200 μs |    368.700 μs |   5,333.7 |  0.99 |         - |         - |    96776 B |        1.00 |
| WritePlainDictionary      | 1000  |   203.583 μs |  11.0274 μs |    57.2761 μs |  3.3179 μs |   115.850 μs |    353.000 μs |   4,912.0 |  1.07 |         - |         - |    96448 B |        1.00 |
| WriteImmutableDictionary  | 1000  | 1,019.152 μs |  87.3608 μs |   441.9481 μs | 26.2711 μs |   520.100 μs |  2,479.600 μs |     981.2 |  5.38 |         - |         - |   711904 B |        7.38 |
|                           |       |              |             |               |            |              |               |           |       |           |           |            |             |
| WriteReadOnlyDictionary   | 10000 |   905.302 μs |  28.9030 μs |   145.1578 μs |  8.6904 μs |   732.100 μs |  1,443.100 μs |   1,104.6 |  1.01 |         - |         - |   960488 B |        1.00 |
| WritePlainDictionary      | 10000 |   925.831 μs |  35.5558 μs |   180.5205 μs | 10.6931 μs |   739.950 μs |  1,662.650 μs |   1,080.1 |  1.03 |         - |         - |   960736 B |        1.00 |
| WriteFrozenDictionary     | 10000 | 1,454.879 μs |  94.5740 μs |   479.3013 μs | 28.4413 μs |   926.850 μs |  3,315.300 μs |     687.3 |  1.62 |         - |         - |  1409072 B |        1.47 |
| WriteImmutableDictionary  | 10000 | 8,094.262 μs | 123.3665 μs |   606.9709 μs | 37.0767 μs | 6,588.600 μs | 10,258.700 μs |     123.5 |  9.03 | 1000.0000 | 1000.0000 |  9273120 B |        9.65 |
