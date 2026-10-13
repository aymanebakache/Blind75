# Encode and Decode Strings

## Approach
- **Encode:** Prefix each string with its length followed by `#`.
- **Decode:** Read the length, extract exactly that many characters, and move to the next string.
- Handles strings containing `#` and empty strings.

## Complexity Analysis
- **Time:** `O(m + n)` for both encoding and decoding.
- **Space:** `O(m + n)`.

Where `m` is the total length of all strings and `n` is the number of strings.