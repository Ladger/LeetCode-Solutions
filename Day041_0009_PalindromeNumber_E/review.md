# 🧠 Problem: 9. Palindrome Number

- **Link:** [Problem Link](https://leetcode.com/problems/palindrome-number/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Math

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- We are reversing the integer through sequence of math operations.
- At the end comparing with the original value and the reversed one.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- I found two solutions, the non-optimal one is turning the number to the string.
- The running time complexity is not changing, however we are using extra O(n) space in that solution.

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Keep two variables: original and reversed
- In the while loop until x becomes zero
  - We are taking the current x's last digit
  - Shifting the reversed to the left and adding the digit we found
  - Divide x by 10
- Compare the reversed and original values and return the result

---

## ⏱️ Complexity
- **Time:** O(n)
- **Space:** O(1)

---

## 🧠 When to Use This Pattern
- When you need to check if a number reads the same forward and backward (**digit symmetry**).
- When the problem involves **reversing digits** or comparing mirrored positions.
- Common in problems involving:
  - Digit manipulation
  - Number reversal
  - Symmetry checks without extra memory

---

## 🔗 Similar Questions
- [234. Palindrome Linked List](https://leetcode.com/problems/palindrome-linked-list/)
- [2217. Find Palindrome With Fixed Length](https://leetcode.com/problems/find-palindrome-with-fixed-length/)
- [3260. Find the Largest Palindrome Divisible by K](https://leetcode.com/problems/find-the-largest-palindrome-divisible-by-k/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2