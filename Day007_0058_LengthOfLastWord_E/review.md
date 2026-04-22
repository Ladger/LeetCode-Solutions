# 🧠 Problem: 58. Length of Last Word

- **Link:** [Problem Link](https://leetcode.com/problems/length-of-last-word/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- String

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- We should skip the empty spaces to reach any word island first.
- When we reached, just increment the length until seeing another space.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- I did not have any struggle for this question.

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Skip Trailing Spaces: Move the pointer from the end until you find a non-space character.
- Count Characters: Continue moving the pointer and increment a counter until you hit a space or the beginning of the string.

---

## ⏱️ Complexity
- **Time:** O(n)
- **Space:** O(1)

---

## 🧠 When to Use This Pattern
- Use Backward Iteration whenever the problem asks for the "last", "suffix", or "end" of a data structure, as it often allows you to ignore the prefix entirely and save time/space.
- Use it for string parsing where trailing noise (spaces, special characters) needs to be ignored.

---

## 🔄 Re-solve Status
- [x] First solve
- [x] Reviewed 1
- [ ] Reviewed 2