# 🧠 Problem: 104. Maximum Depth of Binary Tree

- **Link:** [Problem Link](https://leetcode.com/problems/maximum-depth-of-binary-tree/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Binary Tree
- DFS/BFS

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- We are counting from deeper side of the tree.
- Than checking who is larger in each depth level.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- I do not have any struggle since it is a textbook depth find of a binary tree.

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Traverse the tree until reaching null nodes
- In each recurse check the left and right of tree
- Take the max, and add 1 for parent tree

---

## ⏱️ Complexity
- **Time:** O(n)
- **Space:** O(h)

---

## 🧠 When to Use This Pattern
- When the problem involves a tree structure and you need to compute a value based on its children (bottom-up thinking).
- When the answer depends on exploring all paths or nodes (e.g., height, depth, diameter).
- Typical signals:
    “maximum/minimum depth”
    “height of tree”
    “longest path”
    “check balanced tree”

---

## 🔗 Similar Questions
- [559. Maximum Depth of N-ary Tree](https://leetcode.com/problems/maximum-depth-of-n-ary-tree/)
- [1376. Time Needed to Inform All Employees](https://leetcode.com/problems/time-needed-to-inform-all-employees/)
- [2458. Height of Binary Tree After Subtree Removal Queries](https://leetcode.com/problems/height-of-binary-tree-after-subtree-removal-queries/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2