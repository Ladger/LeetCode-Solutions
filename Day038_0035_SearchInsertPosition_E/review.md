# 🧠 Problem: 35. Search Insert Position

- **Link:** [Problem Link](https://leetcode.com/problems/search-insert-position/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Array
- Binary Search

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Use binary search to narrow down the position of the target.
- If the target is not found, the left pointer (l) ends up at the correct insert position.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- Tried to manually adjust mid (m += ... / m -= ...) instead of recomputing it each iteration
- Initially computed midpoint incorrectly as (r - l) / 2 (lost offset of l)
- Caused infinite loop / TLE due to not shrinking the search space properly

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Always recompute midpoint using: m = l + (r - l) / 2;
- Update boundaries correctly:
    - nums[m] < target → l = m + 1
    - nums[m] > target → r = m - 1
- If not found, return l, which represents the correct insertion index

---

## ⏱️ Complexity
- **Time:** O(logn)
- **Space:** O(1)

---

## 🧠 When to Use This Pattern
- When working with a sorted array
- When searching for:
    - exact value
    - insertion position
    - boundary (first ≥ target, last ≤ target, etc.)
- When you need logarithmic performance instead of linear scan

---

## 🔗 Similar Questions
- [278. First Bad Version](https://leetcode.com/problems/first-bad-version/)
- [3065. Minimum Operations to Exceed Threshold Value I](https://leetcode.com/problems/minimum-operations-to-exceed-threshold-value-i/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2