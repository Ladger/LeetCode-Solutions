# 🧠 Problem:

- **Link:** [Problem Link](https://leetcode.com/problems/symmetric-tree/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Binary Tree
- DFS/BFS

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Recurse mirror movement between left and right subtrees
- Compare the current node from both subtrees

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- I am used to binary tree questions, therefore it was not so challanging

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Call TraverseSymmetric() function with root's left and right nodes
- In each recursion check:
    - If both nodes are null return true since they are same
    - Else if one of the nodes is null return false since they are different
- Return the result by checking 
    - Two nodes values, 
    - Result of left's left and right's right, 
    - Result of left's right and right's left

---

## ⏱️ Complexity
- **Time:** O(n)
- **Space:** O(h) (height of the tree)

---

## 🧠 When to Use This Pattern
- When the problem involves checking **symmetry or mirror structure** in a tree.
- When two subtrees need to be compared in a **cross manner**:
  - left subtree of one vs right subtree of the other.
- When the structure matters as much as the values (not just traversal order).
- Common in problems involving:
  - Tree symmetry checks
  - Structural equality with mirrored constraints
  - Recursive tree comparison

---

## 🔄 Re-solve Status
- [x] First solve
- [x] Reviewed 1
- [ ] Reviewed 2