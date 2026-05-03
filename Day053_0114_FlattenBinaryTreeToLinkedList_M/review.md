# 🧠 Problem: 114. Flatten Binary Tree to Linked List

- **Link:** [Problem Link](https://leetcode.com/problems/flatten-binary-tree-to-linked-list)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Linked List
- Stack
- Binary Tree
- DFS/BFS

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- Reconstruct the tree from top to bottom
- Each step attach the right subtree to the rightmost node on left subtree
- And attach the left subtree to the root as the right subtree

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- Firstly, I tried to go from bottom to top, however this way is much easier
- In my first attempt, I faced an issue of cycle in my tree
- I tried to solve with recursion, however it increases space complexity to O(h) which is quite unneccessary

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Iterate until root is null
- If there is a left subtree, find the predecessor of the root
    - Attach the right subtree to the predecessor's right
    - Attach the left subtree as right subtree of the root
    - Set the left subtree of the root to null
- Move the root to the right subtree (used to be left subtree)

---

## ⏱️ Complexity
- **Time:** O(n)
- **Space:** O(1)

---

## 🧠 When to Use This Pattern
- When you need to transform a tree in-place without extra space
- When the problem involves re-linking nodes rather than computing values
- When you want to simulate DFS preorder traversal using pointers instead of recursion

### 💡 Mental trigger:
- “Can I reuse existing pointers to store traversal order instead of using extra memory?”

---

## 🔗 Similar Questions
- [Flatten a Multilevel Doubly Linked List](https://leetcode.com/problems/flatten-a-multilevel-doubly-linked-list/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2