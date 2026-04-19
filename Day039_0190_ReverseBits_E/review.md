# 🧠 Problem: 190. Reverse Bits

- **Link:** [Problem Link](https://leetcode.com/problems/reverse-bits/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Divide and Conquer
- Bit Manipulation

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Each iteration shift the result and add least signifacnt bit of n,
- Then shift n for the next LSB.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- In my first attempt, I used stack for pushing the bits and taking reverse order.
- It causing unnecessary two passes, which we can deal with only one.
- Also I tried to use Math.Pow() function, it is odd since we can just shift the result variable each iteration.
- I forgot the int variables is always 32 bit, so I have tried to find the length of the integer.

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Iterate 32 times
- Shift the result to the left
- Mask the LSB of n on that iteration and add to the result
- Shift n to the right

---

## ⏱️ Complexity
- **Time:** O(1) (int is 32-bit)
- **Space:** O(1)

---

## 🧠 When to Use This Pattern
- Dealing with bit manipulation problems (especially reversing, shifting, or constructing numbers bit-by-bit)
- Required to process a fixed number of bits (e.g., 32-bit integers)
- Asked to reverse binary representation or reorder bits
- Building a result incrementally using shifts (<<, >>)
- Trying to avoid extra space (like stacks, arrays)

---

## 🔗 Similar Questions
- [7. Reverse Integer](https://leetcode.com/problems/reverse-integer/)
- [191. Number of 1 Bits](https://leetcode.com/problems/number-of-1-bits/)
- [2119. A Number After a Double Reversal](https://leetcode.com/problems/a-number-after-a-double-reversal/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2