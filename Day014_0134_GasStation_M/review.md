# 🧠 Problem: 134. Gas Station

- **Link:** [Problem Link](https://leetcode.com/problems/gas-station/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Array
- Greedy

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- If the total gas smaller than total cost, it is impossible to finish
- If at any point, the tank becomes negative than we know between the start and the current cannot be valid start
- So, when tanks becomes negative at a point jump to next start

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- If you fail at i, all stations between previous start and i are invalid.
- Overthinking circular traversal with modulo when it's not necessary for optimal solution.
- Treating it as a simulation problem instead of a greedy elimination problem.

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Track two things:
    - total → overall feasibility
    - tank → current segment feasibility
- Core greedy logic is if tank < 0, discard current start and reset
- Any station between A and B would have even less gas to reach B, so they must also fail.

---

## ⏱️ Complexity
- **Time:** O(n)
- **Space:** O(1)

---

## 🧠 When to Use This Pattern
- When:
    - You need to find a valid starting point in a circular structure
    - There is a feasibility condition (total >= 0)
    - Local failures can eliminate ranges of candidates
- Common in:
    - Circular array problems
    - Greedy + prefix sum hybrid problems

---

## 🔗 Similar Questions
- [2202. Maximize the Topmost Element After K Moves](https://leetcode.com/problems/maximize-the-topmost-element-after-k-moves/)

---

## 🔄 Re-solve Status
- [x] First solve
- [x] Reviewed 1
- [ ] Reviewed 2