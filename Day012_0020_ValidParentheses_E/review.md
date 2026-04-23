# 🧠 Problem: 20. Valid Parentheses

- **Link:** [Problem Link](https://leetcode.com/problems/valid-parentheses/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- String
- Stack

---

## 💡 Key Idea
- The core insight is utilizing the Last-In-First-Out (LIFO) property of a Stack. 
- Every time you encounter an opening bracket, you save it. 
- Whenever you encounter a closing bracket, it *must* correspond to the most recently saved (unclosed) opening bracket at the top of the stack.

---

## ❌ Mistakes / Struggles
- I did not have many struggles, since I knew the problem before I started to solve.

---

## 🔁 Better / Optimal Solution
- If opening parenthes, push the stack
- If closing parenthes, pop from stack
- Compare the current and popped parentheses, 
    - if they match continue
    - else return false since it is invalid

---

## ⏱️ Complexity
- **Time:** O(N)
- **Space:** O(N)

---

## 🧠 When to Use This Pattern
- Whenever you are dealing with matching pairs, nested structures, or evaluating mathematical expressions/syntax.
- Any time the most recent item you encountered is the first item you need to resolve (Last-In-First-Out).
- Problems involving parsing paths (like simplifying directory paths).

---

## 🔗 Similar Questions
- [22. Generate Parentheses](https://leetcode.com/problems/generate-parentheses/)
- [921. Minimum Add to Make Parentheses Valid](https://leetcode.com/problems/minimum-add-to-make-parentheses-valid/)
- [1047. Remove All Adjacent Duplicates In String](https://leetcode.com/problems/remove-all-adjacent-duplicates-in-string/)

---

## 🔄 Re-solve Status
- [x] First solve
- [x] Reviewed 1
- [ ] Reviewed 2