# 🧠 Problem: 14. Longest Common Prefix

- **Link:** [Problem Link](https://leetcode.com/problems/longest-common-prefix/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Array
- String
- Trie

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- The longest common prefix must be a prefix of every string.
- We can compare characters either horizontally (string by string) or vertically (column by column).
- The moment a mismatch occurs, we stop, everything before that is the answer.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- Rebuilding strings repeatedly using StringBuilder (unnecessary overhead). 
- It causes O(M) space complexity where M is the prefix length

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Iterate over each character index i of the first string.
- Compare that character with all other strings.
- Stop immediately when:
    Index goes out of bounds
    Characters differ

---

## ⏱️ Complexity
- **Time:** O(M * N)
- **Space:** O(1)

---

## 🧠 When to Use This Pattern
- You need to find a common prefix / shared structure
- You can terminate early on mismatch
- You are comparing multiple strings character-by-character

---

## 🔗 Similar Questions
- [2996. Smallest Missing Integer Greater Than Sequential Prefix Sum](https://leetcode.com/problems/smallest-missing-integer-greater-than-sequential-prefix-sum/)
- [3043. Find the Length of the Longest Common Prefix](https://leetcode.com/problems/find-the-length-of-the-longest-common-prefix/)
- [3093. Longest Common Suffix Queries](https://leetcode.com/problems/longest-common-suffix-queries/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2