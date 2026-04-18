# 🧠 Problem: 191. Number of 1 Bits

- **Link:** [Problem Link](https://leetcode.com/problems/number-of-1-bits/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Divide and Conquer
- Bit Manipulation

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Each iteration check the least significant bit 1 or 0,
- If 1 add to counter and take the next bit.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- I didn't know about the precedence on '&' operator
- "n & 1 == 1" statement is checking the '1 == 1' first, therefore it causes error

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Check the last bit is set by (n & 1) == 1, if yes increment counter
- Shift the number to the right (divide by 2)
- Repeat until number becomes 0
- Return the counter

---

## ⏱️ Complexity
- **Time:** O(1) (int is 32-bit)
- **Space:** O(1)

---

## 🧠 When to Use This Pattern
- When you want to inspect bits one by one
- When learning or debugging bitwise operations
- When the constraint is small/fixed (e.g., 32-bit integers)
- Useful for:
    - understanding binary representation
    - simple bit checks (&, >>)
    - stepping into more advanced tricks later

---

## 🔗 Similar Questions
- [190. Reverse Bits](https://leetcode.com/problems/reverse-bits/)
- [231. Power of Two](https://leetcode.com/problems/power-of-two/)
- [338. Counting Bits](https://leetcode.com/problems/counting-bits/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2