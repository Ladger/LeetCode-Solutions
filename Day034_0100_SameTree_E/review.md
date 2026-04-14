# 🧠 Problem: 100. Same Tree

- **Link:** [Problem Link](https://leetcode.com/problems/same-tree/)

## 🧩 Pattern / Topic
- Binary Tree  
- DFS (Recursion)  
- Tree Comparison  

---

## 💡 Key Idea
- Compare both trees node by node.
- Trees are the same only if:
  - Current node values are equal
  - Left subtrees are the same
  - Right subtrees are the same

---

## ❌ Mistakes / Struggles
- I challenged to think about the nissing the **one null, one not null case** (should return false).
- However, it is not about it didn't come to my mind. I just couldn't express.

---

## 🔁 Better / Optimal Solution
- Base cases:
  - If both nodes are null → return true
  - If one is null → return false
- Recursively:
  - Check current values
  - Recurse on left children
  - Recurse on right children
- Combine all with logical AND

---

## ⏱️ Complexity
- **Time:** O(n)  
- **Space:** O(h)  

---

## 🧠 When to Use This Pattern
- When comparing **two tree structures**.
- When you need **pairwise traversal** of two trees.
- Typical signals:
  - “same tree”
  - “identical trees”
  - “check if equal”
  - “compare two trees”

---

## 🔗 Similar Questions
- [101. Symmetric Tree](https://leetcode.com/problems/symmetric-tree/)  
- [572. Subtree of Another Tree](https://leetcode.com/problems/subtree-of-another-tree/)  
- [951. Flip Equivalent Binary Trees](https://leetcode.com/problems/flip-equivalent-binary-trees/)  

---

## 🔄 Re-solve Status
- [x] First solve  
- [ ] Reviewed 1  
- [ ] Reviewed 2  