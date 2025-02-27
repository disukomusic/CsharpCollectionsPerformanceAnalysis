Angelo Licavoli

CMP220 SP25

2/27/2025

Collections Analysis

### Example Usage

```CollectionsAnalysis.exe --t 10 --w 1000000```

`--t [number]` : The number of tests to run.

`--w [number]` : The number of strings to add to each collection.

### Design Theory

The [original collections test](https://github.com/Chatham-University/java-collection-performance-disukomusic), written in Java, had a few issues I aimed to fix.
1. We often aren't adding a bunch of random ints to a collection.
   1. Let's use strings instead, which might be more common in actual code. 
2. There's no way to choose how many numbers to add to each collection without editing the java code.
   1. I added variables and command line arguments to choose how many tests to run.
3. To get more accurate results, you would have to run multiple varying tests and calculate average on your own.
   1. The test now can run multiple tests automatically and returns the user the average of all the results instead of 
   the results of just 1.
4. I'm bad at java so i ported it to c# lol

### Sample Results

Each results value used the average of 25 tests.

| Number of Strings | Array Time (ms) | ArrayList Time (ms) | List Time (ms) | LinkedList |
|-------------------|-----------------|---------------------|-------|------------|
| 10                | 0.28            | 0.04                | 0.04  | 0.2        |
| 100               | 0.04            | 0                   | 0     | 0          |
| 1,000             | 0.08            | 0.08                | 0.04  | 0.04       |
| 10,000            | 0.04            | 0.2                 | 0.04  | 0.08       |
| 100,000           | 0.12            | 1.2                 | 0.64  | 2.84       |
| 1,000,000         | 5.96            | 9.6                 | 8.56  | 89.12      |
| 10,000,000        | 46.08           | 188.4               | 119.56 | 912.8      |
| 100,000,000       | 458.96          | 1721.6              | 1281.2 | 8733.44    |
| 1,000,000,000     | 4437            | 10033               | 12531 | N/A        |

*1 Billion Times are a little inaccurate, my RAM maxed out on the 1 billion LinkedList, so I lowered it down to just 1 test for each type.*
