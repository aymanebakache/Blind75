# Two Sum

**NeetCode:** https://neetcode.io/problems/two-integer-sum/question?list=blind75
**Difficulty:** Easy  
**Category:** Arrays & Hashing

## Problem

Given an integer array `nums` and an integer `target`, return the indices of the two numbers such that they add up to `target`.

You may assume that each input has exactly one solution, and you cannot use the same element twice.

### Example

```text
Input:
nums = [2, 7, 11, 15]
target = 9

Output:
[0, 1]
```

Because:

```text
nums[0] + nums[1]
= 2 + 7
= 9
```

---

## Approach: HashMap / Dictionary

### Idea

For each number, we need to find its **complement**:

```text
complement = target - current
```

Instead of searching the entire array for the complement, we store previously visited numbers and their indices in a `Dictionary`.

The dictionary stores:

```text
number → index
```

For every element:

1. Calculate its complement.
2. Check whether the complement already exists in the dictionary.
3. If it exists, we found the two required indices.
4. Otherwise, store the current number and its index.



## Complexity

Let `n` be the length of `nums`.

### Time Complexity

We traverse the array once:

```text
O(n)
```

Dictionary operations such as `ContainsKey` and insertion are **O(1)** on average.

Therefore:

```text
Time: O(n)
```

### Space Complexity

In the worst case, we store all elements in the dictionary:

```text
Space: O(n)
```

---

