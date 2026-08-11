# Group Anagrams

**NeetCode:** https://neetcode.io/problems/anagram-groups/question?list=blind75
**Difficulty:** Medium  
**Category:** Arrays & Hashing

## Approach

Two words are anagrams if they have the same frequency for each character.

Since the input contains lowercase English letters, we use a frequency array of size `26`.

For each word:

```text
character → index
'a'       → 0
'b'       → 1
...
'z'       → 25
```

The frequency array is converted into a string and used as the `Dictionary` key.

```csharp
string key = string.Join("#", frequencies);
```

The `#` is simply a separator between frequency values.

### Example

```text
eat → [1,0,0,0,1,0,...,1]
tea → [1,0,0,0,1,0,...,1]
ate → [1,0,0,0,1,0,...,1]
```

They have the same key, so they belong to the same group.



## Complexity

Let `n` be the number of words and `k` the maximum word length.

- **Time:** `O(n × k)`
- **Space:** `O(n × k)`

```