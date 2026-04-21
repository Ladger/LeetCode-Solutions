# 🧠 Problem: 69. Sqrt(x)

- **Link:** [Problem Link](https://leetcode.com/problems/sqrtx)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Math
- Binary Search

---

## 💡 Key Idea
- We are asked to compute the integer square root of `x` (i.e., floor of √x).
- Instead of linearly checking numbers, we can use **Binary Search** on the range `[1, x/2]`.
- The key comparison is `mid * mid` vs `x`, but must be handled carefully to avoid overflow.

---

## ❌ Mistakes / Struggles
- Using a linear approach (`i * i <= x`) → too slow for large inputs.
- Integer overflow when doing `mid * mid` with large values.
- Not handling edge cases like `x = 0` or `x = 1`.
- Infinite loop due to incorrect boundary updates in binary search.

---

## 🔁 Better / Optimal Solution
- Use **Binary Search** to narrow down the answer.
- Avoid overflow by:
  - Casting to `long`, or
  - Using `mid <= x / mid` instead of `mid * mid <= x`.

---

## ⏱️ Complexity
- **Time:** O(logn)
- **Space:** O(1)

---

## 🧠 When to Use This Pattern
- When searching for a value in a monotonic function (increasing/decreasing).
- When brute-force would be too slow (e.g., O(√n) or O(n)).
- Keywords: “find largest/smallest such that…”

---

## 🔗 Similar Questions
- [50. Pow(x, n)](https://leetcode.com/problems/powx-n/)
- [367. Valid Perfect Square](https://leetcode.com/problems/valid-perfect-square/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2