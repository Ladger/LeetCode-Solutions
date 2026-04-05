# 🧠 Problem: 45. Jump Game II

- **Link:** [Problem Link](https://leetcode.com/problems/jump-game-ii/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Array
- Greedy

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Core idea is get furthest reach by summing my current jump and the jump that is the next jump I will made.
- Count every jump at the start of the loop.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- Acutally no struggle since I made the exact solution for the Jump Game question

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- The Goal: Reach the last index in the fewest steps (or determine if it's possible).
- The Decision: At index i, you look at all indices from i + 1 to i + nums[i].
- The Evaluation: For each potential landing spot, you calculate: Reach = Current Index + Jump Power at that Index
- The Move: You "commit" to the landing spot that provides the highest total reach and increment your jump counter.

---

## ⏱️ Complexity
- **Time:** O(N)
- **Space:** O(1)

---

## 🧠 When to Use This Pattern
- Identifying the "Best" Next Step
- Classic greedy optimization where local best leads to global best

---

## 🔗 Similar Questions
- [45. Jump Game](https://leetcode.com/problems/jump-game/)
- [1306. Jump Game III](https://leetcode.com/problems/jump-game-iii/)
- [1871. Jump Game VII](https://leetcode.com/problems/jump-game-vii/)
- [2617. Minimum Number of Visited Cells in a Grid](https://leetcode.com/problems/minimum-number-of-visited-cells-in-a-grid/)
- [2789. Largest Element in an Array after Merge Operations](https://leetcode.com/problems/largest-element-in-an-array-after-merge-operations/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2