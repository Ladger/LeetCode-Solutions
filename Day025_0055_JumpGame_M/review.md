# 🧠 Problem: 55. Jump Game

- **Link:** [Problem Link](https://leetcode.com/problems/jump-game/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Array
- Greedy

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Core idea is simple, each iteration try to increase furthest point we can reach
- If the index of element will be greater than furthest that we could reach in iteration, it is impossible to reach at the end

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- At the first attempt, I try to decide on what will be my furthest reach at the possible options
- I was trying to get furthest reach by summing my current jump and the jump that is the next jump I will made
- It is still working with O(n) but slower compared to optimized solution
- HOWEVER, my solution could be better if we try to solve the minimum numbers of jumps.

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Optimal solution, instead of trying every possible jump combination, algorithm simply keeps track of the "horizon"
- The absolute furthest point you can reach at any given moment.
- This speeds up since we are just simply iterating the list and not looking combinations of possible jumps.

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
- [45. Jump Game II](https://leetcode.com/problems/jump-game-ii/)
- [1306. Jump Game III](https://leetcode.com/problems/jump-game-iii/)
- [1871. Jump Game VII](https://leetcode.com/problems/jump-game-vii/)
- [2617. Minimum Number of Visited Cells in a Grid](https://leetcode.com/problems/minimum-number-of-visited-cells-in-a-grid/)
- [2789. Largest Element in an Array after Merge Operations](https://leetcode.com/problems/largest-element-in-an-array-after-merge-operations/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2