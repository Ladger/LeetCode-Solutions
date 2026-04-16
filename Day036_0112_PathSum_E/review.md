# 🧠 Problem: 112. Path Sum

- **Link:** [Problem Link](https://leetcode.com/problems/path-sum/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Binary Tree
- DFS/BFS

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Traverse the tree using DFS while accumulating the sum of the current path.
- When reaching a leaf node, check if the accumulated sum equals the target.
- Return true if any root-to-leaf path satisfies the condition.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- Using an extra total parameter makes the solution slightly less clean.
- Thinking in terms of “building sum” instead of “reducing target” (less optimal pattern).

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Instead of accumulating (total + node.val), subtract from targetSum.
- Better approach idea:
    - At each node:
    - Reduce the target: targetSum - node.val
    - At leaf → check if targetSum == node.val

---

## ⏱️ Complexity
- **Time:** O(n)
- **Space:** O(h)

---

## 🧠 When to Use This Pattern
- When working with tree path problems
- When you need to evaluate root-to-leaf conditions
- When the problem asks:
    - “Does a path exist…”
    - “Is there a path such that…”

---

## 🔗 Similar Questions
- [113. Path Sum II](https://leetcode.com/problems/path-sum-ii/)
- [124. Binary Tree Maximum Path Sum](https://leetcode.com/problems/binary-tree-maximum-path-sum/)
- [129. Sum Root to Leaf Numbers](https://leetcode.com/problems/sum-root-to-leaf-numbers/)
- [437. Path Sum III](https://leetcode.com/problems/path-sum-iii/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2