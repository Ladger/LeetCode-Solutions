# 🧠 Problem: 54. Spiral Matrix

- **Link:** [Problem Link](https://leetcode.com/problems/spiral-matrix/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Array
- Matrix
- Simulation

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Treat the matrix as layers (top row, right column, bottom row, left column) and shrink boundaries after each traversal.
- Keep track of four boundaries (top, bottom, left, right) and iterate while a valid submatrix still exists.
- The process is a controlled simulation rather than movement with visited tracking.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- Using visited array unnecessarily, making the solution more complex than needed.
- Incorrect loop condition using || instead of &&, which allows invalid traversal states.
- Forgetting to check boundary validity before traversing bottom row or left column.
- Attempting to “react” to edges instead of proactively controlling boundaries.

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Use four boundaries to represent the current valid submatrix.
- Traverse in four fixed directions in order: left → right, top → bottom, right → left, bottom → top.
- After each direction, shrink the corresponding boundary.
- Always ensure boundaries still define a valid region before continuing traversal steps.

---

## ⏱️ Complexity
- **Time:** O(m x n)
- **Space:** O(m x n) (output list creation)

---

## 🧠 When to Use This Pattern
- When traversing 2D grids in layers or rings.
- When a problem involves visiting matrix elements in a specific order without revisiting.
- When simulation with controlled boundaries is required instead of graph traversal.

---

## 🔗 Similar Questions
- [59. Spiral Matrix II](https://leetcode.com/problems/spiral-matrix-ii/)
- [885. Spiral Matrix III](https://leetcode.com/problems/spiral-matrix-iii/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2