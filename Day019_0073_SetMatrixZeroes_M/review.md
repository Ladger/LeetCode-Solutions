# 🧠 Problem: 73. Set Matrix Zeroes

- **Link:** [Problem Link](https://leetcode.com/problems/set-matrix-zeroes/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Array
- Hash Table
- Matrix

---

## 💡 Key Idea
- If you mutate a matrix while actively iterating through it, you trigger a chain reaction of incorrect zeroes. 
- To achieve true $O(1)$ auxiliary space, you can use the matrix's *own* first row and first column as state buffers (acting as the boolean arrays) to track which rows and columns need to be zeroed out.

---

## ❌ Mistakes / Struggles
- The initial approach used a `HashSet` to store indices. While mathematically $O(M + N)$ space, the hashing overhead and heap allocations in C# drag down performance.
- Upgrading to primitive boolean arrays solved the hashing overhead, but still required allocating $O(M + N)$ extra memory.
- When transitioning to the constant space solution, the biggest trap is `matrix[0][0]`. Since the first row and first column share this top-left cell, they can overwrite each other's state. 
- We must isolate the checks for the first row and first column into their own boolean variables (`firstRowZero`, `firstColZero`) *before* you start using them as flag storage for the rest of the grid.

---

## 🔁 Better / Optimal Solution
- **The True $O(1)$ Space Approach:** 
  1. Scan just the first row and first column to see if they naturally contain zeroes, saving this in two boolean variables.
  2. Iterate through the *rest* of the matrix (from index 1,1 onwards). If you find a zero, flag the corresponding cell in the first row and first column (e.g., `matrix[i][0] = 0` and `matrix[0][j] = 0`).
  3. Iterate through the rest of the matrix again, zeroing out cells if their corresponding first row/col flag is 0.
  4. Finally, apply the saved boolean variables to zero out the first row and first column if necessary.
- This is incredibly efficient as it completely eliminates external array allocations.

---

## ⏱️ Complexity
- **Time:** O(M * N)
- **Space:** O(1)

---

## 🧠 When to Use This Pattern
- Whenever a problem demands strict $O(1)$ memory constraints and you need to update a grid based on its *current* state. 
- Storing flag data *within* the data structure itself (like hijacking the first row/column, or using the sign bit of integers) is a classic optimization trick. This is highly applicable to engine architecture where avoiding heap allocations per frame is critical for performance.

---

## 🔗 Similar Questions
- [289. Game of Life](https://leetcode.com/problems/game-of-life/)
- [2125. Number of Laser Beams in a Bank](https://leetcode.com/problems/number-of-laser-beams-in-a-bank/)

---

## 🔄 Re-solve Status
- [x] First solve
- [x] Reviewed 1
- [ ] Reviewed 2