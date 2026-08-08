# Contains Duplicate
URL:https://neetcode.io/problems/duplicate-integer/question?list=blind75
LeetCode: 217
Difficulty: Easy
## Description of the Problem
Given an integer array nums, return true if any value appears more than once in the array, otherwise return false.

## Approach

Use a HashSet to keep track of values already seen.

For every number:
- If it already exists in the HashSet → duplicate found.
- Otherwise, add it to the HashSet.

## Complexity

Time: O(n)
Space: O(n)