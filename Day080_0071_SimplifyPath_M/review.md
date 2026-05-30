# 🧠 Problem: 71. Simplify Path

- **Link:** [Problem Link](https://leetcode.com/problems/simplify-path)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- String
- Stack

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Split the path by `'/'` and process each token one by one.
- Ignore empty strings (`""`) and current-directory markers (`"."`).
- When encountering `".."`, move up one directory by popping from the stack if possible.
- Otherwise, push the directory name onto the stack.
- The remaining stack contents represent the canonical path.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- Initially tried to parse the string character-by-character, which introduced edge cases such as:
  - Reaching the end of the string without a trailing slash.
  - Handling consecutive slashes (`"//"`).
- Forgot that reconstructing the answer by repeatedly popping a stack reverses the directory order.
- Needed to handle `".."` carefully when already at the root directory.

---

## 🔁 Better / Optimal Solution
- Using `Split('/')` removes most parsing complexity and lets the solution focus on path semantics.
- The stack naturally models directory navigation:
  - Enter directory → Push.
  - Go back (`".."`) → Pop.
- After processing all tokens, reverse the stack contents (or convert to an array and reverse) before joining them into the final path.

---

## ⏱️ Complexity
- **Time:** O(n)
- **Space:** O(n)

---

## 🧠 When to Use This Pattern
- When processing nested structures that support "undo" operations.
- When the input contains navigation/history semantics.
- When elements can invalidate or remove previously processed elements.

### 💡 Mental trigger:
"As I read elements from left to right, can the current element cancel or remove something that came before it?"

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2