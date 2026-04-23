# 🧠 Problem: 151. Reverse Words in a String

- **Link:** [Problem Link](https://leetcode.com/problems/reverse-words-in-a-string/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Two Pointers
- Array

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Instead of directly reversing word order, reverse the entire string first, then reverse each word individually to restore correct word structure.
- Finally, rebuild the string in-place while removing extra spaces using a read/write pointer technique.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- Initially relied on a stack + string builder approach, which increased space complexity unnecessarily.
- Missed handling of trailing spaces, leading to incorrect outputs with extra spaces at the end.
- Incorrect pointer movement (especially advancing the read pointer too early) caused skipped characters.
- Confusion between “removing spaces” vs “not copying unwanted spaces.”

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Use a character array to simulate in-place modification (since strings are immutable in C#).
- Reverse the entire array first.
- Traverse and reverse each word individually using two pointers.
- Perform a final pass using read and write pointers to:
    - skip leading spaces
    - copy words
    - insert a single space between words
- This avoids extra data structures and ensures O(1) auxiliary space (ignoring the char array conversion).

---

## ⏱️ Complexity
- **Time:** O(n)
- **Space:** O(1) (regarding char array, since c# strings not mutable)

---

## 🧠 When to Use This Pattern
- When modifying a string or array in-place is required.
- When needing to reorder elements without extra space.
- Problems involving:
    - removing duplicates or extra characters
    - compressing or normalizing sequences (e.g., spaces)
    - reversing segments within an array/string
- When a problem involves both transformation and cleanup, separate them into phases (e.g., reverse → fix → compress).

---

## 🔗 Similar Questions
- [Reverse Words in a String II](https://leetcode.com/problems/reverse-words-in-a-string-ii/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2