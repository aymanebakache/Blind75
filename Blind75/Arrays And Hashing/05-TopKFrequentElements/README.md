# Top K Frequent Elements

**NeetCode:** (https://neetcode.io/problems/top-k-elements-in-list/question?list=blind75)  
**Difficulty:** Medium  
**Category:** Arrays & Hashing

## Problem

Given an integer array `nums` and an integer `k`, return the `k` most frequent elements.

### Example

```text
Input:
nums = [1,1,1,2,2,3]
k = 2

Output:
[1,2]
```

---

## Approach: Bucket Sort

First, count how many times each number appears using a `Dictionary`.

```text
number → frequency
```

For example:

```text
1 → 3
2 → 2
3 → 1
```

Then invert this relationship and create buckets based on frequency:

```text
frequency → numbers
```

```text
Bucket[1] → [3]
Bucket[2] → [2]
Bucket[3] → [1]
```

The bucket index represents the frequency of the numbers inside it.

Finally, iterate through the buckets from the highest frequency to the lowest and collect the first `k` elements.

---



## Complexity

Let `n` be the length of `nums`.

- **Time:** `O(n)`
- **Space:** `O(n)`

We avoid sorting the elements, which would require `O(n log n)` time.

---

## Key Pattern

```text
nums
  ↓
Dictionary
number → frequency
  ↓
Bucket Sort
frequency → numbers
  ↓
Traverse from highest frequency
  ↓
Take K elements
```

### Important Idea

The key transformation is:

```text
number → frequency
```

becomes:

```text
frequency → numbers
```

This allows us to find the most frequent elements without sorting.