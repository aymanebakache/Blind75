# Products of Array Except Self

## Approach
- First pass: Store the product of all elements to the left of each index.
- Second pass: Multiply each result by the product of all elements to the right.
- Uses constant extra space, excluding the result array.

## Complexity Analysis
- **Time:** `O(n)`
- **Space:** `O(1)` auxiliary space, excluding the output array.