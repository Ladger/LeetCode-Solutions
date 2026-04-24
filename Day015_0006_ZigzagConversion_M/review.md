# 🧠 Problem: 6. Zigzag Conversion

- **Link:** [Problem Link](https://leetcode.com/problems/zigzag-conversion)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- String

---

## 💡 Key Idea
- Instead of building a literal 2D grid with blank spaces, we can simulate the row-by-row traversal by "bouncing" between the top and bottom rows. 
- By using an array of strings (or StringBuilders) for each row and a simple directional flag, we can place each character in its correct bucket in a single pass.

---

## ❌ Mistakes / Struggles
- Started with a literal `1D to Grid` approach. This perfectly matched the visual description but wasted massive amounts of memory on empty cells and wasted time iterating over those blanks at the end.
- Moved to the `Formula Based` approach next. This solved the memory issue and was highly optimized, but calculating the exact `cycleLen` and diagonal jump indices is very tricky and highly prone to off-by-one errors during implementation. 
- Overcomplicated the problem before realizing a simple simulation of the reading direction was an option.

---

## 🔁 Better / Optimal Solution
- The "Bouncing" simulation approach (using an array of row buckets and a `goingDown` boolean toggle) is the sweet spot. 
- It achieves the exact same optimal O(N) time complexity as the complex math formula, but is vastly easier to read, write, and debug under pressure. 
- It completely removes the need to calculate cycle leaps.

---

## ⏱️ Complexity
- **Time:** O(N)
- **Space:** O(N)

---

## 🧠 When to Use This Pattern
- When a problem describes a complex physical layout or traversal path (like zigzags, spirals, or matrices) but only asks for the final sequence. 
- Before jumping to complex index math, check if a simple directional toggle (up/down, left/right) and discrete buckets can simulate the process cleanly.

---

## 🔄 Re-solve Status
- [x] First solve
- [x] Reviewed 1
- [ ] Reviewed 2