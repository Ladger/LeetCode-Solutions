# 🧠 Problem: 125. Valid Palindrome

- **Link:** [Problem Link](https://leetcode.com/problems/valid-palindrome)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Two Pointers
- String

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Put two pointers one in left, one in right
- Move them until both of them are valid letter or digit

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- I struggled how to understand the digits are valid
- Because I did not know any function for the char data type called **IsLetterOrDigit()**

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Iterate until l smaller than r
- Start pointers one from left, other from right
- Check them whether they are valid
- If not move the pointer for invalid one
- If both are valid just compare them
    - If they are equal, move the both pointers
    - If not return false

---

## ⏱️ Complexity
- **Time:** O(n)
- **Space:** O(1)

---

## 🧠 When to Use This Pattern
- You need to compare elements from the ends of a sequence toward the center.
- You are checking for symmetry (palindromes).
- You are asked to reverse a string or array in-place.
- You need to find pairs in a sorted array that sum to a target (Two Sum on sorted input).

---

## 🔗 Similar Questions
- [234. Palindrome Linked List](https://leetcode.com/problems/palindrome-linked-list/)
- [680. Valid Palindrome II](https://leetcode.com/problems/valid-palindrome-ii/)
- [2002. Maximum Product of the Length of Two Palindromic Subsequences](https://leetcode.com/problems/maximum-product-of-the-length-of-two-palindromic-subsequences/)

---

## 🔄 Re-solve Status
- [x] First solve
- [x] Reviewed 1
- [ ] Reviewed 2