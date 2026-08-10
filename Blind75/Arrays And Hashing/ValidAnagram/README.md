# Valid Anagram

**NeetCode:** https://neetcode.io/problems/is-anagram/question?list=blind75
**Difficulty:** Easy  
**Category:** Arrays & Hashing

## Problem

Given two strings `s` and `t`, return `true` if `t` is an anagram of `s`, and `false` otherwise.

An anagram is a word or phrase formed by rearranging the letters of another word or phrase, using all the original letters exactly once.

### Example

```text
Input:  s = "anagram"
        t = "nagaram"

Output: true
```

```text
Input:  s = "rat"
        t = "car"

Output: false
```

---

## Approach 1: Sorting

### Idea

Two strings are anagrams if they contain exactly the same characters with the same frequencies.

If we sort both strings, anagrams will produce the same sorted string.

```text
"anagram" → "aaagmnr"
"nagaram" → "aaagmnr"
```

Therefore, we can simply compare the sorted strings.

### Complexity

Let `n` be the length of the strings.

- **Time:** `O(n log n)`
- **Space:** `O(n)`

The sorting operation dominates the time complexity.

---

## Approach 2: Frequency Array

### Idea

Since the problem only contains lowercase English letters (`a-z`), there are only **26 possible characters**.

We can use an integer array of size 26 to count the frequency of each character.

```text
'a' → index 0
'b' → index 1
'c' → index 2
...
'z' → index 25
```

The expression:

```csharp
s[i] - 'a'
```

converts a character into its corresponding array index.

For every character in `s`, increment its frequency:

```csharp
frequencies[s[i] - 'a']++;
```

For every character in `t`, decrement its frequency:

```csharp
frequencies[t[i] - 'a']--;
```

If `s` and `t` are anagrams, all frequencies will be `0` at the end.


### Complexity

Let `n` be the length of the strings.

- **Time:** `O(n)`
- **Space:** `O(26)` → `O(1)`

---

## Comparison

| Approach | Time | Space | Main Idea |
|---|---:|---:|---|
| Sorting | `O(n log n)` | `O(n)` | Sort and compare |
| Frequency Array | `O(n)` | `O(1)` | Count characters |

