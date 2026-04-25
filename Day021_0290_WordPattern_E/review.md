# 🧠 Problem: 290. Word Pattern

- **Link:** [Problem Link](https://leetcode.com/problems/word-pattern/description/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Hashmap
- Bijection

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Storing the relation between character and the word for bidirectional, since every letter must represent only one word.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- In my first run, I tried to make this without word splitting that caused me index errors and small bugs.
- Also, I believed if TryGetValue returns false, the out value will be default and therefore i was checking '\0' or null instead of boolean.

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- I used 2 dictionaries for mapping char to string and string to char to provide biconditinal structure.
- I created a function for processing word, it compares the mapped values are correct if not we return false.
If both dictionaries have not mapping, I am adding the mapping for next iterations
- I am using edge case comparing pattern length and words list length, if they are not equal return false automatically

---

## ⏱️ Complexity
- **Time:** O(n)
- **Space:** O(n)

---

## 🧠 When to Use This Pattern
- Pattern matching
- Encoding/Decoding mappings

---

## 🔗 Similar Questions
- [205. Isomorphic Strings](https://leetcode.com/problems/isomorphic-strings/)
- [890. Find and Replace Pattern](https://leetcode.com/problems/find-and-replace-pattern/)

---

## 🔄 Re-solve Status
- [x] First solve
- [x] Reviewed 1
- [ ] Reviewed 2