# First Duplicate
Solution to the "First Duplicate" problem in C#.

## Problem

Given an array that contains only numbers in the range 1 to array.Length, find the first duplicate number for
which the second occurrence has the minimal index. If there is no such number, return -1.

**Note:** Write a solution with O(n) time complexity and O(1) additional space complexity.

### Example

Input:

```
[2, 3, 3, 1, 5, 2]
```

Output:

```
3
```
There are 2 duplicates: 2 and 3. the second occurrence of 3 has smaller index (position 2 of the array) than the second occurrence
of 2 (position 5 of the array). Hence the first duplicate is 3.

Input:

```
[2, 4, 3, 5, 1]
```

Output:

```
- 1
```
There is not duplicated numbers in the array.

### Constraints

```
1 <= array.Length <= 10^5
1 <= array[i] <= a.length
```

