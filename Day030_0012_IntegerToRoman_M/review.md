# 🧠 Problem: 12. Integer To Roman

- **Link:** [Problem Link](https://leetcode.com/problems/integer-to-roman/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- HashMap / Dictionary
- Math
- String
- Greedy

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Instead of handling Roman rules manually, define all valid Roman numeral values including subtractive cases (e.g., 900, 400, 90, etc.).
- Iterate from largest to smallest and greedily subtract from the number while appending the corresponding symbol.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- Initially tried to break the number into frequencies of base values (1000, 500, etc.), which made handling subtractive cases (like 4, 9) complex.
- Attempted to handle special cases using index manipulation (i+1, i-1), which is error-prone.
- Used separate structures (dictionary + fractions), causing unnecessary complexity and double lookup.

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Store all values and symbols together, including subtractive ones:
    (1000, "M"), (900, "CM"), (500, "D"), ...
- Iterate through them and:
- While the number is greater than or equal to the value:
    Append symbol
    Subtract value
    This is a greedy + data-driven approach with no special-case logic.

---

## ⏱️ Complexity
- **Time:** O(1)
- **Space:** O(1)

---

## 🧠 When to Use This Pattern
- When a problem involves fixed mappings with special edge cases
- When a greedy approach works with ordered values (largest → smallest)

---

## 🔗 Similar Questions
- [13. Roman to Integer](https://leetcode.com/problems/roman-to-integer/)
- [171. Excel Sheet Column Number](https://leetcode.com/problems/excel-sheet-column-number/)
- [168. Excel Sheet Column Title](https://leetcode.com/problems/excel-sheet-column-title/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2