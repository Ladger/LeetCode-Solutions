# 🧠 Problem: 530. Minimum Absolute Difference in BST

- **Link:** [Problem Link](https://leetcode.com/problems/minimum-absolute-difference-in-bst)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- DFS/BFS
- BST
- Senior

---

## 💡 Key Idea
<!-- The core insight in 1–3 sentences -->
- In a BST, inorder traversal produces nodes in sorted order.
- The minimum absolute difference must occur between two consecutive values in that sorted order.
- While traversing inorder, keep track of the previously visited node and update the minimum difference.

---

## ❌ Mistakes / Struggles
<!-- Wrong approaches and struggles -->
- Tried solving it locally for every node by checking:
  - rightmost node of left subtree
  - leftmost node of right subtree
- Although correct, this caused unnecessary repeated traversal and complexity.
- Initially forgot that inorder traversal already gives the BST in sorted order.

---

## 🔁 Better / Optimal Solution
<!-- What did I learn from better solutions? -->
- Convert the BST problem mentally into: “Find minimum difference between adjacent elements in a sorted array.”
- Inorder traversal naturally generates this sorted sequence without extra storage.
- Only two pieces of state are needed:
  - prev → previous visited node
  - minDiff → current best answer

---

## ⏱️ Complexity
- **Time:** O(n)
- **Space:** O(h) - h is tree height

---

## 🧠 When to Use This Pattern
- When a BST question involves:
  - closest values
  - minimum/maximum differences
  - ordering relationships
  - predecessor/successor logic

### 💡 Mental trigger:
“Can inorder traversal turn this into a sorted array problem?”

---

## 🔗 Similar Questions
- [K-diff Pairs in an Array](https://leetcode.com/problems/k-diff-pairs-in-an-array/)

---

## 🔄 Re-solve Status
- [x] First solve
- [ ] Reviewed 1
- [ ] Reviewed 2