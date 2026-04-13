# 🧠 Problem: 392. Is Subsequence

- **Link:** [Problem Link](https://leetcode.com/problems/is-subsequence/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Two Pointers
- String Traversal

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Use two pointers to iterate through both strings.
- Move pointer in s only when characters match, always move pointer in t.
- If you reach the end of s, it is a subsequence.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- Forgetting edge case: empty s should return true.
- I faced index out of range problems, but getting better to solve immidieatly.

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Giving two pointer; one for potential subsequence, one for string.
- Iterate until one of them reaches their length.
- At the end we are checking potential subsequence reached its length, if yes than it is subsequence.

---

## ⏱️ Complexity
- **Time:** O(n + m)
- **Space:** O(1)

---

## 🧠 When to Use This Pattern
- When checking if one sequence is contained in another in order
- When relative order matters but not contiguity

---

## 🔗 Similar Questions
- [792. Number of Matching Subsequences](https://leetcode.com/problems/number-of-matching-subsequences/)
- [2486. Append Characters to String to Make Subsequence](https://leetcode.com/problems/append-characters-to-string-to-make-subsequence/)
- [2825. Make String a Subsequence Using Cyclic Increments](https://leetcode.com/problems/make-string-a-subsequence-using-cyclic-increments/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2