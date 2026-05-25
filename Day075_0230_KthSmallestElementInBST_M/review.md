# 🧠 Problem: 230. Kth Smallest Element in BST

- **Link:** [Problem Link](https://leetcode.com/problems/kth-smallest-element-in-a-bst/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- DFS
- Binary Search Tree

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Inorder traversal of a BST visits nodes in sorted ascending order.
- Traverse the tree inorder while decrementing k.
- The moment k becomes 0, the current node is the kth smallest element.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- I had not any struggle through solving the O(n) approach.

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Early stopping during traversal avoids unnecessary recursion after finding the answer.
- A more advanced approach exists using subtree sizes (Order Statistic Tree idea), which can achieve O(h) lookup. (Solve in Review Session)

---

## ⏱️ Complexity
- **Time:** O(n)
- **Space:** O(h)

---

## 🧠 When to Use This Pattern
- When working with BST problems involving:
  - kth smallest/largest
  - sorted order
  - range traversal
  - predecessor/successor
- When tree traversal order itself contains useful information.

### 💡 Mental trigger:
“BST + sorted/order-related question”
→ Think: inorder traversal.

---

## 🔗 Similar Questions
- [Binary Tree Inorder Traversal](https://leetcode.com/problems/binary-tree-inorder-traversal/)
- [Second Minimum Node In a Binary Tree](https://leetcode.com/problems/second-minimum-node-in-a-binary-tree/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2