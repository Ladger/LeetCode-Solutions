# 🧠 Problem: 108. Convert Sorted Array to Binary Search Tree

- **Link:** [Problem Link](https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/)

## 🧩 Pattern / Topic
<!-- e.g. HashMap, Two Pointers, Sliding Window, DFS, DP -->
- Array
- Divide and Conquer
- BSTs

---

## 💡 Key Idea
- A strictly increasing, sorted array is essentially the "in-order traversal" of a Binary Search Tree. 
- To ensure the resulting tree is height-balanced, the middle element of the array (or subarray) must become the root node. 
- We can then recursively apply this exact same logic to the left half of the array to build the left subtree, and the right half to build the right subtree. 
---

## ❌ Mistakes / Struggles
- Since BST questions are same pattern always, I did not have any challange to find the answer.

---

## 🔁 Better / Optimal Solution
- The recursive divide-and-conquer strategy is the optimal solution for this problem.
- By consistently picking the exact middle element, the algorithm inherently guarantees the depth of the two subtrees never differs by more than one, 
- Satisfying the height-balanced requirement without needing complex balancing logic (like AVL or Red-Black tree rotations).

---

## ⏱️ Complexity
- **Time:** O(N)
- **Space:** O(log N)

---

## 🧠 When to Use This Pattern
- Whenever you need to convert linear, sorted data (like arrays or linked lists) into balanced hierarchical structures.
- When a problem can be cleanly split into two or more independent, identical sub-problems (Divide and Conquer).

---

## 🔗 Similar Questions
- [109. Convert Sorted List to Binary Search Tree](https://leetcode.com/problems/convert-sorted-list-to-binary-search-tree/)

---

## 🔄 Re-solve Status
- [x] First solve
- [x] Reviewed 1
- [ ] Reviewed 2