# 🧠 Problem: 289. Game of Life

- **Link:** [Problem Link](https://leetcode.com/problems/game-of-life/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Array
- Matrix
- Simulation

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Get neighbor count of an element
- Mark the transitions different from 1 and 0
- Iterate the matrix again and set the transitions either 1 or 0

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- If I remember correct, the first challange I faced was inplace constraint in the follow up
- I could not think adding -1 and 2 states for transitions and iterate the matrix two times

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Iterate the matrix and get neighbor count of the element
    - If element is 1 check neighbor count, if it is greater than 3 or lower than 2 mark as -1
    - If element is 0 check neighbor count, if it is exactly 3 mark as 2
- Iterate the matrix second time
    - If element is greater than 0, mark them as 1 since the next generation state
    - Else, mark them as 0 since the next generation state
- 2 means dead->alive, -1 means alive->dead transitions

---

## ⏱️ Complexity
- **Time:** O(n^2)
- **Space:** O(1)

---

## 🧠 When to Use This Pattern

- When a problem requires **simultaneous updates** to a grid (you cannot overwrite values immediately).
- When you need to **avoid extra space** and perform updates **in-place**.
- When the current state and next state both need to be accessible during iteration.
- When working with **matrix/grid neighbor-based rules** (e.g., 8-directional checks).
- When constraints push for **O(1) space optimization** instead of using a copy of the board.
- When you can **encode multiple states in one cell** (e.g., using markers like -1, 2).
- Common in problems involving:
  - Cellular automata (like Game of Life)
  - Image processing (neighbor-based transformations)
  - Grid simulations with transition rules

---

## 🔗 Similar Questions
- [73. Set Matrix Zeroes](https://leetcode.com/problems/set-matrix-zeroes/)

---

## 🔄 Re-solve Status
- [x] First solve
- [x] Reviewed 1
- [ ] Reviewed 2