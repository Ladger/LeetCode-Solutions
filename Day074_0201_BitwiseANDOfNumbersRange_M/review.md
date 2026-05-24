# 🧠 Problem: 201. Bitwise AND of Numbers Range

- **Link:** [Problem Link](https://leetcode.com/problems/bitwise-and-of-numbers-range/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Bit Manipulation

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- The bitwise AND of a range only keeps the bits that are identical in every number in the range.
- As soon as a bit changes between left and right, all lower bits will become 0 due to intermediate numbers.
- So the result is just the common binary prefix of left and right, with the rest filled with zeros.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- Trying brute force AND across all numbers in the range → TLE.
- Initially thinking per-bit comparison requires complex logic.
- Not realizing that once a bit differs, lower bits become irrelevant immediately.

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Instead of iterating all numbers, focus on binary structure.
- Either:
  - Find the common prefix bit-by-bit from MSB → LSB, or
  - Repeatedly right shift both numbers until they become equal (removing differing suffix)
- Then restore the prefix by shifting back.

---

## ⏱️ Complexity
- **Time:** O(1)
- **Space:** O(1)

---

## 🧠 When to Use This Pattern
- Range problems involving bitwise AND/OR/XOR
- When intermediate values in a range “destroy” bit information
- Problems asking for result over a continuous interval of integers

### 💡 Mental trigger:
“If numbers are consecutive, think about bit changes across range instead of iterating.”

---

## 🔗 Similar Questions
- [Longest Nice Subarray](https://leetcode.com/problems/longest-nice-subarray/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2