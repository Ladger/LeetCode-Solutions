# 🧠 Problem: 226. Invert Binary Tree

- **Link:** [Problem Link](https://leetcode.com/problems/invert-binary-tree/)

## 🧩 Pattern / Topic
- Binary Tree  
- DFS (Recursion)  
- Tree Traversal  

---

## 💡 Key Idea
- Swap the left and right children of every node.
- Do this recursively for the entire tree.

---

## ❌ Mistakes / Struggles
- I do not have any struggles, since the general binary search tree logic was not too hard.

---

## 🔁 Better / Optimal Solution
- Traverse the tree recursively.
- At each node:
  - Swap left and right children.
  - Recursively invert left subtree.
  - Recursively invert right subtree.

---

## ⏱️ Complexity
- **Time:** O(n)  
- **Space:** O(h)  

---

## 🧠 When to Use This Pattern
- When you need to **modify every node in a tree**.
- When the problem involves **mirroring, flipping, or restructuring** a tree.
- Typical signals:
  - “invert”
  - “mirror”
  - “swap children”
  - “modify tree structure”

---

## 🔗 Similar Questions
- [100. Same Tree](https://leetcode.com/problems/same-tree/)  
- [101. Symmetric Tree](https://leetcode.com/problems/symmetric-tree/)  
- [617. Merge Two Binary Trees](https://leetcode.com/problems/merge-two-binary-trees/)  

---

## 🔄 Re-solve Status
- [x] First solve  
- [ ] Reviewed 1  
- [ ] Reviewed 2  