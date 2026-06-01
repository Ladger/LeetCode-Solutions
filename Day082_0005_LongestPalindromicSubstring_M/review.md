# 🧠 Problem: 5. Longest Palindromic Substring

- **Link:** [Problem Link](https://leetcode.com/problems/longest-palindromic-substring/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Two Pointers
- Array
- Dynamic Programming

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- A substring `s[i..j]` is a palindrome if the endpoints match (`s[i] == s[j]`) AND the inner substring `s[i+1..j-1]` is also a palindrome.
- We store whether each substring is valid using a DP table so we don’t recompute results for overlapping substrings.
- We build solutions from smaller substrings to larger ones (by increasing length).

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- Confusing DP state meaning at first (`dp[i][j]` felt abstract).
- Trying to iterate with `i, j` directly instead of understanding required order.
- Incorrect base case logic (`i - j` instead of using substring length).
- Not initially understanding how DP dependency (`dp[i+1][j-1]`) forces evaluation order.

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Use a 2D DP table:
  - `dp[i][j] = true if s[i..j] is palindrome`
- Fill by increasing substring length:
  - length = 1 → always true
  - length = 2 → compare characters
  - length ≥ 3 → use recurrence:
    - `s[i] == s[j] && dp[i+1][j-1]`
- Track the longest valid substring during DP updates.

---

## ⏱️ Complexity
- **Time:** O(n^2)
- **Space:** O(n^2)

---

## 🧠 When to Use This Pattern
- When a problem involves:
  - substrings / subarrays
  - overlapping subproblems
  - checking validity of a range `[i..j]`
- Especially when the answer depends on smaller inner segments.

### 💡 Mental trigger:
“Can I determine the answer for a range using a smaller range inside it?”

---

## 🔗 Similar Questions
- [Shortest Palindrome](https://leetcode.com/problems/shortest-palindrome/)
- [Palindrome Pairs](https://leetcode.com/problems/palindrome-pairs/)
- [Longest Palindromic Subsequence](https://leetcode.com/problems/palindrome-pairs/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2