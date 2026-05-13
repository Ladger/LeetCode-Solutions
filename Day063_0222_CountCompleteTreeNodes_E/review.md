# 🧠 Problem: 222. Count Complete Tree Nodes

- **Link:** [Problem Link](https://leetcode.com/problems/count-complete-tree-nodes/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Binary Search
- Bit Manipulation
- Binary Tree

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- In a complete binary tree, one subtree is always a perfect binary tree.
- By comparing the leftmost heights of the left and right subtrees, we can determine which side is perfect and count it instantly using: 2^h - 1

instead of traversing every node.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- Tried to explicitly detect the last leaf node instead of identifying perfect subtrees.
- Confusion about why: (1 << height)
- Initially difficult to see why only one recursive branch is needed.

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Compute:
    - left subtree height
    - right subtree height
- If heights are equal:
    - left subtree is perfect
    - count it instantly and recurse right
- Otherwise:
    - right subtree is perfect
    - count it instantly and recurse left

---

## ⏱️ Complexity
- **Time:** O((logn)^2)
- **Space:** O(logn)

---

## 🧠 When to Use This Pattern
- Complete binary tree problems
- When subtree structure can be inferred from heights
- Problems where a full traversal can be avoided by mathematically counting portions of the tree

### 💡 Mental trigger:
“Can I prove an entire subtree is complete/perfect and count it without traversing?”

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2