# 🧠 Problem: 124. Binary Tree Maximum Path Sum

- **Link:** [Problem Link](https://leetcode.com/problems/binary-tree-maximum-path-sum)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Dynamic Programming
- Binary Tree
- DFS

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Each node calculates two different values:
  - the best one-way path it can contribute to its parent
  - the best complete path passing through itself
- A complete path can use both children, but a parent can only continue through one side.
- Negative subtree sums are ignored using Math.Max(0, gain).

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- The implementation was not hard, however the idea of carrying the relevant information was hard to think.
- I am getting better at DP-like questions but it is still hard to idealize.

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Use DFS postorder traversal.
- At every node:
- Compute left/right gains.
- Ignore negative gains.
- Update global maximum using: complete path=leftGain+rightGain+root.val
- Return the one-way contribution: one-way gain=root.val+max(leftGain,rightGain)

---

## ⏱️ Complexity
- **Time:** O(n)
- **Space:** O(h)

---

## 🧠 When to Use This Pattern
- Tree problems where:
  - each node combines information from children
  - the answer may terminate at an internal node
  - parent and global answers require different meanings

### 💡 Mental trigger:
“The value returned upward is different from the value used to update the answer.”

---

## 🔗 Similar Questions
- [Path Sum](https://leetcode.com/problems/path-sum/)
- [Sum Root to Leaf Numbers](https://leetcode.com/problems/sum-root-to-leaf-numbers/)
- [Time Needed to Inform All Employees](https://leetcode.com/problems/time-needed-to-inform-all-employees/)
- [Difference Between Maximum and Minimum Price Sum](https://leetcode.com/problems/difference-between-maximum-and-minimum-price-sum/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2