# 🧠 Problem: 189. Rotate Array

- **Link:** [Problem Link](https://leetcode.com/problems/rotate-array/)

## 🧩 Pattern / Topic
- Array
- Two Pointers
- Math

---

## 💡 Key Idea
- The core insight is treating the array as two distinct blocks of data: the first `n - k` elements and the last `k` elements. 
- By reversing these blocks individually and then reversing the entire array, the blocks seamlessly swap positions while restoring their original internal order, effectively rotating the array without needing extra memory.

---

## ❌ Mistakes / Struggles
- In the follow-up, it asked find diffrent 3 solutions at least.
- The new list solution was not hard to find.
- The inplace solution was not hard to find however multiple cyclic behaviour challanged me little.
- However, finding reversal solution was hard to find and I could not make it the get that solution.

---

## 🔁 Better / Optimal Solution
- I learned that the "Block Reversal" trick is the most elegant, optimal, and least error-prone approach. 
- Instead of mathematically calculating exactly where each individual element should land and carefully avoiding overwriting data, 
- You can achieve the exact same result through three simple array reversals. 
- It completely sidesteps the need for complex cycle-tracking variables or additional memory allocation.

---

## ⏱️ Complexity
- **Time:** O(N)
- **Space:** O(1)

---

## 🧠 When to Use This Pattern
- Whenever a problem asks you to shift, rotate, or cleanly swap large contiguous blocks of data within an array or string.
- When strict in-place modification is required, preventing the use of helper structures like stacks, queues, or secondary arrays.
- Any time you see "rotate in-place", the double-reversal trick should immediately come to mind.

---

## 🔗 Similar Questions
- [151. Reverse Words in a String](https://leetcode.com/problems/reverse-words-in-a-string/)
- [796. Rotate String](https://leetcode.com/problems/rotate-string/)
- [396. Rotate Function](https://leetcode.com/problems/rotate-function/)

---

## 🔄 Re-solve Status
- [x] First solve
- [x] Reviewed 1
- [ ] Reviewed 2