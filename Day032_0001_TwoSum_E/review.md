# 🧠 Problem: 1. Two Sum

- **Link:** [Problem Link](https://leetcode.com/problems/two-sum/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Array
- Hash Table

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- As you iterate through the array, store each number in a hash map.
- For each element, check if its complement (target - current) has already been seen.
- This allows finding the answer in one pass.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- At my very first attempt (probably last year), I have tried brute force first (nested loops → O(n²))
- I am assuming we are having O(1) lookup with dictionary, however there might be hash collisions that will leads us to O(n^2) solution again.

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Use a Dictionary (value → index) for O(1) lookup
- Iterate once and check if complement exists
- This reduces time complexity from O(n²) → O(n)

---

## ⏱️ Complexity
- **Time:** O(n)
- **Space:** O(n)

---

## 🧠 When to Use This Pattern
- When you need to:
    Find a pair with a specific sum
    Check existence of a value quickly
- Especially useful when:
    Array is unsorted
    You need fast lookup (O(1))

---

## 🔗 Similar Questions
- [15. 3Sum](https://leetcode.com/problems/3sum/)
- [18. 4Sum](https://leetcode.com/problems/4sum/)
- [560. Subarray Sum Equals K](https://leetcode.com/problems/subarray-sum-equals-k/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2