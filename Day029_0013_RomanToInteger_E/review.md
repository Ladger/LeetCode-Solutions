# 🧠 Problem: 13. Roman to Integer

- **Link:** [Problem Link](https://leetcode.com/problems/roman-to-integer/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- HashMap / Dictionary
- String Traversal
- Greedy

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Roman numerals are usually added, but in some cases smaller values before larger ones mean subtraction.
- Traverse the string and compare adjacent values.
- If a smaller value comes before a larger one → subtract, otherwise → add.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Use a dictionary to map Roman characters to integers.
- Traverse the string right to left
- If the current is smaller than the previous substract the result
- Else add the result

---

## ⏱️ Complexity
- **Time:** O(n)
- **Space:** O(1)

---

## 🧠 When to Use This Pattern
- When dealing with symbol-to-value mappings (e.g., Roman numerals)
- When local comparisons determine global result
- When greedy decisions can be made based on adjacent elements

---

## 🔗 Similar Questions
- [12. Integer to Roman](https://leetcode.com/problems/integer-to-roman/)
- [171. Excel Sheet Column Number](https://leetcode.com/problems/excel-sheet-column-number/)
- [168. Excel Sheet Column Title](https://leetcode.com/problems/excel-sheet-column-title/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2