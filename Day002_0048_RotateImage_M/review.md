# 🧠 Problem: 48. Rotate Image

- **Link:** [Problem Link](https://leetcode.com/problems/rotate-image/description/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Matrix Manipulation
- In-place

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- 90-180-270 degrees rotations can represented by transpose, column and row reversals.
Therefore, we can make the rotations in-place also.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
It can be leading error if we forget it is only valid for the square matrices.

Only struggle for this problem thinking the rotations as matrix operations.
So here is the cheat sheet (clockwise):
- 90 Degrees Rotation: transpose + reverse rows
- 180 Degrees Rotation: reverse rows + reverse columns
- 270 Degrees Rotation: transpose + reverse columns

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- I learnt we can represent rotations by using the basic matrix operations efficiently and very straightforward

---

## ⏱️ Complexity
- **Time:** O(n^2)
- **Space:** O(1)

---

## 🧠 When to Use This Pattern
- Rotating square matrices
- In-place matrix transformations
- Puzzle/Board simulations

---

## 🔄 Re-solve Status
- [x] First solve
- [x] Reviewed 1
- [ ] Reviewed 2