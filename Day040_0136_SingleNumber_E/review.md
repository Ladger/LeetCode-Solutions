# 🧠 Problem: 136. Single Number

- **Link:** [Problem Link](https://leetcode.com/problems/single-number/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Array
- Bit Manipulation

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Use the XOR operation to cancel out duplicate numbers.
- Since `a ^ a = 0` and `a ^ 0 = a`, all paired elements eliminate each other, leaving only the unique number.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- Initially tried using `~(a ^ b)` instead of pure XOR.
- This introduced unnecessary bitwise negation, breaking the cancellation property.
- The solution *passed all test cases*, which was misleading.
- Failed to recognize that correctness relied on hidden constraints (array length parity).

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Use a single variable and apply XOR across all elements
- This works because duplicate numbers cancel out, and only the unique number remains.

---

## ⏱️ Complexity
- **Time:** O(n)
- **Space:** O(1)

---

## ⚠️ Special Note (Interesting Edge Insight)

- An alternative operation like ~(a ^ b) may also appear to work.
- This is because:
    - ~x = x ^ (-1) (bitwise inversion)
    - The operation effectively becomes XOR with an extra toggle mask.
- Over the entire array, this results in:
    - result = (XOR of all elements) ^ (mask if n is even)
- However, in this problem:
    - Array size is always 2k + 1 (odd), due to pairing + one unique element.
    - So the extra mask is never applied at the end → result stays correct.

### 👉 Important:
This method is not generally correct
It only works because of the odd-length constraint

---

## 🧠 When to Use This Pattern
- Every element appears exactly twice except one
- Frequency problems without extra memory
- Bit manipulation optimization scenarios

---

## 🔗 Similar Questions
- [137. Single Number II](https://leetcode.com/problems/single-number-ii/)
- [260. Single Number III](https://leetcode.com/problems/single-number-iii/)
- [268. Missing Number](https://leetcode.com/problems/missing-number/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2